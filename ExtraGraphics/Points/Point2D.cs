using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraGraphics.Points
{
    public class Point2D<T> : IPoint
    {
        public T X;
        public T Y;

        public Point2D(T x, T y)
        {
            X = x;
            Y = y;
        }
    }
}
