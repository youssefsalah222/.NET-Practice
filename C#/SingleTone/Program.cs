using Classes;

namespace SingleTone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GCard c1 = GCard.GetCard();
            GCard c2 = GCard.GetCard();
            Console.WriteLine($"c1 = {c1.GetHashCode()}");
            Console.WriteLine($"c2 = {c2.GetHashCode()}");


            // GCard c1 = GCard.SingleToneObj; 
        }
    }
}
