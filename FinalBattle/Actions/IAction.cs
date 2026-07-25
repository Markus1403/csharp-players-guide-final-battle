namespace FinalBattle;

public interface IAction
{
    bool Run(Battle battle, Character character);
}
