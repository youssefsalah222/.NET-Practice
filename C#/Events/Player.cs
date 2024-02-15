using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Events
{

    // Subsc. 
    internal class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }

        // CallBackMethod
        // match event delegate signature


        // V1
        public void Run ()
        {
            Console.WriteLine($"Player {Name} is running");
        }


        // V2
        public void Run(Location BallNewLocation)
        {
            Console.WriteLine($"Player {Name} is running to {BallNewLocation}");
        }

        public override string ToString() => $"Player: {Name} , Team: {Team}";
    }
}
