namespace App.Tests;

public class UnitTest1
{
    [Fact]
    public void TestAdd()
    {
        int result = Calculator.Add(2, 3);
        Assert.Equal(5, result);
    }
}
