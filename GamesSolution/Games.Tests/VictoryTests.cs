using Games.Exceptions;

namespace Games.Tests;

public class VictoryTests
{
    [Fact]
    public void SingleVictorTest()
    {
        //when
        var game = new BowlingGame();

        //then
        game.AddPlayer("Jim", 120);
        game.AddPlayer("Sue", 286);
        game.AddPlayer("Sam", 180);
        game.AddPlayer("Paul", 120);

        List<Player> victors = new();
        victors.Add(game.GetPlayerByName("Sue"));

        List<Player> losers = new();
        losers.Add(game.GetPlayerByName("Jim"));
        losers.Add(game.GetPlayerByName("Paul"));

        List<List<Player>> L = new();
        L.Add(victors);
        L.Add(losers);
        //done
        Assert.True( areEqual(game.DetermineVictors(), L) );
    }

    [Fact]
    public void MultipleVictorsTest()
    {
        //when
        var game = new BowlingGame();

        //then
        game.AddPlayer("Jim", 120);
        game.AddPlayer("Sue", 286);
        game.AddPlayer("Sam", 180);
        game.AddPlayer("Ray", 286);
        game.AddPlayer("Paul", 120);

        List<Player> victors = new();
        victors.Add(game.GetPlayerByName("Sue"));
        victors.Add(game.GetPlayerByName("Ray"));

        List<Player> losers = new();
        losers.Add(game.GetPlayerByName("Jim"));
        losers.Add(game.GetPlayerByName("Paul"));

        List<List<Player>> L = new();
        L.Add(victors);
        L.Add(losers);
        //done
        Assert.True( areEqual(game.DetermineVictors(), L));
    }

    [Fact]
    public void CannotWinAGameWithOnePlayer()
    {
        //when
        var game = new BowlingGame();

        //then
        game.AddPlayer("Jim", 120);

        //done
        Assert.Throws< NotEnoughPlayersException >(() => game.DetermineVictors());

    }

    public bool areEqual(List<List<Player>> L1, List<List<Player>> L2)
    {
        foreach (Player p in L1[0].ToList())//check if victors match
        {
            if (L2[0].ToList().Any(pl => pl == p))
            {

            }
            else
            {
                return false;
            }
        }

        foreach (Player p in L1[1])
        {
            if (L2[1].ToList().Any(pl => pl == p))
            {

            }
            else
            {
                return false;
            }
        }
        return true;
    }
}
