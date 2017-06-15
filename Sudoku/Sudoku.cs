using System;
using System.Collections.Generic;
using System.Linq;

namespace Sudoku
{
    class Sudoku : ISudoku
    {
        public int Size { get; }
        private static IList<Box> Boxes = new List<Box>
            {
            new Box(0, 2, 0, 2),
            new Box(3, 5, 0, 2),
            new Box(6, 8, 0, 2),
            new Box(0, 2, 3, 5),
            new Box(3, 5, 3, 5),
            new Box(6, 8, 3, 5),
            new Box(0, 2, 6, 8),
            new Box(3, 5, 6, 8),
            new Box(6, 8, 6, 8),
            };
        
        public IDictionary<IPosition, IValue> SudokuValues { get; set; }
        public IDictionary<IPosition, Box> BoxesByPosition { get; private set; }

        public Sudoku(string input)
        {
            Size = 9;
            var inputLines = input.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            if (inputLines.Count() != Size)
                throw new ArgumentException("Lines do not match size!");

            var entries = inputLines
                            .Select(line => line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries));

            if (!entries.All(e => e.Count() == Size))
                throw new ArgumentException("Elements do not match size!");
            var trimmedEntries = entries.Select(l => l.Select(el => el.Trim()));

            Func<Box, bool> isBoxDefault = (box) => box.Right == 0 || box.Bottom == 0;
            this.SudokuValues = new Dictionary<IPosition, IValue>();
            this.BoxesByPosition = new Dictionary<IPosition, Box>();

            for (int i = 0; i < Size; i++)
            {
                var currentLine = trimmedEntries.ElementAt(i);
                for (int j = 0; j < Size; j++)
                {
                    var currentElement = currentLine.ElementAt(j);
                    var success = int.TryParse(currentElement, out int parsedRes);
                    var currentValue = new Value();
                    if (success)
                        currentValue.Solve(parsedRes);
                    var box = Boxes.SingleOrDefault(b => b.Left <= i && b.Right >= i && b.Top <= j && b.Bottom >= j);
                    var position = new Position(i, j);
                    BoxesByPosition.Add(position, box);
                    if (isBoxDefault(box))
                        throw new ArgumentException("Could not find box!");
                    SudokuValues.Add(position, currentValue);
                }
            }
        }


    }
}
