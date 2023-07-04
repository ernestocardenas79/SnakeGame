namespace SwormGame;
internal class Initializer
{
    private readonly Settings settings;

    internal Initializer(Settings _settings)
    {
        settings = _settings;
    }

    internal Game CreateSankeGame()
    {
        initialPrompt();
        return new Game(settings);
    }

    internal void initialPrompt()
    {
        Console.Clear();
        Console.WriteLine("Pulsa S para iniciar el juego");
    }
}
