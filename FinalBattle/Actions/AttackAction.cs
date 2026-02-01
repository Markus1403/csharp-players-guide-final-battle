namespace FinalBattle;
public class AttackAction : IAction {

    private readonly Character target;
    
    public AttackAction(Character target) {
        this.target = target;
    }

    public void Run(Battle battle, Character character) {
        Console.WriteLine($"{character.Name} used {character.StandardAttack} on {target.Name}.");
    }
}