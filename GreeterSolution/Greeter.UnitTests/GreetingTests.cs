
using Microsoft.VisualStudio.TestPlatform.CoreUtilities.Helpers;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;

namespace Greeter.UnitTests;

public class GreetingTests
{
    [Theory]
    [InlineData("Hello, Winton!", "Winton")]
    public void SingleName(string solution, params string[] names)
    {
        var greeter = new GreetingMaker();

        string greeting = greeter.Greet("Winton");

        Assert.Equal(solution, greeting);
    }

    [Fact]
    public void allowNull()
    {
        var greeter = new GreetingMaker();

        string greeting = greeter.Greet(null);

        Assert.Equal("Sup Doc!", greeting);
    }

    [Theory]
    [InlineData("HELLO, WINTON!", "WINTON")]
    public void matchEnthusiasm(string solution, params string[] names)
    {
        var greeter = new GreetingMaker();

        string greeting = greeter.Greet(names);

        Assert.Equal(solution, greeting);
    }

    [Theory]
    [InlineData( "Hello, Winton, and Ana!", "Winton", "Ana")]
    [InlineData("Hello, Winton, Mercy, and Ana!", "Winton", "Mercy", "Ana")]
    public void allowMultipleNames(string solution, params string[] names)
    {
        var greeter = new GreetingMaker();

        string greeting = greeter.Greet(names);

        Assert.Equal(solution, greeting);
    }

    [Theory]
    [InlineData("HELLO, COLE, COOPER, ROSENFIELD, PRESTON, MILFORD, AND JEFFRIES!", "COLE", "COOPER", "ROSENFIELD", "PRESTON", "MILFORD", "JEFFRIES")]
    [InlineData("Hello, Bob, Jim, AND SUE!", "Bob", "SUE", "Jim")]
    public void mixedShouting(string solution, params string[] names)
    {
        var greeter = new GreetingMaker();

        string greeting = greeter.Greet(names);

        Assert.Equal(solution, greeting);
    }

    [Theory]
    [InlineData("Hello, Bob, Mike, and Karl!", "Bob", "Mike, Karl")]
    public void SplitCommaSeperatedNames(string solution, params string[] names)
    {
        var greeter = new GreetingMaker();

        string greeting = greeter.Greet(names);

        Assert.Equal(solution, greeting);
    }
}
