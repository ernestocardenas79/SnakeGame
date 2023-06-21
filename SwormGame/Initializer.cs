using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwormGame;
internal class Initializer
{
    private readonly Settings settings;

    internal Initializer(Settings _settings) {
        settings = _settings;
    }

    internal Game CreateSankeGame()
    {
      return new Game(new Settings()
        {
            snakeSymbol = "0",
            canvasHeight = 15,
            canvasWidth = 15,
            edgeSymbol = ":"
        });

    }    
}
