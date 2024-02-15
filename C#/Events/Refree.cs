using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{

    // Subsc.
    internal class Refree
    {
        public string Name { get; set; }

        // CallBackMethod
        // match event delegate signature


        // V1
        public void Look()
        {
            Console.WriteLine($"Refree {Name} is Looking");
        }


        // V2
        public void Look(Location l)
        {
            Console.WriteLine($"Refree {Name} is Looking at {l}");
        }

        public override string ToString() => $"Refree: {Name}";
    }
}
