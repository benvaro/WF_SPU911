using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_Multiform
{
    public partial class Form1 : Form
    {
        //  Передача даних з батьківської форми на дочірню:
        //   1- перевантажити конструктор дочірньої форми (однооразовий варіант)
        //   2- перевантажити виклик ShowDialog
        //   3- створити відкриту властивість на батьківській формі
        //      створити екземпляр батьківської форми на дочірній
        public Form1()
        {
            InitializeComponent();
        }

        public string TextProperty { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            //var child = new Child(textBox1.Text);  // 1 case
            //child.ShowDialog();

            //2 case
            //var child = new Child();
            //child.ShowDialog(textBox1.Text);

            var child = new Child(this);
            child.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextProperty = textBox1.Text;
        }
    }
}
