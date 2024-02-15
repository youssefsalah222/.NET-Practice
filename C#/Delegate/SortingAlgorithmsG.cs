using Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    // User Defined Generic Delegate
    public delegate TReslut ComFunDel<in T1, in T2, out TReslut>(T1 L, T2 R);

    internal class SortingAlgorithmsG
    {
        public static void BSort<T>(T[] arr, ComFunDel<T , T , bool> ComFunPtr)
        {
            for (int i = 0; i < arr?.Length; i++)
                for (int j = 0; j < arr?.Length - i - 1; j++)
                    if (ComFunPtr?.Invoke(arr[j], arr[j + 1]) == true)
                        // Call CompFun using Pointer
                        Swap(ref arr[j], ref arr[j + 1]);

        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T tmp = a;
            a = b;
            b = tmp;
        }

    }


    public class ComFunV02
    {
        public static bool CompLen(string s1, string s2) { return s1.Length > s2.Length; }
    }
}

