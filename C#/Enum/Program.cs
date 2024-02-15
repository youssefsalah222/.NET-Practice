namespace Enum
{
    internal class Program
    {

        enum Grades
        {
            A , B , C
        }

        enum Branches:byte
        {
            Cairo = 200 , Imsailia, Giza
        }

        [Flags]
        enum Permissions : byte
        {
            Read = 8, Write = 4, Execute = 2, Delete = 1
        }

        static void Main(string[] args)
        {
            #region Enum EX01

            /*Grades grades = Grades.A;
                grades = Grades.A;
                if (grades == Grades.A)
                    Console.WriteLine("YES");

                grades = (Grades) 2;
                Console.WriteLine(grades);  // C

                grades = (Grades) 8;
                Console.WriteLine(grades);  // 8*/
            #endregion

            #region Enum EX02

            /*Branches branches = new Branches();
               branches = Branches.Cairo;
               Console.WriteLine(branches);*/
            #endregion

            #region Bit Flag Enum

            /*  Permissions p = new Permissions();
                p = Permissions.Read;
                Console.WriteLine(p);
                p ^= Permissions.Write;
                Console.WriteLine(p);

                *//*if (p == Permissions.Read)    // (==) not check for single bit
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("NO");    // No *//*


                if ((p & Permissions.Read) == Permissions.Read)
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("NO");   


                p = (Permissions) 15;
                Console.WriteLine(p);*/
            #endregion

        }
    }
}
