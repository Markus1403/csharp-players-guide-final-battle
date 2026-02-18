namespace FinalBattle;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "The Final Battle";
        Game game = new Game();
        game.GameRunning();
    }
}
