namespace Sudoku
{
    interface IPosition
    {
        int X { get; }
        int Y { get; }
        bool Solved { get; set; }
    }
}
