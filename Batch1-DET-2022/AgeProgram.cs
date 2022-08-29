using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class AgeProgram
    {
        public static void Main()
        {
            int Age;
            try
            {
                Console.WriteLine("Enter the age b.w 1-100");
                Age = int.Parse(Console.ReadLine());
                if (Age > 100)
                    throw new InvalidAgeException("Entered age is invalid");
            }
            catch (InvalidAgeException a)
            {
                Console.WriteLine(a.Message);
            }
            catch (Exception a)
            { }
        }
    }
}
