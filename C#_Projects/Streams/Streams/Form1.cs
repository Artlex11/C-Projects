using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Streams
{
    public partial class Form1 : Form
    {
        Thread t1;
        Thread t2;
        Thread t3;
        Thread t4;
        Thread t5;
        Thread t6;
        Thread t7;
        Thread t8;
        Thread t9;
        Thread t;
        Thread tm;
        int x, y, c, d, a, b, i, f, g, h, m, n, q, w, r, j, u, p;
        double angle1 = 0.0;
        double angle2 = 0.0;
        double angle3 = 0.0;
        double angle4 = 0.0;
        double angle5 = 0.0;
        double angle6 = 0.0;
        double angle7 = 0.0;
        double angle8 = 0.0;
        double angle9 = 0.0;
        double angle = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile(@"D:\C#_Projects\Streams\Ajy.jpg");
            this.WindowState = FormWindowState.Maximized;
            // цвет фона
            this.BackColor = Color.White;
            // убираем мерцание при перерисовке
            this.DoubleBuffered = true;
            // подключаем событие Paint
            this.Paint += new PaintEventHandler(Form1_Paint);

            t = new Thread(new ThreadStart(Run));
            t.Start();
            t1 = new Thread(new ThreadStart(Run1));
            t1.Start();
            t2 = new Thread(new ThreadStart(Run2));
            t2.Start();
            t3 = new Thread(new ThreadStart(Run3));
            t3.Start();
            t4 = new Thread(new ThreadStart(Run4));
            t4.Start();
            t5 = new Thread(new ThreadStart(Run5));
            t5.Start();
            t6 = new Thread(new ThreadStart(Run6));
            t6.Start();
            t7 = new Thread(new ThreadStart(Run7));
            t7.Start();
            t8 = new Thread(new ThreadStart(Run8));
            t8.Start();
            t9 = new Thread(new ThreadStart(Run9));
            t9.Start();
            tm = new Thread(new ThreadStart(Runm));
            tm.Start();
        }
        PictureBox Mercury;
        void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            // e.Graphics.RotateTransform((float)angle);
            Brush brush = new SolidBrush(Color.Yellow);
            Rectangle rectpl = new Rectangle(727, 458, 30, 30);
            e.Graphics.DrawEllipse(new Pen(Color.Transparent, 1), rectpl);
            e.Graphics.FillEllipse(brush, rectpl);

            //e.Graphics.RotateTransform((float)angle1);
            e.Graphics.DrawEllipse(Pens.White, 670, 423, 140, 100); //орбита Меркурия
            Brush brush1 = new SolidBrush(Color.Brown);
            Rectangle rectpl1 = new Rectangle(x, y, 19, 19);
            e.Graphics.DrawEllipse(new Pen(Color.Transparent, 1), rectpl1);
            e.Graphics.FillEllipse(brush1, rectpl1);

            /*Image Mercury = Image.FromFile(@"D:\ThreadsSunSystem\Files\Mercury.png"); 
            e.Graphics.DrawImage(Mercury, x, y, 15, 15);*/

            //e.Graphics.RotateTransform((float)angle2);
            e.Graphics.DrawEllipse(Pens.White, 637, 393, 208, 160); //орбита Венеры
            Brush brush2 = new SolidBrush(Color.Chocolate);
            Rectangle rectpl2 = new Rectangle(c, d, 20, 20);
            e.Graphics.DrawEllipse(new Pen(Color.Transparent, 1), rectpl2);
            e.Graphics.FillEllipse(brush2, rectpl2);

            //e.Graphics.RotateTransform((float)angle3);
            e.Graphics.DrawEllipse(Pens.White, 592, 348, 290, 252); //орбита Земли
            Brush brush3 = new SolidBrush(Color.SkyBlue);
            Rectangle rectpl3 = new Rectangle(a, b, 20, 20);
            e.Graphics.DrawEllipse(new Pen(Color.Transparent, 1), rectpl3);
            e.Graphics.FillEllipse(brush3, rectpl3);

            //e.Graphics.RotateTransform((float)angle4);
            e.Graphics.DrawEllipse(Pens.White, 550, 311, 374, 325); //орбита Марса
            Brush brush4 = new SolidBrush(Color.DarkRed);
            Rectangle rectpl4 = new Rectangle(i, f, 16, 16);
            e.Graphics.DrawEllipse(new Pen(Color.Transparent, 1), rectpl4);
            e.Graphics.FillEllipse(brush4, rectpl4);

            //e.Graphics.RotateTransform((float)angle5);
            e.Graphics.DrawEllipse(Pens.White, 492, 261, 502, 440); //орбита Юпитера
            Brush brush5 = new SolidBrush(Color.Bisque);
            Rectangle rectpl5 = new Rectangle(g, h, 30, 30);
            e.Graphics.DrawEllipse(new Pen(Color.Transparent, 1), rectpl5);
            e.Graphics.FillEllipse(brush5, rectpl5);

            //e.Graphics.RotateTransform((float)angle6);
            e.Graphics.DrawEllipse(Pens.White, 422, 201, 640, 558); //орбита Сатурна
            Brush brush6 = new SolidBrush(Color.Moccasin);
            Rectangle rectpl6 = new Rectangle(m, n, 27, 27);
            e.Graphics.DrawEllipse(new Pen(Color.Transparent, 1), rectpl6);
            e.Graphics.FillEllipse(brush6, rectpl6);

            //e.Graphics.RotateTransform((float)angle7);
            e.Graphics.DrawEllipse(Pens.White, 362, 143, 756, 668); //орбита Урана
            Brush brush7 = new SolidBrush(Color.MediumSeaGreen);
            Rectangle rectpl7 = new Rectangle(q, w, 25, 25);
            e.Graphics.DrawEllipse(new Pen(Color.Transparent, 1), rectpl7);
            e.Graphics.FillEllipse(brush7, rectpl7);

            //e.Graphics.RotateTransform((float)angle8);
            e.Graphics.DrawEllipse(Pens.White, 300, 83, 877, 778); //орбита Нептуна
            Brush brush8 = new SolidBrush(Color.SlateBlue);
            Rectangle rectpl8 = new Rectangle(r, j, 18, 18);
            e.Graphics.DrawEllipse(new Pen(Color.Transparent, 1), rectpl8);
            e.Graphics.FillEllipse(brush8, rectpl8);

            //e.Graphics.RotateTransform((float)angle9);
            e.Graphics.DrawEllipse(Pens.White, 234, 59, 998, 820); //орбита Плутона
            Brush brush9 = new SolidBrush(Color.White);
            Rectangle rectpl9 = new Rectangle(u, p, 12, 12);
            e.Graphics.DrawEllipse(new Pen(Color.Transparent, 1), rectpl9);
            e.Graphics.FillEllipse(brush9, rectpl9);
        }
        public void Run()
        {
            while (true)
            {
                angle += 0.1;
                this.Invalidate();
                Thread.Sleep(20);
            }
        }
        public void Run1()
        {
            while (true)
            {
                x = (int)(70 * Math.Cos(angle1)) + Width / 2;
                y = (int)(50 * Math.Sin(angle1)) + Height / 2;
                angle1 += 0.1;
                this.Invalidate();
                Thread.Sleep(20);
            }
        }
        public void Run2()
        {
            while (true)
            {
                c = (int)(104 * Math.Cos(angle2)) + Width / 2;
                d = (int)(82 * Math.Sin(angle2)) + Height / 2;
                angle2 -= 0.033;
                this.Invalidate();
                Thread.Sleep(20);
            }
        }
        public void Run3()
        {
            while (true)
            {
                a = (int)(142 * Math.Cos(angle3)) + Width / 2;
                b = (int)(128 * Math.Sin(angle3)) + Height / 2;
                angle3 += 0.025;
                this.Invalidate();
                Thread.Sleep(20);
            }
        }
        public void Run4()
        {
            while (true)
            {
                i = (int)(188 * Math.Cos(angle4)) + Width / 2;
                f = (int)(162 * Math.Sin(angle4)) + Height / 2;
                angle4 += 0.015;
                this.Invalidate();
                Thread.Sleep(20);
            }
        }
        public void Run5()
        {
            while (true)
            {
                g = (int)(254 * Math.Cos(angle5)) + Width / 2;
                h = (int)(220 * Math.Sin(angle5)) + Height / 2;
                angle5 += 0.01;
                this.Invalidate();
                Thread.Sleep(20);
            }
        }
        public void Run6()
        {
            while (true)
            {
                m = (int)(320 * Math.Cos(angle6)) + Width / 2;
                n = (int)(280 * Math.Sin(angle6)) + Height / 2;
                angle6 += 0.008;
                this.Invalidate();
                Thread.Sleep(20);
            }
        }
        public void Run7()
        {
            while (true)
            {
                q = (int)(380 * Math.Cos(angle7)) + Width / 2;
                w = (int)(340 * Math.Sin(angle7)) + Height / 2;
                angle7 += 0.007;
                this.Invalidate();
                Thread.Sleep(20);
            }
        }
        public void Run8()
        {
            while (true)
            {
                r = (int)(440 * Math.Cos(angle8)) + Width / 2;
                j = (int)(390 * Math.Sin(angle8)) + Height / 2;
                angle8 += 0.005;
                this.Invalidate();
                Thread.Sleep(20);
            }
        }
        public void Run9()
        {
            while (true)
            {
                u = (int)(500 * Math.Cos(angle9)) + Width / 2;
                p = (int)(410 * Math.Sin(angle9)) + Height / 2;
                angle9 += 0.002;
                this.Invalidate();
                Thread.Sleep(20);
            }
        }
        
        public void Runm()
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"D:\C#_Projects\Streams\Земляне - И снится нам не рокот космодрома (mp3store (mp3cut.net).mp3";
            wplayer.settings.setMode("Loop", true);

            wplayer.controls.play();
        }
    }
}
