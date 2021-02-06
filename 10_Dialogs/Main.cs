using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace _10_Dialogs
{
    public partial class Form1 : Form
    {
        // Folder browser dialog
        // Save file dialog
        // Color dialog
        // Open File dialog
        // Font dialog
        public Form1()
        {
            InitializeComponent();
            for (int i = 2; i <= 72; i += 2)
            {
                toolStripCbSize.Items.Add(i);
            }

            var fontFamilies = FontFamily.Families;
            foreach (var item in fontFamilies)
            {
                toolStripCbFont.Items.Add(item.Name);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                if (String.Equals(Path.GetExtension(saveFileDialog1.FileName), ".rtf", StringComparison.CurrentCultureIgnoreCase))
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                }
                else
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
            }
        }

        private void contactsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripCbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText.Length > 0)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, Convert.ToSingle(toolStripCbSize.SelectedItem));
            }
            else
            {
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, Convert.ToSingle(toolStripCbSize.SelectedItem));
            }
        }

        private void toolStripCbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText.Length > 0)
            {
                richTextBox1.SelectionFont = new Font(toolStripCbFont.SelectedItem.ToString(), richTextBox1.SelectionFont.Size);
            }
            else
            {
                richTextBox1.Font = new Font(toolStripCbFont.SelectedItem.ToString(), richTextBox1.Font.Size);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (richTextBox1.SelectedText.Length > 0)
                {
                    richTextBox1.SelectionColor = colorDialog1.Color;
                }
                else
                {
                    richTextBox1.ForeColor = colorDialog1.Color;
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var italicBtn = sender as ToolStripButton;
            italicBtn.Checked = !italicBtn.Checked;
            var fontStyle = italicBtn.Checked
                    ? FontStyle.Italic
                    : FontStyle.Regular;

            if (richTextBox1.SelectedText.Length > 0)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, fontStyle);
            }
            else
            {
                richTextBox1.Font = new Font(richTextBox1.Font, fontStyle);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            // richTextBox1.SelectionBullet = true; // маркер списку
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            var fontDialog = new FontDialog();
            fontDialog.ShowColor = true;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                if (richTextBox1.SelectedText.Length > 0)
                {
                    richTextBox1.SelectionFont = fontDialog.Font;
                    richTextBox1.SelectionBackColor = fontDialog.Color;
                }
                else
                {
                    richTextBox1.Font = fontDialog.Font;
                    richTextBox1.BackColor = fontDialog.Color;
                }
            }
        }

        private void folderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowNewFolderButton = false;
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowserDialog1.ShowDialog();
            richTextBox1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog.Filter = "Rich Text document |*.rtf|Text files |*.txt|All files |*.*|Pdf |*.pdf"; // Mask: <Text for user|mask>
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //richTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
                if (String.Equals(Path.GetExtension(openFileDialog.FileName), ".rtf", StringComparison.CurrentCultureIgnoreCase))
                {
                    richTextBox1.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
                }
                else
                {
                    richTextBox1.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Are u sure u want to cancel entered text?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }
    }
}
