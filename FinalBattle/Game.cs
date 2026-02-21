namespace FinalBattle;

public class Game
{
    private Party heroes;
    private List<Party> enemyParties;

    private IPlayer friendlyPlayer;
    private IPlayer enemyPlayer;

    private EnemyFactory enemyFactory;
    private HeroFactory heroFactory;

    public Game()
    {
        Console.WriteLine("Game Mode Selection:");
        Console.WriteLine("1 - Human vs. Computer");
        Console.WriteLine("2 - Computer vs. Computer");
        Console.WriteLine("3 - Human vs. Human");
        Console.Write("Select a Game Mode: ");
        string choice = Console.ReadLine() ?? string.Empty;

        if (choice == "1")
        {
            friendlyPlayer = new HumanPlayer();
            enemyPlayer = new ComputerPlayer();
        }
        else if (choice == "2")
        {
            friendlyPlayer = new ComputerPlayer();
            enemyPlayer = new ComputerPlayer();
        }
        else
        {
            friendlyPlayer = new HumanPlayer();
            enemyPlayer = new HumanPlayer();
        }

        Console.Clear();

        heroFactory = new HeroFactory(friendlyPlayer);
        enemyFactory = new EnemyFactory(enemyPlayer);

        heroes = heroFactory.CreateHeroParty();

        enemyParties = new List<Party>
        {
            enemyFactory.CreateEnemyType1(),
            enemyFactory.CreateEnemyType1(),
            enemyFactory.CreateBoss(),
        };
    }

    public void GameRunning()
    {
        foreach (var enemyParty in enemyParties)
        {
            var battle = new Battle(heroes, enemyParty);
            battle.RunBattle();

            if (heroes.Characters.Count == 0)
                break;
        }
    }
}
