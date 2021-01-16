using System;
using System.Windows.Forms;

namespace _04_Keyboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = String.Empty;
        }

        string info = String.Empty;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (char.IsDigit((char)e.KeyValue))
            {
                e.Handled = true;
                return;
            }
            info = $"KeyDown: {e.KeyCode} Modifiers: {e.Modifiers}";
            label1.Text = info;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = true;
            info += $"\nKeyPress: {e.KeyChar}";
            label1.Text = info;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (char.IsDigit((char)e.KeyValue))
                e.Handled = true;
            info += $"\nKeyUp: {(char)e.KeyValue} Modifiers: {e.Modifiers}";
            label1.Text = info;
        }
    }
}
