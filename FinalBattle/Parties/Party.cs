namespace FinalBattle;

public class Party
{
    public IPlayer Player { get; }
    public List<Character> Characters { get; } = new List<Character>();
    public List<IInventory> Inventory { get; } = new List<IInventory>();

    public Party(IPlayer player)
    {
        Player = player;
    }
}
