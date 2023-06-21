using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwormGame;
internal class Engine
{
    private int limit = 100;

    private readonly Settings _settings;
    private Canvas _canvas { get; init; }
    private char[,] Grid { get; init; }

    internal Engine(Settings settings, Canvas canvas)
    {
        _settings = settings;
        Grid = initializeGrid();
        _canvas = canvas;
    }

    private char[,] initializeGrid()
    {
        char emptyCell = ' ';
        char[,] grid = new char[_settings.canvasHeight,_settings.canvasHeight];
        for (var i = 0; i < _settings.canvasHeight; i++)
        {
            for(var j = 0; j < _settings.canvasWidth; j++)
            {
                grid[i,j]= emptyCell;
            }
        }

        return grid;
    }

    internal void Start()
    {
        var counter = 0;
        do
        {
            Thread.Sleep(500);
            DrawCanvas();
        } while (counter++ < limit);
    }

    private void DrawCanvas()
    {
        _canvas.Draw(Grid);
    }
}
