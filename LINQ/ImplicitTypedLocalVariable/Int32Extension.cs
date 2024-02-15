using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitTypedLocalVariable
{
    static class Int32Extension
    {

        // Extension Method
        public static int Mirror (this int i)
        {
            var arr = i.ToString().ToCharArray();

            Array.Reverse(arr);
            return int.Parse(new string(arr));
        }
    }
}
