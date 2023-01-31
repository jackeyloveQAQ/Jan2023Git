using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    //Delegates are objects that take in a function pointer as a value
    //[Access modifier] delegate [return-type] name (paramters)
    //Delegates are type safe for functions because it must have the
    //same function signiture as the delegate
    public delegate void MathDelegate(int a, int b);
}
