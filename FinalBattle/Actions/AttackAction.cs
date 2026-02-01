namespace FinalBattle;

using System;

public class AttackAction : IAction {

    private readonly Character target;
    private readonly IAttack attack;


    public AttackAction(IAttack attack, Character target) {
        this.target = target;
        this.attack = attack;
    }

    public void Run(Battle battle, Character character) {
        Console.WriteLine($"{character.Name} used {attack.Name} on {target.Name}.");
        target.TakeDamage(attack.Damage);
        Console.WriteLine($"{attack.Name} dealt {attack.Damage} damage to {target.Name}");
        Console.WriteLine($"{target.Name} is now at {target.CurrentHealth}/{target.InitialHealth} HP");
    }
}