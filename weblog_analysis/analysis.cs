using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace weblog_analysis
{
    public partial class analysis : Form
    {
        private const int treeDepthLimit = 3;
        private TreeNode tnSelectNode = null;
        private JToken settingJson = null;
        private JObject selectJObject = null;

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filepath);

        [DllImport("kernel32")]
        private static extern long GetPrivateProfileString(string section, string key, string def, StringBuilder reVal, int size, string filepath);

        [DllImport("kernel32")]
        private static extern long GetPrivateProfileString(string section, string key, string def, string reVal, int size, string filepath);

        public analysis()
        {
            InitializeComponent();
            InitializeSetting();
        }

        private void InitializeSetting()
        {
            // json file
            //string rootDir = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            //string rootDir = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string rootDir = Environment.CurrentDirectory;
            string jsonFile = Path.Combine(rootDir, "setting.json");

            if (File.Exists(jsonFile))
            {
                using (StreamReader file = File.OpenText(jsonFile))
                {
                    using (JsonTextReader reader = new JsonTextReader(file))
                    {
                        //settingJson = (JObject)JToken.ReadFrom(reader);
                        settingJson = JToken.Load(reader);
                    }
                }
            }
            else
            {
                settingJson = new JObject(
                    new JProperty("Server", null)
                );

                File.WriteAllText(jsonFile, settingJson.ToString());
            }

            DisplayTreeView(settingJson);


            // ini file
            string iniFile = Path.Combine(rootDir, "setting.ini");
            if (!File.Exists(iniFile))
            {
                WritePrivateProfileString("pattern", "include", ".do;.jsp", iniFile);
                WritePrivateProfileString("pattern", "exclude", ".js;.css;.gif;.png;.jpg;.ico;.jpe;.jpeg;.bmp;.tif;.tiff;.html;.htm", iniFile);
                WritePrivateProfileString("option", "analysis_term(min)", "5", iniFile);
            }

            StringBuilder sbValue = new StringBuilder(512);
            GetPrivateProfileString("pattern", "include", "", sbValue, sbValue.Capacity, iniFile);
            tbIncludePattern.Text = sbValue.ToString();

            sbValue.Clear();
            GetPrivateProfileString("pattern", "exclude", "", sbValue, sbValue.Capacity, iniFile);
            tbExcludePattern.Text = sbValue.ToString();

            // term
            sbValue.Clear();
            GetPrivateProfileString("option", "analysis_term(min)", "", sbValue, sbValue.Capacity, iniFile);
            cbxAnalysisTerm.SelectedIndex = cbxAnalysisTerm.Items.IndexOf(sbValue.ToString());
        }

        private void DisplayTreeView(JToken root)
        {
            tvServerList.BeginUpdate();
            try
            {
                tvServerList.Nodes.Clear();
                TreeNode tNode = tvServerList.Nodes[tvServerList.Nodes.Add(new TreeNode("Server"))];

                AddNode(root, tNode);

                tvServerList.ExpandAll();
            }
            finally
            {
                tvServerList.EndUpdate();
            }
        }

        private void AddNode(JToken token, TreeNode inTreeNode)
        {
            if (token == null)
                return;
            
            if (token is JObject && token.HasValues)
            {
                JObject obj = (JObject)token;

                if (obj["name"] != null)
                {
                    string childrenName = obj.Property("name").Value.ToString();
                    TreeNode childrenNode = inTreeNode.Nodes[inTreeNode.Nodes.Add(new TreeNode(childrenName))];
                    //childrenNode.Tag = obj.Property("files").Value;
                    childrenNode.Tag = token;

                    AddNode(obj.Property("children").Value, childrenNode);
                }
            }
            else if (token is JArray)
            {
                var array = (JArray)token;

                foreach (JObject obj in array)
                {
                    string childrenName = obj.Property("name").Value.ToString();
                    TreeNode childrenNode = inTreeNode.Nodes[inTreeNode.Nodes.Add(new TreeNode(childrenName))];
                    //childrenNode.Tag = obj.Property("files").Value;
                    childrenNode.Tag = token;

                    AddNode(obj.Property("children").Value, childrenNode);
                }
            }
            else
            {
                Debug.WriteLine(string.Format("{0} not implemented", token.Type)); // JConstructor, JRaw
            }
        }

        private void analysis_Load(object sender, EventArgs e)
        {
            tvServerList.ExpandAll();
        }

        private void tvServerList_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tvServerList.SelectedNode = e.Node;
            int level = e.Node.Level;
            
            if (e.Button == MouseButtons.Right && e.Node.Bounds.Contains(e.Location))
            {
                // root
                if (e.Node.Parent == null)
                {
                    ctxmiAdd.Visible = true;
                    ctxmiModify.Visible = false;
                    ctxmiDelete.Visible = false;
                    ctxmServerTree.Show(tvServerList, e.Location);
                }
                // children (not last leaf)
                else if (level < treeDepthLimit)
                {
                    ctxmiAdd.Visible = true;
                    ctxmiModify.Visible = true;
                    ctxmiDelete.Visible = true;
                    ctxmServerTree.Show(tvServerList, e.Location);
                }
                // last leaf
                else if (level == treeDepthLimit)
                {
                    ctxmiAdd.Visible = false;
                    ctxmiModify.Visible = true;
                    ctxmiDelete.Visible = true;
                    ctxmServerTree.Show(tvServerList, e.Location);
                }
                // other
                else
                {
                    //not thing 
                }
            }
        }

        private void tvServerList_MouseDown(object sender, MouseEventArgs e)
        {
            tnSelectNode = tvServerList.GetNodeAt(e.X, e.Y);
        }

        private void tvServerList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lvLogFile.Items.Clear();

            TreeNode currentNode = e.Node;

            if (currentNode.Tag != null && ((JArray)((JObject)currentNode.Tag).Property("files").Value).Count > 0)
            {
                JArray files = (JArray)((JObject)currentNode.Tag).Property("files").Value;

                foreach (JObject file in files)
                {
                    string[] data = new string[]
                    {
                        "",
                        file.Property("filename").Value.ToString(),
                        file.Property("filepath").Value.ToString(),
                        file.Property("size").Value.ToString(),
                        file.Property("created").Value.ToString(),
                        file.Property("updated").Value.ToString()
                    };

                    ListViewItem lvItem = new ListViewItem( data);
                    lvLogFile.Items.Add(lvItem);
                }
            }
        }


        private void ctxmiAdd_Click(object sender, EventArgs e)
        {
            TreeNode newNode = new TreeNode("New");
            tnSelectNode.Nodes.Add(newNode);
            tnSelectNode.Expand();

            tvServerList.LabelEdit = true;
            if (!newNode.IsEditing)
            {
                newNode.BeginEdit();
            }
        }

        private void ctxmiModify_Click(object sender, EventArgs e)
        {
            if (tnSelectNode != null && tnSelectNode.Parent != null)
            {
                tvServerList.SelectedNode = tnSelectNode;
                tvServerList.LabelEdit = true;
                if (!tnSelectNode.IsEditing)
                {
                    tnSelectNode.BeginEdit();
                }
            }
            else
            {
                MessageBox.Show("No tree node selected or selected node is a root node.\n" +
                   "Editing of root nodes is not allowed.", "Invalid selection");
            }
        }

        private void ctxmiDelete_Click(object sender, EventArgs e)
        {
            TreeNode tnParentNode = tnSelectNode.Parent;

            if (tnSelectNode != null && tnParentNode != null)
            {
                DialogResult result = MessageBox.Show("Are you want to delete the node?\n(Warning!! Include children node)", "Node delete", MessageBoxButtons.OKCancel);
                
                if (result == DialogResult.OK)
                {
                    tnParentNode.Nodes.Remove(tnSelectNode);
                    tvServerList.SelectedNode = tnParentNode;
                }
            }
        }

        private void tvServerList_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            JArray children = (JArray)((JObject)tnSelectNode.Tag).Property("children").Value;
            
            bool isNew = children.Any(x => ((JObject)x).Property("name").Value.ToString() == e.Node.Text);

            JObject jsonObj = new JObject();
            jsonObj.Add("name", e.Node.Text);
            jsonObj.Add("files", null);
            jsonObj.Add("children", null);

            if (tnSelectNode.Parent is null)
            {
                ((JArray)settingJson).Add(jsonObj);
            }
            else
            {
                
                children.Add(jsonObj);
            }
        }

        private void btnSearchFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.DefaultExt = "log";
            openFileDialog.Filter = "Log Files (*.log)|*.log|" +
                                    "All files (*.*)|*.*";

            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Select log files";

            DialogResult dr = openFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string dir = openFileDialog.InitialDirectory;
                
                foreach (string file in openFileDialog.FileNames)
                {
                    string filename = Path.GetFileName(file);
                    string filepath = Path.Combine(dir, file);

                    if (File.Exists(filepath))
                    {
                        FileInfo info = new FileInfo(filepath);

                        DateTime dtCreateTime = info.CreationTime;
                        DateTime dtUpdateTime = info.LastWriteTime;
                        long fileSize = info.Length; // Byte

                        string[] data = new string[] { ""
                                                     , filename
                                                     , filepath
                                                     , fileSize.ToString()
                                                     , dtCreateTime.ToString("yyyy-MM-dd HH:mm:ss")
                                                     , dtUpdateTime.ToString("yyyy-MM-dd HH:mm:ss")
                                                     };

                        ListViewItem lvItem = new ListViewItem(data);
                        lvLogFile.Items.Add(lvItem);

                        JObject jsonObj = new JObject();
                        jsonObj.Add("filename", filename);
                        jsonObj.Add("filepath", filepath);
                        jsonObj.Add("size", fileSize.ToString());
                        jsonObj.Add("created", dtCreateTime.ToString("yyyy-MM-dd HH:mm:ss"));
                        jsonObj.Add("updated", dtUpdateTime.ToString("yyyy-MM-dd HH:mm:ss"));

                        JArray files = (JArray)((JObject)tnSelectNode.Tag).Property("files").Value;
                        files.Add(jsonObj);
                    }
                }
            }
        }

        private void lvLogFile_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 0)
            {
                bool value = false;
                try
                {
                    value = Convert.ToBoolean(this.lvLogFile.Columns[e.Column].Tag);
                }
                catch (Exception)
                {
                }
                this.lvLogFile.Columns[e.Column].Tag = !value;
                foreach (ListViewItem item in this.lvLogFile.Items) item.Checked = !value;
                this.lvLogFile.Invalidate();
            }
        }

        private void lvLogFile_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.DrawBackground();
                bool value = false;
                try
                {
                    value = Convert.ToBoolean(e.Header.Tag);
                }
                catch (Exception)
                {
                }
                CheckBoxRenderer.DrawCheckBox(e.Graphics, new Point(e.Bounds.Left + 4, e.Bounds.Top + 4),
                    value ? System.Windows.Forms.VisualStyles.CheckBoxState.CheckedNormal :
                    System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal);
            }
            else e.DrawDefault = true;
        }

        private void lvLogFile_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void lvLogFile_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string rootDir = Environment.CurrentDirectory;
            string iniFile = Path.Combine(rootDir, "setting.ini");

            if (File.Exists(iniFile))
            {
                WritePrivateProfileString("pattern", "include", tbIncludePattern.Text, iniFile);
                WritePrivateProfileString("pattern", "exclude", tbExcludePattern.Text, iniFile);
                WritePrivateProfileString("option", "analysis_term(min)", cbxAnalysisTerm.SelectedItem.ToString(), iniFile);
            }

            string jsonFile = Path.Combine(rootDir, "setting.json");
            if (File.Exists(jsonFile))
            {
                File.WriteAllText(jsonFile, settingJson.ToString());
            }
        }

       
    }
}
