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
        public void AddRange(IEnumerable<int> range)
        {
            if (Solved)
                return;
            var normalisedValues = range.Where(i => i > 0 && i < 10);
            suggestions.UnionWith(normalisedValues);
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
