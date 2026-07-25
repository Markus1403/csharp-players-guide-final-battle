namespace FinalBattle;

public class UseItemAction : IAction
{
    private readonly IInventory item;

    public UseItemAction(IInventory item)
    {
        this.item = item;
    }

    public bool Run(Battle battle, Character user)
    {
	Console.WriteLine($"{user.Name} used {item.Name}.");

        item.Use(battle, user);

	Party party = battle.GetPartyMember(user);

        party.Inventory.Remove(item);

        return true;
    }
}
