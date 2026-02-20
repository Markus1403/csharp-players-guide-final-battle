namespace FinalBattle;

public class UncodedOne : Character
{
    public override string Name => "The Uncoded One";

    public override IAttack StandardAttack { get; } = new Unraveling();

    public UncodedOne()
        : base(15) { }
}
