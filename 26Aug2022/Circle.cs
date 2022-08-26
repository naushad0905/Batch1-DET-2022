using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
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
