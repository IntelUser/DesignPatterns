using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Given
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            

            ChristmasTree tree;
            BalledTree ball;
            ToppedTree top;

            List<BalledTree> treesWithBalls = new List<BalledTree>();

            
            tree = new ChristmasTree();
            Application.Run(tree);

            ball = new BalledTree(tree);
            treesWithBalls.Add(ball);
            Application.Run(ball);
            
            DialogResult t = MessageBox.Show("Ok for new ball, cancel resume", "   ", MessageBoxButtons.OKCancel);
            while (t == DialogResult.OK)
            {
                switch (t)
                {

                    case DialogResult.OK:
                        treesWithBalls.Add(new BalledTree(treesWithBalls.ElementAt(treesWithBalls.Count - 1)));
                        Application.Run(treesWithBalls.ElementAt(treesWithBalls.Count - 1));
                         t = MessageBox.Show("Ok for new ball, press cancel to position topper.", "   ", MessageBoxButtons.OKCancel);

                        break;
                    case DialogResult.Cancel:

                        break;
                    default:
                        break;
                }
            }
            top = new ToppedTree(treesWithBalls.ElementAt(treesWithBalls.Count - 1));
            Application.Run(top);
            try
            {
                Application.Run(tree);

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
