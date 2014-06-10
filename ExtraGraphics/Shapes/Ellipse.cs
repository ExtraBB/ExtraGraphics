using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ExtraGraphics.Shapes
{
    public class Ellipse : IShape
    {
        public float Top;
        public float Left;
        public float VerticalRadius;
        public float HorizontalRadius;

        /// <summary>
        /// Constructor for the IShape implementation, Ellipse.
        /// </summary>
        /// <param name="top">Top-left X coordinate of the bounding square of the ellipse</param>
        /// <param name="left">Top-left Y coordinate of the bounding square of the ellipse</param>
        /// <param name="verticalRadius">Vertical radius of the ellipse</param>
        /// <param name="horizontalRadius">Horizontal radius of the ellipse</param>
        public Ellipse(float left, float top, float verticalRadius, float horizontalRadius)
        {
            Top = top;
            Left = left;
            VerticalRadius = verticalRadius;
            HorizontalRadius = horizontalRadius;
        }
    }
}
