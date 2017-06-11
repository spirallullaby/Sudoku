using System;
using System.Collections.Generic;
using System.Text;

namespace Sudoku
{
    class SudokuSolver
    {
        private ISudoku sudoku;
        public SudokuSolver(ISudoku data)
        {
            sudoku = data;
        }
        public ISudoku Solve()
        {
            throw new NotImplementedException();
        }
    }
}
