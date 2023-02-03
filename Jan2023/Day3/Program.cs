

using Day3;
using Day3.Entity;
using System.Data.SqlClient;
using System.Text; //Stringbuilder

//string strST = "hello world";

//Console.WriteLine(strST[1]);

////strST[1] = 'm'; //cant change strings

//strST = "hmllo world" + strST;

//StringBuilder sb = new StringBuilder("Hello World");
//sb[0] = 'Q';

//Console.WriteLine(sb);

////Comparerr comp = new Comparerr();
////bool b = comp.CheckEquality("str", new int[]{1,2,3});
////Console.WriteLine(b);

//Comparerr<int> compInt = new Comparerr<int>();
////compInt.CheckEquality("string", "string");
//Comparerr<string> compString = new Comparerr<string>();
//compString.CheckEquality("string", "string");

//List<int> lInt = new List<int>();
//lInt.Add(1);
//lInt.Remove(1);
////List<List<List<int>>> lList = new List<List<List<int>>>();

//Dictionary<int, List<string>> dict = new Dictionary<int, List<string>>();

//SqlConnection sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");

try
{
    //int input = Convert.ToInt32(Console.ReadLine());
    Employee emp = new Employee();
    emp.Age = 75;
}
catch (FormatException ex)
{
    Console.WriteLine("Exception was detected");
    Console.WriteLine("The exception was " + ex.Message);
}
catch (OverflowException ex)
{
    Console.WriteLine("Exception was detected");
    Console.WriteLine("The exception was " + ex.Message);
}
catch(AgeException ex)
{
    Console.WriteLine($"The Exception was {ex.Message}");
}
catch(Exception ex)
{
    Console.WriteLine("anyother Exception is caught here");
}

try 
{
    Console.WriteLine("Try try try");
}
catch(Exception ex)
{

}
finally
{
    //sqlConnection.Close();
    //sqlConnection.Dispose();
    Console.WriteLine("No matter what, I will run");
}
//using (SqlConnection con)
//{

//}
/*

SOLID:
Single Responsibility Prinicple:
A class should only have one reason to change
If a class des more than one thing, consider making two seperate
objects that other services respectively rather than one object 
doing two things

Open/Closed Principle:
Start using upcasting with Interfaces to create an object of 
an interface that allows different functionality
In this way, we are open for extension by creating a new object
that can be upcased into the interfaces
This allows the previous code to be closed for modification because
we are now using another object that does not interfere with previous
working code.

Liskov's substitution princple: A parent having two classes can be 
interchangable with two classes via upcasting without causing errors or
passing new exceptions
This is essentailly adding an open closed pricinple but everything
must follow the ability to be substituted. Virtual should be made 
to create a parent class.

Interface segregation principle: happens when there is an interfaces
that has some properties that does not apply to some of the classes
that inherits it. So divide your interfaces into smaller interfaces that
inherit each other to allow more flexibility.

Counterpoint: If you make a specific interface for one particular thing,
there could be no point of an interface.
Solution: as long as the interface is properly documemted and used with
DI, then it is okay since it allows more flexibility

Dependancy Inversion Princple: high level modeules should not depend
on low level modules but both should depend on abstractions but
abstractions should not depend on details:
It means that we should create more objects using upcasted Interfaces.
This allows for open closed princple and liskov's princple of flexibility
and scalability for an applicaiton. This also lets you unit test
using abstracted interfaces rather than the objects themselves.

*/

var ao = new ArithmeticOperations();
var math = new MathDelegate(ao.Addition);
math(10, 20);
math += ao.Subtraction;
math(30, 15);

//math += ArithmeticOperations.Multiply;

//math -= ao.Subtraction;
//math = null; //clears any stored function pointers

ao.UseDelegate(math, 50, 25);
//math += ao.Sub;
//Action
//Func
//Predicate 

SealedClassEx exOfMap = new SealedClassEx() { DepartmentId=100, DepartmentLocation= "Chicago",
                                EmployeeId = 1000, EmployeeName = "Betty"};
var empEx = new Employee();
var depEx = new Department();
empEx = exOfMap.MapHelper(ref depEx);
