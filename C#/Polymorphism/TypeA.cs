using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class TypeA
    {
        public int A { get; set; }
        public TypeA(int a)
        {
            A = a;
        }

        public void Fun01() { Console.WriteLine("Parent Class"); }
        public virtual void Fun02() { Console.WriteLine($"A = {A}"); }
    }
}
