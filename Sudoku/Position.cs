﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sudoku
{
    struct Position
    {
        public int X { get; }
        public int Y { get; }
        //public Box Box { get; }
        public Position(int x, int y)
        {
            X = x;
            Y = y;
            //Box = b;
        }
    }
}
