namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region One D Arrays

            /*int[] arr = { 1, 2, 3, 4 };

            Array.Sort(arr);
            
            Console.WriteLine($"Number of Dimensions = {arr.Rank}");

            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]}  ");

            int[] arr2= { 5, 6, 7 };

            Console.WriteLine("Before clone: ");
            Console.WriteLine($"arr = {arr.GetHashCode()}");
            Console.WriteLine($"arr2 = {arr2.GetHashCode()}");

            // arr2 = arr.Clone();
            // error , derived = base : not valid nust use Explicit casting
            // base = derived : valid 

            arr2 = (int[])arr.Clone();
            // arr2 new object , but with same arr value
            
            Console.WriteLine("After clone: ");
            Console.WriteLine($"arr = {arr.GetHashCode()}");
            Console.WriteLine($"arr2 = {arr2.GetHashCode()}");*/

            #endregion

            #region 2D Array

            /*int[,] arr = new int[3,5];

            Console.WriteLine($"Number of rows = {arr.GetLength(0)}");
            Console.WriteLine($"Number of columns = {arr.GetLength(1)}");

            // iterate on 2D aray using one loop

            /*int[,] arr2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < arr2?.Length; i++)
                Console.WriteLine(arr2[i / arr2.GetLength(1) , i % arr2.GetLength(1)]);*/


            #endregion

            #region 2D - Judged Array

            /*int[][] arr = new int[3][];

            // arr[0] = { 1 , 2 , 3};   // Error

            arr[0] = new int[] {1 ,2 ,3};
            arr[1] = new int[] {4 , 5};
            arr[2] = new int[] {6};

            for (int i = 0; i < arr.Length; i++) 
            {
                for (int j = 0; j < arr[i].Length; j++)
                    Console.Write(arr[i][j] + " ");
                Console.WriteLine();
            }*/

            #endregion
         
        }
    }
}
