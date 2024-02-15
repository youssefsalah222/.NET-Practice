using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    struct PhoneBook
    {
        // Attributes 

        int size;
        int[] Numbers;
        string[] Names;

        public int Size { get { return size; } }   // Readonly Property

        public PhoneBook(int _size)
        {
            size = _size;
            Numbers = new int[size];
            Names = new string[size];
        }

        #region Setter & Getter

        // Getter
        /* public int GetNumber(string name)
         {
             if (Names is not null && Numbers is not null)
             {
                 for (int i = 0; i < Names.Length; i++)
                     if (Names[i] == name)
                         return Numbers[i];
             }
             return -1;
         }


         // Setter

         public void SetNumber(string name, int Newnum)
         {
             if (Names is not null && Numbers is not null)
             {
                 for (int i = 0; i < Names.Length; i++)
                 {
                     if (Names[i] == name)
                     {
                         Numbers[i] = Newnum;
                         break;
                     }
                 }
             }
         } */
        #endregion

        public void AddPerson(int idx, string name, int num)
        {
            if (Names is not null && Numbers is not null)
            {
                if (idx >= 0 && idx < size)
                {
                    Names[idx] = name;
                    Numbers[idx] = num;
                }
            }
        }


        #region Indexer

        public int this[string name]         // SetNumber & GetNumber by name
        {
            get
            {
                if (Names is not null && Numbers is not null)
                    for (int i = 0; i < Names.Length; i++)
                        if (Names[i] == name)
                            return Numbers[i];
                return -1;
            }
            set
            {
                if (Names is not null && Numbers is not null)
                {
                    for (int i = 0; i < Names.Length; i++)
                    {
                        if (Names[i] == name)
                        {
                            Numbers[i] = value;
                            break;
                        }
                    }
                }
            }
        }

        //===============================================================

        public int this[int idx, string name]       // Add Person
        {
            set
            {
                if (Names is not null && Numbers is not null)
                {
                    if (idx >= 0 && idx < size)
                    {
                        Names[idx] = name;
                        Numbers[idx] = value;
                    }
                }
            }
        }


        //=======================================================

        public string this[int idx]    //  Print Indexer
        {
            get
            {
                return $"{idx} :: {Names[idx]} :: {Numbers[idx]}";
            }
        }

        #endregion

    }
}
