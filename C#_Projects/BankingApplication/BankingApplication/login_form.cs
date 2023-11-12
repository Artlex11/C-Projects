using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace BankingApplication
{
    public partial class login_form : Form
    {
        

        public login_form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void login_form_Load(object sender, EventArgs e)
        {
        
        } 
        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"D:\C#_Projects\BankingApplication\Clients.txt"))
            {
                if (adminpastxt.Text != "Artlex11")
                {
                    MessageBox.Show("Wrong password");
                }
                else
                {
                    List_of_clients list = new List_of_clients();
                    list.Show();
                }
            }

            else
            {
                MessageBox.Show("Fail doesn't exist");
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Services_form f = new Services_form();
            f.Show();
        }
    }
}
