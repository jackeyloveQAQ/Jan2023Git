namespace Jan2023.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class LearningParameters
{
    public int PassByValue(int a, int b)
    {
        a = 100;
        b = 200;
        Console.WriteLine($"a = {a}, b = {b} sum = {a+b} inside function");
        return a + b;
    }
    public int PassByRef( ref int a, ref int b)
    {
        a = 100;
        b = 200;
        Console.WriteLine($"a = {a}, b = {b} sum = {a + b} inside function");
        return a + b;
    }
    public bool Author(string uname, string pass, out string msg)
    {
        msg = "";
        if(uname == "bob" && pass == "smith")
        {
            msg = "verified";
            return true;
        }
        else
        {
            msg = "Not verified";
            return false;
        }
    }

    public void DefPara( int hundo = 100, double pi = 3.14)
    {
        Console.WriteLine(hundo * pi);
    }


    public void ParamsLearning(int a, string str, params int[] ints)//Formal
    {
        int sum = 0;
        foreach (int i in ints)
        {
            sum += i;

        }
        Console.WriteLine(sum);
    }
}
