using System;
using System.IO;
using System.Windows.Forms;

namespace _14_TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Nodes.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Text = e.Node.FullPath;
        }
    }
}
