using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Given
{
    class ToppedTree : ChristmasTree
    {
        private ChristmasTree _tree;
        private Image image, image2;
        private int _xPos;
        private int _yPos;


        public ToppedTree(ChristmasTree p)
        {
            image = new Bitmap(@"C:\Users\Johannes\Dropbox\Schoolspul\Stenden\Jaar 3\Design Patterns\treetop.png");
            image2 = new Bitmap(image, new Size(image.Width, image.Height));
            _tree = p;
            _xPos = Mouse.x;
            _yPos = Mouse.y;

        }

        public override void Drawer(object source, System.Windows.Forms.PaintEventArgs e)
        {
           _tree.Drawer(source, e);
           e.Graphics.DrawImage(image2, _xPos-image.Width, _yPos-image.Height);
           
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(588, 753);
            this.Name = "ToppedTree";
            this.ResumeLayout(false);

        }

       
    }
}
