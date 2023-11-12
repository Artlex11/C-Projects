using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseButterfly
{
    public partial class Form1 : Form
    {
        PictureBox Butterfly;

        private int butWidth = 150, butHeight = 150;

        Point MousePosition;

        public Form1()
        {
            InitializeComponent();
            
        }
        int w, h;
        int mw, mh;
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            w = rnd.Next(451);
            h = rnd.Next(451);

            this.MaximumSize = new Size(600, 600);
            this.MinimumSize = new Size(600, 600);

            this.BackgroundImage = Image.FromFile("D:\\C#_Projects\\MouseButterfly\\Img\\Flowers.jpg");

            Butterfly = new PictureBox();

            Butterfly.Size = new Size(butWidth, butHeight);

            Butterfly.Image = Image.FromFile("D:\\C#_Projects\\MouseButterfly\\Img\\ButterflyLeft.png");
            Butterfly.SizeMode = PictureBoxSizeMode.StretchImage;

            Butterfly.Location = new Point(w, h);

            this.Controls.Add(Butterfly);

            Butterfly.BackColor = Color.Transparent;

            Butterfly.MouseEnter += new EventHandler(this.Butterfly_MouseEnter);
        }

        private void Butterfly_MouseEnter(object sender, EventArgs e)
        {
            Random rand = new Random();
            int x = rand.Next(10, this.ClientSize.Width - Butterfly.Width);
            int y = rand.Next(10, this.ClientSize.Height - Butterfly.Height);
            Butterfly.Location = new Point(x, y);
        }

        /*private void Butterfly_MouseEnter(object sender, EventArgs e)
        {
           MousePosition = e.Location;
           if (MousePosition.X > w || MousePosition.X < w + 150) {
              if ((w > 451) || (h > 451))
               {
                   w -= 10;
                   h -= 10;
                   Butterfly.Location = new Point(w, h);
               }
               if ((w > 451) || (h < 151))
               {
                   w -= 10;
                   h += 10;
                   Butterfly.Location = new Point(w, h);
               }
               if ((w < 151) || (h < 151))
               {
                   w += 10;
                   h += 10;
                   Butterfly.Location = new Point(w, h);
               }
               if ((w < 151) || (h > 451))
               {
                   w += 10;
                   h -= 10;
                   Butterfly.Location = new Point(w, h);
               }

               Butterfly.Location = new Point(w + 10, h + 10);
           }         
       }*/

    }

}
