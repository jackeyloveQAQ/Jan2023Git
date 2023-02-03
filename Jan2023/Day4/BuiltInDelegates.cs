using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public class BuiltInDelegates
    {
        //Action: takes in any type/number of input but returns void
        public void usingFuncPointer(int a)
        {
            Console.WriteLine(a);
        }
        public void ActionExample()
        {
            Action<int> action1 = usingFuncPointer;
            Action<int> action2 = (intPara) =>
            {
                int a = 0, b = 1, c = 2;
                for (int i = 0; i < intPara; i++)
                {
                    Console.WriteLine(a + " ");
                    c = a + b;
                    a = b;
                    b = c;
                }
            };
            action2(10);
        }
        public void PredicateExam()
        {
            Predicate<string> isLongerThanTen = str =>
            {
                if (str.Length > 10) return true;
                else return false;
            };
        }
        public void FuncExample()
        {
            Func<string, int, int > isLongerThanInt = (str, num) =>
            {
                if (str.Length > num) return 1;
                else return 0;
            };
        
        }
    }
}
