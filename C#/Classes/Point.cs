using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Point
    {
        public int X {  get; set; }
        public int Y {  get; set; }



        // Make Equals functions Value Equality
        public override bool Equals(object? obj)
        {

            // Point p = (Point)obj;  // Unsafe casting


            // (1)

            /*  if (obj is Point)  // is return false if casting will fail , no exceptions will be thrown
              {
                  Point p = (Point)obj;
                  return (X == p.X && Y == p.Y);
              }*/


            // (2)

            /*  if (obj is Point p)
                  return (X == p.X && Y == p.Y);
              return false;*/ 


            // (3)

            Point p = obj as Point;  // as returns null if casting fails , no exceptions will be thrown

            if (p == null) return false;
            if (this.GetType() != p.GetType()) return false;
            return (X == p.X && Y == p.Y);


        }
    }
}
