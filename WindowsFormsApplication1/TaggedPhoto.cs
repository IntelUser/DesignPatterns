using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Given
{
    class TaggedPhoto : ChristmasTree
    {
        private readonly ChristmasTree _photo;
        private readonly string _tag;
        private readonly int _number;
        private static int _count;
        private static readonly List<string> Tags = new List<string>();

        public TaggedPhoto(ChristmasTree p, string t)
        {
            _photo = p;
            _tag = t;
            Tags.Add(t);
            _number = ++_count;
        }

        public override void Drawer(object source, PaintEventArgs e)
        {
            _photo.Drawer(source, e);
            e.Graphics.DrawString(_tag, new Font("Arial", 16), new SolidBrush(Color.Black), new PointF(80, 100 + _number * 20));
        }

        public string ListTaggedPhotos()
        {
            return Tags.Aggregate("Tags are: ", (current, t) => current + (t + " "));
        }
    }
}
