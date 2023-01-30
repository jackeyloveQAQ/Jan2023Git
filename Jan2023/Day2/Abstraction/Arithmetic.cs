using HelperLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Abstraction
{
    public class Arithmetic :  IArithmetic, ISeconds
    {
        //public override int SomeNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        void IArithmetic.Addition(params int[] arr)
        {
            throw new NotImplementedException();
        }
        void ISeconds.Addition(params int[] arr)
        {
            throw new NotImplementedException();
        }

        public void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
            Console.WriteLine(StaticHelper.value);
        }

        public void Subtraction()
        {
            throw new NotImplementedException();
        }

        //public override void SomeMethod(int i)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
