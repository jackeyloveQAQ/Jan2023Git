using Day3.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public sealed class SealedClassEx
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentLocation { get; set; }

        public Employee MapHelper(ref Department dept)
        {
            var emp = new Employee() { Id = EmployeeId, Name = EmployeeName };
            dept = new Department() { Id = DepartmentId, Location = DepartmentLocation };
            return emp;
        }
    }

    //public class AttemptsToInherit : SealedClassEx
    //{

    //}
}
