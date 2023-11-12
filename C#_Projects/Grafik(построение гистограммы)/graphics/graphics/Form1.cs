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

namespace graphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        List<int> x;
        List<int> y;
        int[] a;


        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
           try
            {
                //Инициализация массивов
                a = new int[20];

                //Заполняем массив а случайными числами
                Random rnd = new Random();
                for (int i = 0; i < a.Length; i++)
                    a[i] = rnd.Next(1, 10);

                //Добавляем точки на график
                foreach (int val in a)
                    chart2.Series["Series1"].Points.Add(val);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error.\n\nError message: {ex.Message}\n\n" +
                $"Details:\n\n{ex.StackTrace}");
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //Инициализация массивов
                    x = new List<int>();
                    y = new List<int>();

                    //Чтение файла и запись значений в List x и y
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    string line;
                    string[] line2;
                    while ((line = sr.ReadLine()) != null)
                    {
                        line2 = line.Split(',', ';'); //разбиваем строку на подстроки
                        x.Add(Convert.ToInt32(line2[0]));
                        y.Add(Convert.ToInt32(line2[1]));
                    }
                    sr.Close();

                    //Заполняем график считанными значениями
                    chart1.Series["Series1"].LegendText = "График XY";
                    for (int i = 0; i < x.Count; i++)
                    {
                        chart1.Series["Series1"].Points.AddXY(x[i], y[i]);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            //Начинаем запись в файл
            StreamWriter sw = new StreamWriter(filename);
            foreach (int val in a)
                sw.WriteLine(val);
            sw.Close();
            MessageBox.Show("Файл сохранен");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
