using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ExtraGraphics.Points;

namespace ExtraGraphics.BoundingBoxes
{
    public interface IBoundingBox3D<T>
    {
        bool IntersectsBoundingBox(Point3D<T> point);

        bool IntersectsShape(Point3D<T> point);
    }
}
