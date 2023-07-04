using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwormGame;
internal class Controller
{
    public bool keepReading { get; set; }
    internal delegate void StartGameHandler();
    internal delegate void EndGameHandler();
    internal delegate void LeftFlowHandler();
    internal event StartGameHandler StartGameEvent;
    internal event EndGameHandler EndGameEvent;
    internal event LeftFlowHandler LeftFlowEvent;
    private ConsoleKeyInfo key;

    internal void StartListen()
    {
        keepReading = true;
        ReadUserKey();
    }

    internal void ReadUserKey()
    {
        if (Console.KeyAvailable)
        {
            key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.S)
            {
                StartGameEvent?.Invoke();
            }

            if (key.Key == ConsoleKey.E)
            {
                keepReading = false;
                EndGameEvent?.Invoke();
            }
            if (key.Key == ConsoleKey.LeftArrow)
            {
                LeftFlowEvent?.Invoke();
            }
        }
    }
}
