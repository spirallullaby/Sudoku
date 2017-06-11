using System.Collections.Generic;

namespace Sudoku
{
    interface IValue
    {
        bool Solved { get; }
        void Add(int i);
        IEnumerable<int> GetSolutions();
        void Solve(int i);
    }
}
