using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChristmasTreeDecorator
{
    public partial class ChristmasTree : Window
    {
        public ChristmasTree()
        {
            InitializeComponent();
            Drawer();
        }

        public virtual void Drawer()
        {
            var uri = new Uri("file://C:/Users/Johannes/Dropbox/Schoolspul/Stenden/Jaar 3/Design Patterns/tree.jpg");
            var bitmap = new BitmapImage(uri);
            var myImageBrush = new ImageBrush(bitmap);
            image_canvas.Background = myImageBrush;
        }

        private void ball_decorator_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
