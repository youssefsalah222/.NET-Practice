using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
     class Employee:IComparable
    {
        public int Id;
        string Name;

        public string GetName()
        {
            return Name;
        }

        internal void SetName(string name)
        {
            Name = name;
        }

        public int CompareTo(object? obj)
        {
            Employee e = (Employee) obj;
            return salary.CompareTo(e.salary);
        }

        decimal salary;

        // Property
        public decimal Salary
        {
            get { return salary; }
            internal set { salary = value; }
        }


        public int Age { get; set; }  // Automatic Property

        // Compiler will generate a hidden (private) attribute and encapsulate it with public property.

        public Employee(int _id , string name , int _salary)
        {
            Id = _id;   
            Name = name;
            Salary = _salary;
        }
     
    }
}
