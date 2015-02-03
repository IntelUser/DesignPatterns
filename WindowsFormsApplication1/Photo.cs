using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Given
{
    public class Photo : Form1
    {
        Image image;

        public Photo()
        {
            image = new Bitmap(@"C:\Users\Johannes\Pictures\jug.jpg");
            this.Text = "Lemonade";
            this.Paint += new System.Windows.Forms.PaintEventHandler(Drawer);
        }

        public virtual void Drawer(Object source, PaintEventArgs e)
        {
            e.Graphics.DrawImage(image, 30, 20);
        }
    }
}
