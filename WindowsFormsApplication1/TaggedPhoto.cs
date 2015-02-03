using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Given
{
    class TaggedPhoto : Photo
    {
        private Photo _photo;
        private string _tag;
        private int _number;
        private static int _count;
        private List<string> _tags = new List<string>();

        public TaggedPhoto(Photo p, string t)
        {
            _photo = p;
            _tag = t;
            _tags.Add(t);
            _number = ++_count;
        }

        public override void Drawer(object source, System.Windows.Forms.PaintEventArgs e)
        {
            base.Drawer(source, e);
            e.Graphics.DrawString(_tag, new System.Drawing.Font("Arial", 16), new SolidBrush(Color.Black), new PointF(80, 100 + _number * 20));
        }

        public string ListTaggedPhotos()
        {
            string s = "Tags are: ";
            foreach (string t in _tags) s += t + " ";
            return s;
        }
    }
}
