using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace Collections
{

    internal class Program
    {

        public static int SumArray(ArrayList al)
        {
            int sum = 0;
            for (int i = 0; i < al?.Count; i++)
                sum += (int)al[i];   // Unboxing
            return sum;
        }

        public static int SumList(List<int> l)
        {
            int sum = 0;
            for (int i = 0; i < l?.Count; i++)
                sum += l[i];
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Non-Generic Collections");

            #region Non Generic Collections

            Console.WriteLine("=============== ArrayList ==================");

            ArrayList alst = new ArrayList();
            alst.Add(1);   // Boxing
            //alst.Add("2");  // Compiler can't enforce type safety at compilation
            alst.AddRange(new int[] { 3, 4, 5 });
            alst.Remove(3);
            Console.WriteLine(SumArray(alst));

            alst.TrimToSize();   // Deallocate unused Bytes
            Console.WriteLine(alst.Count);
            Console.WriteLine(alst.Capacity);

            #endregion

            Console.WriteLine("=========================================");
            Console.WriteLine("Generic Collections - Lists");

            #region Generic Collection


            #region List

            Console.WriteLine("=============== List ==================");

            List<int> list = new List<int>();
            Console.WriteLine($"Size = {list.Count} , capacity = {list.Capacity}");
            list.Add(1);
            list.Insert(1, 2);  // Insert element into specific Index

            //   list.Add ("2");   // Compiler enforce type safety at compilation
            Console.WriteLine($"Size = {list.Count} , capacity = {list.Capacity}");

            list.TrimExcess();   // Free unused Bytes ,  Capacity = size , not capacity *= 2

            // You can not use indexer of list to add

            #endregion

            #region Linked List

            Console.WriteLine("=============== Linked List ==================");

            LinkedList<int> LinkedList = new LinkedList<int>();
            LinkedList.AddFirst(1);
            LinkedList.AddFirst(2);
            LinkedList.AddLast(3);

            LinkedList.AddAfter(LinkedList.Find(1) , 5);

            foreach (int i in LinkedList)
                Console.WriteLine(i);

            #endregion

            #region Stack

            Console.WriteLine("=============== Stack ==================");

            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Peek());  // 3
            Console.WriteLine(stack.Pop());   // 3
            Console.WriteLine(stack.Peek());  // 2

            #endregion

            #region Queue

            Console.WriteLine("=============== Queue ==================");

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine(queue.Peek());  // 1

            Console.WriteLine(queue.Dequeue());   // 1

            Console.WriteLine(queue.Peek());  // 2

            #endregion

            #endregion

            Console.WriteLine("=========================================");
            Console.WriteLine("Generic Collections - HashTable");

            #region Generic Collections - HashTable

            #region Dictionary

            Console.WriteLine("=============== Dictionary ==================");

            Dictionary<string, int> D = new Dictionary<string, int>();
            D.Add("Youssef", 1);
            //  D.Add("Youssef", 2);  // No duplicate key 

            D["Salah"] = 222;  // Use indexer for add
            D["Youssef"] = 2002;  // Use indexer for update

            // Protective Code to Add in Dictionary
            if (!D.ContainsKey("Abdelrahman"))
                D.Add("Abdelrahman", 555);

            if (!D.TryAdd("Abdelrahman", 555))   // Exists
                D["Abdelrahman"] = 222222;
           
            foreach (KeyValuePair<string, int> i in D)
            {
                Console.WriteLine($"{i.Key}:{i.Value}");
            }

         //   Console.WriteLine(D["Salah"]);    // Unsafe Code (if Key Not Found)

            if (D.TryGetValue("ss", out int v))
                Console.WriteLine(v);
            else
                Console.WriteLine("NA");

            #endregion

            #region HashSet

            Console.WriteLine("=============== HashSet ==================");

            HashSet<int> set = new HashSet<int>();
            set.Add(1);
            set.Add(2);
            set.Add(2);

            foreach (int i in set)
                Console.WriteLine(i);

            #endregion

            #endregion



        }
    }

}
