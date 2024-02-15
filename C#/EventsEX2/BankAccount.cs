using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsEX2
{
    internal class BankAccount
    {
        public int AccountNumber { get; set; }
        public string CustomerName { get; set; }

        decimal balance;
        public decimal Balance { get => balance; set => balance = value; }

        public bool Credit (decimal amount)
        {
            if (amount > 0) 
            {
                balance += amount;
                return true;
            }
            return false;
        }

        public bool Debit(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                return true;
            }
            else
            {
                // Notify Sibsc.
                OnOverBalanceEvent(new EventArgs());
            return false;

            }
        }


        public event EventHandler OverBalanceEvent;

        protected virtual void OnOverBalanceEvent(EventArgs e)
        { OverBalanceEvent?.Invoke(this , e); }

        public override string ToString() => $"{AccountNumber} , {CustomerName} , {balance}";
    }
}
