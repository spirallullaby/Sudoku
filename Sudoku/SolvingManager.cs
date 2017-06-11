namespace Sudoku
{
    class SolvingManager
    {
        ISudokuSolver solver;
        public SolvingManager(string input)
        {
            var sudoku = new Sudoku(input);
            solver = new SudokuSolver(sudoku);
        }
        public ISudoku GetSolution()
        {
            return solver.Solve();
        }
    }
}
