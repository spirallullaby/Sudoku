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
            for (int row = 0; row < sudoku.Size; row++)
            {
                var rowValues = sudoku.SudokuValues.Where(sv => sv.Key.Y == row);
                for (int col = 0; col < sudoku.Size; col++)
                {
                    var colValues = sudoku.SudokuValues.Where(sv => sv.Key.X == col);
                    var boxValues = sudoku.BoxesByPosition[new Position(row, col)];
                }
            }
        }
    }
}
