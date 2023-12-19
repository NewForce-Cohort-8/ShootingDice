using ShootingDice;

Player player1 = new Player();
player1.Name = "Bob";

Player player2 = new Player();
player2.Name = "Sue";

// player2.Play(player1);

Console.WriteLine("-------------------");

Player player3 = new Player();
player3.Name = "Wilma";

// player3.Play(player2);

Console.WriteLine("-------------------");

Player large = new LargeDicePlayer();
large.Name = "Bigun Rollsalot";

// player1.Play(large);

SmackTalkingPlayer Darrin = new SmackTalkingPlayer();
Darrin.Name = "Darrin";
// Darrin.Taunt = $"Forget you {player2.Name}";

OneHigherPlayer maryJane = new OneHigherPlayer();
maryJane.Name = "Mary Jane";

// maryJane.Play(player3);
Darrin.Play(maryJane);

HumanPlayer sarah = new HumanPlayer();
sarah.Name = "Sarah";

// sarah.Play(Darrin); --- add Sarah to manyplayer
CreativeSmackTalkingPlayer Colin = new CreativeSmackTalkingPlayer();
Colin.Name = "Lil Collie";

// Colin.Play(Darrin);

SoreLoserPlayer Andy = new SoreLoserPlayer();
Andy.Name = "Andy";

// Andy.Play(Darrin);

UpperHalfPlayer Chelsea = new UpperHalfPlayer();
Chelsea.Name = "Chelsea";

// Chelsea.Play(Colin);

SoreLoserUpperHalfPlayer ANya = new SoreLoserUpperHalfPlayer();
ANya.Name = "A-Nya";

Andy.Play(ANya);

Console.WriteLine("-------------------");

List<Player> players = new List<Player>() {
    player1, player2, player3, large, Darrin, maryJane, Colin, Andy, ANya
};


PlayMany(players);

static void PlayMany(List<Player> players)
{
    Console.WriteLine();
    Console.WriteLine("Let's play a bunch of times, shall we?");

    // We "order" the players by a random number
    // This has the effect of shuffling them randomly
    Random randomNumberGenerator = new Random();
    List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

    // We are going to match players against each other
    // This means we need an even number of players
    int maxIndex = shuffledPlayers.Count;
    if (maxIndex % 2 != 0)
    {
        maxIndex = maxIndex - 1;
    }

    // Loop over the players 2 at a time
    for (int i = 0; i < maxIndex; i += 2)
    {
        Console.WriteLine("-------------------");

        // Make adjacent players play noe another
        Player player1 = shuffledPlayers[i];
        Player player2 = shuffledPlayers[i + 1];
        player1.Play(player2);
    }
}