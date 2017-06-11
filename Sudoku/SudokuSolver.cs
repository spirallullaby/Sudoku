using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sudoku
{
    class SudokuSolver : ISudokuSolver
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
        private void FillInPossibleSolutions()
        {
            for (int i = 0; i < sudoku.Size; i++)
            {
                var row = sudoku.SudokuValues.Where(sv => sv.Key.Y == i);
                var col = sudoku.SudokuValues.Where(sv => sv.Key.X == i);
            }
        }
    }
}
