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
            int totalPay = 0;
                
            
                

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
                Console.WriteLine("Enter Start Time (from 5pm - 3am):");
                inputStartTime = Console.ReadLine();
                
                //Start time validation
                while (!(Int32.TryParse(inputStartTime, out startTime)))
                {
                    Console.WriteLine("Please enter a valid START time: ");
                    inputStartTime = Console.ReadLine();
                }
        
                //more start time validation
                startTime = Int32.Parse(inputStartTime);
                //Using 1-12, because time constraints are 5,6,7,8,9,10,11,12,1,2,3&4
                while (startTime == 4 || (!(startTime >= 1 && startTime <= 12)))
                {
                    Console.WriteLine("Please enter a valid START time: ");
                    inputStartTime = Console.ReadLine();
                    startTime = Int32.Parse(inputStartTime);
                }
                //User enters end time
                Console.WriteLine("Enter End Time (from 6pm - 4am):");
                inputEndTime = Console.ReadLine();
                //End time validation
                while (!(Int32.TryParse(inputEndTime, out endTime)))
                {
                    Console.WriteLine("Please enter a valid END time: ");
                    inputEndTime = Console.ReadLine();
                }

                endTime = Int32.Parse(inputEndTime);
                while (endTime == 5 || (!(endTime >= 1 && endTime <= 12)))
                {
                    Console.WriteLine("Please enter a valid END time: ");
                    inputEndTime = Console.ReadLine();
                    endTime = Int32.Parse(inputEndTime);
                }
                //Choosing a switch statement to test against the diff. start & end times with family A, B or C to get totalPay
                switch (family)
                {
                    case "A":
                    //Family A 
                    break; 
                    
                    case "B":
                    //Family B 
                    break;
                    
                    case "C":
                    //Family C
                    break;
                    
                    default:
                        break;
                }

            }

        }
    }
}