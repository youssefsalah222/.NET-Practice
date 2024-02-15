using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsEX2
{
    static class BlackList
    {
        static List<string> Blist = new List<string>();

        public static int Size => Blist.Count;

        public static void AddToList(object sender, EventArgs e)
        {
            if (sender is BankAccount BC && (!Blist.Contains(BC.CustomerName)))
            {
                Blist.Add(BC.CustomerName);
            }
        }

        public static string ListContent()
        {
            StringBuilder sb = new StringBuilder();
            for ( int i = 0; i < Blist?.Count; i++ )
                sb.Append(Blist[i]).Append(" , ");
            return sb.ToString();
        }
    }
}
