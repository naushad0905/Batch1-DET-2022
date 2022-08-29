using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class TestPerson1
    {
        public static void Main()
        {
            try
            {
                Person1 t = new Person1("Syed", "Naushad", "syednaushad@Audi.com", new DateOnly(1998, 05, 09));
                int byear = t.BirthYear();
                if (byear < 1900 || byear > 2022)
                {
                    throw new InvalidEmpIdException("ENTER VALID BIRTH YEAR");
                }
                string r = t.GetSunSign();
                string s = t.ChineseZodiac();
                string w = t.IsAdult();
                string b = t.BDayStatus();
                string u = t.DefaultUsername();
                string n = t.GetInfo();
                Console.WriteLine($"NAME = {n}");
                Console.WriteLine($"Sun Sign = {r}");
                Console.WriteLine($"Chinese Zodiac = {s}");
                Console.WriteLine($"Age Status = {w}");
                Console.WriteLine($"Birthday Status = {b}");
                Console.WriteLine($"Default Username = {u}");
            }
            catch (InvalidEmpIdException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception m)
            {
                Console.WriteLine(m.Message);
            }
        }
    }
}
