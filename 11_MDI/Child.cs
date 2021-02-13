using System.Windows.Forms;

namespace _11_MDI
{
    public partial class Child : Form
    {
        public Child()
        {
            InitializeComponent();
        }

        private void Child_FormClosing(object sender, FormClosingEventArgs e)
        {
            var parent = (Form1)this.MdiParent;
            var items = parent.WindowToolStripMenuItem.DropDownItems; // пункти меню
            for (var i = 0; i < items.Count; i++)
            {
                if (items[i].Text == (sender as Child).Text) // якщо текст пункту меню == заголовку вікна
                {
                    items.RemoveAt(i);
                    break;
                }
            }
        }
    }
}
