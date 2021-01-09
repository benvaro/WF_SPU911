using System;
using System.Drawing;
using System.Windows.Forms;

namespace _01_Designer
{
    public partial class Main : Form
    {
        bool isClicked = false;
        public Main()
        {
            InitializeComponent();
            timer.Enabled = false;
            btnStart.Text = "Start timer";
        }

        private void Main_Click(object sender, EventArgs e)
        {
            //((Form)sender).BackColor = Color.Orange;
            BackColor = isClicked ? Color.Blue : Color.Orange;
            isClicked = !isClicked;
        }

        private void Main_MouseClick(object sender, MouseEventArgs e)
        {
            var text = $"Clicked: {e.Button}, coords: {e.Location}";
            Text = text;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            var random = new Random();
            btnInfo.Location = new Point(random.Next(ClientSize.Width),
                                        random.Next(ClientSize.Height));
        }

        int time = 0;

        private void timer_Tick(object sender, EventArgs e)
        {
            if (time < 5)
            {
                label1.Text = $"{++time} sec";
            }
            else
            {
                (sender as Timer).Stop();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
