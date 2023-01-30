using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Abstraction
{
    //Abstract class: abstract classes cannot be instantiated but contrete classes can
    //As long as there is one abstract method in the class, the class must be abstract.
    // Abstract classes can contain concrete methods as well as abstract methods.

    //Abstract method: is a method that can be used in an abstract class.
    //It doesnt have a body and the body is provided in the derived class
    //Abstract vs virtual:
    //Abstract method doesnt provide implementation and forced derived class to override
    //Virtual gives the OPTION of overriding.

    public abstract class Shapes
    {
        public Shapes()
        {
            
        }
        public int Id { get; set; }
        public abstract int SomeNumber { get; set; }

        public abstract void SomeMethod(int i);

        public int GetId()
        {
            return Id;
        }
    }
    public class Square : Shapes, IArithmetic
    {
        public override int SomeNumber { get; set; }

        public void Addition(params int[] arr)
        {
            throw new NotImplementedException();
        }

        public override void SomeMethod(int i)
        {
            Console.WriteLine("Out some method");
        }

        public void Subtraction()
        {
            throw new NotImplementedException();
        }
    }
}
