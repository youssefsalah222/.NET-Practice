namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook(10);
            phoneBook.AddPerson(0, "Youssef", 2002);
            phoneBook.AddPerson(1, "Salah", 2222);

            phoneBook["Salah"] = 2002;
            Console.WriteLine(phoneBook["Salah"]);

            phoneBook["Ali"] = 1999;
            Console.WriteLine(phoneBook["Ali"]);   // Not found

            phoneBook[2, "Ali"] = 1889;
            Console.WriteLine(phoneBook["Ali"]);

            for (int i = 0; i < phoneBook.Size; i++) Console.WriteLine(phoneBook[i]);  // Print Indexer
        }
    }
}
