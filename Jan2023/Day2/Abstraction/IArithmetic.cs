using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Abstraction
{
    //Interfaces: is a contract that gives a list of methods which must be
    //implemented by the derived class

    /*
     Interfaces by default has all members as public
    interfaces can only hae method declaration and not implemention
    interfaces cannot have constructors, but abstract can
    interfaces connot have variables but can have properties
    you cannot make instance of an interface, but you can still upcast
    interfaces can support multiple inheritance but abstract classes cannot
     */
    public interface IArithmetic
    {
        public void Addition(params int[] arr);
        public void Subtraction();
    }
}
