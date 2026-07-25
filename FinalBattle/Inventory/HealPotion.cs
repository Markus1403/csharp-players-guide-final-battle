namespace FinalBattle;

public class HealPotion : IInventory
{
    public string Name => "Health Potion";

    public void Use(Battle battle, Character user)
    {
        user.HP += 10;
	Console.WriteLine($"{user.Name} used {Name} to increase HP by 10.");
    }

}
