using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLearning
{
    public class EmployeeRepository
    {
        public List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee() {Id = 1, Name = "Fred", Salary= 5000,
                Department= "It"},
                new Employee() {Id = 2, Name = "Elva", Salary= 5001,
                Department= "Sales"},
                new Employee() {Id = 3, Name = "Rem", Salary= 5002,
                Department= "HR"},
                new Employee() {Id = 4, Name = "Jack", Salary= 5003,
                Department= "Marketing"},
                new Employee() {Id = 5, Name = "Sikuang", Salary= 5004,
                Department= "It"}
            };
        }
    }
}
