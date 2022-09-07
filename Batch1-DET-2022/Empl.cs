using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class Empl
    {
        int id;
        string name;
        string dept;
        double sal;
        DateOnly doj;
        internal string Ename;

        public int Empno { get; internal set; }
        public int Sal { get; internal set; }
        public int Deptno { get; internal set; }
        public string Job { get; internal set; }

        //constructor - is a function used to init object data
        //has the same name as classname, no ret type
        public Empl(int eid, string ename, DateOnly doj)
        {
            id = eid; name = ename; this.doj = doj;
        }
        public Empl()
        {
            id = -1; name = "no name";
        }
        public Empl(int id, string name)
        {
            this.id = id; this.name = name;
        }

        //function written inside a class is known as method
        public int GetYearsofExp()
        {
            return DateTime.Now.Year - doj.Year;
        }

        public string Print()   //only virtual method can be overridden
        {
            return $"Emp Id={id}, Name={name}, Experience={GetYearsofExp()} Years";
        }

    }
}
