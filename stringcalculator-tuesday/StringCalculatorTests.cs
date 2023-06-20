
namespace StringCalculator;

public class StringCalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("1",1)]
    [InlineData("2", 2)]
    [InlineData("3", 3)]
    [InlineData("118", 118)]
    public void SingleDigit(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var results = calculator.Add(numbers);

        Assert.Equal(expected, results);
    }

    [Theory]
    [InlineData("1,1",2)]
    [InlineData("3,6", 9)]
    [InlineData("8,4", 12)]
    [InlineData("9,7", 16)]
    public void DoubleDigit(string numbers, int expected) {
        var calculator = new StringCalculator();

        var results = calculator.Add(numbers);

        Assert.Equal(expected, results);
    }

    [Theory]
    [InlineData("1,1,1", 3)]
    [InlineData("3,6,9,12", 30)]
    [InlineData("8,4,2,1,1", 16)]
    [InlineData("9,7,5,3,1", 25)]
    public void NDigit(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var results = calculator.Add(numbers);

        Assert.Equal(expected, results);
    }

    [Theory]
    [InlineData("1,1\n1", 3)]
    [InlineData("3,6,9,12", 30)]
    [InlineData("8,4\n2,1,1", 16)]
    [InlineData("9,7,5,3,1", 25)]
    public void NewLineDigit(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var results = calculator.Add(numbers);

        Assert.Equal(expected, results);
    }

    [Theory]
    [InlineData("//;\n1,1;1;1", 4)]
    [InlineData("//;\n3,6;9,12", 30)]
    [InlineData("//:\n8,4:2,1:1", 16)]
    [InlineData("//]\n9]7,5]3,1", 25)]
    public void CustomDelimiter(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var results = calculator.Add(numbers);

        Assert.Equal(expected, results);
    }
}
