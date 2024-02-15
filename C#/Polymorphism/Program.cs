namespace Polymorphism
{
    internal class Program
    {

        public static int Sum(int x, int y) { return x + y; }
        public static double Sum(double x, int y) { return x + y; }
        public static double Sum(double x, double y) { return x + y; }

        static void Main(string[] args)
        {
            #region Overloading

            Console.WriteLine(Sum(2, 3));
            Console.WriteLine(Sum(2.5, 3.5));
            Console.WriteLine(Sum(2.5, 3));

            #endregion

            Console.WriteLine("----------------------------------------------------");

            #region Overriding

            TypeA a = new TypeA(2);
            a.Fun01();
            a.Fun02();

            TypeB b = new TypeB(2, 4);
            b.Fun01();
            b.Fun02();

            #endregion
        }
    }
}
