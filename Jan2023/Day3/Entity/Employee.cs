using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Entity
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get { return Age; }
            set
            {
                if(value < 18 || value > 65) { throw new AgeException(); }
                Age = value;
            }
        
        }

        public int DeptId { get; set; }
        public decimal Salary { get; set; }
    }
}
