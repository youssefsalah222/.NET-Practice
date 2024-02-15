namespace Nullable_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = 2;
            // x = null;   Error

            int? y;  // Nullable int , IL --> Nullable<int>

            y = 5;
            y = null;

            // x = y;   // error

            // x = (int)y;
            // Unsafe , explicit

            // Console.WriteLine(x);   // Error , Nullable object must have a value.


            // Protective Programming

            if (y != null)
                x = (int)y;
            else
                x = 0;


            if (y.HasValue)
                x = y.Value;
            else
                x = 0;


            // x = y.HasValue? x = y.Value : 0;


            // Null coalescing operator ( ?? )  ==> syntax suger to ternary opertor

            // x = y ?? 0;   ==> if y = null , x = 0

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");

        }
    }
}
