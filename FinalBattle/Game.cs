namespace FinalBattle;

public class Game {

    private Party heroes;
    private Party monsters;

    private Battle battle;

    public Game() {
        Console.Clear();
        this.heroes = new Party();
        heroes.Character.Add(new TheTrueProgrammer());

        this.monsters = new Party();
        monsters.Character.Add(new Skeleton());
        battle = new Battle(heroes, monsters); 
    }

    public void GameRunning () {
        Console.Clear();
        battle.RunBattle();
    }
}

