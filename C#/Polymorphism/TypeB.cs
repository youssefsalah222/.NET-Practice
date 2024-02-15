using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class TypeB: TypeA
    {
        public int B { get; set; }
        public TypeB(int a, int b) : base(a) { B = b; }

        // Apply Overriding using New Keyword
        public new void Fun01() { Console.WriteLine("Child Class"); }

        // Apply Overriding using Override Keyword
        public override void Fun02() { Console.WriteLine($"A = {A} , B = {B}"); }
    }
}
