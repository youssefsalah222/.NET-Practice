using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitTypedLocalVariable
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj is  Employee R) 
            {
                if (R == null) return false;

                if (this.GetType() != R.GetType()) return false;

                return (Id == R.Id) && (Name == R.Name) && (Salary == R.Salary);
            }

            return false;
        }

        public override string ToString() => $"{Id}:{Name}:{Salary}";
    }
}
