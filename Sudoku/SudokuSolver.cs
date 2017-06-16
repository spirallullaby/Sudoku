using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Sudoku
{
    class SudokuSolver : ISudokuSolver
    {
        private ISudoku sudoku;
        private int[] allValues = new int[] { 1,2,3,4,5,6,7,8,9 };
        public SudokuSolver(ISudoku data)
        {
            sudoku = data;
        }
        public ISudoku Solve()
        {
            FillInPossibleSolutions();
            return null;
        }
        private void FillInPossibleSolutions()
        {
            for (int row = 0; row < sudoku.Size; row++)
            {
                var rowValues = sudoku.SudokuValues.Where(sv => sv.Key.Y == row)
                                                    .Select(p => p.Value)
                                                    .Where(v => v.Solved);
                for (int col = 0; col < sudoku.Size; col++)
                {
                    var currentPosition = new Position(row, col);
                    if (sudoku.SudokuValues[currentPosition].Solved)
                        continue;
                    var colValues = sudoku.SudokuValues.Where(sv => sv.Key.X == col)
                                        .Select(p => p.Value)
                                        .Where(v => v.Solved);
                    var boxRows = sudoku.BoxesByPosition[currentPosition].GetBoxRows();
                    var boxCols = sudoku.BoxesByPosition[currentPosition].GetBoxColumns();
                    var boxValues = 
                        boxRows.SelectMany(r => boxCols.Select(c => Tuple.Create(r, c)))
                        .Select(comb => sudoku.SudokuValues[new Position(comb.Item1, comb.Item2)])
                        .Where(val => val.Solved);
                    var allValuesDistinct = rowValues.Concat(colValues).Concat(boxValues)
                                                .Select(v => v.GetSolutions().SingleOrDefault())
                                                .Distinct();
                    var suggestions = allValues.Except(allValuesDistinct);
                    //if(!suggestions.Any())
                    //{
                    //    throw new Exception("This should have been solved");
                    //}
                    if(!suggestions.Skip(1).Any())
                    {
                        sudoku.SudokuValues[currentPosition].Solve(suggestions.Single());                        
                    }
                    else
                    {
                        sudoku.SudokuValues[currentPosition].AddRange(suggestions);
                    }
                }
            }
        }
    }
}
