using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe
{
    class grid
    {
        // Constructor of the grid
        public grid(int locationConstructor, bool occupiedConstructor, bool chosenTempConstructor)
        {
            location = locationConstructor;
            occupied = occupiedConstructor;
        }
        public int location
        {
            get;
            set;
        }
        // Shows Value of the spot. 0 = nothing, 1 = X, 2 = O
        public int value;
        public string letter;
        public bool occupied { get; set; }
        public string chosenPositionString;
        public bool chosenTemp;
        public int chosenPosition;
        // Letter converter function
        public void convertLetter()
        {
            if (value == 0)
            {
                letter = " ";

            }
            if (value == 1)
            {
                letter = "X";
            }
            if (value == 2)
            {
                letter = "O";
            }
        }


    }

}