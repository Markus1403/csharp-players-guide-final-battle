namespace FinalBattle;

public class HeroFactory
{
    private IPlayer player;

    public HeroFactory(IPlayer player)
    {
        this.player = player;
    }

    public Party CreateHeroParty()
    {
        var heroes = new Party(player);
        heroes.Characters.Add(new TheTrueProgrammer());
        return heroes;
    }
}
