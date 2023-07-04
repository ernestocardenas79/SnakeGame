using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwormGame;
internal class Settings
{
    internal char snakeSymbol { get; init; } = '0';
    internal int canvasHeight { get; init; } = 5;
    internal int canvasWidth { get; init; } = 5;
    internal string edgeSymbol { get; init; } = "::";
}
