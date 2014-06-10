using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExtraGraphics.Shapes;
using ExtraGraphics.Points;
using ExtraGraphics.BoundingBoxes;

namespace ExtraGraphics
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            Ellipse e = new Ellipse(0, 0, 20, 100);
            Point2D<int> p = new Point2D<int>(1, 1);
            EllipseBox eb = new EllipseBox(e);
            Console.WriteLine(eb.IntersectsBoundingBox(p));
            Console.WriteLine(eb.IntersectsShape(p)); 
        }
    }
}
