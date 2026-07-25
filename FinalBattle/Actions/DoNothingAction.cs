namespace FinalBattle;

public class DoNothingAction : IAction
{
    public bool Run(Battle battle, Character character)
    {
        Console.WriteLine($"{character.Name} did NOTHING.");

        return true;
    }
}
