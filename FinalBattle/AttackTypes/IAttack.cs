namespace FinalBattle;

public interface IAttack {
    string Name {
        get;
    }

    AttackData Create();
}
