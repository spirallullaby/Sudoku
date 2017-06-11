using System;

namespace Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sudoku with , between each number and ; at the end of the line. Missing numbers enter as '-'");
            var input = Console.ReadLine();
            var solSolver = new SolvingManager(input);
        }
    }
}