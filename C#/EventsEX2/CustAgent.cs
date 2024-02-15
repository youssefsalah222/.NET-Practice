
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsEX2
{
    internal class CustAgent
    {
        public string Name { get; set; }


        // V01
        public void ContactCustomer(object sender, EventArgs e)
        {
            if (sender is BankAccount BC)
            {
                Console.WriteLine($"Agent {Name} is contacting customer {BC.CustomerName}");
            }
        }



        public override string ToString() => Name;
    }
}
