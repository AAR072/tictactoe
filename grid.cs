﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe {
  class grid {
    // Constructor of the grid
    public grid(int locationConstructor) {
      location = locationConstructor;

    }
    public int location {
      get;
      set;
    }
    // Shows Value of the spot. 0 = nothing, 1 = X, 2 = O
    public int value;
    public string letter;
    public void convertLetter() {
      if (value == 0) {
        letter = "0";

      }
      if (value == 1) {
        letter = "X";
      }
      if (value == 2) {
        letter = "O";
      }
    }

  }
}