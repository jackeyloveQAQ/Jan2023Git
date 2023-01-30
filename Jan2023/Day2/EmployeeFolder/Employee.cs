

namespace Day2.EmployeeFolder
{
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
        public Employee()
        {
            Console.WriteLine("From Base Parameterless Constructor");
        }
        public Employee(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        // All abstract methods are virtual
        // Virtual means that the following method has the OPTION to be overridden.
        public virtual void Work()
        {
            Console.WriteLine("Working from Employeee class");
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
        public override void Work()
        {
            Console.WriteLine("Im fulltime working");
        }
    }

    public class PartTime : Employee
    {
        static PartTime()
        {
            Console.WriteLine("first");
        }
        public PartTime()
        {
            Console.WriteLine("From Parameterless PartTime constructor");
        }
        public PartTime(int id, string name, string email)
        {
            Console.WriteLine("From FullTime Constructor");
        }
        public override void Work()
        {
            Console.WriteLine("Im fulltime working");
        }
    }
}
