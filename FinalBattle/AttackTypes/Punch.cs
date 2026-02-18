namespace FinalBattle;

public class Punch : IAttack
{
    public string Name => "PUNCH";

    public AttackData Create() => new AttackData(1);
}
