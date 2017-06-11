using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sudoku
{
    class Value : IValue
    {
        private ISet<int> suggestions;
        public Value()
        {
            suggestions = new HashSet<int>();
        }
        public void Add(int i)
        {
            if (i <= 0 || i > 9)
            {
                throw new Exception($"Invalid value: {i}");
            }
            suggestions.Add(i);
        }
        public IEnumerable<int> GetPossibleValues()
        {
            return suggestions;
        }
        public int GetSolution()
        {
            if (suggestions.Count > 1)
                return -1;
            return suggestions.Single();
        }
        public void Solve(int i)
        {
            suggestions.Clear();
            suggestions.Add(i);
        }
    }
}
