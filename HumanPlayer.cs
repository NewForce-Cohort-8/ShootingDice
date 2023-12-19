namespace ShootingDice;

// TODO: Complete this class

// A player the prompts the user to enter a number for a roll
public class HumanPlayer : Player
{
    public override int Roll()
    {
        Console.WriteLine($"What would you like to roll?");
        string humanRoll = Console.ReadLine();
        int parsedHumanRoll = int.Parse(humanRoll);
        
        return parsedHumanRoll;
    }
}