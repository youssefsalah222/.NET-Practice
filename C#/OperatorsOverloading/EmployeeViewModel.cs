using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsOverloading
{
    internal class EmployeeViewModel
    {
        public string FName { get; set; }
        public string LName { get; set; }

        public static explicit operator EmployeeViewModel(Employee e)
        {
            string[] Name = e.FullName.Split(' ');
            return new EmployeeViewModel()
            {
                FName = Name[0],
                LName = Name[1]
            };
        }
    }
}
