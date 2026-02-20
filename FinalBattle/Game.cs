namespace FinalBattle;

public class Game
{
    private Party heroes;
    private List<Party> enemyParties;

    private IPlayer friendlyPlayer = new ComputerPlayer();
    private IPlayer enemyPlayer = new ComputerPlayer();

    private EnemyFactory enemyFactory;
    private HeroFactory heroFactory;

    public Game()
    {
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
