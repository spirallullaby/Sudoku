using System.Collections.Generic;

namespace Sudoku
{
    internal interface ISudoku
    {
        int Size { get; } //currently working with 9
        IDictionary<Position, IValue> SudokuValues { get; set; }
        IDictionary<Position, Box> BoxesByPosition { get; }
        string ToString();
    }
}