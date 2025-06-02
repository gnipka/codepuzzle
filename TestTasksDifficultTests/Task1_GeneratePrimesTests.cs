using TestTasksDifficult;

namespace TestTasksDifficultTests;

public class Task1_GeneratePrimesTests
{
    [Fact]
    public void GeneratePrimes_Zero_ReturnsEmpty()
    {
        var result = Task1_GeneratePrimes.GeneratePrimes(0);
        Assert.Empty(result);
    }

    [Fact]
    public void GeneratePrimes_One_Returns2()
    {
        var result = Task1_GeneratePrimes.GeneratePrimes(1);
        Assert.Equal(new[] { 2 }, result);
    }

    [Fact]
    public void GeneratePrimes_Five_ReturnsFirstFivePrimes()
    {
        var result = Task1_GeneratePrimes.GeneratePrimes(5);
        Assert.Equal(new[] { 2, 3, 5, 7, 11 }, result);
    }
}