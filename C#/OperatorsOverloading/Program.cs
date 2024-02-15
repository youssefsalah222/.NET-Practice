using Classes;

namespace OperatorsOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Operator Overloading & Casting Operator Overloading

            Complex c1 = new Complex() { Real = 20, Imag = 30 };
            Complex c2 = new() { Real = 40, Imag = 50 };
            Complex c3 = default, c4 = default;

            c3 = c1 + c2;  // Error without operator overloading
            /*
                        c4 = c1 + 10;

                        c1 += c2;

                        int x = 20;
                        int y = -x;   // unary arithmatic operator 
                                      // c1 = -c2;

                        c3 = ++c1;
                        c3 = c2++;*/

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);

            int z = (int)c1;   // Casting Operator Overloading

            string ss = c2;

            #endregion

            Console.WriteLine("========================================");

            #region User Definded Casting Operator (Manual Mapping)

            Employee e = new Employee() { Id = 10 , FullName = "Youssef Salah" , Password = "22"};

            EmployeeViewModel evm = (EmployeeViewModel) e;

            Console.WriteLine(evm.FName);
            Console.WriteLine(evm.LName);

            #endregion
        }
    }
}
