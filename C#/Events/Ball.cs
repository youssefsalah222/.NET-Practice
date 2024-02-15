using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{

    // Publisher Class
    internal class Ball
    {
        public int ID {  get; set; }

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
                    BallLocationChanged?.Invoke();
                    // Loop through invocation list
                    // Call Subscriberes. Call back method
                }
            }
        }

        // Event declaration

        public event Action BallLocationChanged;


        public override string ToString() => $"Ball {ID} at {ballLocation}";
    }
}
