using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace BankingApplication
{
    public partial class List_of_clients : Form
    {
        DataTable clients;
        List<Bankclient> Bankclients;

        string filterField = "UserName";
        public List_of_clients()
        {
            InitializeComponent();
        }


        private void List_of_clients_Load_1(object sender, EventArgs e)
        {
            clients = new DataTable();

            clients.Columns.Add("UserName");
            clients.Columns.Add("Password");
            clients.Columns.Add("Credit sum");
            clients.Columns.Add("Contribution");
            clients.Columns.Add("Period");
            clients.Columns.Add("Percent");
            clients.Columns.Add("Dol");
            clients.Columns.Add("Euro");
            clients.Columns.Add("Funt");
            clients.Columns.Add("Metall");
            clients.Columns.Add("Gram");

            string filename = @"D:\BankingApplication\Clients.txt";

            if (File.Exists(filename))
            {
                StreamReader file = new StreamReader(filename);

                string[] values;
                string newline;

                while ((newline = file.ReadLine()) != null)
                {
                    DataRow dr = clients.NewRow();
                    values = newline.Split(' ', ':');
                    for (int i = 0; i < values.Length; i++)
                    {
                        dr[i] = values[i];
                        
                    }
                    clients.Rows.Add(dr);

                }
                file.Close();

                dataGridView1.DataSource = clients;

                dataGridView1.AutoResizeColumns();
            }
            else
            {
                MessageBox.Show("File doesn't excist");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //поиск по имени

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            clients.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterField, Searchbox.Text);
        }


        //кнопка удалить
        private void delbut_Click(object sender, EventArgs e)
        {
            string filename = @"D:\BankingApplication\Clients.txt";

            if (File.Exists(filename))
            {
                StreamReader file = new StreamReader (filename);

                string[] values;

                string newfile;

                string usr;
                string pas;
                string crsum;
                string cont;
                string yea;
                string p;
                string d;
                string eu;
                string f;
                string met;
                string g;

                Bankclient b;

                Bankclients = new List<Bankclient>();

                while((newfile = file.ReadLine()) != null)
                {

                }
            }
        }


    }
}
