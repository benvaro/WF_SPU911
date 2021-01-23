using System;
using System.Windows.Forms;

namespace _07_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //  tbItem.TabIndex = 0;

            var games = new[] { "FIFA", "GTA5", "Fallout", "Ref dead" };
            var students = new[] {
                new Student { Id = 1, Name = "Ivan", Surname = "Ivanov"},
                new Student { Id = 2, Name = "Ivanka", Surname = "Ivanov"}
            };


            listBox1.Items.AddRange(students);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tbItem.Text))
            {
                listBox1.Items.Add(tbItem.Text);
                Clear();
            }
        }

        private void Clear()
        {
            tbItem.Clear();
        }

        private void tbItem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnAdd_Click(null, null);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.MultiColumn = checkBox1.Checked;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            if (rb.Checked)
            {
                var mode = rb.Text;
                listBox1.SelectionMode = (SelectionMode)Enum.Parse(typeof(SelectionMode), mode);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            while (listBox1.SelectedItems.Count > 0)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }

            if (listBox1.Items.Count > 0)
            {
                listBox1.SetSelected(0, true);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
                return;

            if (!(listBox1.SelectedItem is Student))
                lbInfo.Text = $"Value: {listBox1.SelectedItem}, index = {listBox1.SelectedIndex}";
            else
                lbInfo.Text = $"Value: {(listBox1.SelectedItem as Student).Name}";
        }
    }
}
