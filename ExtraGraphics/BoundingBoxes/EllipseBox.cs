using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ExtraGraphics.Shapes;
using ExtraGraphics.Points;

namespace ExtraGraphics.BoundingBoxes
{
    public class EllipseBox : IBoundingBox2D<int>
    {
        Ellipse obj;
        public EllipseBox(Ellipse ellipse)
        {
            obj = ellipse;
        }
        
        public bool IntersectsBoundingBox(Point2D<int> p)
        {
            return p.X >= obj.Left && p.X <= obj.Left + 2 * obj.HorizontalRadius
                && p.Y >= obj.Top && p.Y <= obj.Top + 2 * obj.VerticalRadius;
        }

        public bool IntersectsShape(Point2D<int> p)
        {
            float centerX = obj.Left + obj.HorizontalRadius;
            float centerY = obj.Top + obj.VerticalRadius;
            return Math.Pow(p.X - centerX, 2) / Math.Pow(obj.HorizontalRadius, 2) + Math.Pow(p.Y - centerY, 2) / Math.Pow(obj.VerticalRadius, 2) <= 1;
        }
    }
}
