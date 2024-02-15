namespace Inheritance___Binding
{
    internal class Program
    {

        public static void CallEmployee(Employee employee)
        {
            employee.Fun01();
            employee.Fun02();
        }

        static void Main(string[] args)
        {
            #region Inheritance

            Parent P = new Parent(2, 5);
            Console.WriteLine(P.Product());

            Child C = new Child(5, 5, 5);
            Console.WriteLine(C.Product());

            #endregion

            Console.WriteLine("=========================================");

            #region Binding (Virtual)

            TypeA baseRef = new TypeA(2);

            baseRef = new TypeB(6, 5);
            // Ref to base  = Derived Object

            baseRef.StaticallyBinded();   // base

            // Statically Binded methods (non virtual) cpmpiler bind call base in reference type
            // not object type

            baseRef.DynamicallyBinded();  // Derived 

            // Dynamically Binded method , CLR will bind function call based on Object type
            // Not reference type


            baseRef = new TypeC(6, 5, 10);
            baseRef.DynamicallyBinded();   // Derived TypeC

            baseRef = new TypeD(10, 20, 30, 40);
            baseRef.DynamicallyBinded();   // Derived TypeC

            TypeD td = new TypeD(10, 20, 30, 40);
            td.DynamicallyBinded();  // Type D

            #endregion

            Console.WriteLine("=========================================");

            #region Binding EX

            FullTimeEmployee FTE = new FullTimeEmployee();
            CallEmployee(FTE);

            PartTimeEmployee PTE = new PartTimeEmployee();
            CallEmployee(PTE);

            #endregion
        }
    }
}
