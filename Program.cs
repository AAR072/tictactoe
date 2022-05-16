using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace tictactoe
{
    //NOTE: I know there may be more efficient ways to do things, however, this code is not so complex that I must do it. The code below is still readable if you follow the comments and use your brain.S
    internal class Program
    {
        public int turn = 1;
        static void Main(string[] args)
        {
            //  Initialize grid classes
            grid topLeft = new grid(1);
            grid topMiddle = new grid(2);
            grid topRight = new grid(3);
            grid middleLeft = new grid(4);
            grid middleMiddle = new grid(5);
            grid middleRight = new grid(6);
            grid bottomLeft = new grid(7);
            grid bottomMiddle = new grid(8);
            grid bottomRight = new grid(9);
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

            topLeft.convertLetter();
            topMiddle.convertLetter();
            topRight.convertLetter();
            middleLeft.convertLetter();
            middleMiddle.convertLetter();
            middleRight.convertLetter();
            bottomRight.convertLetter();
            bottomMiddle.convertLetter();
            bottomLeft.convertLetter();

            Console.WriteLine("----------");
            Console.WriteLine($"{topLeft.letter} | {topMiddle.letter} | {topRight.letter}");
            Console.WriteLine("----------");
            Console.WriteLine($"{middleLeft.letter} | {middleMiddle.letter} | {middleRight.letter}");
            Console.WriteLine("----------");
            Console.WriteLine($"{bottomLeft.letter} | {bottomMiddle.letter} | {bottomRight.letter}");
            Console.WriteLine("----------");
            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();

        }
    }
}