using FinalBattle;

public class TheTrueProgrammer : Character
{
    private string? name;

    public override string Name => name ?? "Unknown Programmer";

    public override IAttack StandardAttack { get; } = new Punch();

    public TheTrueProgrammer()
        : base(25)
    {
        ConsoleColor previousColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write("You are the True Programmer, what is your name: ");
        Console.ForegroundColor = previousColor;

        Console.ForegroundColor = ConsoleColor.Cyan;
        name = Console.ReadLine();
        Console.ForegroundColor = previousColor;
    }

    public TheTrueProgrammer(string name)
        : base(25)
    {
        this.name = name;
    }
}
