using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {//获取整个树
            treeView1.Nodes.Add("添加第一个节点");
            //每一个节点都是treeNode
            TreeNode treeNode = new TreeNode();
            treeNode.Name = "123";
            treeNode.Text = "treeNode形式添加的节点";
            treeNode.ToolTipText = "气泡提示";

            treeView1.Nodes.Add(treeNode);

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            TreeNode treeNode = new TreeNode();
            //移除最后一个

           // treeView1.Nodes.Remove
        }
    }
}
