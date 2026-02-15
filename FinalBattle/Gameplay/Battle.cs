namespace FinalBattle;

public class Battle {

    private Party heroes;
    private Party monsters;

    public Battle(Party heroes, Party monsters) {
        this.heroes = heroes;
        this.monsters = monsters;
    }

    public void RunBattle() {
        Console.Clear();
        while (!IsPartyEmpty) {
            foreach (Party party in new[] { heroes, monsters }) {
                foreach (Character character in party.Characters) {
                    Console.WriteLine();
                    Console.WriteLine($"{character.Name} is taking a turn...");
                    party.Player.ChooseAction(this, character).Run(this, character);

                    if (IsPartyEmpty) break;
                }
                if (IsPartyEmpty) break;
            }
        }

        if (heroes.Characters.Count > 0) {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You have defeated the Uncoded One's forces! You have won the battle!");
        } else {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You have been defeated. The Uncoded One has won.");
        }
    }

    public bool IsPartyEmpty => heroes.Characters.Count == 0 || monsters.Characters.Count == 0;

    public Party GetPartyMember(Character character) {
        if (heroes.Characters.Contains(character)) {
            return heroes;
        } else {
            return monsters;
        }
    }

    public Party GetEnemyPartyMember(Character character) {
        if (heroes.Characters.Contains(character)) {
            return monsters;
        } else {
            return heroes;
        }
    }
}
