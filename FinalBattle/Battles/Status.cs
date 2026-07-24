namespace FinalBattle;

public static class Status
{
    public static void Render(Battle battle, Character currentCharacter)
    {
        Console.WriteLine(
            $"===================================================== BATTLE ===================================================="
        );

        foreach (Character character in battle.heroes.Characters)
        {
            Console.WriteLine($"{character.Name, -45} ({character.HP, 3}/{character.MaxHP, -3})");
        }

        Console.WriteLine(
            "------------------------------------------------------- VS -------------------------------------------------------"
        );

        foreach (Character character in battle.monsters.Characters)
        {
            Console.WriteLine(
                $"                                                          {character.Name, 45} ({character.HP, 3}/{character.MaxHP, -3})"
            );
        }

        Console.WriteLine(
            "================================================================================================================="
        );
    }
}
