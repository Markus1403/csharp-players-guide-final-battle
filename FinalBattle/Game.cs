namespace FinalBattle;

public class Game {

    private Party heroes;
    private Party monsters;

    private Battle battle;

    public Game() {
        Console.Clear();
        this.heroes = new Party(new ComputerPlayer());
        heroes.Characters.Add(new TheTrueProgrammer());

        this.monsters = new Party(new ComputerPlayer());
        monsters.Characters.Add(new Skeleton());
        battle = new Battle(heroes, monsters);
    }

    public void GameRunning() {
        battle.RunBattle();
    }
}
