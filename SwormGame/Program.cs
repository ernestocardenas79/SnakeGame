// See https://aka.ms/new-console-template for more information

using SwormGame;

var snakeGame = new Initializer(
    new Settings()
    {
        snakeSymbol = "0",
        canvasHeight = 15,
        canvasWidth = 15,
        edgeSymbol = ":"
    }).CreateSankeGame();

 snakeGame.Start();

Console.ReadLine();
