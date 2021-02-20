using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InitializeListView();
        }

        private void InitializeListView()
        {
            lvMain.View = View.SmallIcon;
            for (int i = 0; i < smallIconsList.Images.Count; i++)
            {
                var item = new ListViewItem($"Item {i + 1}", i);
                InitializeSubItems(item);
                lvMain.Items.Add(item);
                lvMain.Columns.Add($"SubItem {i + 1}", 100);
            }

          //  lvMain.Columns.Add("Item", 200);
        }

        private void InitializeSubItems(ListViewItem item)
        {
            for (int i = 0; i < 3; i++)
            {
                item.SubItems.Add($"Subitem {i + 1}");
            }
        }

        private void checkedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lvMain.CheckBoxes = !lvMain.CheckBoxes;
            (sender as ToolStripMenuItem).Checked = lvMain.CheckBoxes;
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            var radioButton = sender as RadioButton;
            var view = (View)Convert.ToInt32(radioButton.Tag.ToString());
            if (radioButton.Checked)
            {
                if (view == View.Tile)
                {
                    errorProvider1.SetError(radioButton, "You cannot set tile mode, when checkboxes are on");
                    return;
                }

                this.lvMain.View = view;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in lvMain.SelectedItems)
            {
                lvMain.Items.Remove((ListViewItem)item);
            }
        }
    }
}
