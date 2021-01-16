using System;
using System.Drawing;
using System.Windows.Forms;

namespace _03_Date
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lb1.Text = lb2.Text = String.Empty;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var dp = (sender as DateTimePicker);
            this.Text = dp.Value.ToShortDateString();

            var month = dp.Value.Month;
            var season = "";
            if (month >= 3 && month <= 5)
                season = "spring";
            else if (month >= 6 && month <= 8)
                season = "summer";
            else if (month >= 9 && month <= 11)
                season = "autumn";
            else season = "winter";

            lb1.Text = season;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            lb2.Text = $"Date started: {e.Start.ToShortDateString()} \n"
                + $"Date end: {e.End.ToShortDateString()}";

            var range = ((MonthCalendar)sender).SelectionRange;
            this.Text = range.ToString();
        }

        private void btnChangeImg_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("../../test.PNG");
        }
    }
}
