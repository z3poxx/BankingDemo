using System;

namespace WintDemo
{
    public static class Messages
    {
        public static void Greet()
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - ");
            Console.WriteLine("Welcome to the WintDemo application");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - ");
        }

        public static void ExplainBasicControls()
        {
            Console.WriteLine();
            Console.WriteLine("These are the basic controls:");
            Console.WriteLine("Press 0 to display all controls.");
            Console.WriteLine("Press 1 to display alla ***");
        }

        public static void TempMSG()
        {
            Console.WriteLine("A place holder message:");
        }
    }
}
