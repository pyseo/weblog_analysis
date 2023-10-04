using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public analysis()
        {
            InitializeComponent();
        }

        private void analysis_Load(object sender, EventArgs e)
        {
            tvServerList.ExpandAll();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
