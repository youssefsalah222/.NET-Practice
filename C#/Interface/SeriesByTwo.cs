using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    // Developer 2 (another one)
    struct SeriesByTwo : Iseries
    {

        int current;
        public int Current { get { return current; } }

        public void GetNext()
        {
            current += 2;
        }

        public void Reset()
        {
            current = 0;
        }
    }
}
