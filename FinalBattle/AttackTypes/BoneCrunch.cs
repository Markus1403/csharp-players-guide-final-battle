namespace FinalBattle;

using System;

public class BoneCrunch : IAttack {

    private static readonly Random random = new Random();

    public string Name => "BONE CRUNCH";

    public int Damage => random.Next(2);
}