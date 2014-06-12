using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtraGraphics.Points;

namespace ExtraGraphics.Shapes
{
    public interface IShape2D
    {
        bool Contains(Point2D point);
        float GetWidth();
        float GetHeight();
    }
}
