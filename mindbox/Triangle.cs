using System;

namespace mindbox
{
    public class Triangle : ISquarable, IRectanglable
    {
        /// <summary>
        /// Three trianglge sides.
        /// </summary>
        readonly double a, b, c;

        /// <summary>
        /// Generate triangle with 3 sides.
        /// </summary>
        public Triangle(float a, float b, float c)
        {
            if( !(a + b > c ||
                  b + c > a ||
                  a + c > b ) )
            {
                throw new ArgumentException("Figure can't exist!");
            }

            if(a < 0 || b < 0 || c < 0)
            {
                throw new ArgumentException("Length of side can't be negative!");
            }

            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double GetSquare()
        {
            var p = GetPerimeter();
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool IsRectangular()
        {
            return
                (a * a) + (b * b) == (c * c) ||
                (b * b) + (c * c) == (a * a) ||
                (a * a) + (c * c) == (b * b);
        }

        /// <summary>
        /// Claculates perimeter of this triangle.
        /// </summary>
        /// <returns>Perimeter of this triangle.</returns>
        private double GetPerimeter()
        {
            return (a + b + c) / 2;
        }
    }
}
