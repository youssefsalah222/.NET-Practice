using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class Shape
    {
        public int Dim1 { get; set; }
        public int Dim2 { get; set; }

        public Shape(int dim1, int dim2)
        {
            Dim1 = dim1;
            Dim2 = dim2;
        }

        public abstract Double Area();  // Abstract method = virtual + No impelementation

        public abstract double Perimeter { get; }  // Abstract ReadOnly Property  

    }


    abstract class RectangleBase: Shape
    {
        public RectangleBase(int w, int h) : base(w, h) { }

        public override double Area()
        {
            return Dim1 * Dim2;
        }
    }


    class Rectangle : RectangleBase
    {
        public Rectangle(int w, int h) : base(w, h) { }

        public override double Perimeter { get { return 2 * (Dim1 + Dim2);} }
    }
}
