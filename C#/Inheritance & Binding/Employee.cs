using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance___Binding
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void Fun01() { Console.WriteLine("Employee"); }
        public virtual void Fun02() { Console.WriteLine($"{Id}:{Name}:{Age}"); }
    }
}
