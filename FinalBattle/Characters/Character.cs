namespace FinalBattle;

using System;

public abstract class Character {

    public abstract string Name {
        get;
    }

    public abstract int InitialHealth { get; }
    public int CurrentHealth { get; private set; }

    public abstract IAttack StandardAttack {
        get;
    }

    protected Character() {
        CurrentHealth = InitialHealth;
    }

    public void TakeDamage(int damage) {
        CurrentHealth = Math.Max(0, CurrentHealth - damage);
    }
}