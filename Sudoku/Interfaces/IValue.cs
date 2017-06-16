using System.Collections.Generic;

namespace Sudoku
{
    interface IValue
    {
        bool Solved { get; }
        void AddRange(IEnumerable<int> range);
        IEnumerable<int> GetSolutions();
        void Solve(int i);
    }
}
