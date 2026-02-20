namespace FinalBattle;

public class EnemyFactory
{
    private IPlayer player;

    public EnemyFactory(IPlayer player)
    {
        this.player = player;
    }

    public Party CreateEnemyType1()
    {
        var monsters = new Party(player);
        monsters.Characters.Add(new Skeleton());
        return monsters;
    }

    public Party CreateEnemyType2()
    {
        var monsters = new Party(player);
        monsters.Characters.Add(new Skeleton());
        monsters.Characters.Add(new Skeleton());
        return monsters;
    }

    public Party CreateBoss()
    {
        var monsters = new Party(player);
        monsters.Characters.Add(new UncodedOne());
        return monsters;
    }
}
