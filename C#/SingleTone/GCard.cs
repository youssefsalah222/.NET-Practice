using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class GCard

    // SingleTone Design Pattern
    {
        public int id { get; set; }

        GCard(int _id)
        {
            id = _id;
        }

        static GCard singleObj;

        public static GCard GetCard()
        {
            if (singleObj == null)
                singleObj = new GCard(124);
            return singleObj;
        }

        //====================================

        // public static GCard SingleToneObj { get; } = new GCard(2);  // singletone 
    }
}
