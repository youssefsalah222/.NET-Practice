using System.Diagnostics;

namespace Stack_Trace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackTrace strace = new StackTrace();

            StackFrame[] sframe = strace.GetFrames();

            for (int i = 0; i < sframe?.Length; i++)
                Console.WriteLine(sframe[i].GetMethod().Name);
        }
    }
}
