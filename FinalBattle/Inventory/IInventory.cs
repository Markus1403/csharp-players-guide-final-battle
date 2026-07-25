namespace FinalBattle;

public interface IInventory
{
    string Name { get; }
    void Use(Battle battle, Character user);
}




