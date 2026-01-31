namespace FinalBattle;

public class Game {

    private Party heroes;
    private Party monsters;

    private Battle battle;

    public Game() {
        Console.Clear();
        this.heroes = new Party(new ComputerPlayer());
        heroes.Character.Add(new TheTrueProgrammer());

        this.monsters = new Party(new ComputerPlayer());
        monsters.Character.Add(new Skeleton());
        battle = new Battle(heroes, monsters); 
    }

    public void GameRunning () {
        Console.Clear();
        battle.RunBattle();
    }
}

