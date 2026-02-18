namespace FinalBattle;

using System;

public abstract class Character
{
    public abstract string Name { get; }
    public abstract IAttack StandardAttack { get; }

    private int Health;

    public int HP
    {
        get => Health;
        set => Health = Math.Clamp(value, 0, MaxHP);
    }

    public int MaxHP { get; }

    public bool IsAlive => HP > 0;

    public Character(int hp)
    {
        MaxHP = hp;
        HP = hp;
    }
}
