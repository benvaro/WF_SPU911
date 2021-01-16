using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_TextBox
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> accounts = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
            this.Height = 150;
            //btnLogin.TabIndex = 0;
        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {
            //this.Text = tbLogin.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            accounts["user"] = "user";
            accounts["admin"] = "admin";
        }

        private void tbLogin_Leave(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(tbLogin.Text))
            {
                tbLogin.Focus();
            }
            else
            {
                if(!accounts.ContainsKey(tbLogin.Text))
                {
                    MessageBox.Show("Incorect Login");
                    tbLogin.Text = String.Empty;
                    tbLogin.Focus();
                }
            }
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            Text = "tbPassword got a focus!";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbPassword.Text))
            {
                tbPassword.Focus();
            }
            else
            {
                if (accounts[tbLogin.Text] != tbPassword.Text)
                {
                    MessageBox.Show("Incorect Password");
                    tbPassword.Text = String.Empty;
                    tbPassword.Focus();
                    return;
                }

                tbLogin.Enabled = false;
                tbPassword.Enabled = false;
                this.Height = 700;
            }
        }

        private void tbText_TextChanged(object sender, EventArgs e)
        {
            var textBox = (sender as TextBox);
            var start = textBox.SelectionStart;
            var length = textBox.Text.Length;
            var selectionLength = textBox.SelectionLength;
            var end = start + selectionLength;

            lbInfo.Text = $"Start selection: {start}\n " +
                $"\nLines: {textBox.Lines.Count()}" +
                $"\nEnd selection: {end}" +
                $"\nLength: {length}" +
                $"\nSelection Length: {selectionLength}";

            tbSelectedText.Text = textBox.SelectedText;
        }

        private void tbText_MouseCaptureChanged(object sender, EventArgs e)
        {
            tbText_TextChanged(sender, null);
        }
    }
}
