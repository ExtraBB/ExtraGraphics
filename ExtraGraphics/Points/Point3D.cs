using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraGraphics.Points
{
    public class Point3D<T> : IPoint
    {
        public T X;
        public T Y;
        public T Z;

        public Point3D(T x, T y, T z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
