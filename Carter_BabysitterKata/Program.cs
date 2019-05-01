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
                        else if (startTime == 5 && endTime == 10){totalPay = 75;}else if (startTime == 5 && endTime == 9){totalPay = 60;}else if (startTime == 5 && endTime == 8){totalPay = 45;}else if (startTime == 5 && endTime == 7){totalPay = 30;}else if (startTime == 5 && endTime == 6){totalPay = 15;}
                        else if (startTime == 6 && endTime == 4){totalPay = 175;}else if (startTime == 6 && endTime == 3) {totalPay = 155;}else if (startTime == 6 && endTime == 2){totalPay = 135;}else if (startTime == 6 && endTime == 1){totalPay = 115;}else if (startTime == 6 && endTime == 12){totalPay = 95;}
                        else if (startTime == 6 && endTime == 11){totalPay = 75;}else if (startTime == 6 && endTime == 10){totalPay = 60;}else if (startTime == 6 && endTime == 9){totalPay = 45;}else if (startTime == 6 && endTime == 8){totalPay = 30;}else if (startTime == 6 && endTime == 7){totalPay = 15;}
                        else if (startTime == 7 && endTime == 4){totalPay = 160;}else if (startTime == 7 && endTime == 3){totalPay = 140;}else if (startTime == 7 && endTime == 2){totalPay = 120;}else if (startTime == 7 && endTime == 1){totalPay = 100;}else if (startTime == 7 && endTime == 12){totalPay = 80;}
                        else if (startTime == 7 && endTime == 11){totalPay = 60;}else if (startTime == 7 && endTime == 10){totalPay = 45;}else if (startTime == 7 && endTime == 9){totalPay = 30;}else if (startTime == 7 && endTime == 8){totalPay = 15;}else if (startTime == 8 && endTime == 4){totalPay = 145;}
                        else if (startTime == 8 && endTime == 3){totalPay = 125;}else if (startTime == 8 && endTime == 2){totalPay = 105;}else if (startTime == 8 && endTime == 1){totalPay = 85;}else if(startTime == 8 && endTime == 12){totalPay = 65;}else if (startTime == 8 && endTime == 11){totalPay = 45;}
                        else if (startTime == 8 && endTime == 10){totalPay = 30;}else if (startTime == 8 && endTime == 9){totalPay = 15;}else if (startTime == 9 && endTime == 4){totalPay = 130;}else if (startTime == 9 && endTime == 3){totalPay = 110;}else if (startTime == 9 && endTime == 2){totalPay = 90;}
                        else if (startTime == 9 && endTime == 1){totalPay = 70;}else if (startTime == 9 && endTime == 12){totalPay = 50;}else if (startTime == 9 && endTime == 11){totalPay = 30;}else if (startTime == 9 && endTime == 10){totalPay = 15;}else if (startTime == 10 && endTime == 4){totalPay = 115;}
                        else if (startTime == 10 && endTime == 3){totalPay = 95;}else if (startTime == 10 && endTime == 2){totalPay = 75;}else if (startTime == 10 && endTime == 1){totalPay = 55; }else if (startTime == 10 && endTime == 12){totalPay = 35; }else if (startTime == 10 && endTime == 11){totalPay = 15;}
                        else if (startTime == 11 && endTime == 4){totalPay = 100;}else if (startTime == 11 && endTime == 3){totalPay = 80;}else if (startTime == 11 && endTime == 2){totalPay = 60;}else if (startTime == 11 && endTime == 1){totalPay = 40;}else if (startTime == 11 && endTime == 12){totalPay = 20;}
                        else if (startTime == 12 && endTime == 4){totalPay = 80;}else if (startTime == 12 && endTime == 3) {totalPay = 60;}else if (startTime == 12 && endTime == 2){totalPay = 40;}else if (startTime == 12 && endTime == 1){totalPay = 20;}else if (startTime == 1 && endTime == 4){totalPay = 60;}
                        else if (startTime == 1 && endTime == 3){totalPay = 40;}else if (startTime == 1 && endTime == 2){totalPay = 20;}else if (startTime == 2 && endTime == 4){totalPay = 40;}else if (startTime == 2 && endTime == 3){totalPay = 20;}else if (startTime == 3 && endTime == 4){totalPay = 20;}
                        break;
                    
                    case "B":
                        //Family B 
                        if (startTime == 5 && endTime == 4){totalPay = 140;}
                        else if (startTime == 5 && endTime == 3){totalPay = 124;}else if (startTime == 5 && endTime == 2){totalPay = 108;}else if (startTime == 5 && endTime == 1){totalPay = 92;}else if (startTime == 5 && endTime == 12){totalPay = 76;}else if (startTime == 5 && endTime == 11){totalPay = 68;}
                        else if (startTime == 5 && endTime == 10){totalPay = 60;}else if (startTime == 5 && endTime == 9){totalPay = 48;}else if (startTime == 5 && endTime == 8){totalPay = 36;}else if (startTime == 5 && endTime == 7){totalPay = 24;}else if (startTime == 5 && endTime == 6){totalPay = 12;}
                        else if (startTime == 6 && endTime == 4){totalPay = 128;}else if (startTime == 6 && endTime == 3){totalPay = 112;}else if (startTime == 6 && endTime == 2){totalPay = 96;}else if (startTime == 6 && endTime == 1){totalPay = 80;}else if (startTime == 6 && endTime == 12){totalPay = 64;}
                        else if (startTime == 6 && endTime == 11){totalPay = 56;}else if (startTime == 6 && endTime == 10){totalPay = 48;}else if (startTime == 6 && endTime == 9){totalPay = 36;}else if (startTime == 6 && endTime == 8){totalPay = 24;}else if (startTime == 6 && endTime == 7){totalPay = 12;}
                        else if (startTime == 7 && endTime == 4){totalPay = 116;}else if (startTime == 7 && endTime == 3){totalPay = 100;}else if (startTime == 7 && endTime == 2){totalPay = 84;}else if (startTime == 7 && endTime == 1){totalPay = 68;}else if (startTime == 7 && endTime == 12){totalPay = 52;}
                        else if (startTime == 7 && endTime == 11){totalPay = 44;}else if (startTime == 7 && endTime == 10){totalPay = 36;}else if (startTime == 7 && endTime == 9){totalPay = 24;}else if (startTime == 7 && endTime == 8){totalPay = 12;}else if (startTime == 8 && endTime == 4){totalPay = 104;}
                        else if (startTime == 8 && endTime == 3){totalPay = 88;}else if (startTime == 8 && endTime == 2){totalPay = 72;}else if (startTime == 8 && endTime == 1){totalPay = 56;}else if (startTime == 8 && endTime == 12){totalPay = 40;}else if (startTime == 8 && endTime == 11){totalPay = 32;}
                        else if (startTime == 8 && endTime == 10){totalPay = 24;}else if (startTime == 8 && endTime == 9){totalPay = 12;}else if (startTime == 9 && endTime == 4){totalPay = 92;}else if (startTime == 9 && endTime == 3){totalPay = 76;}else if (startTime == 9 && endTime == 2){totalPay = 60;}
                        else if (startTime == 9 && endTime == 1){totalPay = 44;}else if (startTime == 9 && endTime == 12){totalPay = 28;}else if (startTime == 9 && endTime == 11){totalPay = 20;}else if (startTime == 9 && endTime == 10){totalPay = 12;}else if (startTime == 10 && endTime == 4){totalPay = 80;}
                        else if (startTime == 10 && endTime == 3){totalPay = 64;}else if (startTime == 10 && endTime == 2){totalPay = 48;}else if (startTime == 10 && endTime == 1){totalPay = 32;}else if (startTime == 10 && endTime == 12){totalPay = 16;}else if (startTime == 10 && endTime == 11){totalPay = 8;}
                        else if (startTime == 11 && endTime == 4){totalPay = 72;}else if (startTime == 11 && endTime == 3){totalPay = 56;}else if (startTime == 11 && endTime == 2){totalPay = 40;}else if (startTime == 11 && endTime == 1){totalPay = 24;}else if (startTime == 11 && endTime == 12){totalPay = 8;}
                        else if (startTime == 12 && endTime == 4){totalPay = 64;}else if (startTime == 12 && endTime == 3) {totalPay = 48; }else if (startTime == 12 && endTime == 2){totalPay = 32;}else if (startTime == 12 && endTime == 1){totalPay = 16;}else if (startTime == 1 && endTime == 4){totalPay = 48;}
                        else if (startTime == 1 && endTime == 3){totalPay = 32;}else if (startTime == 1 && endTime == 2){totalPay = 16;}else if (startTime == 2 && endTime == 4){totalPay = 32;}else if (startTime == 2 && endTime == 3){totalPay = 16; }else if (startTime == 3 && endTime == 4){totalPay = 16;}
                        break;
                    
                    case "C":
                        //Family C
                        if (startTime == 5 && endTime == 4){totalPay = 189;}
                        else if (startTime == 5 && endTime == 3){totalPay = 174;}else if (startTime == 5 && endTime == 2){totalPay = 159;}else if (startTime == 5 && endTime == 1){totalPay = 144;}else if (startTime == 5 && endTime == 12){totalPay = 129;}else if (startTime == 5 && endTime == 11){totalPay = 114;}
                        else if (startTime == 5 && endTime == 10){totalPay = 99;}else if (startTime == 5 && endTime == 9){totalPay = 84;}else if (startTime == 5 && endTime == 8){totalPay = 63;}else if (startTime == 5 && endTime == 7){totalPay = 42;}else if (startTime == 5 && endTime == 6){totalPay = 21;}
                        else if (startTime == 6 && endTime == 4){totalPay = 168;}else if (startTime == 6 && endTime == 3){totalPay = 153;}else if (startTime == 6 && endTime == 2){totalPay = 138;}else if (startTime == 6 && endTime == 1){totalPay = 123;}else if (startTime == 6 && endTime == 12){totalPay = 108;}
                        else if (startTime == 6 && endTime == 11){totalPay = 93;}else if (startTime == 6 && endTime == 10){totalPay = 78;}else if (startTime == 6 && endTime == 9){totalPay = 63;}else if (startTime == 6 && endTime == 8){totalPay = 42;}else if (startTime == 6 && endTime == 7){totalPay = 21;}
                        else if (startTime == 7 && endTime == 4){totalPay = 147;}else if (startTime == 7 && endTime == 3){totalPay = 132;}else if (startTime == 7 && endTime == 2){totalPay = 117;}else if (startTime == 7 && endTime == 1){totalPay = 102;}else if (startTime == 7 && endTime == 12){totalPay = 87;}
                        else if (startTime == 7 && endTime == 11){totalPay = 72;}else if (startTime == 7 && endTime == 10){totalPay = 57;}else if (startTime == 7 && endTime == 9){totalPay = 42;}else if (startTime == 7 && endTime == 8){totalPay = 21;}else if (startTime == 8 && endTime == 4){totalPay = 126;}
                        else if (startTime == 8 && endTime == 3){totalPay = 111;}else if (startTime == 8 && endTime == 2) {totalPay = 96;}else if (startTime == 8 && endTime == 1){totalPay = 81;}else if (startTime == 8 && endTime == 12){totalPay = 66;}else if (startTime == 8 && endTime == 11){totalPay = 51;}
                        else if (startTime == 8 && endTime == 10){totalPay = 36;}else if (startTime == 8 && endTime == 9){totalPay = 21;}else if (startTime == 9 && endTime == 4){totalPay = 105;}else if (startTime == 9 && endTime == 3){totalPay = 90;}else if (startTime == 9 && endTime == 2){totalPay = 75;}
                        else if (startTime == 9 && endTime == 1){totalPay = 60;}else if (startTime == 9 && endTime == 12){totalPay = 45;}else if (startTime == 9 && endTime == 11){totalPay = 30;}else if (startTime == 9 && endTime == 10){totalPay = 15;}else if (startTime == 10 && endTime == 4){totalPay = 90;}
                        else if (startTime == 10 && endTime == 3){totalPay = 75;}else if (startTime == 10 && endTime == 2){totalPay = 60;}else if (startTime == 10 && endTime == 1){totalPay = 45;}else if (startTime == 10 && endTime == 12){totalPay = 30;}else if (startTime == 10 && endTime == 11){totalPay = 15;}
                        else if (startTime == 11 && endTime == 4){totalPay = 75;}else if (startTime == 11 && endTime == 3){totalPay = 60;}else if (startTime == 11 && endTime == 2){totalPay = 45;}else if (startTime == 11 && endTime == 1){totalPay = 30;} else if (startTime == 11 && endTime == 12){totalPay = 15;}
                        else if (startTime == 12 && endTime == 4){totalPay = 60;}else if (startTime == 12 && endTime == 3){totalPay = 45;}else if (startTime == 12 && endTime == 2){totalPay = 30;}else if (startTime == 12 && endTime == 1){totalPay = 15;}else if (startTime == 1 && endTime == 4){totalPay = 45;}
                        else if (startTime == 1 && endTime == 3){totalPay = 30;}else if (startTime == 1 && endTime == 2){totalPay = 15;}else if (startTime == 2 && endTime == 4){totalPay = 30;}else if (startTime == 2 && endTime == 3){totalPay = 15;}else if (startTime == 3 && endTime == 4){totalPay = 15;}
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
                
                //Ask to calculate a new night
                Console.WriteLine("Would you like to calculate another night or work with a different family [Y or N]");

                //Reset text color
                Console.ResetColor();

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }

        }
    }
}