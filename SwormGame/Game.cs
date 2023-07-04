namespace SwormGame;
internal class Game
{
    internal Settings Settings { get; init; }
    private readonly Engine engine;

    internal Game(Settings settings)
    {
        Settings = settings;
        engine = new Engine(settings, new Canvas(settings), new Controller());
        engine.Start();
    }

    internal void Start()
    {
        // engine.Start();
    }

    internal void EndGame()
    {
        engine.isGaming = false;
    }
}
