using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace tictactoe
{
    //NOTE: I know there may be more efficient ways to do things, however, this code is not so complex that I must do it. The code below is still readable if you follow the comments and use your brain.
    internal class Program
    {
        public static string gameState = "running";
        public static string chosenPositionString;
        public static int chosenPosition;
        static void Main(string[] args)
        {
            //  Initialize grid classes
            grid topLeft = new grid(1, false, false);
            grid topMiddle = new grid(2, false, false);
            grid topRight = new grid(3, false, false);
            grid middleLeft = new grid(4, false, false);
            grid middleMiddle = new grid(5, false, false);
            grid middleRight = new grid(6, false, false);
            grid bottomLeft = new grid(7, false, false);
            grid bottomMiddle = new grid(8, false, false);
            grid bottomRight = new grid(9, false, false);

            // This is for debugging and controlling the game state
            grid masterGrid = new grid(999, false, false);
            // Instructions
            Console.WriteLine("Each grid has a number from 1 to 9 from left to right. Here is an example");
            Console.WriteLine("----------");
            Console.WriteLine($"{topLeft.location} | {topMiddle.location} | {topRight.location}");
            Console.WriteLine("----------");
            Console.WriteLine($"{middleLeft.location} | {middleMiddle.location} | {middleRight.location}");
            Console.WriteLine("----------");
            Console.WriteLine($"{bottomLeft.location} | {bottomMiddle.location} | {bottomRight.location}");
            Console.WriteLine("----------");
            Thread.Sleep(1000);

            Console.WriteLine("Player 1, you are X. Go first");

            while (gameState.Equals("running"))
            {

                Console.WriteLine("Player 1. Which box would you like to go?");
                chosenPositionString = Console.ReadLine();
                chosenPosition = Int32.Parse(chosenPositionString);
                Console.WriteLine(chosenPosition);
                // Ok some annoying if statements here we go....
                if (chosenPosition == 1)
                {
                    topLeft.chosenTemp = true;
                }
                if (chosenPosition == 2)
                {
                    topMiddle.chosenTemp = true;
                }
                if (chosenPosition == 3)
                {
                    topLeft.chosenTemp = true;
                }
                if (chosenPosition == 4){
                    middleLeft.chosenTemp = true;
                }
                if (chosenPosition == 5){
                    middleMiddle.chosenTemp = true;
                }
                if (chosenPosition == 6){
                    middleRight.chosenTemp = true;
                }
                if (chosenPosition == 7)
                {
                    bottomLeft.chosenTemp = true;
                }
                if (chosenPosition == 8){
                    bottomMiddle.chosenTemp = true;
                }
                if (chosenPosition == 9)
                {
                    bottomRight.chosenTemp = true;
                }

                // If statements are done!


                // Make sure numbers are correctly formatted
                topLeft.convertLetter();
                topMiddle.convertLetter();
                topRight.convertLetter();
                middleLeft.convertLetter();
                middleMiddle.convertLetter();
                middleRight.convertLetter();
                bottomRight.convertLetter();
                bottomMiddle.convertLetter();
                bottomLeft.convertLetter();
                // Display grid
                Console.WriteLine("----------");
                Console.WriteLine($"{topLeft.letter} | {topMiddle.letter} | {topRight.letter}");
                Console.WriteLine("----------");
                Console.WriteLine($"{middleLeft.letter} | {middleMiddle.letter} | {middleRight.letter}");
                Console.WriteLine("----------");
                Console.WriteLine($"{bottomLeft.letter} | {bottomMiddle.letter} | {bottomRight.letter}");
                Console.WriteLine("----------");
                Console.WriteLine();
            }
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();

        }
    }
}