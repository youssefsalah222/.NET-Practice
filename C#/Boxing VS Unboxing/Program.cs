namespace Boxing_VS_Unboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Boxing

            // System.Object & any value type

            /* int x = 5;
             object o = new object();
             o = x;
             // base = child
             // safe*/

            #endregion

            #region Unboxing

            /*int y;

            object O = new object();
 

            // y = O;
            // error , derived = base 
            // unsafe  , use explicit 

            y = (int)O;*/


            #endregion
        }
    }
}
