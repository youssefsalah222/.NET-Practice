using System.Linq;

namespace ImplicitTypedLocalVariable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LINQ : Language Integrated Query
            // Use +40 C# Function (Query Operator) Against Data , Regardless of Data source 

            #region  Implicit Typed Local Variable

            // var v = null;    // Invalid

            var v = 3.4;
            Console.WriteLine(v.GetType()); // Double 

            //    v = "youssef";   // Not valid , C# is strongly typed language , statically typed language

            #endregion

            #region Extension Method

            int x = 12345;
            int y = Int32Extension.Mirror(x);
            Console.WriteLine(y);


            y = x.Mirror();
            Console.WriteLine(y);

            List<int> list = new List<int>() { 1, 2, 3 };

            Console.WriteLine(list.First());  // 1

            #endregion

            #region Anonymous Type

            /* Employee e = new Employee() { Id = 1 , Name = "salah" , Salary = 2000};
                Console.WriteLine(e.GetType().Name);
                Console.WriteLine(e);

                Employee e2 = new Employee() { Id = 1, Name = "salah", Salary = 2000 };

                if (e.Equals(e2))
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");

                // Anonymous Type

                var E = new { Id = 1, Name = "salah", Salary = 2000M };
                Console.WriteLine(E.GetType().Name);

                //  E.Name = "youssef";   /// Invalid , Immutable object

                var E2 = new { Id = 2, Name = "youssef", Salary = 4000M };

                // Same Data Type as long as Same Names (with some characters case) , same property type,
                // same sequence

                Console.WriteLine(E2.GetType().Name);

                var E3 = new { Id = 2, Salary = 4000M , Name = "youssef" };
                // New Anonymous Data Type

                Console.WriteLine(E3.GetType().Name);

                var E4 = new { Id = 2, Name = "youssef", Salary = 4000M };

                if (E2.Equals(E4))
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");

                Console.WriteLine(E2.GetHashCode());
                Console.WriteLine(E4.GetHashCode());
                // same GetHashCode

                // GetHashCode based on values not identity*/

            #endregion

        }
    }
}
