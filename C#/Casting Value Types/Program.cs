namespace Casting_Value_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implicit & Explicit casting

            // 1 : Implicit casting [safe casting] (from smaller to larger)
            //int x = 5;
            //long y = x;

            // 2 : Explicit casting [Unsafe casting] (from larger to smaller)

            //long n1 = 123456789101112;
            //int n2 = (int) n1;
            //Console.WriteLine(n2);   // output is overflow

            // to give me exeption

            // CLR will throw OverFlowException

            //checked
            //{
            //    long n1 = 123456789101112;
            //    int n2 = (int)n1;
            //    Console.WriteLine(n2);
            //} 
            #endregion

            #region Parse

            // string name = Console.ReadLine();

            //// Console.ReadLine() => return string
            // int x = int.Parse(Console.ReadLine());

            // Console.WriteLine(name);    
            // Console.WriteLine(x);    
            #endregion

            #region Convert

            //string name = Console.ReadLine();

            // Console.ReadLine() => return string
            //int x = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(name);
            //Console.WriteLine(x); 
            #endregion
        }
    }
}
