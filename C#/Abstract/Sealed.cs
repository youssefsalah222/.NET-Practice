using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    sealed class Sealed
    {
        public int X {  get; set; }
    }

    //  class Child : Sealed { }    // Not Valid

    abstract class TypeA
    {
        public abstract void MyFun();
    }

    sealed class Sealed2 : TypeA     // Valid
    {
        public override void MyFun()
        {
            throw new NotImplementedException();
        }
    }

    class TypeB : TypeA
    {
        public sealed override void MyFun()
        {
            Console.WriteLine("Yes"); ;
        }
    }

   /* class TypeC : TypeB
    {
        public override void MyFun()    // Not Valid
        {
            Console.WriteLine("Yes"); ;
        }
    }*/




}
