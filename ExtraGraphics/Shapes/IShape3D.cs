using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtraGraphics.Points;

namespace ExtraGraphics.Shapes
{
    public interface IShape3D
    {
        bool Contains(Point3D point);
        float GetWidth();
        float GetHeight();
        float GetDepth();
    }
}
