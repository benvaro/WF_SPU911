using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace _08_CheckedListBox
{
    public partial class Form1 : Form
    {
        private List<ProgrammingLanguage> Languages { get; set; } = new List<ProgrammingLanguage>();
        public Form1()
        {
            InitializeComponent();
            checkedListBox1.Items.AddRange(new[] { "234", "apple", "sleep" });

            Languages.AddRange(new[]
            {
                new ProgrammingLanguage
                {
                    Name = "C++",
                    Popularity = 7
                },
                new ProgrammingLanguage
                {
                    Name = "C#",
                    Popularity = 8
                },
                new ProgrammingLanguage
                {
                    Name = "Python",
                    Popularity = 6
                }
            });

            //listBox1.Items.AddRange(languages);
            RefreshDataSource();
        }

        private void twoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var text = "";
            foreach (int item in checkedListBox1.CheckedIndices)
            {
                text += checkedListBox1.Items[item] + "; ";
            }

            toolStripStatusLabel1.Text = text;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //toolStripStatusLabel2.Text = (listBox1.SelectedItem as ProgrammingLanguage).Popularity.ToString();
            toolStripStatusLabel2.Text = listBox1.SelectedValue?.ToString();  // ? - null check
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var lang = new ProgrammingLanguage
            {
                Name = tbName.Text,
                Popularity = int.Parse(tbPopularity.Text)
            };

            Languages.Add(lang);
            RefreshDataSource();
        }

        private void RefreshDataSource()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = Languages;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Popularity";
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            notifyIcon1.ShowBalloonTip(3000);
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var path = new DirectoryInfo(".");
            var files = path.GetFiles();
            listBox2.DataSource = files;
            listBox2.DisplayMember = "Name";
            listBox2.ValueMember = "Length";
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbFile.Text))
            {
                errorProvider1.SetError(tbFile, "File cannot be empty");
                return;
            }
            File.Create(tbFile.Text);
        }

        private void tbFile_Enter(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = Path.GetFileName((listBox2.SelectedItem as FileInfo).FullName);
            textBox3.Text = Path.GetFileName((listBox2.SelectedItem as FileInfo).Extension);
            textBox2.Text = ((listBox2.SelectedItem as FileInfo).Length / Math.Pow(2, 10)).ToString();
        }
    }
}
