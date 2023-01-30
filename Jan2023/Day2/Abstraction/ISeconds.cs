using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Abstraction
{
    public interface ISeconds
    {
        public void Addition(params int[] seconds);
        public void Multiply(int a, int b);
    }
}
