using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ExtraGraphics.Points;
using ExtraGraphics.Shapes;

namespace ExtraGraphics.BoundingBoxes
{
    public class BoundingBox2D
    {
        IShape2D shape;
        float Width;
        float Height;
        Point2D TopLeft;

        public BoundingBox2D(IShape2D obj, Point2D topLeft)
        {
            shape = obj;
            TopLeft = topLeft;
            Width = obj.GetWidth();
            Height = obj.GetHeight();
        }
        
        public bool Contains(Point2D p)
        {
            return p.X >= TopLeft.X && p.X <= TopLeft.X + Width
                && p.Y >= TopLeft.Y && p.Y <= TopLeft.Y + Height;
        }

        public bool ShapeContains(Point2D p)
        {
            return shape.Contains(p);
            
        }
    }
}
