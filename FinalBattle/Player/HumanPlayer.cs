namespace FinalBattle;

public class HumanPlayer : IPlayer
{
    public IAction ChooseAction(Battle battle, Character character)
    {
        Console.WriteLine($"It is {character.Name}'s turn... ");
        Console.WriteLine($"1 - Standard Attack ({character.StandardAttack.Name})");
        Console.WriteLine("2 - Do Nothing");

        int choice;
        while (true)
        {
            Console.Write("What do you want to do? ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out choice) && (choice == 1 || choice == 2))
                break;

            Console.WriteLine("Invalid choice.");
        }

        var enemies = battle.GetEnemyPartyMember(character).Characters;
        if (enemies.Count == 0) return new DoNothingAction();

        return choice switch
        {
            1 => new AttackAction(character.StandardAttack, enemies[0]),
            2 => new DoNothingAction(),
            _ => new DoNothingAction(),
        };
    }
}
