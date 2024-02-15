using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance___Binding
{
    internal class TypeA
    {
        public int A { get; set; }

        public TypeA(int _A) { A = _A; }

        public void StaticallyBinded() { Console.WriteLine("Base"); }

        public virtual void DynamicallyBinded() { Console.WriteLine("Base"); }
    }


    class TypeB : TypeA
    {
        public int B { get; set; }

        public TypeB(int _A, int _B)
            : base(_A)
        {
            B = _B;
        }

        public void StaticallyBinded() { Console.WriteLine("Child"); }

        public override void DynamicallyBinded()
        {
            Console.WriteLine("Derived");
        }
    }


    class TypeC : TypeB
    {
        public int C { get; set; }

        public TypeC(int _A, int _B, int _C)
            : base(_A, _B)
        {
            C = _C;
        }

        public override void DynamicallyBinded()
        {
            Console.WriteLine("Derived TypeC");
        }
    }


    class TypeD : TypeC
    {
        public int D { get; set; }
        public TypeD(int _A, int _B, int _C, int _D)
            : base(_A, _B, _C)
        {
            D = _D;
        }


        public new void DynamicallyBinded() { Console.WriteLine("Type D"); }
        // new Statically binded 

        // public new virtual void DynamicallyBinded() { Console.WriteLine("Type D"); }
        // new Dynamically Binded
    }
}
