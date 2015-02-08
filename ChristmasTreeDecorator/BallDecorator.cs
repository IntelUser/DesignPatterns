using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ChristmasTreeDecorator
{
    class BallDecorator : ChristmasTree
    {
        private ChristmasTree _tree;

        public BallDecorator(ChristmasTree component)
        {
            _tree = component;
        }
        public override void Drawer()
        {
            //Execute Drawer method on saved component
            _tree.Drawer();
            ImageBrush brush = new ImageBrush(new BitmapImage(new Uri("")));
            image_canvas

        }
    }
}
