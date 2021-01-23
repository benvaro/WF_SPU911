using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbInfo_CheckedChanged(object sender, EventArgs e)
        {
            btnGo.Enabled = cbInfo.Checked;
        }

        private void cbInfo_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbInfo.CheckState == CheckState.Indeterminate)
            {
                btnGo.Enabled = false;
            }
        }

        string text = "";

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            text = "";
            var checkBox = sender as CheckBox;
            foreach (Control item in splitContainer2.Panel1.Controls)
            {
                if (item is CheckBox && (item as CheckBox).Checked)
                {
                    text += item.Text + Environment.NewLine;
                }
            }

            lbLanguages.Text = text;
        }
    }
}
