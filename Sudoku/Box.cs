namespace Sudoku
{
    struct Box
    {
        public int Left;
        public int Right;
        public int Top;
        public int Bottom;
        public Box(int l, int r, int t, int b)
        {
            Left = l;
            Right = r;
            Top = t;
            Bottom = b;
        }
    }
}
