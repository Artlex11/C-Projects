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
    public partial class Form3 : Form
    {
        DataTable dt;
        List<Student> student_list;

        string filterField = "Фамилия";
        public Form3()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dt.Columns.Add("Средний балл");

                dataGridView1.Columns.Add("Средний балл", "Средний балл");

                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    double Exam = Convert.ToDouble(dt.Rows[i]["Экзамен"]);
                    double CourseWork = Convert.ToDouble(dt.Rows[i]["Курсовая работа"]);
                    dt.Rows[i]["Средний балл"] = (Exam + CourseWork) / 2;
                }

                dataGridView1.DataSource = dt;
            }

            else
            {
                dt.Columns.Remove("Средний балл");
                dataGridView1.Columns.Remove("Средний бвлл");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = string.Format("[{0}] Like '{1}'%", filterField, textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = @"D:\STUDENT\student.txt";

            if (File.Exists(filename))
            {
                StreamReader file = new StreamReader(filename);

                string[] values;

                string newLine;

                string ln;
                string fn;
                string gr;
                double ex;
                double cw;

                Student s;

                student_list = new List<Student>();

                while ((newLine = file.ReadLine()) != null)
                {
                    values = newLine.Split(' ');

                    ln = values[0];
                    fn = values[1];
                    gr = values[2];

                    ex = Convert.ToDouble(values[3]);
                    cw = Convert.ToDouble(values[4]);

                    s = new Student(ln, fn, gr, ex, cw);

                    student_list.Add(s);
                }
                file.Close();

                int j = 0;
                while (j < student_list.Count)
                {
                    s = student_list[j];

                    if (s.getLastName().Equals(textBox1.Text))
                        student_list.RemoveAt(j);
                    else
                        j++;
                }

                j = 0;

                string data;

                while (j < dt.Rows.Count)
                {
                    data = dt.Rows[j][0].ToString();
                    if (data.Equals(textBox1.Text))
                        dt.Rows[j].Delete();
                    j++;
                }

                textBox1.Text = String.Empty;

                string message = "";

                foreach (var x in student_list) message += x.Info() + "\n";

                MessageBox.Show(message);

                file.Close();

                StreamWriter new_file = new StreamWriter(@"D:\STUDENT\student.txt");

                foreach (var x in student_list)
                    new_file.WriteLine(x.Info());
                new_file.Close();

                dataGridView1.DataSource = dt;

                dataGridView1.Update();
                dataGridView1.Refresh();
            }
            else MessageBox.Show("Нет файла с данными");
        }

    }
}
