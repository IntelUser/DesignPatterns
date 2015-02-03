using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Given
{
    class BorderedPhoto : Photo
    {
        private Photo _photo;
        private Color _color;

        public BorderedPhoto(Photo p, Color c)
        {
            _photo = p;
            _color = c;
        }

        public override void Drawer(object source, System.Windows.Forms.PaintEventArgs e)
        {
            _photo.Drawer(source, e);
            e.Graphics.DrawRectangle(new Pen(_color, 10), 25, 15, 215, 225);
        }
    }
}
