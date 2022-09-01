using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class EmployeeLINQ
    {
        public EmployeeLINQ(int id, string name, string dept)
        {
            this.ID = id;
            this.Name = name;
            this.Dept = dept;

        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }

        private static List<EmployeeLINQ> GetListofEmployees()
        {
            List<EmployeeLINQ> emps = new List<EmployeeLINQ>();
            emps.Add(new EmployeeLINQ(1, "John", "Training"));
            emps.Add(new EmployeeLINQ(2, "Mark", "Finance"));
            emps.Add(new EmployeeLINQ(3, "Peter", "Technical"));
            emps.Add(new EmployeeLINQ(4, "Bob", "Technical"));
            emps.Add(new EmployeeLINQ(5, "Robert", "Finance"));
            emps.Add(new EmployeeLINQ(6, "Jason", "Training"));

            return emps;
        }
    }
}
