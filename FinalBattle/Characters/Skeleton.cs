namespace FinalBattle;

public class Skeleton : Character {
    public override string Name => "SKELETON";

    public override int InitialHealth => 5;
    public override IAttack StandardAttack { get; } = new BoneCrunch();
    
}