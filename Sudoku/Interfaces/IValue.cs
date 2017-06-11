using System.Collections.Generic;

namespace Sudoku
{
    interface IValue
    {
        void Add(int i);
        int GetSolution();
        IEnumerable<int> GetPossibleValues();
        void Solve(int i);
    }
}
