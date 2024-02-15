using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class BallV02
    {
        public int ID { get; set; }

        Location ballLocation;

        internal Location BallLocation
        {
            get => ballLocation;
            set
            {
                if (value != ballLocation)   // there is no == or != in struct (must use operator overloading)
                {
                    ballLocation = value;
                    // Notify Subscriberes
                    BallLocationChanged?.Invoke(ballLocation);
                    // Loop through invocation list
                    // Call Subscriberes. Call back method
                }
            }
        }

        // Event declaration

        public event Action<Location> BallLocationChanged;


        public override string ToString() => $"Ball {ID} at {ballLocation}";
    }
}
