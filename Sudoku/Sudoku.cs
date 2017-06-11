using System;
using System.Collections.Generic;
using System.Linq;

namespace Sudoku
{
    class Sudoku : ISudoku
    {
        public int Size { get; } //currently working with 9

        public IDictionary<IPosition, Value> SudokuValues { get; set; }

        public Sudoku(string input)
        {
            Size = 9;
            var inputLines = input.Split(new char[] { ';' });

            if (inputLines.Count() != Size)
                throw new ArgumentException("Lines do not match size!");

            var entries = inputLines
                            .Select(line => line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries));

            if (!entries.All(e => e.Count() == Size))
                throw new ArgumentException("Elements do not match size!");
            var trimmedEntries = entries.Select(l => l.Select(el => el.Trim()));
            this.SudokuValues = new Dictionary<IPosition, Value>();
            for (int i = 0; i < Size; i++)
            {
                var currentLine = trimmedEntries.ElementAt(i);
                for (int j = 0; j < Size; j++)
                {
                    var currentElement = currentLine.ElementAt(i);
                    var success = int.TryParse(currentElement, out int parsedRes);
                    var currentValue = new Value();
                    if (success)
                        currentValue.Add(parsedRes);
                    SudokuValues.Add(new Position(i, j, success), currentValue);
                }
            }
        }
    }
}
