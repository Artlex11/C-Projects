using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Threads
{
    public partial class Form1 : Form
    {
        int x1, x2;

        bool ezh1 = false;

        bool increment1 = false;

        bool ezh2 = false;

        bool increment2 = false;

        int angle;

        Thread t1;
        Thread t2;
        Thread t3;
        Thread t4;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(500, 600);
            this.MinimumSize = new Size(500, 600);

            this.Paint += new PaintEventHandler(Form1_Paint);

            this.BackColor = Color.AliceBlue;

            this.DoubleBuffered = true;


            x1 = -100;
            x2 = -100;

            t1 = new Thread(new ThreadStart(Run1));
            t1.Start();

            t2 = new Thread(new ThreadStart(Run2));
            t2.Start();

            t3 = new Thread(new ThreadStart(Run3));
            t3.Start();

            t4 = new Thread(new ThreadStart(Run4));
            t4.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Image fon = Image.FromFile(@"D:\\C#_Projects\\Threads\\HelpfulFiles\\fon_ezh-sun.png");
            e.Graphics.DrawImage(fon, 0, 0, this.Width, this.Height);

            Image sun = Image.FromFile(@"D:\\C#_Projects\\Threads\\HelpfulFiles\\sun_ezh.png");

            Image img1 = Image.FromFile(@"D:\\C#_Projects\\Threads\\HelpfulFiles\\ezh1.png");

            Image img2 = Image.FromFile(@"D:\\C#_Projects\\Threads\\HelpfulFiles\\ezh2.png");

            if (ezh1 == false)
            {
                e.Graphics.DrawImage(img1, x1, 420, 50, 50);
            }
            else
                e.Graphics.DrawImage(img2, x1, 420, 100, 100);

            if (ezh1 == false)
            {
                e.Graphics.DrawImage(img1, x2, 420, 100, 100);
            }
            else
                e.Graphics.DrawImage(img2, x2, 420, 100, 100);

            e.Graphics.TranslateTransform(370, 100);

            e.Graphics.RotateTransform(angle);

            e.Graphics.DrawImage(sun, -60, -60, 120, 120);
        }

        public void Run1()
        {
            while (true)
            {
                if (increment1)
                    x1 += 5;
                else
                    x1 -= 5;

                if (x1 > 350)
                {
                    increment1 = false;
                    ezh1 = true;
                }

                if (x1 < 50)
                {
                    increment1 = true;
                    ezh1 = false;
                }

                this.Invalidate();
                Thread.Sleep(99);
            }
        }

        public void Run2()
        {
            while (true)
            {
                if (increment2)
                    x2 += 5;
                else
                    x2 -= 5;

                if (x2 > 350)
                {
                    increment2 = false;
                    ezh2 = true;
                }

                if (x2 < 50)
                {
                    increment2 = true;
                    ezh2 = false;
                }

                this.Invalidate();
                Thread.Sleep(50);
            }
        }

        public void Run3()
        {
            while (true)
            {
                angle++;
                this.Invalidate();
                Thread.Sleep(20);
            }
        }

        public void Run4()
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"D:\\C#_Projects\\Threads\\HelpfulFiles\\Ezhik-rezinovy.mp3";
            wplayer.settings.setMode("Loop", true);

            wplayer.controls.play();
        }
    }
}
