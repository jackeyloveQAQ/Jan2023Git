
namespace Jan2023.Console.Day2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Employee
    {
        //private int _id;
        //public int Id
        //{
        //    get { return _id; }
        //    set
        //    {
        //        _id = value;
        //    }
        //}
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Employee() {
        Console.WriteLine("From Base Parameterless Constructor"); 
        }
        public Employee(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

    }
    public class FullTime : Employee
    {
        static FullTime() 
        {
        Console.WriteLine("first");
        }
        public FullTime()
        {
        Console.WriteLine("From Parameterless fullTime constructor");
        }
        public FullTime(int id, string name, string email)
        {
            Console.WriteLine("From FullTime Constructor");
        }
    }



