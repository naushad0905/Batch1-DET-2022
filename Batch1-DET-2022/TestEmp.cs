using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class TestEmpl
    {
        public static void Main()
        {
            Empl e = new Empl(22804, "Syed Naushad", new DateOnly(2020, 8, 1));
            Console.WriteLine($"Your Years of Experience {e.GetYearsofExp()}");
        }
    }
}
