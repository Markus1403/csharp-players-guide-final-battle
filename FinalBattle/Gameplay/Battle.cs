namespace FinalBattle;

public class Battle {
    private Party heroes;
    private Party monsters;

    public Battle(Party heroes, Party monsters) {
        this.heroes = heroes;
        this.monsters = monsters;
    }

    public void RunBattle() {
        while (true)  {
            foreach(Party party in new[] {heroes, monsters}) {
                foreach(Character character in party.Characters) {
                    Console.WriteLine();
                    Console.WriteLine($"{character.Name} is taking a turn...");
                    Thread.Sleep(700);
                    party.Player.ChooseAction(this, character).Run(this, character);
                }
            }
        }
    }

    public Party GetPartyFor(Character character) {
            if (heroes.Characters.Contains(character)) {
                return monsters;
            } else {
                return heroes;
            }
        }

    public Party GetEnemyPartyFor(Character character) {
        if (heroes.Characters.Contains(character)) {
            return monsters;
        } else {
            return heroes;
        }
    }
}