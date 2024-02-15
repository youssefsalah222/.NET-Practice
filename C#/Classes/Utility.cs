using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    static class Utility

        // Container to only static members
        // No object can be created from this class
        // No inheritance for static class
    {
/*
        int x, y;
        public Utility(int _x , int _y)
        {
            x = _x;
            y = _y;
         // pi = 3.14;  // object constructor is not the right place for initialize static members
        }*/


        // Static Constructor
        static Utility()
        {
            Console.WriteLine("Static ctor");
            pi = 3.14;
        }

        static double pi;
        // Static attributes allocate in heap 
        // Static members initialized to default values by default
        public static double CircleArea(double r)
        {
            return pi * r * r;
        }
    }
}
