// See https://aka.ms/new-console-template for more information

using SwormGame;

var snakeGame = new Initializer(
    new Settings()
    {
        snakeSymbol = '0',
        canvasHeight = 25,
        canvasWidth = 50,
        edgeSymbol = "!"
    }).CreateSankeGame();
