using System.Collections.Generic;

namespace Sudoku
{
    internal interface ISudoku
    {
        int Size { get; } //currently working with 9
        IDictionary<IPosition, IValue> SudokuValues { get; set; }
        IDictionary<IPosition, Box> BoxesByPosition { get; }
    }
}