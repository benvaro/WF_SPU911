using System;
using System.Drawing;
using System.Windows.Forms;

namespace WF_00
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Using MessageBox
            //var result = MessageBox.Show("Hello", "My first window", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            //switch (result)
            //{
            //    case DialogResult.OK:
            //        Console.WriteLine("User pressed OK");
            //        break;
            //    case DialogResult.Cancel:
            //        Console.WriteLine("User pressed Cancel");
            //        break;
            //} 
            #endregion

            var form = new Form();

            form.Text = "Hello";
            form.BackColor = Color.DarkViolet;
            form.ForeColor = Color.FromName("yellow");
            form.Size = new Size(400, 300);

            var button = new Button();
            button.Text = "Hello";
            button.BackColor = Color.FromArgb(123, 200, 90);
            button.Width = 100;
            button.Height = 30;
            button.Location = new Point(form.ClientSize.Width / 2 - button.Size.Width / 2, form.ClientSize.Height / 2 - button.Size.Height / 2);
            button.Click += ClickHandler;

            var label = new Label();
            label.Text = "Hello label";
            label.Location = new Point(130, 0);
            label.Font = new Font("Segoe Script", 26, FontStyle.Italic);
            label.AutoSize = true;

            form.Controls.Add(button);
            form.Controls.Add(label);

            form.ShowDialog();
        }

        private static void ClickHandler(object sender, EventArgs e)
        {
            //MessageBox.Show("Clicked!!!");
            (sender as Button).BackColor = Color.Red;
            var form = new Form();
            ((sender as Button).Parent as Form).Hide();
            var res = form.ShowDialog();
            if(res == DialogResult.Cancel)
            {
                ((sender as Button).Parent as Form).Show();
            }
        }
    }
}
