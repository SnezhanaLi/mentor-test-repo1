using Xunit;

public sealed class CalculatorTests
{
    [Fact]
    public void Smoke_Ok()
    {
        Assert.Equal(7, 4 + 3);
    }

    [Fact]
    public void Intentional_Fail()
    {
        Assert.Equal("HELLO!", "HELLO");
    }
}
