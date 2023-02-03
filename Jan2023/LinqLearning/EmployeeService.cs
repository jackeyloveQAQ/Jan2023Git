using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LinqLearning
{
    public class EmployeeService
    {
        EmployeeRepository empRepo;
        public EmployeeService()
        {
            empRepo = new EmployeeRepository();
        }
        public void Demo()
        {
            Func<Employee, int> replace = x =>
            {
                return x.Salary;
            };

            //Select * From Employee
            var empList = empRepo.GetEmployees();
            //Query Comprehension Syntax
            var result1 = (from employee in empList select employee).ToList(); ;
            //Lambda Exmpression
            var result2 = empList.Select(GiveEmp).ToList();
            var result3 = empList.Select(x => x).ToList();

            //Northwind :Many many tables

            foreach (var item in result3)
            {
                Console.WriteLine(item);
            }

            var result5 = empList.Where(x => x.Salary < 5002).ToList();
            foreach (var item in result5)
            {
                Console.WriteLine($" {item.Name} + {item.Salary}");
            }
            //Using Anonymous Types for query comprehension
            var result6 = (from emp in empList
                           where emp.Salary < 5002 //&& emp.Department == "Marketing"
                           select new
                           {
                               Id = emp.Id,
                               Name = emp.Name,
                               Salary = emp.Salary
                           }).ToList();
            //Using anonymous types for lambda syntax 
            var result7 = empList.Where(x => x.Salary < 5002)
                .Select(x => new { Id = x.Id, Name = x.Name }).ToList();

            Employee mapEmp = new Employee()
            { Id = result6[0].Id, Name = result6[0].Name };

            var result4 = empList.Sum(replace);



            Console.WriteLine(result4);
            //Anonymous Types
            var customer = new { Id = 1, flashbang = true, name = "sally" };
            Console.WriteLine(customer.Id);
            //Anonymous Methods: exists without a name
            //helps you to elimiate the need to have a full function
            //coded but can have an immdiate function without a name


            //LINQ Any First / Single methods

            var result8 = empList.Average(x => x.Salary);
            var result9 = empList.GroupBy(x => x.Department).Select(emp => new
            {
                Department = emp.Key,
                TotalSalary = emp.Sum(e => e.Salary),
                AverageSalary = Math.Round(emp.Average(e => e.Salary), 2)
            }).OrderBy(x => x.Department);

            var result10 = empList.Any(x => x.Salary > 5002);

            var result11 = empList.FirstOrDefault(x => x.Id == 1) ?? new Employee
            {
                Id = -1,
                Name = "N/a"
            };
            var result12 = empList.Single(x => x.Id == 1);
            var result13 = empList.SingleOrDefault(x => x.Id == 1) ?? new Employee
            {
                Id = -1,
                Name = "N/a"
            };
            Console.WriteLine(result13);
            
            Console.WriteLine(result13);

        }

        public Employee GiveEmp(Employee emp)
        {
            return emp;
        }

        //Immediate vs Deferred Execution
    }
}
