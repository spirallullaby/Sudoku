using System;
using System.Collections.Generic;
using System.Text;

namespace Sudoku
{
    class Position : IPosition
    {
        public int X { get; }
        public int Y { get; }
        public bool Solved { get; set; }
        public Position(int x, int y, bool solved)
        {
            X = x;
            Y = y;
            Solved = solved;
        }
    }
}
