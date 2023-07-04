using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwormGame;

internal enum Flow
{
    Left,
    Rigth,
    Up,
    Down
}
internal class Engine
{
    public bool isGaming { get; set; }
    private readonly Settings _settings;
    private readonly Controller controller;
    private Canvas _canvas { get; init; }
    private char[,] Grid { get; set; }
    private Random rnd = new Random();
    private int rndX;
    private int rndY;

    internal Engine(Settings settings, Canvas canvas, Controller controller)
    {
        _settings = settings;
        Grid = initializeGrid();
        GenerateRandomePiece();
        _canvas = canvas;
        this.controller = controller;
        controller.StartGameEvent += Start;
        controller.EndGameEvent += EndGame;
        controller.LeftFlowEvent += ListenFlow;
        controller.StartListen();
    }

    private char[,] initializeGrid()
    {
        char emptyCell = ' ';
        char[,] grid = new char[_settings.canvasWidth, _settings.canvasHeight];
        for (var i = 0; i < _settings.canvasWidth; i++)
        {
            for (var j = 0; j < _settings.canvasHeight; j++)
            {
                grid[i, j] = emptyCell;
            }
        }
        return grid;
    }

    internal void Start()
    {
        isGaming = true;
        _canvas.DrawFrame();
        do
        {
            controller.ReadUserKey();
            Thread.Sleep(100);
            DrawCanvas();

        } while (isGaming);
    }

    internal void EndGame()
    {
        isGaming = false;
        Console.WriteLine("Game Over");
    }

    private void DrawCanvas()
    {
        _canvas.Draw(Grid);
    }

    private void GenerateRandomePiece()
    {
        rndY = rnd.Next(0, _settings.canvasHeight);
        rndX = rnd.Next(0, _settings.canvasWidth);
        Grid[rndX, rndY] = _settings.snakeSymbol;
    }

    private void ListenFlow()
    {
        char emptyCell = ' ';
        char[,] grid = new char[_settings.canvasWidth, _settings.canvasHeight];
        for (var i = 0; i < _settings.canvasWidth; i++)
        {
            for (var j = 0; j < _settings.canvasHeight; j++)
            {
                grid[i, j] = emptyCell;
            }
        }
        var flow = Flow.Left;
        if (Flow.Left == flow)
        {
            if (rndX - 1 > 0)
            {
                grid[--rndX, rndY] = _settings.snakeSymbol;

            }
            else
            {
                grid[_settings.canvasWidth - 1, rndY] = _settings.snakeSymbol;
                rndX = _settings.canvasWidth - 1;
            }
        }
        Grid = grid;
    }
}
