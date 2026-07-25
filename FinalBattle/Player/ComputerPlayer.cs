namespace FinalBattle;
using System.Linq; //needed for counting items

public class ComputerPlayer : IPlayer
{

    private static Random random = new Random();

    public IAction ChooseAction(Battle battle, Character character)
    {
        Thread.Sleep(1000);

        List<Character> targets = battle.GetEnemyPartyMember(character).Characters;

	Party party = battle.GetPartyMember(character);
	
	int potionCount = party.Inventory.Count(item => item is HealPotion);
	bool hpThreshold = character.HP / (float)character.MaxHP < 0.5;

        if (potionCount > 0 && hpThreshold && random.NextDouble() < 0.25)
        {
            return new UseItemAction(party.Inventory[0]);
        }

        if (targets.Count > 0)
        {
            return new AttackAction(
                character.StandardAttack,
                battle.GetEnemyPartyMember(character).Characters[0]
            );
        }

        return new DoNothingAction();
    }
}
