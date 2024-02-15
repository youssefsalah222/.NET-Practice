using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Airplane : Imoveable, Iflyable
    {

        // Implement interface explicitly
        void Iflyable.Forward()
        {
            Console.WriteLine("On Air");
        }

        void Imoveable.Forward()
        {
            Console.WriteLine("On Ground");
        }
    }
}
