using System.Text;

namespace Deep___Shallow_Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Array of Value Type

            Console.WriteLine("=====  Array of Value Type  =======");

            int[] arr01 = { 1, 2, 3 };
            int[] arr02 = new int[3];

            #region Shallow Copy

            Console.WriteLine("==========  Shallow Copy ============");

            arr02 = arr01;

            Console.WriteLine($"Arr01 = {arr01.GetHashCode()}");
            Console.WriteLine($"Arr02 = {arr02.GetHashCode()}");
            // Same address
            arr02[0] = 100;

            Console.WriteLine($"Arr01 = {arr01[0]}");   // 100
            Console.WriteLine($"Arr02 = {arr02[0]}");   // 100

            #endregion

            #region Deep Copy

            Console.WriteLine("========= Deep Copy =================");

            arr02 = (int[])arr01.Clone();
            Console.WriteLine($"Arr01 = {arr01.GetHashCode()}");
            Console.WriteLine($"Arr02 = {arr02.GetHashCode()}");
            // Not same address 

            arr02[1] = 200;

            Console.WriteLine($"Arr01 = {arr01[1]}");   // 2
            Console.WriteLine($"Arr02 = {arr02[1]}");   // 200

            #endregion

            #endregion

            Console.WriteLine("================================================");

            #region Array of Ref Type - immutable

            Console.WriteLine("=====  Array of Ref Type [immutable]  =======");

            string[] Names01 = new string[] { "Youssef" };
            string[] Names02 = new string[1];

            #region Shallow Copy

            Console.WriteLine("==========  Shallow Copy ============");

            Names02 = Names01;

            Console.WriteLine($"Names01 = {Names01.GetHashCode()}");
            Console.WriteLine($"Names02 = {Names02.GetHashCode()}");
            // Same address
            Names02[0] = "Salah";

            Console.WriteLine($"Names01 = {Names01[0]}");   // Salah
            Console.WriteLine($"Names02 = {Names02[0]}");   // Salah

            #endregion

            #region Deep Copy

            Console.WriteLine("========= Deep Copy =================");

            Names02 = (string[])Names01.Clone();

            Console.WriteLine($"Names01 = {Names01.GetHashCode()}");
            Console.WriteLine($"Names02 = {Names02.GetHashCode()}");

            Names02[0] = "Adham";

            Console.WriteLine($"Names01 = {Names01[0]}");   // Salah
            Console.WriteLine($"Names02 = {Names02[0]}");   // Adham

            #endregion

            #endregion

            Console.WriteLine("================================================");

            #region Array of Ref Type - Mutable

            Console.WriteLine("=====  Array of Ref Type [Mutable]  =======");

            StringBuilder[] sbNames01 = new StringBuilder[1];
            // sbNames01.Append("Youssef");   // NullReferenceException

            sbNames01[0] = new StringBuilder("Youssef");

            StringBuilder[] sbNames02 = new StringBuilder[1];

            #region Shallow Copy

            Console.WriteLine("==========  Shallow Copy ============");

            sbNames02 = sbNames01;

            Console.WriteLine($"Names01 = {sbNames01.GetHashCode()}");
            Console.WriteLine($"Names02 = {sbNames02.GetHashCode()}");
            // Same address

            sbNames02[0].Append("Salah");

            Console.WriteLine($"Names01 = {sbNames01[0]}");   // YoussefSalah
            Console.WriteLine($"Names02 = {sbNames02[0]}");   // YoussefSalah

            #endregion

            #region Deep Copy

            Console.WriteLine("========= Deep Copy =================");

            sbNames02 = (StringBuilder[]) sbNames01.Clone();
            Console.WriteLine($"Names01 = {sbNames01.GetHashCode()}");
            Console.WriteLine($"Names02 = {sbNames02.GetHashCode()}");

            sbNames02[0].Append("Abdelrahman");

            Console.WriteLine($"Names01 = {sbNames01[0]}");   // YoussefSalahAbdelrahman
            Console.WriteLine($"Names02 = {sbNames02[0]}");   // YoussefSalahAbdelrahman

            #endregion

            #endregion

        }
    }
}
