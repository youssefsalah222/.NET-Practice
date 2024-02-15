using System.Security.Cryptography;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Classes

            /*Car c1 = new Car(202, "JEEP", 140);
                Car c2 = new Car(100);

                Console.WriteLine(c1);
                Console.WriteLine(c2);
                c2 = c1;

                Console.WriteLine(c1.GetHashCode());
                Console.WriteLine(c2.GetHashCode());

                Console.WriteLine("==========================");

                // c2 new obj with new identity , same state as c1

                c2 = new Car(c1);   // copy constructor

                Console.WriteLine(c1.GetHashCode());
                Console.WriteLine(c2.GetHashCode());

                Console.WriteLine("==========================");

                c2 = (Car)c1.Clone();   // must implement ICloneable interface

                Console.WriteLine(c1.GetHashCode());
                Console.WriteLine(c2.GetHashCode()); */
            #endregion

            #region Static ctor , Static class

            // Console.WriteLine(Utility.CircleArea(10));

            #endregion

            #region Equals

            /*Point p1 = new Point() { X = 10 , Y = 20};
                Point p2 = new Point() { X = 10 , Y = 20};

                if (p1.Equals(p2))
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");

                // Yes  ==> p1 values = p2 values

                Console.WriteLine("==========================");
                if (p1.Equals("p2"))
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");

                // No  ==> Can't cast string to point

                Console.WriteLine("==========================");

                p2 = default;

                if (p1.Equals(p2))
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");

                // No 

                Console.WriteLine("==========================");

                Point p4 = new Point3D() { X = 10 , Y = 20 , Z = 30};

                if (p1.Equals(p4))
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");

                // No ==> Not the same Type*/ 
            #endregion

        }

       
    }
}
