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
        public static int turn = 1;
        public static int turnCounter = 0;
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
                checkVictoryP1();
                checkVictoryP2();
                if (turnCounter == 9){
                    gameState = "tie";
                }
                if (turn == 1 && gameState.Equals("running"))
                {
                    Console.WriteLine("Player 1. Which box would you like to go?");
                    chosenPositionString = Console.ReadLine();
                    try {
                    chosenPosition = Int32.Parse(chosenPositionString);
                    } catch (FormatException){
                        Console.WriteLine("Error: The input is not a valid number.");
                    }
                    Console.WriteLine(chosenPosition);
                    // Ok some annoying if statements here we go....
                    if (chosenPosition == 1)
                    {
                        if (!topLeft.occupied)
                        {
                            topLeft.value = 1;
                            topLeft.occupied = true;
                            turn = 2;
                            displayGrid();
                            turnCounter++;
                            continue;
                        }
                        else if (topLeft.occupied)
                        {
                            Console.WriteLine("That spot is already occupied. Please choose somewhere else");
                            displayGrid();
                            continue;
                        }
                    }
                    if (chosenPosition == 2)
                    {
                        if (!topMiddle.occupied)
                        {
                            topMiddle.value = 1;
                            topMiddle.occupied = true;
                            turn = 2;
                            displayGrid();
                            turnCounter++;
                            continue;
                        }
                        else if (topMiddle.occupied)
                        {
                            Console.WriteLine("That spot is already occupied. Please choose somewhere else");
                            displayGrid();
                            continue;
                        }
                    }
                    if (chosenPosition == 3)
                    {
                        if (!topRight.occupied)
                        {
                            topRight.value = 1;
                            topRight.occupied = true;
                            turn = 2;
                            turnCounter++;
                            displayGrid();
                            continue;
                        }
                        else if (topRight.occupied)
                        {
                            Console.WriteLine("That spot is already occupied. Please choose somewhere else");
                            displayGrid();
                            continue;
                        }
                    }
                    if (chosenPosition == 4)
                    {
                        if (!middleLeft.occupied)
                        {
                            middleLeft.value = 1;
                            middleLeft.occupied = true;
                            turn = 2;
                            turnCounter++;
                            displayGrid();
                            continue;
                        }
                        else if (middleLeft.occupied)
                        {
                            Console.WriteLine("That spot is already occupied. Please choose somewhere else");
                            displayGrid();
                            continue;
                        }
                    }
                    if (chosenPosition == 5)
                    {
                        if (!middleMiddle.occupied)
                        {
                            middleMiddle.value = 1;
                            middleMiddle.occupied = true;
                            turn = 2;
                            turnCounter++;
                            displayGrid();
                            continue;
                        }
                        else if (middleMiddle.occupied)
                        {
                            Console.WriteLine("That spot is already occupied. Please choose somewhere else");
                            displayGrid();
                            continue;
                        }
                    }
                    if (chosenPosition == 6)
                    {
                        if (!middleRight.occupied)
                        {
                            middleRight.value = 1;
                            middleRight.occupied = true;
                            turn = 2;
                            turnCounter++;
                            displayGrid();
                            continue;
                        }
                        else if (middleRight.occupied)
                        {
                            Console.WriteLine("That spot is already occupied. Please choose somewhere else");
                            displayGrid();
                            continue;
                        }
                    }
                    if (chosenPosition == 7)
                    {
                        if (!bottomLeft.occupied)
                        {
                            bottomLeft.value = 1;
                            bottomLeft.occupied = true;
                            turn = 2;
                            turnCounter++;
                            displayGrid();
                            continue;
                        }
                        else if (bottomLeft.occupied)
                        {
                            Console.WriteLine("That spot is already occupied. Please choose somewhere else");
                            displayGrid();
                            continue;
                        }
                    }
                    if (chosenPosition == 8)
                    {
                        if (!bottomMiddle.occupied)
                        {
                            bottomMiddle.value = 1;
                            bottomMiddle.occupied = true;
                            turn = 2;
                            turnCounter++;
                            displayGrid();
                            continue;
                        }
                        else if (bottomMiddle.occupied)
                        {
                            Console.WriteLine("That spot is already occupied. Please choose somewhere else");
                            displayGrid();
                            continue;
                        }
                    }
                    if (chosenPosition == 9)
                    {
                       if (!bottomRight.occupied)
                        {
                            bottomRight.value = 1;
                            bottomRight.occupied = true;
                            turn = 2;
                            turnCounter++;
                            displayGrid();
                            continue;
                        }
                        else if (bottomRight.occupied)
                        {
                            Console.WriteLine("That spot is already occupied. Please choose somewhere else");
                            displayGrid();
                            continue;
                        }
                    }
                    if (chosenPosition > 9){
                        Console.WriteLine("That's not a valid spot. Please try again");
                        displayGrid();
                        continue;
                    }
                    if (chosenPosition < 1){
                        Console.WriteLine("That's not a valid spot. Please try again");
                        displayGrid();
                        continue;
                    }
                }
                // Yay player 2
                if (turn == 2 && gameState.Equals("running"))
                {
                    Console.WriteLine("Player 2. Which box would you like to go?");
                    chosenPositionString = Console.ReadLine();
                    chosenPosition = Int32.Parse(chosenPositionString);
                    Console.WriteLine(chosenPosition);
                    // Ok some annoying if statements here we go....
                    if (chosenPosition == 1)
                    {
                        if (!topLeft.occupied)
                        {
                            topLeft.value = 2;
                            topLeft.occupied = true;
                            turn = 1;
                            turnCounter++;
                            displayGrid();
                            continue;
                        }
                        else if (topLeft.occupied)
                        {
                            Console.WriteLine("That spot is already occupied. Please choose somewhere else");
                            displayGrid();
                            continue;
                        }
                    }
                    if (chosenPosition == 2)
                    {
                        if (!topMiddle.occupied)
                        {
                            topMiddle.value = 2;
                            topMiddle.occupied = true;
                            turn = 1;
                            turnCounter++;
                            displayGrid();
                            continue;
                        }
                        else if (topMiddle.occupied)
                        {
                            Console.WriteLine("That spot is already occupied. Please choose somewhere else");
                            displayGrid();
                            continue;
                        }
                    }
                    if (chosenPosition == 3)
                    {
                        if (!topRight.occupied)
                        {
                            topRight.value = 2;
                            topRight.occupied = true;
                            turn = 1;
                            turnCounter++;
                            displayGrid();
                            continue;
                        }
                        else if (topRight.occupied)
                        {
                            Console.WriteLine("That spot is already occupied. Please choose somewhere else");
                            displayGrid();
                            continue;
                        }
                    }
                    if (chosenPosition == 4)
                    {
                        if (!middleLeft.occupied)
                        {
                            middleLeft.value = 2;
                            middleLeft.occupied = true;
                            turn = 1;
                            turnCounter++;
                            displayGrid();
                            continue;
                        }
                        else if (middleLeft.occupied)
                        {
                            Console.WriteLine("That spot is already occupied. Please choose somewhere else");
                            displayGrid();
                            continue;
                        }
                    }
                    if (chosenPosition == 5)
                    {
                        if (!middleMiddle.occupied)
                        {
                            middleMiddle.value = 2;
                            middleMiddle.occupied = true;
                            turn = 1;
                            turnCounter++;
                            displayGrid();
                            continue;
                        }
                        else if (middleMiddle.occupied)
                        {
                            Console.WriteLine("That spot is already occupied. Please choose somewhere else");
                            displayGrid();
                            continue;
                        }
                    }
                    if (chosenPosition == 6)
                    {
                        if (!middleRight.occupied)
                        {
                            middleRight.value = 2;
                            middleRight.occupied = true;
                            turn = 1;
                            turnCounter++;
                            displayGrid();
                            continue;
                        }
                        else if (middleRight.occupied)
                        {
                            Console.WriteLine("That spot is already occupied. Please choose somewhere else");
                            displayGrid();
                            continue;
                        }
                    }
                    if (chosenPosition == 7)
                    {
                        if (!bottomLeft.occupied)
                        {
                            bottomLeft.value = 2;
                            bottomLeft.occupied = true;
                            turn = 1;
                            turnCounter++;
                            displayGrid();
                            continue;
                        }
                        else if (bottomLeft.occupied)
                        {
                            Console.WriteLine("That spot is already occupied. Please choose somewhere else");
                            displayGrid();
                            continue;
                        }
                    }
                    if (chosenPosition == 8)
                    {
                        if (!bottomMiddle.occupied)
                        {
                            bottomMiddle.value = 2;
                            bottomMiddle.occupied = true;
                            turn = 1;
                            turnCounter++;
                            displayGrid();
                            continue;
                        }
                        else if (bottomMiddle.occupied)
                        {
                            Console.WriteLine("That spot is already occupied. Please choose somewhere else");
                            displayGrid();
                            continue;
                        }
                    }
                    if (chosenPosition == 9)
                    {
                       if (!bottomRight.occupied)
                        {
                            bottomRight.value = 2;
                            bottomRight.occupied = true;
                            turn = 1;
                            turnCounter++;
                            displayGrid();
                            continue;
                        }
                        else if (bottomRight.occupied)
                        {
                            Console.WriteLine("That spot is already occupied. Please choose somewhere else");
                            displayGrid();
                            continue;
                        }
                    }
                    if (chosenPosition > 9){
                        Console.WriteLine("That's not a valid spot. Please try again");
                        displayGrid();
                        continue;
                    }
                    if (chosenPosition < 1){
                        Console.WriteLine("That's not a valid spot. Please try again");
                        displayGrid();
                        continue;
                    }
                }
                // If statements are done!
                // Check if player 1 won
                void checkVictoryP1(){
                    if (topLeft.value == 1 && topRight.value == 1 && topMiddle.value == 1){
                        gameState = "p1";
                    }
                    if (middleLeft.value == 1 && middleMiddle.value == 1 && middleRight.value == 1){
                        gameState = "p1";
                    }
                    if (bottomLeft.value == 1 && bottomMiddle.value == 1 && bottomRight.value == 1)
                    {
                        gameState = "p1";
                    }
                    if (topLeft.value == 1 && middleLeft.value == 1 && bottomLeft.value == 1){
                        gameState = "p1";
                    }
                    if (topMiddle.value == 1 && middleMiddle.value == 1 && bottomMiddle.value ==1){
                        gameState = "p1";
                    }
                    if (topLeft.value == 1 && middleLeft.value == 1 && bottomLeft.value == 1){
                        gameState = "p1";
                    }
                    if (topLeft.value == 1 && middleMiddle.value == 1 && bottomRight.value == 1){
                        gameState = "p1";
                    }
                    if (topRight.value == 1 && middleMiddle.value == 1 && bottomLeft.value == 1){
                        gameState = "p1";
                    }
                }
                // Check if player 2 won
                 void checkVictoryP2(){
                    if (topLeft.value == 2 && topRight.value == 2 && topMiddle.value == 2){
                        gameState = "p2";
                    }
                    if (middleLeft.value == 2 && middleMiddle.value == 2 && middleRight.value == 2){
                        gameState = "p2";
                    }
                    if (bottomLeft.value == 2 && bottomMiddle.value == 2 && bottomRight.value == 2)
                    {
                        gameState = "p2";
                    }
                    if (topLeft.value == 2 && middleLeft.value == 2 && bottomLeft.value == 2){
                        gameState = "p2";
                    }
                    if (topMiddle.value == 2 && middleMiddle.value == 2 && bottomMiddle.value == 2){
                        gameState = "p2";
                    }
                    if (topLeft.value == 2 && middleLeft.value == 2 && bottomLeft.value == 2){
                        gameState = "p2";
                    }
                    if (topLeft.value == 2 && middleMiddle.value == 2 && bottomRight.value == 2){
                        gameState = "p2";
                    }
                    if (topRight.value == 2 && middleMiddle.value == 2 && bottomLeft.value == 2){
                        gameState = "p2";
                    }
                }
                void displayGrid()
                {
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
            }
            
            while (gameState.Equals("p1"))
            {
                Console.WriteLine("Player 1 wins!");
                gameState = ("");
            }
            while (gameState.Equals("p2"))
            {
                Console.WriteLine("Player 2 wins!");
                gameState = ("");
            }
            while (gameState.Equals("tie"))
            {
                Console.WriteLine("It's a tie!");
                gameState = ("");
            }
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();

        }
    }
}