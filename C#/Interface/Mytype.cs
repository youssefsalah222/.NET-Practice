using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{

   //  Developer 1
    interface  Iseries
    {
        // int x;   // Not supported

        int Current {  get; }

        void GetNext();
        void Reset();


        // C# 8.0 featrue ==> Default implemented method
        internal void fun2()
        {
            Console.WriteLine("Hello");
        }
    }
}
