namespace Generics
{
    internal class Program
    {

        // Generic method in non generic class
        public static void Swap<T>(ref T x , ref T y)
        {
            T temp = x;
            x = y;
            y = temp;

        }

        static void Main(string[] args)
        {
            #region Generic Method

            /*int a = 3 , b = 4;
                Swap<int>(ref a, ref b);
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine("==========================");

                double x = 4.2, y = 5.2;
                Swap(ref x, ref y);
                Console.WriteLine(x);
                Console.WriteLine(y);*/

            // In case of Generic method (Not Generic class / struct / interface)
            // Compiler can detect parameter T type from input parameteres

            #endregion

            #region Generic Class

            /* int a = 3, b = 4;
                Helper<int>.Swap(ref a, ref b);  // No Type inference for Generic class
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine("==========================");

                double x = 4.2, y = 5.2;
                Helper<double>.Swap(ref x, ref y);
                Console.WriteLine(x);
                Console.WriteLine(y);

                Console.WriteLine("==========================");

                Point p1 = new Point () { X = 10 , Y = 20 };
                Point p2 = new Point () {  Y = 30 , X = 40 };

                Helper<Point>.Swap(ref p1, ref p2);*/ 

            #endregion
        }
    }
}
