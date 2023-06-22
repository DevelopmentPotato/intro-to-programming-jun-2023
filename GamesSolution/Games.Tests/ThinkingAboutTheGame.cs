

using System.Runtime.Intrinsics.X86;
using Games.Exceptions;

namespace Games.Tests;

public class ThinkingAboutTheGame
{
    [Fact]
    public void DuplicateNamesAreNotAllowed()
    {
        //given
        var game = new BowlingGame();

        //when
        game.AddPlayer("Jim", 120);
        game.AddPlayer("Sue", 300);

        //then
        Assert.Throws<PlayerAlreadyAddedToGameException>(() => game.AddPlayer("Jim", 200));
        
    }

    

}
