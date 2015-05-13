using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Circle
    {
        public double radius;

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
        public double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }
        public double CalculateDiameter()
        {
            return 2 * radius;
        }
    }
}
