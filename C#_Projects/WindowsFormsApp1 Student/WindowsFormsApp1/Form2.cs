using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        string ln;
        string fn;
        static string gr;
        double ex;
        double cw;

        List<Student> student_list = new List<Student>();
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            gr = comboBox.SelectedItem.ToString();
        }

        private void Mark_TextChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            AverageBall.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = false;

            string[] group = { "РФ-425", "РФ-426", "РФ-427", "РФ-428", "РФ-429" };

            Box1.DataSource = group;
            Box1.SelectedIndex = 0;

            Box1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            Exam.KeyPress += Exam_KeyPress;
            CourseWork.KeyPress += Exam_KeyPress;


            Exam.TextChanged += Mark_TextChanged;
            CourseWork.TextChanged += Mark_TextChanged;
        }


        //Кнопка загрузить фото
        //************************************************************************************
        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openPicture = new OpenFileDialog();
            openPicture.Filter = "JPG|*.jpg;*.jpeg|PNG|*.png";
            if (openPicture.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openPicture.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }
        //*************************************************************************************


        private void Exam_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != ',')
            {
                e.Handled = true;
            }
        }


        //Кнопка сохранить
        //********************************************************************************
        private void button2_Click(object sender, EventArgs e)
        {
            if (LastName.Text != String.Empty)
            {
                ln = LastName.Text;
            }
            else
            {
                MessageBox.Show("Заполните поле Фамилия");
                LastName.Focus();
                return;
            }
            if (FirstName.Text != String.Empty)
            {
                fn = FirstName.Text;
            }
            else
            {
                FirstName.Focus();
                MessageBox.Show("Заполните поле Имя");
                return;
            }
            if (Exam.Text != String.Empty)
            {
                ex = Convert.ToDouble(Exam.Text.Replace(',', '.'));
            }
            else
            {
                Exam.Focus();
                MessageBox.Show("Заполните поле Экзамен");
                return;
            }
            if (CourseWork.Text != String.Empty)
            {
                cw = Convert.ToDouble(CourseWork.Text.Replace(',', '.'));
            }
            else
            {
                CourseWork.Focus();
                MessageBox.Show("Заполните поле Курсовая работа");
                return;
            }
            // Создаем объект Student
            Student s = new Student(ln, fn, gr, ex, cw);

            // Выводим информацию
            MessageBox.Show(s.Info());
            student_list.Add(s);

            StreamWriter streamwriter = new StreamWriter(@"D:\STUDENT\student.txt", true,
                System.Text.Encoding.GetEncoding("UTF-8"));
            streamwriter.WriteLine(s.Info());
            streamwriter.Close();

            pictureBox1.Image.Save(@"D:\STUDENT\images" + LastName.Text + "jpg");
        }
        //*************************************************************************************



        //вычисление среднего балла
        //***************************************************************************************
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            double sred_ball = 0;

            if (Exam.Text != String.Empty)
            {
                ex = Convert.ToDouble(Exam.Text.Replace(',', '.'));
            }

            else
            {
                Exam.Focus();
                MessageBox.Show("Заполните поле Экзамен ");
                return;
            }

            if (CourseWork.Text != String.Empty)
            {
                cw = Convert.ToDouble(CourseWork.Text.Replace(',', '.'));
            }

            else
            {
                CourseWork.Focus();
                MessageBox.Show("Заполните поле Курсовая работа ");
                return;
            }
            sred_ball = (ex + cw) / 2;
            AverageBall.Text = sred_ball.ToString();
        }
        //****************************************************************************

        private bool checkField()
        {
            if (LastName.Text != String.Empty)
            {
                ln = LastName.Text;
            }

            else
            {
                MessageBox.Show("Заполните поле Фамилия");
                LastName.Focus();
                return false;
            }

            if (FirstName.Text != String.Empty)
            {
                fn = FirstName.Text;
            }

            else
            {
                FirstName.Focus();
                MessageBox.Show("Заполните поле Имя");
                return false;
            }

            if (Exam.Text != String.Empty)
            {
                ex = Convert.ToDouble(Exam.Text.Replace(',', '.'));
            }

            else
            {
                Exam.Focus();
                MessageBox.Show("Заполните поле Экзамен");
                return false;
            }

            if (CourseWork.Text != String.Empty)
            {
                cw = Convert.ToDouble(CourseWork.Text.Replace(',', '.'));
            }

            else
            {
                CourseWork.Focus();
                MessageBox.Show("Заполните поле Курсовая работа");
                return false;
            }

            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkField())
            {
                Student s;

                s = new Student(ln, fn, gr, ex, cw);

                Student.List.Add(s);

                Student.List.Sort();

                string message = "";

                foreach (var x in student_list) message += x.Info() + "\n";

                MessageBox.Show(message);

                string path = @"D:\STUDENT";

                DirectoryInfo dirInfo = new DirectoryInfo(path);
                if (dirInfo.Exists)
                {
                    dirInfo.Create();
                    MessageBox.Show(@"Create dir D:\STUDENT");
                }

                StreamWriter file = new StreamWriter(@"D:\STUDENT\student.txt", true);

                foreach (var x in student_list)
                    file.WriteLine(x.Info());
                file.Close();

            }
        }
    }   

}   


