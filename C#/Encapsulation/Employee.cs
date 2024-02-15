using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Employee
    {
        #region Attributes

        public int id;
        public string name;
        #endregion

        #region Setter & Getter

        public string GetName() { return name; }
        public void SetName(string n) { name = n; }

        #endregion

        #region Full Proprety

        /*   public int ID
           {
               get { return id; }
               set { id = value; }
           }

           public string Name
           {
               get { return name; }
               set { name = value; }
           }*/

        #endregion

        #region Automatic Property

        public int ID { get; set; }
        public string Name { get; set; }

        #endregion

        #region Constructor

        public Employee(int _id, string _name)
        {
            id = _id;
            name = _name;
        }

        #endregion

        public override string ToString()
        {
            return $"{id} : {name}";
        }
    }
}
