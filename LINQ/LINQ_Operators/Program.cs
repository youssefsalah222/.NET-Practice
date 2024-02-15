
using static L2O___D09.ListGenerators;
using System.Linq;
using L2O___D09;
using System.Text.RegularExpressions;

namespace LINQ_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Where - Filtration Operator

            /*  var Res = ProductList.Where(P => P.UnitsInStock == 0);  // Product quantity = 0

              Res = from P in ProductList
                    where P.UnitsInStock == 0
                    select P;



              Res = ProductList.Where(P => (P.UnitsInStock == 0) && (P.Category == "Meat/Poultry"));

              Res = from P in ProductList
                    where (P.UnitsInStock == 0) && (P.Category == "Meat/Poultry")
                    select P;

              //===============================================================================

              // Indexed Where
              Res = ProductList.Where((P, i) => P.UnitsInStock == 0 && i <= 10); // In first i (10) Products

              // Indexed where valid only in Fluent Syntax
              // Can't be written using Query Expression


              foreach (var i in Res)
                  Console.WriteLine(i);*/

            #endregion

            #region Transformation Operator - [Select , SelectMany]

            #region Select

            // Tranaform every element in input Seq to new element in output Seq of new DataType or same Type

            /*  var Res2 = ProductList.Select(P => P.ProductName);
              // Product => String

              Res2 = from P in ProductList
                     select P.ProductName;

              *//*  foreach (var i in Res2)
                Console.WriteLine(i);*//*


              //====================================================================

              var Res21 = ProductList.Where(P => P.UnitsInStock == 0)
                  .Select(P => new { Id = P.ProductID , P.ProductName });

              Res21 = from P in ProductList
                      select new { Id = P.ProductID ,P.ProductName };
              // Product =? Anonymous Type

              *//* foreach (var i in Res21)
                   Console.WriteLine(i);*//*


              //====================================================================

              var DiscoundLst = ProductList.Select(P => new Product()
              {
                  ProductID = P.ProductID,
                  ProductName = P.ProductName,
                  UnitsInStock = P.UnitsInStock,
                  Category = P.Category,
                  UnitPrice = 0.9M * P.UnitPrice,
              });
              // Product => Product

              DiscoundLst = from P in ProductList
                            select new Product()
                            {
                                ProductID = P.ProductID,
                                ProductName = P.ProductName,
                                UnitsInStock = P.UnitsInStock,
                                Category = P.Category,
                                UnitPrice = 0.9M * P.UnitPrice,
                            };


              //====================================================================

              //Indexed Select , valid only in Fluent Syntax

             var Res22 = ProductList.Where(P => P.UnitsInStock == 0)
                  .Select((P, i) => new { Index = i, Name = P.ProductName });

              foreach (var i in Res22)
                  Console.WriteLine(i);

              Console.WriteLine("============================");

              //====================================================================

              var Res23 = from P in ProductList
                          select new { Name = P.ProductName, Newprice = P.UnitPrice }
                          into TaxedPrice
                          where TaxedPrice.Newprice > 20
                          select TaxedPrice;


              foreach (var i in Res23)
                  Console.WriteLine(i);*/

            #endregion

            #region Select Many 

            // Output Seq Count > Input Seq Count
            // transform each element in Input Seq to sub Seq

            /* var Res7 = CustomerList.SelectMany(C => C.Orders);

             foreach (var i in Res7)
                 Console.WriteLine(i); */

            //=============================================================================

            /*List<string> NameList = new List<string>() {  "Youssef Salah" , "Ahmed Ali"  };
            var Res7 = NameList.SelectMany(FN => FN.Split(' '));

            // Query Syntax : use multiple from to produce Select Many

            var Res71 = from FN in NameList
                        from SN in FN.Split(' ')
                        select SN;

            var Res72 = Res7.SelectMany(FN => FN.ToCharArray());

            foreach (var i in Res7)
                Console.WriteLine(i); */

            #endregion

            #endregion

            #region Ordering Operators

            /*  var Res3 = ProductList.OrderBy(P => P.UnitsInStock)
                  .Select(p => new { p.ProductName, p.UnitsInStock , p.UnitPrice});

              Res3 = from P in ProductList
                     orderby P.UnitsInStock
                     select new{ P.ProductName, P.UnitsInStock , P.UnitPrice};

              //=========================================================================

              // Order By Descending

              Res3 = ProductList.OrderByDescending(P => P.UnitsInStock)
                  .Select(p => new { p.ProductName, p.UnitsInStock , p.UnitPrice });

              Res3 = from P in ProductList
                     orderby P.UnitsInStock descending
                     select new { P.ProductName, P.UnitsInStock , P.UnitPrice };

              //=========================================================================

              // Order by 2 attributes

              Res3 = ProductList.OrderByDescending(P => P.UnitsInStock)
                  .ThenBy( P => P.UnitPrice )
                 .Select(p => new { p.ProductName, p.UnitsInStock, p.UnitPrice });

              Res3 = from P in ProductList
                     orderby P.UnitsInStock descending , P.UnitPrice
                     select new { P.ProductName, P.UnitsInStock, P.UnitPrice };

              //=========================================================================

              Res3 = ProductList.OrderByDescending(P => P.UnitsInStock)
              .ThenByDescending(P => P.UnitPrice)
             .Select(p => new { p.ProductName, p.UnitsInStock, p.UnitPrice });


              Res3 = from P in ProductList
                     orderby P.UnitsInStock descending, P.UnitPrice descending
                     select new { P.ProductName, P.UnitsInStock, P.UnitPrice };

              //=========================================================================

              foreach (var i in Res3)
                 Console.WriteLine(i); */

            #endregion

            #region Element Operators - Immediate Execution

            // Valid only with Fluent Syntax

            /*  List<Product> DiscoundLST = new List<Product>();  // Empty Sequence

              var Res4 = ProductList.First();

              Res4 = ProductList.Last();

              Res4 = ProductList.First(P => P.UnitsInStock == 0);
              Res4 = ProductList.Last(P => P.UnitsInStock == 0);

              // ===============================================================

            //  Res4 = DiscoundLST.First();
              // if input Seq is empty , Throw Exception 

              Res4 = DiscoundLST.FirstOrDefault();
              Res4 = DiscoundLST.LastOrDefault();
              // return first element is Seq , return default value if Empty Seq


              // Res4 = ProductList.First(P => P.UnitPrice > 300);
              // if No element matching predicate (condition) , Throw Exception

              Res4 = ProductList.FirstOrDefault(P => P.UnitPrice > 300);



              //============================================================

              // Hybrid Styntax =>  (Query Syntax).Fluent Syntax

              var Res41 = ( from P in ProductList
                     where P.UnitsInStock == 0
                     select new {P.ProductName , P.Category} ).First();


              //============================================================

              Res4 = ProductList.ElementAt(17);   // (index)

             // Res4 = ProductList.ElementAt(1700);   // Throw Execption (out of range)

              Res4 = ProductList.ElementAtOrDefault(12344);

              //===============================================================

              // Res4 = ProductList.Single();   // Exception 
              // Return Single element in Seq (Only One in input Seq)
              // Throw Exception if empty Seq or more than One element exists

              DiscoundLST.Add(ProductList[0]);
              Res4 = DiscoundLST.Single();
              Res4 = ProductList.Single(P => P.ProductID == 7); // Return Name

              //===============================================================

              Res4 = ProductList.SingleOrDefault(P => P.ProductID == 7444);  // NA

             // Res4 = ProductList.SingleOrDefault(P => P.UnitsInStock == 0);   // Exception

              // Throw Exception if more than One product match condition
              // Retrun defalut if No Elements match condition

              DiscoundLST.Clear();
              Res4 = DiscoundLST.SingleOrDefault();     // NA

              Console.WriteLine(Res4?.ProductName ?? "NA");*/

            #endregion

            #region Aggregate Operators - Immediate Execution

            /*   var Res5 = ProductList.Count(P => P.UnitsInStock == 0);
               Console.WriteLine(Res5);

               //=============================================================

               var Res51 = ProductList.Max();
               Console.WriteLine(Res51);
               // Return Max (Based on IComparable Implementation ) Product

               var Res52 = ProductList.Max(P => P.UnitPrice);
               Console.WriteLine(Res52);
               // Return Max Price

               //=============================================================

               var Res53 = ProductList.Min(P => P.ProductName.Length);
               Console.WriteLine(Res53);

               var Res531 =( from P in ProductList
                       where P.ProductName.Length == ProductList.Min(P => P.ProductName.Length)
                       select P).FirstOrDefault();

               Console.WriteLine(Res531?.ProductName?? "NA");
               // Get First Prodcut that its Name.Length = Min Name.Length

               //=============================================================

               Console.WriteLine(ProductList.Average(P => P.UnitsInStock));

               //=============================================================

               Console.WriteLine(ProductList.Sum(P => P.UnitsInStock));

            //====================================================================

            string[] Names = { "Youssef", "Salah", "Abdelrahman" };

            var Res54 = Names.Aggregate((s1, s2) => $"{s1} {s2}");

            Console.WriteLine(Res54); */

            #endregion

            #region Casting Operators - Immediate Execution

            /* List<Product> NALst = ProductList.Where(P => P.UnitsInStock == 0).ToList();

             Product[] Prp = ProductList.Where(P => P.UnitsInStock == 0).ToArray();

            // var Res8 = ProductList.Where(P => P.UnitsInStock == 0)
                           // .ToHashSet();
                           //   .ToDictionary(P => P.ProductID);   // Dictionary<long , Product>
                           //  .ToDictionary(P => P.ProductID, PR => new { PR.ProductID, PR.ProductName });
                           // .ToLookup();*/

            #endregion

            #region Generators Operators

            // Generating Output Seq , No Input Seq
            // Only way to call them is a Static Members from Enumerable Class
            // valid only with fluent syntax

            /*   var Res6 = Enumerable.Range(0, 10);

               Res6 = Enumerable.Empty<int>();

               Res6 = Enumerable.Repeat(2 , 5);

               foreach (var i in Res6)
                   Console.WriteLine(i);*/

            #endregion

            #region Set Operators

            /* var Seq1 = Enumerable.Range(0, 20);
             var Seq2 = Enumerable.Range(10, 30);
             var Lst1 = Seq1.ToList();

             Console.WriteLine(Lst1[^1]);    // Last Element

             //====================================================

             var Res9 = Seq1.Union(Seq2);     // Remove Duplicates

             Res9 = Seq1.Concat(Seq2);

             Res9 = Res9.Distinct();

             Res9 = Seq1.Except(Seq2);

             Res9 = Seq1.Intersect(Seq2);

             foreach (var i in Res9)
                 Console.Write($"{i} , ");
             Console.WriteLine();*/

            #endregion

            #region Qunatifier Operators - Return bool

            /* Console.WriteLine( ProductList.Any());   
             // Return true if input Seq have at least one element   

             Console.WriteLine( ProductList.Any(P => P.UnitPrice > 40));
             // Return true if input Seq have at least one element matching Predicate


             Console.WriteLine( ProductList.All(P => P.UnitsInStock > 0));
             // Return true if ALL elements input Seq matching Predicate 

             var Seq1 = Enumerable.Range(0, 20);
             var Seq2 = Enumerable.Range(10, 30);

             Console.WriteLine( Seq1.SequenceEqual(Seq2));
             // Compare each element in Seq1 with Seq 2*/

            #endregion

            #region Zip Operators

            /* List<string> NameList = new List<string>() { "Youssef Salah", "Ahmed Ali" };
             var LST = Enumerable.Range(0, 10);

          //   var Res10 = NameList.Zip(LST);
            var Res10 = NameList.Zip(LST , (FN , i) => new {i , Name = FN.ToUpper()});

             foreach (var i in Res10)
                 Console.WriteLine(i);*/

            #endregion

            #region Grouping Operators

            /*  var Res11 = from P in ProductList
                          where P.UnitsInStock > 0
                          group P by P.Category;

              foreach(var Cat in Res11)
              {
                  Console.WriteLine($"Category {Cat.Key} has Products: ");
                  foreach(var P in Cat) 
                  {
                      Console.WriteLine(P.ProductName);
                  }
              }*/

            #endregion

            #region Partition Operators

            var Res12 = ProductList.Where(P => P.UnitsInStock == 0).Take(5);
             Res12 = ProductList.Where(P => P.UnitsInStock == 0).TakeLast(5);
             Res12 = ProductList.Where(P => P.UnitsInStock == 0).Skip(5);
             Res12 = ProductList.Where(P => P.UnitsInStock == 0).SkipLast(5);

            int[] Nums = { 5, 4, 1, 3, 9, 8 };
            var Res122 = Nums.TakeWhile(N => N < 9);
            Res122 = Nums.TakeWhile((N, I) => N > I);

            Res122 = Nums.SkipWhile(N => N % 3 != 0);

            foreach (var n in  Res122)
                Console.WriteLine(n);

            #endregion

            #region Let , Into - Introducing new range variable in Query Syntax

            List<string> list = new List<string>()
            { "Youssef" , "Salah" , "Adham" , "Ali"};

            // Regular Expression

            var Res13 = from N in list
                        select Regex.Replace(N, "[aeiouAEIOU]", string.Empty)
                      // Restart Query with new Range Variable , Old Range Variable (N) is not Accessible
                        into NV
                        where NV.Length >= 3
                        select NV;


            var Res131 = from N in list
                        let NV = Regex.Replace(N, "[aeiouAEIOU]", string.Empty)
                        // Let, continue Query with added Range Variable
                         where NV.Length >= 3
                         select NV;


            foreach (var i in Res13)
                Console.WriteLine(i);

            #endregion
        }
    }
}
