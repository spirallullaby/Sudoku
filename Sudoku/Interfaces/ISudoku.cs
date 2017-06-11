using System.Collections.Generic;

namespace Sudoku
{
    internal interface ISudoku
    {
        int Size { get; } //currently working with 9
        IDictionary<IPosition, Value> SudokuValues { get; set; }
    }
}