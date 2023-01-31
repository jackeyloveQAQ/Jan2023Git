using Day3.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class EmployeeRepo
    {
        //Single Responciplity Princple 
        //Solid Principle Design patterns #1 
        //Repositories interact with the Database
        //Services Use Repository methods to
        //implement Business logic
        List<Employee> _db;
        public EmployeeRepo()
        {
            _db = new List<Employee>();
        }

        public void AddEmployee(Employee emp)
        {
            _db.Add(emp);
        }
        public List<Employee> GetAllEmployee()
        {
            return _db;
        }
        public void UpdateEmployee(Employee empInput)
        {

        }
        public void DeleteEmployee(int id)
        {
            foreach(Employee emp in _db)
            {
                if(emp.Id == id)
                {
                    _db.Remove(emp);
                }
            }
        }

    }
}
