using FinalBattle;

public class ComputerPlayer : IPlayer {
    public IAction ChooseAction(Battle battle, Character character) {
        Thread.Sleep(700);
        return new DoNothingAction();
    }
}