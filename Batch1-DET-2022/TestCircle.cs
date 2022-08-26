using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class TestCircle
    {
        public static void Main()
        {
            Circle a = new Circle(10);
            Console.WriteLine($"The Area of a circle is {a.Area()}");
        }
    }
}
