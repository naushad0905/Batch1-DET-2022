using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class IterratorDemo
    {
        public static System.Collections.Generic.IEnumerable<int>
    EvenSequence(int firstNumber, int lastNumber)
        {
            // Yield even numbers in the range.
            for (int number = firstNumber; number <= lastNumber; number++)
            {
                if (number % 2 == 0)
                {
                    yield return number;
                }
            }
        }

        static void Main()
        {
            foreach (int number in EvenSequence(1, 20))
            {
                Console.Write(number.ToString() + " ");
            }
            Console.ReadKey();
        }
    }
}
