using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindbox
{
    public class Circle : ISquarable
    {
        /// <summary>
        /// Circle radius.
        /// </summary>
        readonly double radius;
        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Radius of circle can't be negative!");
            }

            this.radius = radius;
        }

        public double GetSquare()
        {
            return Math.PI * (radius * radius);
        }
    }
}
