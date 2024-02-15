using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance___Binding
{
    internal class FullTimeEmployee: Employee
    {
        public int Salary { get; set; }

        public new void Fun01() { Console.WriteLine("Full Time Employee"); }
        public override void Fun02() { Console.WriteLine($"Full Time => {Id}:{Name}:{Age}:{Salary}"); }
    }
}
