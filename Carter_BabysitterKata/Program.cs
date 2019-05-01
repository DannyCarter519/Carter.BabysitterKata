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
                    if (startTime == 5 && endTime == 4){totalPay = 190;}
                    else if (startTime == 5 && endTime == 3){totalPay = 170;}else if (startTime == 5 && endTime == 2){totalPay = 150;}else if (startTime == 5 && endTime == 1){totalPay = 130;}else if (startTime == 5 && endTime == 12){totalPay = 110;}else if (startTime == 5 && endTime == 11){totalPay = 90;}
                    break; 
                    
                    case "B":
                    //Family B 
                    if (startTime == 5 && endTime == 4){totalPay = 140;}
                    else if (startTime == 5 && endTime == 3){totalPay = 124;}else if (startTime == 5 && endTime == 2){totalPay = 108;}else if (startTime == 5 && endTime == 1){totalPay = 92;}else if (startTime == 5 && endTime == 12){totalPay = 76;}else if (startTime == 5 && endTime == 11){totalPay = 68;}
                    break;
                    
                    case "C":
                    //Family C
                    if (startTime == 5 && endTime == 4){totalPay = 189;}
                    else if (startTime == 5 && endTime == 3){totalPay = 174;}else if (startTime == 5 && endTime == 2){totalPay = 159;}else if (startTime == 5 && endTime == 1){totalPay = 144;}else if (startTime == 5 && endTime == 12){totalPay = 129;}else if (startTime == 5 && endTime == 11){totalPay = 114;}
                    break;
                    
                    default:
                        break;
                }
                //Get input

                //Change text color
                Console.ForegroundColor = ConsoleColor.DarkGreen;

                //Give users total pay
                Console.WriteLine("Your total pay for tonight is $" + totalPay);

                //Reset text color
                Console.ResetColor();
                
                //Change text color
                Console.ForegroundColor = ConsoleColor.DarkYellow;

            }

        }
    }
}