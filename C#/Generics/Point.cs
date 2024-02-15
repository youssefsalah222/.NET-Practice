using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Point:IComparable<Point>
    {
        public int X {  get; set; }
        public int Y { get; set; }

        public int CompareTo(Point? other)
        {
            if (X == other.X)
                return Y.CompareTo(other.Y);
            return X.CompareTo(other.X);
        }
    }
}
