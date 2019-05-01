using System;

namespace Carter_BabysitterKata
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Set app variables
            string inputStartTime = "";
            string family = "";

            while (true)
            {
                //User enters which family they want
                Console.WriteLine("Enter Family Name (A, B or C): ");

                //Added"ToUpper to allow lowercase input too
                family = Console.ReadLine().ToUpper();
                
                //Family choice validation
                while (family != "A" && family != "B" && family != "C")
                {
                    Console.WriteLine("Please enter a valid family letter. Enter Family Name (A, B or C): ");
                    family = Console.ReadLine();
                }
                
                
                

            }

        }
    }
}