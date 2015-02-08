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
        private readonly ChristmasTree _tree;
        private readonly Image _image, _image2;
        private readonly int _xPos, _yPos;


        public ToppedTree(ChristmasTree p)
        {
            _image = new Bitmap(@"C:\Users\Johannes\Dropbox\Schoolspul\Stenden\Jaar 3\Design Patterns\treetop.png");
            _image2 = new Bitmap(_image, new Size(_image.Width, _image.Height));
            _tree = p;
            _xPos = Mouse.X;
            _yPos = Mouse.Y;

        }

        public override void Drawer(object source, System.Windows.Forms.PaintEventArgs e)
        {
           _tree.Drawer(source, e);
           e.Graphics.DrawImage(_image2, _xPos-_image.Width, _yPos-_image.Height);
           
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
