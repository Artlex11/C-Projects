using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Media;

namespace keyboardApp_Klad
{
    public partial class Form1 : Form
    {
        
        int x, y;
        Random rnd = new Random();
        PictureBox hero, klad;
        Bitmap hero_image;
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            x = rnd.Next(101, 801);
            y = rnd.Next(101, 801);
            this.MaximumSize = new Size(900, 900);
            this.MinimumSize = new Size(900, 900);

            this.BackgroundImage = Image.FromFile("D:\\C#_Projects\\keyboardApp_Klad\\Img\\Карта.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.StartPosition = FormStartPosition.CenterScreen;

            hero = new PictureBox();

            hero.Width = this.Width / 15;
            hero.Height = this.Height / 15;

            hero.Image = Image.FromFile("D:\\C#_Projects\\keyboardApp_Klad\\Img\\Герой.png");
            hero.SizeMode = PictureBoxSizeMode.StretchImage;

            hero.Location = new Point(100, 300);

            hero.Parent = this;
           
            this.Controls.Add(hero);
            hero.BackColor = Color.Transparent;
            hero_image = (Bitmap)hero.Image;

            this.Paint += new PaintEventHandler(this.Form1_Paint);

            this.KeyDown += new KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new KeyEventHandler(this.Form1_KeyUp);


            klad = new PictureBox();

            klad.Width = 100;
            klad.Height = 100;

            klad.Image = Image.FromFile("D:\\C#_Projects\\keyboardApp_Klad\\Img\\Klad.png");
            klad.SizeMode = PictureBoxSizeMode.StretchImage;
            klad.Location = new Point(x, y);

            this.Controls.Add(klad);
            klad.BackColor = Color.Transparent;



            this.Paint += new PaintEventHandler(this.Form1_Paint);

            this.KeyDown += new KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new KeyEventHandler(this.Form1_KeyUp);


            timer1.Enabled = true;

            MessageBox.Show("You have only 100 seconds to find klad\n Good luck!");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
          
            Graphics g = e.Graphics;
            Rectangle dropRect = new Rectangle(x, y, 100, 100);
            Pen pen = new Pen(Color.Purple, 3);

            e.Graphics.DrawRectangle(pen, dropRect);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {

                Bitmap bitmap = (Bitmap)Bitmap.FromFile("D:\\C#_Projects\\keyboardApp_Klad\\Img\\Герой.png");

                hero.Image = bitmap;
                
                    hero.Left += 10;

                    hero_image = bitmap;
      
            }

            else if (e.KeyCode == Keys.Left)
            {
                Bitmap bitmap = (Bitmap)Bitmap.FromFile("D:\\C#_Projects\\keyboardApp_Klad\\Img\\Герой.png");


                hero.Image = bitmap;

                hero.Left -= 10;

                hero_image = bitmap;
            }

            else if (e.KeyCode == Keys.Up)
            {
                Bitmap bitmap = (Bitmap)Bitmap.FromFile("D:\\C#_Projects\\keyboardApp_Klad\\Img\\Герой.png");

                hero.Image = bitmap;
                hero.Top -= 10;
                hero_image = bitmap;

            }

            else if (e.KeyCode == Keys.Down)
            {
                Bitmap bitmap = (Bitmap)Bitmap.FromFile("D:\\C#_Projects\\keyboardApp_Klad\\Img\\Герой.png");


                hero.Image = bitmap;
                hero.Top += 10;
                hero_image = bitmap;
            }

            Rectangle dropRect = new Rectangle(x, y, 100, 100);
            if (dropRect.Contains(hero.Bounds))
            {
                MessageBox.Show("Congratulation!\nYou win!");
                timer1.Enabled = false;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                hero.Size = new Size(this.Width / 10, this.Height / 10);

                hero.Image = hero_image;
            }
        }

        int i;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            i++;
            if (i > 100)
            {
                MessageBox.Show("Game over!");
                timer1.Enabled = false;
            }
        }

       
    }
}
