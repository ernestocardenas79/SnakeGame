using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwormGame;
internal class Game
{
    internal Settings Settings { get; init; }
    private readonly Engine engine;

    internal Game(Settings settings) { 
        Settings = settings;

        engine = new Engine(settings, new Canvas(settings));
    }

    internal void Start()
    {
        engine.Start();
    }
}
