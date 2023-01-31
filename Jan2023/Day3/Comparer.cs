using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class Comparerr<T> 
    {
        //Dont Repeat Yourself DRY
        //public bool CheckEquality(int a, int b)
        //{
        //    return a == b;
        //}
        //public bool CheckEquality(float a, float b)
        //{
        //    return a == b;
        //    //return a.Equals(b);
        //}

        //public bool CheckEquality(object a, object b)
        //{
        //    return a.Equals(b);
        //}

        public bool CheckEquality(T a, T b)
        {
            return a.Equals(b);
        }
    }
}
