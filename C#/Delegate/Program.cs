using Collections;
using System.Collections.Generic;

namespace Delegate
{
    internal class Program
    {

        // New class (Delegate) , specify fun signature

        public delegate int StringFunDel(string s);

        /* Any o bject from thid Delegate can point to (Hold address)
     any function with the exact signature  bool (int , int)

   Point to any function ( Static , object) , regardless of access modifier
    */


        //====================================================================

        // Non Generic

        public delegate bool CondDel(int n);


        public static List<int> FindCondition(List<int> list, CondDel cd)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < list?.Count; i++)
                if (cd?.Invoke(list[i]) == true)
                    result.Add(list[i]);

            return result;

        }

        //=============================================================================

        // Generic

        public delegate bool CondDel<in T>(T n);
        // User Defind Generic Delegate

        public static List<T> FindCondition<T>(List<T> list , /* CondDel<T> cd */  Predicate<T> cd) 
        {
            List<T> result = new List<T>();
            for (int i = 0; i < list?.Count; i++)
                if (cd?.Invoke(list[i]) == true)
                    result.Add(list[i]);

            return result;

        } 


        static void Main(string[] args)
        {
            #region Delegate EX01

            /* // 1. Delegate object declaration
                StringFunDel sfd;

                // 2. Pointer to Function (Delegate object) initialization
                sfd = new StringFunDel(StringFun.GetLen);

                // 3. Using Pointer to Function , Call function
                int res = sfd.Invoke("Youssef");  // 7
                Console.WriteLine(res);

                sfd = new StringFunDel(StringFun.GetUpperCharCount);
                res = sfd.Invoke("YouSSef");  // 3
                Console.WriteLine(res);

                // sfd = new StringFunDel(StringFun.GetFullName);  // Error
                // Compiler Enforce Delegate signature

                StringFun sf = new StringFun() { c = 's' };
                sfd = new StringFunDel(sf.GetCharCount);

                res = sfd("Youssef");
                Console.WriteLine(res);   // 2*/
            #endregion

            #region Delegate EX02

            /*int[] arr = { 6, 4, 5, -2, 3, 1, 7, -8 };
                SortingAlgorithms.BSort(arr);

                ComFunDel cfd = new ComFunDel(ComFun.CompLess);

                cfd = ComFun.CompLess;
                // Implicit casting from function to function pointer 

                SortingAlgorithms.BSort(arr , cfd);


                foreach (int i in arr)
                    Console.WriteLine(i);*/
            #endregion

            #region Non Generic Delegate

            /* List<int> list = Enumerable.Range(0, 100).ToList();
                List<int> res;

                CondDel CD = new CondDel(ConditionFun.CheckEven);
                res = FindCondition(list, CD);

                foreach (var i in res)
                    Console.WriteLine(i);*/
            #endregion

            #region  Generic Delegate
            /*
                        List<string> Names = new List<string>() { "Youssef", "Salah", "Ali" };

                        CondDel<string> CD02 = new CondDel<string>(ConditionFun.CheckLen);

                        Predicate<string> CD04 = (ConditionFun.CheckLen);
                        // Predicate (Built in Delegate)

                        foreach (var i in FindCondition(Names, CD02))
                            Console.WriteLine(i);*/
            #endregion

            #region Generic Delegate EX02

            /* //  ComFunDel<int , int , bool> cfd = new ComFunDel< int, int , bool> (ComFun.CompLess);

                Func<int, int, bool> cfd02 = ComFun.CompLess;  // Func built in delegate

                List<string> Names = new List<string>() { "Youssef", "Salah", "Ali" };

                var NameList = Names.ToArray();

                SortingAlgorithmsG.BSort<string>(NameList, ComFunV02.CompLen);

                foreach (var i in NameList)
                    Console.WriteLine(i);*/

            #endregion

            #region Anonymous Method

            /* List<int> list = Enumerable.Range(0, 100).ToList();
             List<int> res;

             Predicate<int> PD;

             // Implicit casting from function body to Pointer to function
             PD = delegate (int x) { return x > 90; };

             res = FindCondition(list, PD);

             foreach (var i in res)
                 Console.WriteLine(i); */

            #endregion

            #region  Lambda Expression

          /*  List<int> list = Enumerable.Range(0, 100).ToList();
            List<int> res;

            Predicate<int> PD;

            // Using Lamda Expression Compiler will generate Anonymous Method

              PD =  (int x) => { return x > 95; };

           // PD = x => x > 95;


            res = FindCondition(list, PD);

            foreach (var i in res)
                Console.WriteLine(i);*/

            #endregion

        }
    }


    public class StringFun
    {
        public char c { get; set; }

        public static int GetLen(string s) { return s?.Length ?? 0; }

        public int GetCharCount(string s)
        {
            int cnt = 0;
            for (int i = 0; i < s?.Length; i++)
                if (s[i] == this.c) cnt++;
            return cnt;
        }

        public static int GetFullName(string fn, string ln) { return fn.Length + ln.Length; }


        public static int GetUpperCharCount(string s)
        {
            int cnt = 0;
            for (int i = 0; i < s?.Length; i++)
                if (char.IsUpper(s[i])) cnt++;
            return cnt;
        }
    }

    public class ConditionFun
    {
        public static bool CheckOdd (int x ) { return x % 2 == 1;}
        public static bool CheckEven (int x ) { return x % 2 == 0;}
        public static bool CheckLen (string s) { return s.Length >= 4;}
    }
}
