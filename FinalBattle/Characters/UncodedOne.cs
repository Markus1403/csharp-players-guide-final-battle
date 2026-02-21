namespace FinalBattle;

public class UncodedOne : Character
{
    public override string Name => "THE UNCODED ONE";

    public override IAttack StandardAttack { get; } = new Unraveling();

    public UncodedOne()
        : base(15) { }
}
