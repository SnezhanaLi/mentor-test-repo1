using Xunit;

public sealed class CalculatorTests
{
    [Fact]
    public void Smoke_Ok()
    {
        Assert.Equal(4, 1 + 3);
    }

    [Fact]
    public void Intentional_Fail()
    {
        Assert.Equal("HELLO!", "HELLO");
    }
}
