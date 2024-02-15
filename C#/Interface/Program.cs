namespace Interface
{
    internal class Program
    {

        // Developer 1
        public static void BuildSeries(Iseries ser) 
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{ser.Current}");
                ser.GetNext();
            }
            ser.Reset();
        }
        static void Main(string[] args)
        {

            #region Interface

            Iseries ise;  // Valid
          //  ise = new Iseries();  // Not valid 
            ise = new SeriesByTwo();   // valid

            SeriesByTwo sbt = new SeriesByTwo();
            BuildSeries(sbt);

            #endregion

            Console.WriteLine("==================================================");

            #region IComparable

            Employee[] e = new Employee[2]
            {
                 new Employee (2 , "Youssef" , 20000),
                 new Employee (3 , "Salah" , 50000)
            };

            Array.Sort(e);

            #endregion


            #region  Implement Interface Explicitly

            Airplane airplane = new Airplane();
           // airplane.forward();  // Invalid

            Imoveable imoveable = new Airplane();
            imoveable.Forward();

            Iflyable iflyable = new Airplane();
            iflyable.Forward();

            #endregion
        }
    }
}
