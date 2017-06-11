using System;
using System.Linq;

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
                var rowValues = sudoku.SudokuValues.Where(sv => sv.Key.Y == i);
                var colValues = sudoku.SudokuValues.Where(sv => sv.Key.X == i);
                //var boxValues = sudoku.SudokuValues.Where(sv => sv.Key.X)
            }
        }
    }
}
