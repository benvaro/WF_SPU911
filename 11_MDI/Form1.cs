using System;
using System.Windows.Forms;

namespace _11_MDI
{
    // Додати в проект "Блокнот" MDI.
    //  - Додати пункт меню New document (child in mdi);
    public partial class Form1 : Form
    {
        // DRY
        // D - dont
        // R - repeat
        // Y - yourself!

        // KISS
        // K - Keep
        // I - it
        // S - simple
        // S - stupid
        public Form1()
        {
            InitializeComponent();
        }

        int id = 0;

        public ToolStripMenuItem WindowToolStripMenuItem
        {
            get
            {
                return this.windowToolStripMenuItem;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var child = new Child();
            child.MdiParent = this;
            child.Text = "Untitled " + ++id;
            child.Show();
            // 1) Додати сепаратор якщо вікно є першим + 
            // 2) Створити пункт меню і налаштувати
            // 3) Додати в випадаючий список елементів пункта меню Window
            if (id == 1)
            {
                windowToolStripMenuItem.DropDownItems.Add(new ToolStripSeparator());
            }

            var newItem = new ToolStripMenuItem();
            newItem.Text = child.Text;
            newItem.Checked = true;
            newItem.CheckOnClick = true;
            newItem.Click += (s, o) =>
            {
                child.Focus();
                if (child.WindowState == FormWindowState.Minimized)
                {
                    child.WindowState = FormWindowState.Normal;
                }
            };
            //toolStripStatusLabel1.Text = child.Text;

            windowToolStripMenuItem.DropDownItems.Add(newItem);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void alignWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void minimizeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in this.MdiChildren)
            {
                item.WindowState = FormWindowState.Minimized;
            }

            var child = (Child)this.ActiveMdiChild;
            this.Focus();
            toolStripStatusLabel1.Text = string.Empty;
            foreach (ToolStripItem item in windowToolStripMenuItem.DropDownItems)
            {
                if (item is ToolStripMenuItem)
                {
                    (item as ToolStripMenuItem).Checked = false;
                }
            }
        }

        private void maximizeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in this.MdiChildren)
            {
                item.WindowState = FormWindowState.Maximized;
            }
        }

        private void restoreAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in this.MdiChildren)
            {
                item.WindowState = FormWindowState.Normal;
            }
        }

        private void Form1_MdiChildActivate(object sender, EventArgs e)
        {
            var child = (Child)this.ActiveMdiChild;

            if (child == null)
            {
                var count = windowToolStripMenuItem.DropDownItems.Count;
                windowToolStripMenuItem.DropDownItems.RemoveAt(count - 1);
                return;
            }

            toolStripStatusLabel1.Text = child.Text;

            foreach (ToolStripItem item in windowToolStripMenuItem.DropDownItems)
            {
                if (item is ToolStripMenuItem)
                {
                    if (item.Text.Contains(child.Text))
                    {
                        (item as ToolStripMenuItem).Checked = true;
                    }
                    else
                    {
                        (item as ToolStripMenuItem).Checked = false;
                    }
                }
            }
        }
    }
}
