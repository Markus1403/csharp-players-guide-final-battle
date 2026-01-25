namespace FinalBattle;

using System;

public abstract class Character {

    public abstract string Name {get;}
    public virtual void Action() {
        Console.WriteLine($"{Name} did NOTHING");
    }
}