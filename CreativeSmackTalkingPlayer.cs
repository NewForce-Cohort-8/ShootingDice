namespace ShootingDice;
// A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
public class CreativeSmackTalkingPlayer : Player
{
    private List<string> _Taunts {get;} = new List<string>()
    {
        "Yo mama", "Hi Now", "Forget you, mother forgetter!", "Make like a tree and GO!"
    };

    public override int Roll()
    {
        int RandomTaunt = new Random().Next(_Taunts.Count);
        Console.WriteLine(_Taunts[RandomTaunt]);

        return base.Roll();
    }
}