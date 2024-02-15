namespace Deffered_Execution___Where
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LINQ Queries against any sequence
            // Sequence : Class implementing IEnumurable<T> Interface
            // Local Sequence : Static [LINQ TO Object] , L2ADO , L2XML
            // Remote Sequence : L2SQL , L2Entity
            // Sequence contains elements


            List<int> Lst = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<string> Names = new List<string> { "Youssef Salah", "Amr Mohamed", "Adham Mohrez" };

            #region LINQ Syntax [Fluent Syntax , Query Syntax]

            // Fluent Syntax 

            // Static function member in Enumerable class
            var result = Enumerable.Where(Lst, i => i % 2 == 0);

            // Extension Method
            var res = Lst.Where(i => i % 2 == 0);

            //==========================================================

            // Query Syntax (SQL Like)

            var r = from i in Lst
                    where i % 2 == 0
                    select i;

            // Valid for only subset of  (+40 LINQ Operators)
            // Some cases it is easier to write Query using Query Syntax (Join , Group , Let , Into)
            // Start with from , end with select or Group by 

            #endregion

            #region Execution Ways [Deffered Execution , Immediate Execution]

            // Most of LINQ Operators , Deffered Execution[Latest version of data]

            var R = Lst.Where(i => i % 2 == 0);

            Lst.Remove(2);
            Lst.AddRange(new int[] { 10, 11, 12 });

            foreach (var i in R)
                Console.Write($"{i} , ");

            Console.WriteLine();
            Console.WriteLine("=========================");

            //=============================================================

            // Immediate Execution (Casting)

            var R2 = Lst.Where(i => i % 2 == 0).ToList();
            Lst.Remove(2);
            Lst.AddRange(new int[] { 14, 16, 20 });

            foreach (var i in R2)
                Console.Write($"{i} , ");   // Not include 14 , 16 , 20 

            #endregion
        }
    }
}
