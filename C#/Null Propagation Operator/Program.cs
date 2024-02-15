namespace Null_Propagation_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = default;
            Console.WriteLine(x); // 0

            int[] arr = default;

            //for (int i = 0; i < arr.Length; i++)
            //    Console.WriteLine(arr[i]);

            // NullReferenceException 


            for (int i = 0; (arr != null) && (i < arr.Length); i++)
                Console.WriteLine(arr[i]);


            // Null Propagation Operator or Null Conditional Operator
            for (int i = 0; arr?.Length > 0; i++)
                Console.WriteLine(arr[i]);

            // do not call Length if arr is null 


            Emp e = default;
            // Console.WriteLine(e.de.name);  // Unsafe

            Console.WriteLine(e?.de?.name ?? "NF");

         //   int r1 = arr.Length;  // Unsafe

            int? r2 = arr?.Length;  // Safe ,

            // arr?.Length ==> (arr != null) ? arr?.Length : null

        }
    }

    class Dep
    {
        public string name;
    }

    class Emp
    {
        public Dep de;
    }
}
