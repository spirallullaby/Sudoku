using Sudoku.Interfaces;
using System.Collections.Generic;
namespace Sudoku
{
    class Box : IBox
    {
        public int Left { get; private set; }
        public int Right { get; private set; }
        public int Top { get; private set; }
        public int Bottom { get; private set; }
        public Box(int l, int r, int t, int b)
        {
            Left = l;
            Right = r;
            Top = t;
            Bottom = b;
        }
    }
}
