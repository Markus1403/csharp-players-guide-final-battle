namespace FinalBattle;

public class ComputerPlayer : IPlayer {
    public IAction ChooseAction(Battle battle, Character character) {
        Thread.Sleep(700);

        List<Character> targets = battle.GetEnemyPartyMember(character).Characters;

        if (targets.Count > 0) {
            return new AttackAction(character.StandardAttack, battle.GetEnemyPartyMember(character).Characters[0]);
        }

        return new DoNothingAction();
    }
}
