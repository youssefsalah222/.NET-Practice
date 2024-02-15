namespace Functions
{
    internal class Program
    {

        public static int SumArray(int[] arr) 
        {
            int sum = 0;
            arr[0] = 100;
            if (arr != null)
                for (int i = 0; i < arr.Length; i++)    
                    sum += arr[i];
            return sum;
        }

        public static int SumArray(ref int[] arr)
        {
            int sum = 0;
            arr[0] = 100;
            if (arr != null)
                for (int i = 0; i < arr.Length; i++)
                    sum += arr[i];
            return sum;
        }

        public static int SumArray01(int[] arr)
        {
            int sum = 0;
            arr = new int[] { 4 , 5 ,6};
            if (arr != null)
                for (int i = 0; i < arr.Length; i++)
                    sum += arr[i];
            return sum;
        }

        public static int SumArray01(ref int[] arr)
        {
            int sum = 0;
            arr = new int[] { 4, 5, 6 };
            if (arr != null)
                for (int i = 0; i < arr.Length; i++)
                    sum += arr[i];
            return sum;
        }

        public static int SumArray02(int count , params int[] arr)
        {
            int sum = 0;
            if (arr != null)
                for (int i = 0; i < arr.Length; i++)
                    sum += arr[i];
            return sum;
        }

        public static void SumMul(int x , int y , out int s , out int mul)
        {
            s = x + y;
            mul = x * y;
        }

        static void Main(string[] args)
        {
            #region Reference Type pass by value

            /* int[] num = { 1, 2, 3 };
             Console.WriteLine(num[0]);
             int res = SumArray(num);
             Console.WriteLine($"Result = {res}");
             Console.WriteLine(num[0]);*/

            #endregion

            #region Reference Type pass by ref

            /*int[] num = { 1, 2, 3 };
            Console.WriteLine(num[0]);
            Console.WriteLine($"Result = {SumArray(ref num)}");
            Console.WriteLine(num[0]); */


            #endregion

            #region Reference Type pass by value EX02

            /*int[] num = { 1, 2, 3 };
            Console.WriteLine(num[0]);  // 1 
            Console.WriteLine($"Result = {SumArray01(num)}");  // 15 
            Console.WriteLine(num[0]);    // 1 */

            #endregion

            #region Reference Type pass by ref EX02

            /* int[] num = { 1, 2, 3 };
             Console.WriteLine(num[0]);  // 1
             Console.WriteLine($"Result = {SumArray01(ref num)}");  // 15
             Console.WriteLine(num[0]);    //  4*/

            #endregion

            #region By out parameter

            int n1 = 20, n2 = 10;
           /* SumMul(n1 , n2 , out int s , out int mul);
            Console.WriteLine($"Sum = {s}");
            Console.WriteLine($"Mul = {mul}");*/

            // Discard (do not use out parameter)

            SumMul(n1, n2, out _, out int mul);
            Console.WriteLine($"Mul = {mul}");

            #endregion

            #region Params

           // int[] Nums = new int[] { 8, 9, 10, };
          //  Console.WriteLine(SumArray02(3 , 10 , 20 , 30));


            #endregion
        }
    }
}
