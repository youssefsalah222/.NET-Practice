namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Abstract

            /*// Shape S;   // Valid

              //   S = new Shape();  // Not Valid


              Rectangle R = new Rectangle(10, 20);
              Console.WriteLine(R.Area());  // 200 

              Console.WriteLine(R.Perimeter);  // 60*/
            #endregion

            #region Sealed

            TypeB b = new TypeB();
            b.MyFun();

            #endregion

        }
    }
}
