using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"D:\STUDENTS\student.txt"))
            {
                Form3 f = new Form3();
                f.Show();
            }

            else
            {
                MessageBox.Show("Файла нет");
                return;
            }
        }
    }
}
