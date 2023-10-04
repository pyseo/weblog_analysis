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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace weblog_analysis
{
    public partial class analysis : Form
    {
        const int treeDepthLimit = 3;
        private TreeNode tnSelectNode = null;
        private JToken settingJson = null;

        public analysis()
        {
            InitializeComponent();

            // to-do
            // setting json load

            InitializeSetting();
        }

        private void InitializeSetting()
        {
            string rootDir = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
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
                    new JProperty("Name", "Server"),
                    new JProperty("Type", "root"),
                    new JProperty("leaf", new JArray[] { })
                );

                File.WriteAllText(jsonFile, settingJson.ToString());
            }

            DisplayTreeView(settingJson, "root");
        }

        private void DisplayTreeView(JToken root, string rootName)
        {
            tvServerList.BeginUpdate();
            try
            {
                tvServerList.Nodes.Clear();
                TreeNode tNode = tvServerList.Nodes[tvServerList.Nodes.Add(new TreeNode(rootName))];
                tNode.Tag = root;

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
            if (token is JValue)
            {
                var childNode = inTreeNode.Nodes[inTreeNode.Nodes.Add(new TreeNode(token.ToString()))];
                childNode.Tag = token;
            }
            else if (token is JObject)
            {
                var obj = (JObject)token;
                foreach (var property in obj.Properties())
                {
                    var childNode = inTreeNode.Nodes[inTreeNode.Nodes.Add(new TreeNode(property.Name))];
                    childNode.Tag = property;
                    AddNode(property.Value, childNode);
                }
            }
            else if (token is JArray)
            {
                var array = (JArray)token;
                for (int i = 0; i < array.Count; i++)
                {
                    var childNode = inTreeNode.Nodes[inTreeNode.Nodes.Add(new TreeNode(i.ToString()))];
                    childNode.Tag = array[i];
                    AddNode(array[i], childNode);
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

            // ListView Item
            if (e.Node.Parent == null)
            {
                lvLogFile.Items.Clear();
                ListViewItem lvItem = new ListViewItem(new string[] { "fileName Sample", "filePath Sample" });
                lvItem.Tag = "object?";
                lvLogFile.Items.Add(lvItem);

                
            }
            
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
                // child (not last leaf)
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
                DialogResult result = MessageBox.Show("Are you want to delete the node?\n(Warning!! Include child node)", "Node delete", MessageBoxButtons.OKCancel);
                
                if (result == DialogResult.OK)
                {
                    tnParentNode.Nodes.Remove(tnSelectNode);
                    tvServerList.SelectedNode = tnParentNode;
                }
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
                    string filepath = Path.Combine(dir, file);

                    if (File.Exists(filepath))
                    {
                        FileInfo info = new FileInfo(filepath);

                        DateTime dtCreateTime = info.CreationTime;
                        DateTime dtUpdateTime = info.LastWriteTime;
                        long fileSize = info.Length; // Byte

                        ListViewItem lvItem = new ListViewItem(new string[] { file, Path.Combine(dir, file)
                                                                            , fileSize.ToString()
                                                                            , dtCreateTime.ToString("yyyy-MM-dd HH:mm:ss")
                                                                            , dtUpdateTime.ToString("yyyy-MM-dd HH:mm:ss")
                                                                            });

                        lvLogFile.Items.Add(lvItem);
                    }
                }
            }
        }
    }
}
