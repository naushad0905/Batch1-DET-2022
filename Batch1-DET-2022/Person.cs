using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class Person
    {
      public int Age { get; set; }

        public string Print()
        {
            return ($"Age = {Age}");
        }
    }
}
