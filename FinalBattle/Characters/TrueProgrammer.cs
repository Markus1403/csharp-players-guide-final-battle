using FinalBattle;

public class TheTrueProgrammer : Character {
    private string? name;

    public TheTrueProgrammer() {
        ConsoleColor previousColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write("You are the True Programmer, what is your name: ");
        Console.ForegroundColor = previousColor;

        Console.ForegroundColor = ConsoleColor.Cyan;
        name = Console.ReadLine();
        Console.ForegroundColor = previousColor;
    }

    public override string Name => name ?? string.Empty;

    public override int InitialHealth => 25;

    public override IAttack StandardAttack { get; } = new Punch();

}