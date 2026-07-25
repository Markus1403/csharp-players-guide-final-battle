namespace FinalBattle;

public class Battle
{
    public Party heroes { get; }
    public Party monsters { get; }

    public Battle(Party heroes, Party monsters)
    {
        this.heroes = heroes;
        this.monsters = monsters;
    }

    public void RunBattle()
    {
        Console.Clear();
        while (!IsPartyEmpty)
        {
            foreach (Party party in new[] { heroes, monsters })
            {
                foreach (Character character in party.Characters)
                {
                    Status.Render(this, character);

                    Console.WriteLine($"{character.Name} is taking a turn...");
                    bool turnTaken = false;

                    while (!turnTaken && !IsPartyEmpty)
                    {
                        turnTaken = party.Player.ChooseAction(this, character).Run(this, character);
                    }

                    if (IsPartyEmpty)
                        break;

                    Console.WriteLine();
                }
                if (IsPartyEmpty)
                    break;
            }
        }

        if (heroes.Characters.Count > 0)
        {
            Console.Clear();
            ConsoleColor previousColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(
                "You have defeated the Uncoded One's forces! You have won the battle!"
            );
            Console.ForegroundColor = previousColor;
        }
        else
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You have been defeated. The Uncoded One has won.");
        }
    }

    public bool IsPartyEmpty => heroes.Characters.Count == 0 || monsters.Characters.Count == 0;

    public Party GetPartyMember(Character character)
    {
        if (heroes.Characters.Contains(character))
        {
            return heroes;
        }
        else
        {
            return monsters;
        }
    }

    public Party GetEnemyPartyMember(Character character)
    {
        if (heroes.Characters.Contains(character))
        {
            return monsters;
        }
        else
        {
            return heroes;
        }
    }
}
