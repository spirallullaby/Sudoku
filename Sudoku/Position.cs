using System;
using System.Collections.Generic;
using System.Text;

namespace Sudoku
{
    class Position : IPosition
    {
        public int X { get; }
        public int Y { get; }
        public Box Box { get; }
        public Position(int x, int y, Box b)
        {
            X = x;
            Y = y;
            Box = b;
        }
    }
}
