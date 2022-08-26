using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Testempsal
    {
        public static void Main()
        {
            empsal e = new empsal(22855, "monika", 584123, "banglore", 914866767, 30000, 1000);
            Console.WriteLine($"emp netsal is{e.GetNetSal()}");
            Console.WriteLine($"emp grade is {e.GetEmpGrade()}");
        }

    }
}
