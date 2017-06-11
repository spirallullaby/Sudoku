using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sudoku
{
    class Value : IValue
    {
        private ISet<int> suggestions;
        public bool Solved { get; private set; }
        public Value()
        {
            suggestions = new HashSet<int>();
            Solved = false;
        }
        public void Add(int i)
        {
            if (Solved)
                return;
            if (i <= 0 || i > 9)
            {
                throw new Exception($"Invalid value: {i}");
            }
            suggestions.Add(i);
        }
        public IEnumerable<int> GetSolutions()
        {
            return suggestions;
        }
        public void Solve(int i)
        {
            suggestions.Clear();
            suggestions.Add(i);
            this.Solved = true;
        }
    }
}
