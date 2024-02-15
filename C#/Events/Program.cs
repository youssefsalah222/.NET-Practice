namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Events V1

           /* Ball B = new Ball();
            Player P1 = new Player() { Name = "P1", Team = "Ahly" };
            Player P2 = new Player() { Name = "P2", Team = "Zam" };
            Player P3 = new Player() { Name = "P3", Team = "RMA" };
            Player P4 = new Player() { Name = "P4", Team = "Barca" };
            Refree R1 = new Refree() { Name = "R1" };

            B.BallLocation = new Location() { X = 20, Y = 20, Z = 20 };
            Console.WriteLine(B);

            // Registration
            // Add Pointer to Subsc. Call Back Method to Publisher Event Invocation list
            B.BallLocationChanged += new Action(P1.Run);
            B.BallLocationChanged += P2.Run;
            B.BallLocationChanged += P3.Run;
            B.BallLocationChanged += P4.Run;
            B.BallLocationChanged += R1.Look;

            B.BallLocation = new Location() { X = 40, Y = 40, Z = 40 };
            Console.WriteLine(B);

            // Deregistration

            B.BallLocationChanged -= P3.Run;
            Console.WriteLine("After Modification");
            B.BallLocation = new Location() { X = 50, Y = 50, Z = 50 };
            Console.WriteLine(B);*/

            #endregion

            Console.WriteLine("=========================================");

            #region Event Arguments 

            BallV02 B = new BallV02();
            Player P1 = new Player() { Name = "P1", Team = "Ahly" };
            Player P2 = new Player() { Name = "P2", Team = "Zam" };
            Player P3 = new Player() { Name = "P3", Team = "RMA" };
            Player P4 = new Player() { Name = "P4", Team = "Barca" };
            Refree R1 = new Refree() { Name = "R1" };

            B.BallLocation = new Location() { X = 20, Y = 20, Z = 20 };
            Console.WriteLine(B);

            // Registration
            // Add Pointer to Subsc. Call Back Method to Publisher Event Invocation list
            B.BallLocationChanged += new Action<Location>(P1.Run);
            B.BallLocationChanged += P2.Run;
            B.BallLocationChanged += P3.Run;
            B.BallLocationChanged += P4.Run;
            B.BallLocationChanged += R1.Look;

            B.BallLocation = new Location() { X = 40, Y = 40, Z = 40 };
            Console.WriteLine(B);

            // Deregistration

            B.BallLocationChanged -= P3.Run;
            Console.WriteLine("After Modification");
            B.BallLocation = new Location() { X = 50, Y = 50, Z = 50 };
            Console.WriteLine(B);

            #endregion

        }

    }
}
