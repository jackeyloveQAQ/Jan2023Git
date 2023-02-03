using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class ArithmeticOperations
    {
        public void Addition(int first, int second)
        {
            Console.WriteLine(first + second);
        }
        public void Subtraction(int first, int second)
        {
            Console.WriteLine(first - second);
        }
        public void UseDelegate(MathDelegate del, int a, int b)
        {
            del(a, b);
        }
        public static void Multiply(int first, int second)
        {
            Console.WriteLine(first * second);
        }

        public void Sub(double a, int b)
        {
            Console.WriteLine( a + b);
        }
    }
}
