using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class CSFeatures
    {
        public static void Main()
        {
            Action<string> action = (string name) => { Console.WriteLine($"Hai {name}");  };

            Action<string, string> action1 = (string s1, string s2) => {Console.WriteLine($" {s1},  you said {s2}"); };
                 
                action.Invoke("Syed");
                action1.Invoke("Naushad", "am in Bangalore");

            Func<int, int, long> multiply = (x, y) =>
            {
                return x * y;
            };
            long result = multiply(2, 2);
            Console.WriteLine(result);
        }

       
    }
}
