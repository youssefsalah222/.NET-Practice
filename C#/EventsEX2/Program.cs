namespace EventsEX2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BankAccount BA01 = new BankAccount() { AccountNumber = 1, CustomerName = "Youssef", Balance = 2000 };
            BankAccount BA02 = new BankAccount() { AccountNumber = 12, CustomerName = "Salah", Balance = 8000 };

            CustAgent A01 = new CustAgent() { Name = "Agent01" };
            CustAgent A02 = new CustAgent() { Name = "Agent02" };

            BA01.OverBalanceEvent += A01.ContactCustomer;
            BA01.OverBalanceEvent += BlackList.AddToList;

            BA02.OverBalanceEvent += A02.ContactCustomer;
            BA02.OverBalanceEvent += BlackList.AddToList;

            BA01.Debit(1000);
            Console.WriteLine(BA01);

            BA02.Debit(10000);
            BA01.Debit(1050);
            Console.WriteLine(BlackList.ListContent());


        }
    }
}
