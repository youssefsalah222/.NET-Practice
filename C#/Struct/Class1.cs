using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{

    // default access modifier inside namespace is internal
    struct point 
    {

        // internal int z;  
        //accessable inside the same project
 
        int x;
        int y;

        // User defined constructor

        public point (int _x, int _y)
        {
            // any user defined constructor in struct
            // Constructor must be fully initialize all struct attributes

            x = _x;
            y = _y;
        }

        public override string ToString()
        {
            return $"({x} , {y})";
        }


        // struct can't have user defined parameterless constructor

        /* public point()
         {

         } */
    }
}
