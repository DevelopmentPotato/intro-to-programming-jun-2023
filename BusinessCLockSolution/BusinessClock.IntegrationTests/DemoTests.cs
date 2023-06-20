namespace BusinessClock.IntegrationTests;

public class DemoTests
{
    [Fact]
    public void CanAddToNumbers()
    {
        //GIVEN 
        int a = 10, b = 20, answer;

        //WHEN
        answer = a + b;

        //THEN exception is thrown if first parameter and answer are not equal
        Assert.Equal(30, answer);
    }

    [Theory]
    [InlineData(10,20,30)]
    [InlineData(8,2,10)]
    public void CanAddAnyTwoNumbers(int a, int b, int expected)
    {
        int answer = a + b;
        Assert.Equal(expected, answer);
    }
}
