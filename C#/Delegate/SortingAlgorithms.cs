using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{

    // Step 0 , Delegate DataType Declaration
    public delegate bool ComFunDel(int l, int r);

    /* Any o bject from thid Delegate can point to (Hold address)
      any function with the exact signature  bool (int , int)

    Point to any function ( Static , object) , regardless of access modifier
     */
    internal class SortingAlgorithms
    {
        public static void BSort(int[] arr)
        {
            for (int i = 0; i < arr?.Length; i++)
                for (int j = 0; j < arr?.Length - i - 1; j++)
                    if (ComFun.CompGrt(arr[j], arr[j + 1]))
                        Swap(ref arr[j], ref arr[j + 1]);

        }


        public static void BSort(int[] arr , ComFunDel ComFunPtr)
        {
            for (int i = 0; i < arr?.Length; i++)
                for (int j = 0; j < arr?.Length - i - 1; j++)
                    if (ComFunPtr?.Invoke(arr[j], arr[j + 1]) == true)
                        // Call CompFun using Pointer
                        Swap(ref arr[j], ref arr[j + 1]);

        }

        public static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

    }


    public class ComFun
    {
        public static bool CompGrt(int l, int r) { return l > r; }
        public static bool CompLess(int l, int r) { return l < r; }
    }

}
