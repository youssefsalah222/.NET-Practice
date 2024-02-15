using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{

   // Generics Constraints
     class Helper<T>
        where T :
         /* Primary Constraints
          0 or 1
         // Special Primary Constraints

         // class  // T must be class 

         //  struct  // T must be struct

         // General Primary Constraints  [class name]

         Point   
         // T Point or Point child
         */

         /* Secondary Constraints
          Interface Constraints
          T must be Class / Struct implemeting IComparable
         0 or many
          */

          IComparable<T>

         /* Constructor Constraints 
           
          , new ()    //  T having accessable parameterless ctor

         // Can not use new() with struct Special Primary Constraints */

    {


        public static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;

        }

        public Helper() 
        {
          T X;
          T Y;
            X = default;
            Y = default;


            //  where T : IComparable

            /*if (X.CompareTo(Y) > 0)
                Console.WriteLine("yes");*/


            //  where T : class

            /*    X = null;
                if (X == Y) ;*/


            //  where T : struct

           //  X = new T();

        }

    }
}
