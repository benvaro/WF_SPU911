using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Mouse
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        private void MyForm_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"Mouse Move: {e.X}; {e.Y}";
            if(e.Button == MouseButtons.Left)
            {
                var label = new Label();
                label.Size = new Size(2, 2);
                label.BackColor = Color.Red;
                label.Location = e.Location;
                this.Controls.Add(label);
            }
            else if (e.Button == MouseButtons.Right)
            {
                var label = new Label();
                label.Size = new Size(2, 2);
                label.BackColor = Color.Navy;
                label.Location = e.Location;
                this.Controls.Add(label);
            }
        }

        private void MyForm_MouseDown(object sender, MouseEventArgs e)
        {
            this.Text = "Mouse Down";

            var label = new Label();
            label.Size = new Size(10, 10);
            label.BackColor = Color.Transparent;
            label.Location = e.Location;
            label.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(label);
        }

        private void MyForm_MouseUp(object sender, MouseEventArgs e)
        {
            this.Text = "Mouse Up";

            var label = new Label();
            label.Size = new Size(10, 10);
            label.BackColor = Color.Black;
            label.Location = e.Location;
            this.Controls.Add(label);
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Enter";
            label1.BackColor = Color.Yellow;
            label1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            //Thread.Sleep(1000);
            label1.Text = "Hover";
            label1.BackColor = Color.Green;
            label1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "Leave";
            label1.BackColor = Color.LightBlue;
            label1.BorderStyle = BorderStyle.None;
        }

        //private void MyForm_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    this.label1.Visible = !label1.Visible;
        //}
    }
}
