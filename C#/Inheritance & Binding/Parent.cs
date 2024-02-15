using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance___Binding
{
    internal class Parent
    {

        public int X { get; set; }
        public int Y { get; set; }

        public Parent(int _x, int _y)
        {
            X = _x;
            Y = _y;
            Console.WriteLine("Base");

        }

        public int Product() { return X * Y; }

        public override string ToString()
        {
            return $"{X}:{Y}";
        }
    }

    class Child : Parent
    {
        public int Z { get; set; }

        public Child(int _x, int _y, int _z)
            : base(_x, _y)
        {
            Z = _z;
            Console.WriteLine("Child");
        }


        // Keyword base used only inside Child class not outside
        public new int Product()
        {
            return Z * base.Product();

            //  return X * Y * Z; 
        }   // Overriding

        public override string ToString()
        {
            return $"{X}:{Y}:{Z}";
        }
    }
}
