using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    /*
     Extension Methods:
    The class containing extension methods must be a static class
    The extension method must be a static method
    The first parameter must be of type which is being executed
    and must include the keyword "this"
     */
    public static class ExtensionMethods
    {
        public static bool IsEven(this int x, int b)
        {
            return (x * b) % 2 == 0;
        }

    }
}
