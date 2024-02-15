using System.Text;

namespace String_VS_Stringbuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String

            string s = "Youssef";
            Console.WriteLine(s.GetHashCode());
            Console.WriteLine("=========================");
            s = new string("salah");
            s = "salah";       // suger syntax

            Console.WriteLine(s.GetHashCode());

            //==================================================================

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            // string msg = string.Format("Result {x} + {y} = {x+y}", x, y, x + y);  // Error

            string msg2 = string.Format("Result {0} + {1} = {2}", x, y, x + y);


            Console.WriteLine(msg2);

            // string is immutable type 

            #endregion

            Console.WriteLine("---------------------------------------------------------------");

            #region StringBuilder

            StringBuilder sb;
            sb = new StringBuilder();
            sb.Append("Youssef");
            Console.WriteLine($"Name is {sb} with code = {sb.GetHashCode()}");
            Console.WriteLine("=========================");
            sb.Append("Salah");
            Console.WriteLine($"Name is {sb} with code = {sb.GetHashCode()}");

            #endregion
        }
    }
}
