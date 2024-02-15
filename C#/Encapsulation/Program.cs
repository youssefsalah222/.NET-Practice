namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Employee e = new Employee(22 , "Youssef");
           Console.WriteLine(e);
           e.SetName("Salah");
           Console.WriteLine(e.GetName());
           e.Name = "Abdelrahman";
           Console.WriteLine(e.Name);

        }
    }
}
