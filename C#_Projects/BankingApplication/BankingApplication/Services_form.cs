using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BankingApplication
{
    public partial class Services_form : Form
    {
        //переменные для кредитов

        double salary, maxyear /*максимальное число денег за год*/,
            maxpayment/* максимальные выплаты за весь срок*/,
            max/*Максимальная сумма кредита*/,
            allpayment/*Выплаты по кредиту*/,
            payment, term, percent;
        //возвращаемая переменная
        double creditsum;
        //



        //переменные для вкладов
        
        //



        //переменные для обмена валют
        double rub;
        double rub1;
        double rub2;
        //



        //переменные для драгоценных металлов
        double rubles;
        //
        public Services_form()
        {
            InitializeComponent();
        }


        private void Services_form_Load(object sender, EventArgs e)
        {

        }


        // кредиты

        //кнопка рассчёта максимальной суммы кредита
        private void button1_Click_1(object sender, EventArgs e)
        {
            //проверка поля зарплата
            if (salarytxt.Text != String.Empty)
            {
                salary = Convert.ToDouble(salarytxt.Text);
            }
            else
            {
                MessageBox.Show("Enter your salary");
                salarytxt.Focus();
            }

            if (salary <= 0)
            {
                MessageBox.Show("Salary can't be negative or null, enter another");
                salarytxt.Focus();
                salarytxt.Clear();
            }


            //проверка поля срок 
            if (termtxt.Text != String.Empty)
            {
                term = Convert.ToDouble(termtxt.Text);
            }
            else
            {
                MessageBox.Show("Enter the term");
                termtxt.Focus();
            }

            if (term <= 0 || term > 5)
            {
                MessageBox.Show("Impossible term, please enter term from 1 to 5 years");
                termtxt.Focus();
                termtxt.Clear();
            }


            //проверка поля процент от зарплаты
            if (salpertxt.Text != String.Empty)
            {
                percent = Convert.ToDouble(salpertxt.Text);
            }
            else
            {
                MessageBox.Show("Enter percent of your salary for paying");
                salpertxt.Focus();
            }

            if (percent <= 0 || percent > 30)
            {
                MessageBox.Show("Enter percent of salary for payment from 1 to 30");
                salpertxt.Focus();
                salpertxt.Clear();
            }

            payment = (salary * percent) / 100;
            maxyear = payment * 12;
            maxpayment = maxyear * term;

            max = maxpayment / ((1 + (term * 6 / 100) + term * 6 / (100 * (term - 1)) / 2));

            msumtxt.Text = maxyear.ToString();
            sumttxt.Text = maxpayment.ToString();
            mcredittxt.Text = max.ToString();
        }





        //кнопка проверки корректности суммы кредита и расчёт всех выплат с процентами
        private void button2_Click_1(object sender, EventArgs e)
        {
            creditsum = Convert.ToDouble(sumtxt.Text);
            if (creditsum > max)
            {
                MessageBox.Show("Your sum of credit is more than possible, please enter the sum less");
                sumtxt.Focus();
                sumtxt.Clear();
            }
            else
            {
                allpayment = creditsum + (creditsum * 6 / 200 + creditsum * 6 / (200 * term)) * term;
                paytxt.Text = allpayment.ToString();
            }
        }


       

        // Вклады

        //кнопка расчёта процента и срока
        private void button4_Click_1(object sender, EventArgs e)
        {
            double contribution = Convert.ToDouble(contsumtxt.Text);
            double contper, period;

            if (contsumtxt.Text == String.Empty)
            {
                MessageBox.Show("Enter a sum of contribution");
                contsumtxt.Focus();
                contsumtxt.Clear();
            }
            if (contribution <= 0)
            {
                MessageBox.Show("Impossible sum, please enter another");
                contsumtxt.Focus();
                contsumtxt.Clear();
            }
            if (contribution > 10000 && contribution < 100000)
            {
                contper = 10;
                period = 4;
                contpertxt.Text = contper.ToString();
                periodtxt.Text = period.ToString();
            }
            else
            {
                if (contribution > 100000 && contribution < 400000)
                {
                    contper = 5;
                    period = 2;
                    contpertxt.Text = contper.ToString();
                    periodtxt.Text = period.ToString();
                }
                else
                {
                    if (contribution > 400000)
                    {
                        contper = 3;
                        period = 1;
                        contpertxt.Text = contper.ToString();
                        periodtxt.Text = period.ToString();
                    }
                }

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();  
        }


        //кнопка расчёта прибыли
        private void button5_Click(object sender, EventArgs e)
        {
            double contribution = Convert.ToDouble(contsumtxt.Text);
            int per1 = Convert.ToInt16(contpertxt.Text);
            int period1 = Convert.ToInt16(periodtxt.Text);
            double profit = 0;
            for (int i = 0; i < period1; i++)
            {
                profit += contribution * per1 / 100;
            }
            prtxt.Text = profit.ToString();
        }



        // обменник валют

        
        //доллары
        private void doltxt_TextChanged_1(object sender, EventArgs e)
        {
            double dol = Convert.ToDouble(doltxt.Text);

            if (dol < 0)
            {
                MessageBox.Show("Impossible, please, enter another");
                doltxt.Focus();
                doltxt.Clear();
            }
            else
            {
                rub = dol * 61.2;
                rubtxt.Text = rub.ToString();
            }
        }

        //евро
        private void eurtxt_TextChanged_1(object sender, EventArgs e)
        {

            double euro = Convert.ToDouble(eurtxt.Text);

            if (euro < 0)
            {
                MessageBox.Show("Impossible, please, enter another");
                eurtxt.Focus();
                eurtxt.Clear();
            }
            else
            {
                rub1 = euro * 59.84;
                rubtxt1.Text = rub1.ToString();
            }
        }

        //фунты
        private void funttxt_TextChanged_1(object sender, EventArgs e)
        {

            double funt = Convert.ToDouble(funttxt.Text);
            if (funt < 0)
            {
                MessageBox.Show("Impossible, please, enter another");
                funttxt.Focus();
                funttxt.Clear();
            }
            else
            {
                rub2 = funt * 69.27;
                rubtxt2.Text = rub2.ToString();
            }
        }





        //драг металлы

        //установка цены на грамм металла при выборе из combobox
        private void prmettxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (prmettxt.SelectedIndex)
            {
                //золото
                case 0:
                    rubletxt.Text = 3283.6.ToString();
                    break;
                //серебро
                case 1:
                    rubletxt.Text = 38.32.ToString();
                    break;
                //платина
                case 2:
                    rubletxt.Text = 1883.41.ToString();
                    break;
                //палладий
                case 3:
                    rubletxt.Text = 3845.96.ToString();
                    break;
                default:
                    break;
            }
        }

        //установка цены за число грамм, введённых пользователем


        private void gramtxt_TextChanged_1(object sender, EventArgs e)
        {
            double ruble = Convert.ToDouble(rubletxt.Text);
            if (gramtxt.Text == String.Empty)
            {
                dragsum.Clear();

            }
            else
            {
                double gram = Convert.ToDouble(gramtxt.Text);
                if (gram < 0)
                {
                    MessageBox.Show("Please enter another mass");
                    gramtxt.Focus();
                    gramtxt.Clear();
                }
                else
                {
                    rubles = ruble * gram;
                    dragsum.Text = rubles.ToString();

                }
            }
        }



        //кнопка сбора всей информации
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
        List<Bankclient> Clients_list = new List<Bankclient>();
        private void accept_Click(object sender, EventArgs e)
        {
            if (usrtxt.Text != String.Empty && passtxt.Text != String.Empty)
            {
                usr = usrtxt.Text;
                pas = passtxt.Text;
                crsum = sumtxt.Text;
                cont = contsumtxt.Text;
                yea = periodtxt.Text;
                p = contpertxt.Text;
                d = doltxt.Text;
                eu = eurtxt.Text;
                f = funttxt.Text;
                met = prmettxt.Text;
                g = gramtxt.Text;

                /*
                double creditsum = Convert.ToDouble(Services_form.sumtxt.Text);
                int period = Convert.ToInt16(Services_form.contsumtxt.Text);
                int percent = Services_form.contpertxt.Text;
                double dol = Services_form.doltxt.Text;
                double euro = Services_form.eurtxt.Text;
                double funt = Services_form.funttxt.Text;
                string metall = Services_form.prmettxt.Text;
                double gram = Services_form.gramtxt.Text;
                */
                if (pas.Length < 8)
                {
                    MessageBox.Show("Password is short, please enter another");
                    passtxt.Clear();
                }
                else
                {
                    Bankclient b = new Bankclient(usr, pas, crsum, cont, yea, p, d, eu, f, met, g );
                    MessageBox.Show(b.Info());
                    usrtxt.Clear();
                    passtxt.Clear();


                    Clients_list.Add(b);

                    string path = @"D:\C#_Projects\BankingApplication";
                    DirectoryInfo dirInfo = new DirectoryInfo(path);
                    if (!dirInfo.Exists)
                    {
                        dirInfo.Create();
                        MessageBox.Show(@"Create dir D:\C#_Projects\BankingApplication");
                    }

                    String fileUsername = "";

                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.DefaultExt = "txt";

                    saveFileDialog.Title = "Cохранить";
                    saveFileDialog.Filter = "Текстовый файл (*.txt)|.txt";

                    saveFileDialog.FileName = (@"D:\C#_Projects\BankingApplication\Clients");


                    string path_images = @"D:\C#_Projects\BankingApplication";

                    DirectoryInfo dir_images = new DirectoryInfo(path_images);
                    if (!dir_images.Exists)
                    {
                        dir_images.Create();
                        MessageBox.Show(@"D:\C#_Projects\BankingApplication");
                    }

                    DialogResult result = saveFileDialog.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        fileUsername = saveFileDialog.FileName;

                        StreamWriter streamwriter = new StreamWriter(fileUsername, true, System.Text.Encoding.GetEncoding("utf-8"));
                        streamwriter.WriteLine(b.Info());

                        streamwriter.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter username or password");
            }
        }

    }



}

