using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class Classmain
    {
        public static Student Student { get; private set; }

        public static void Main()
        {
            ScienceStudent Student = new ScienceStudent { regno = 12, Name = "Syed" };
            ScienceStudent sciencesubject = new ScienceStudent { physics = 54, chemistry = 75, maths = 45 };
            CommerceStudent Commercessubject = new CommerceStudent { economices = 44, accounts = 82, banking = 44 };

            Console.WriteLine($"The average marks of Science subject is {sciencesubject.GetAvgMarks()}");
            Console.WriteLine($"The average marks of Commerce subject is {Commercessubject.GetAvgMarks()}");
        }
    }
}
