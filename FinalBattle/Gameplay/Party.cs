namespace FinalBattle;

public class Party {
    public IPlayer Player {get;}
    public List<Character> Character { get; } = new List<Character>();

    public Party(IPlayer player) {
        Player = player;
    }
}