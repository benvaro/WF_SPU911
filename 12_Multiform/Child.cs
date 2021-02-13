using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_Multiform
{
    public partial class Child : Form
    {
        Form1 _parent = null;
        public Child(Form1 parent)
        {
            InitializeComponent();
            _parent = parent;
            label1.Text = _parent.TextProperty;
        }
        public Child(string text)
        {
            InitializeComponent();
            label1.Text = text;
        }

        public void ShowDialog(string text)
        {
            label1.Text = text;
            base.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _parent.BackColor = Color.FromName(textBox1.Text);
            this.Close();
        }
    }
}
