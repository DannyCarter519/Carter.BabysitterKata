using System;

namespace Carter_BabysitterKata
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Set app all variables
            string inputStartTime = "";
            string inputEndTime = "";
            int startTime = 0;
            int endTime = 0;
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
                //User enters start time
                Console.WriteLine("Enter Start Time (from 5 - 3):");
                inputStartTime = Console.ReadLine();
                
                //Start time validation
                while (!(Int32.TryParse(inputStartTime, out startTime)))
                {
                    Console.WriteLine("Please enter a valid START time: ");
                    inputStartTime = Console.ReadLine();
                }




            }

        }
    }
}