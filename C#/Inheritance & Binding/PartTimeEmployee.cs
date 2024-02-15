using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheritance___Binding
{
    internal class PartTimeEmployee: Employee
    {
        public int HourRate { get; set; }
        public int CountOfHours { get; set; }
        public new void Fun01() { Console.WriteLine("Part Time Employee"); }
        public override void Fun02() { Console.WriteLine($"Part Time => {Id}:{Name}:{Age}:{HourRate}:{CountOfHours}"); }
    }
}
