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
        Console.Clear();
        for (int row = 0; row <= _settings.canvasHeight; row++)
        {
            Console.Write(_settings.edgeSymbol);
        }
        Console.WriteLine(_settings.edgeSymbol);

        for (int row = 0; row < _settings.canvasHeight; row++)
        {
            Console.Write(_settings.edgeSymbol);

            for (int col = 0; col < _settings.canvasWidth; col++)
            {
                Console.Write(grid[row, col]);
            }
            Console.WriteLine(_settings.edgeSymbol);
        };

        for (int row = 0; row <= _settings.canvasHeight; row++)
        {
            Console.Write(_settings.edgeSymbol);
        }
        Console.WriteLine(_settings.edgeSymbol);

        Console.WriteLine();
        Console.WriteLine("Printed times "+ ++printedTimes);
       
    }
}