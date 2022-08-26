using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Circle
    {
        double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Area()
        {
            double Area = Math.PI * radius * radius;
            return (Area);
        }
    }
}
