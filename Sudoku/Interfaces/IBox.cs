using System;
using System.Collections.Generic;
using System.Text;

namespace Sudoku.Interfaces
{
    interface IBox
    {
        int Left { get; }
        int Right { get; }
        int Top { get; }
        int Bottom { get; }
    }
}
