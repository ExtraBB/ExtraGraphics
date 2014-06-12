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
    public class BoundingBox3D
    {
        IShape3D shape;
        Point3D TopLeftFront;
        float Width;
        float Height;
        float Depth;

        public BoundingBox3D(IShape3D obj, Point3D topLeftFront)
        {
            shape = obj;
            TopLeftFront = topLeftFront;
            Width = obj.GetWidth();
            Height = obj.GetHeight();
            Depth = obj.GetDepth();
        }
        
        
        public bool Contains(Point3D p)
        {
            return p.X >= TopLeftFront.X && p.X <= TopLeftFront.X + Width
                && p.Y >= TopLeftFront.Y && p.Y <= TopLeftFront.Y + Height
                && p.Z >= TopLeftFront.Z && p.Z <= TopLeftFront.Z + Depth;
        }

        public bool ShapeContains(Point3D point)
        {
            return shape.Contains(point);
        }
    }
}
