using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseApp
{
    public partial class Form1 : Form
    {
        PictureBox mouse;

        private int mouseWidth = 200, mouseHeight = 200;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(500, 500);
            this.MinimumSize = new Size(500, 500);

            mouse = new PictureBox();

            mouse.Size = new Size(mouseWidth, mouseHeight);

            mouse.Image = Image.FromFile("D:\\C#_Projects\\MouseApp\\Img\\mouse1.png");
            mouse.SizeMode = PictureBoxSizeMode.StretchImage;

            mouse.Location = new Point(100, 150);

            mouse.BorderStyle = BorderStyle.Fixed3D;

            this.Controls.Add(mouse);

            mouse.MouseDoubleClick += new MouseEventHandler(this.mouse_MouseDoubleClick);
            mouse.MouseEnter += new EventHandler(this.mouse_MouseEnter);
            mouse.MouseLeave += new EventHandler(this.mouse_MouseLeave);

            mouse.MouseDown += new MouseEventHandler(this.mouse_MouseDown);
            mouse.MouseMove += new MouseEventHandler(this.mouse_MouseMove);
            mouse.MouseUp += new MouseEventHandler(this.mouse_MouseUp);

            this.MouseWheel += new MouseEventHandler(mouse_MouseWheel);
        }

        private void mouse_MouseClick(object sender, MouseEventArgs e)
        {
            int x_mouse = e.X;
            int y_mouse = e.Y;
            MessageBox.Show("Координаты мыши внутри Form: " + x_mouse + " " + y_mouse);
        }

        private void mouse_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int x_mouse= e.X;
            int y_mouse = e.Y;
            MessageBox.Show("Координа мыши внутри PictureBox: " + x_mouse + " " + y_mouse);        
        }


        private void mouse_MouseEnter(object sender, EventArgs e)
        {
            mouse.Image = Image.FromFile("D:\\C#_Projects\\MouseApp\\Img\\mouse2.png");
            mouse.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void mouse_MouseLeave(object sender, EventArgs e)
        {
            mouse.Image = Image.FromFile("D:\\C#_Projects\\MouseApp\\Img\\mouse1.png");
            mouse.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private bool isDragging  = false;
        private int oldX, oldY;

        private void mouse_MouseDown(object senter, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;

            if(e.Button == MouseButtons.Left)
            {
                isDragging = true;
                oldX = e.X;
                oldY = e.Y;
            }

            if(e.Button == MouseButtons.Right)
            {
                ToolTip tip = new ToolTip();
                tip.SetToolTip(mouse, "I'm really good! \nGood job!\nGood work!\nWay to go");
            }
        }

        private void mouse_MouseMove (object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                mouse.Top = mouse.Top + (e.Y - oldY);

                mouse.Left = mouse.Left + (e.X - oldX);
            }
        }

        private void mouse_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private double ImageScale = 1.0;

        private void mouse_MouseWheel(object sender, MouseEventArgs e)
        {
            const double scale_per_delta = 0.1 / 120;

            ImageScale += e.Delta * scale_per_delta;

            if (ImageScale < 0.5) ImageScale = 0.5;

            if (ImageScale > 1.5) ImageScale = 1.5;

            mouse.Size = new Size((int)(mouseWidth * ImageScale),
                (int)(mouseHeight * ImageScale));
        }

    }
}
