namespace FinalBattle;

using System;

public class Unraveling : IAttack
{
    private static readonly Random random = new Random();

    public string Name => "Unraveling";

    public AttackData Create() => new AttackData(random.Next(3));
}
