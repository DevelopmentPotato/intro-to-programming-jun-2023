using Games.Exceptions;

namespace Games.Tests;

public class ScoresTests
{
    [Fact]
    public void AverageScoreTest()
    {
        //when
        var game = new BowlingGame();

        //then
        game.AddPlayer("Jim", 120);
        game.AddPlayer("Sue", 286);
        game.AddPlayer("Sam", 180);
        game.AddPlayer("Ray", 286);
        game.AddPlayer("Paul", 120);

        //done
        Assert.Equal(198.40, game.AverageScore());



    }

    [Theory]
    [InlineData(-1)]
    [InlineData(301)]
    public void ScoreNotPossibleAmount(int score)
    {
        var game = new BowlingGame();
        Assert.Throws<ScoreNotPossibleException>(() => game.AddPlayer("Jim", score));
    }
}
