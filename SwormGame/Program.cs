// See https://aka.ms/new-console-template for more information

var snakeSymbol = "0";
var canvasHeight = 5;
var canvasWidth = 5;
var edgeSymbol = "::";
CreateCanvas(canvasHeight, canvasWidth);
Console.Clear();

CreateCanvas(canvasHeight, canvasWidth);

void CreateCanvas(int canvasHeight, int canvasWidth)
{
    for (int row = 0; row <= canvasHeight+1; row++)
	{
        for (int col = 0; col <= canvasWidth + 1; col++)
        {
            if (row == 0 || row == canvasHeight + 1)
            {
                snakeSymbol = "::";
            }
            else
            {
                snakeSymbol = "0";
            }
            
            if (col > 0 && col < canvasWidth + 1)
            {
                Console.Write(snakeSymbol);
                continue;
            }

            if (col == 0)
            {
                Console.Write(edgeSymbol);
                continue;
            }

            if (col == canvasWidth + 1)
            {
                Console.WriteLine(edgeSymbol);
            }
        }
    };
}

Console.ReadLine();
