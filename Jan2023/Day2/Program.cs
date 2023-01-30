using Day2.Abstraction;
using Day2.EmployeeFolder;
using HelperLibrary;
namespace Day2;

public class Program
{
    public static void Main()
    {
        //Visitor visit = new Visitor();

        ////Upcasting
        Employee empWithFull = new FullTime();

        //empWithFull.Work();

        //Employee employee = new Employee();
        //FullTime fulltime = new FullTime();

        //employee.Work();
        //// If we dont override, it takes in Employee's method
        //// If we do override, we use Fulltime method
        //empWithFull.Work();
        //fulltime.Work();


        //Employee employeeP = new PartTime();
        //employeeP.Work();

        //int i = 0;
        //Object o = i;
        //int j = (int)o;

        //Enums
        //DaysOfWeek e = DaysOfWeek.Saturday;
        //if((int)e == 6)
        //{
        //    Console.WriteLine("Today is a saturday");
        //}
        //switch (e)
        //{
        //    case (DaysOfWeek.Monday):
        //        Console.WriteLine("Do something for monday");
        //        break;
        //    case (DaysOfWeek.Tuesday):
        //        Console.WriteLine("Do Something for Tuesday");
        //        break;
        //    default:
        //        Console.WriteLine("Do something for default");
        //        break;
        //}

        //switch (empWithFull)
        //{
        //    case (PartTime):
        //        Console.WriteLine("Do something for PartTime");
        //        break;
        //    case (FullTime):
        //        Console.WriteLine("Do Something for FullTime");
        //        break;
        //    default:
        //        Console.WriteLine("Do something for default");
        //        break;
        //}
        //int read = Convert.ToInt32(Console.ReadKey());
        //Employee emp = Program.Choice(read);


        Shapes s = new Square();

        IArithmetic a = new Arithmetic();
        ISeconds sec = new Arithmetic();

        //Static:
        //Belonging to the class level
        //USed for Extension Methods
        int ten = 10;
        Console.WriteLine(ten.IsEven(22));

        StaticHelper.Qwerty();
        //Singleton
        Console.WriteLine(StaticHelper.value);
        //StaticHelper.value = 1000;
        Arithmetic arith = new Arithmetic();
        arith.Multiply(10 , 20);


        //Generics
        //Design patterns
        //Sample application
        //Delegates
        //Exceptions and exception handling

    }

    public static void WorkEmployee(Employee e)
    {
        e.Work();

        if(e is FullTime)
        {
            Console.WriteLine("This object came from Fulltime");
            FullTime fFromEmp = (FullTime)e;
        }
    }

    public static Employee Choice(int choice)
    {
        switch (choice)
        {
            case (1):
                return new FullTime();
                break;
            case (2):
                return new PartTime();
                break;
            default:
                return new Employee();
                break;
        }
    }
}