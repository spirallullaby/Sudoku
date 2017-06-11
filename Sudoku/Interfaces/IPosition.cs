namespace Sudoku
{
    interface IPosition
    {
        int X { get; }
        int Y { get; }
        Box Box { get; }
    }
}
