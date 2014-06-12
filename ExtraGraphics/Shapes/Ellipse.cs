using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ExtraGraphics.Points;

namespace ExtraGraphics.Shapes
{
    public class Ellipse : IShape2D
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

        public bool Contains(Point2D p)
        {
            float centerX = Left + HorizontalRadius;
            float centerY = Top + VerticalRadius;
            return Math.Pow(p.X - centerX, 2) / Math.Pow(HorizontalRadius, 2) + Math.Pow(p.Y - centerY, 2) / Math.Pow(VerticalRadius, 2) <= 1;
        }

        public float GetWidth()
        {
            return 2 * HorizontalRadius;
        }

        public float GetHeight()
        {
            return 2 * VerticalRadius;
        }
    }
}
