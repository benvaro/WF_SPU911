using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace _09_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            hScrollBar1.Maximum = imageList1.Images.Count - 1;
            hScrollBar1.Minimum = 0;
            toolStripProgressBar1.Step = toolStripProgressBar1.Maximum / imageList1.Images.Count;
            var count = typeof(Color).GetProperties().Count();

            cbColors.Items.AddRange(typeof(Color)
                .GetProperties()
                .Select(p => p.Name)
                .Take(count - 9)
                .ToArray());

            cbColors.SelectedIndex = 0;

            //for (int i = 0; i < 9; i++)
            //{
            //    cbColors.Items.RemoveAt(cbColors.Items.Count - 1);
            //}
        }

        private void cbColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelColor.BackColor = Color.FromName(cbColors.SelectedItem.ToString());
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            splitContainer1.Panel2.BackColor = Color.FromArgb(trackBar1.Value,
                trackBar2.Value,
                trackBar3.Value);
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[hScrollBar1.Value];
            toolStripProgressBar1.Value = (hScrollBar1.Value + 1) * toolStripProgressBar1.Step;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = toolStripProgressBar1.Step;
            toolStripProgressBar1.Minimum = toolStripProgressBar1.Step;
        }
    }
}
