using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal interface ICar
    {
        int GetPrice(string Name);
    }

    class BMW : ICar
    {
        public int GetPrice(string Name)
        {
            if (Name == "M3")
                return 1300000;
            else if (Name == "X7")
                return 9600000;
            else
                return 100000;
        }
    }

    class Hyundai : ICar
    {
        public int GetPrice(string Name)
        {
            if (Name == "Q3")
                return 140000;
            else if (Name == "2Q")
                return 650000;
            else
                return 20000;
        }
    }
    class TestICar
    {
        public static void Main()
        {
            BMW a = new BMW { };
            Hyundai hyundai = new Hyundai();

            Console.WriteLine($"The Price of BMW-M3 is {a.GetPrice("M3")}");
            Console.WriteLine($"The Price of Hyundai-2Q is {hyundai.GetPrice("2Q")}");
        }
    }
}
