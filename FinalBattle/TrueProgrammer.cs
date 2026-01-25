using FinalBattle;

public class TheTrueProgrammer : Character {
    private string? name;

    public TheTrueProgrammer() {
        Console.Write("You are the True Programmer, what is your name: ");
        name = Console.ReadLine();
    }

    public override string Name => name ?? string.Empty;
}