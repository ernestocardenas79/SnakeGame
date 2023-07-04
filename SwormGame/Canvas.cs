namespace SwormGame;

internal class Canvas
{
    private readonly Settings _settings;
    private int printedTimes;
    internal Canvas(Settings settings)
    {
        _settings = settings;
    }

    internal void Draw(char[,] grid)
    {
        for (int row = 1; row <= _settings.canvasWidth; row++)
        {
            for (int col = 1; col <= _settings.canvasHeight; col++)
            {
                Console.SetCursorPosition(row, col);
                Console.Write(grid[row - 1, col - 1]);
            }
        };

        Console.SetCursorPosition(0, _settings.canvasHeight + 3);
    }

    internal void DrawFrame()
    {
        Console.Clear();
        Console.CursorVisible = false;

        for (int row = 0; row <= _settings.canvasHeight + 1; row++)
        {
            Console.SetCursorPosition(0, row);
            Console.Write(_settings.edgeSymbol);
            Console.SetCursorPosition(_settings.canvasWidth + 1, row);
            Console.Write(_settings.edgeSymbol);
        }

        for (int col = 1; col <= _settings.canvasWidth; col++)
        {
            Console.SetCursorPosition(col, 0);
            Console.Write(_settings.edgeSymbol);
            Console.SetCursorPosition(col, _settings.canvasHeight + 1);
            Console.Write(_settings.edgeSymbol);
        }
    }
}