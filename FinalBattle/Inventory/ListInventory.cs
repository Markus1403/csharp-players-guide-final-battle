namespace FinalBattle;

public class ListInventory : IAction
{
    public bool Run(Battle battle, Character user)
    {
        Party party = battle.GetPartyMember(user);

        if (party.Inventory.Count == 0)
	{
            Console.WriteLine("Your Inventory is Empty");
            return false;
        }

        if (party.Inventory.Count > 0) {
            for (int i = 0; i < party.Inventory.Count; i++)
            {
		Console.WriteLine($"{i + 1} - {party.Inventory[i].Name}");
	    }
            Console.WriteLine("0 - Cancel");
        }

        while (true)
        {
            Console.Write("Choose an item from your inventory: ");
            string? input = Console.ReadLine();

	    if (int.TryParse(input, out int choice) && choice >= 0 && choice <= party.Inventory.Count)
            {
                if (choice == 0)
                {
                    Console.WriteLine($"{user.Name} did nothing.");
                    return false;
                }

                IInventory item = party.Inventory[choice - 1];
                item.Use(battle, user);
                party.Inventory.RemoveAt(choice - 1);
                return true;
            }

            Console.WriteLine("Invalid choice.");
        }

    }
}
