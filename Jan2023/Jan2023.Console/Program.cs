
using Jan2023.Console;
using Jan2023.Console.Day2;
using System.Collections;

public class Program
{
    public static void Main()
    {
        //Program p = new Program();
        //var answer = p.TwoSum(new int[] { 1, 2, 3, 4 }, 5);
        //foreach(int  i in answer)
        //{
        //    Console.WriteLine(i);
        //}
        ///*
        // int, string, double, float, decimal, bool
        // */
        ///*
        // List, Dictionary, ArrayList, IEnumerable, Hashset
        //Queue, Stack
        // */

        //double dub = 3.14d;
        //float flo = 123.123f;
        //decimal deci = 321.123m;
        //bool flag = true;

        //int inte = (int)deci;
        //Console.WriteLine(inte);
        ////Concatonation
        //string str = "jakdslf;jsldkjf" + "asdfdsfasdf" + inte;

        //string intToString = Convert.ToString(inte);
        ////Interpolation
        //string strInterp = $"The value for Deci = {(int)deci + (int)flo / 3}";
        //Console.WriteLine(strInterp);

        ////Value types vs reference 
        ////value cannot be null
        ////Arrays

        //int[] array1 = new int[10];
        //for(int i = 0; i < array1.Length; i++)
        //{
        //    Console.WriteLine(array1[i]);
        //}
        //foreach(int i in array1)
        //{
        //    Console.WriteLine(i);
        //}

        //int[] array2 = new int[5] { 1, 2, 3, 4, 5 };
        //int[] array3 = new int[] { 1, 2, 3, 4, 5 };
        //int[] array4 = { 4, 2, 1, 4, 5 };

        ////two diminsional arrays
        //int[,] array5 = new int[2, 3];
        //int[,] array6 = { { 1, 2, 3 }, { 4, 5, 6 } };

        //Array.Sort(array4);

    

        //LearningParameters lp = new LearningParameters();

        //int a = 10;
        //int b = 20;
        //lp.PassByValue(a, b);
        //Console.WriteLine($"a = {a}, b = {b}");

        //lp.PassByRef(ref a, ref b);
        //Console.WriteLine($"a = {a}, b = {b}");

        //string msg = "";
        //bool result = lp.Author( "bob", "biily", out msg);
        //Console.WriteLine(result + " " + msg);

        //lp.DefPara();
        //lp.DefPara(200, 3);



        //lp.ParamsLearning(1, "this is the string", 2, 3, 4, 5, 5, 6, 7, 8);//Actual
        //Console.ReadKey();

        Employee employee = new Employee(1, "Sam", "sam@gmail.com");
        FullTime femployee = new FullTime(1, "Sam", "sam@gmail.com");


    }
    ////LeetCode Question 1
    //public int[] TwoSum(int[] arr, int target)
    //{
    //    //Your code here
    //    return new int[] { 0, 0 };
    //}

    /*
     Constructors are used to create an object of the class and initialize class member
    Default constructirs do not take any parameters
    if we create any other constructor, default constructor will be replaced
    constructors can be overloaded
    Constructors cannot be inherited so a constructor cannot be overridden
    By default, derived class constructor will make a call to the base class parameterless
    constructor.
     */
}