using TestTasks;

namespace TestTasksTests;

public class Task2_PrintNumbersWhileTests
{
    [Fact]
    public void PrintNumbersWhile_PositiveN_PrintsNumbers()
    {
        var sw = new StringWriter();
        Console.SetOut(sw);
        Task2_PrintNumbersWhile.PrintNumbersWhile(5);
        var output = sw.ToString().Trim().Split(Environment.NewLine);
        Assert.Equal(new[] { "1", "2", "3", "4", "5" }, output);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-3)]
    public void PrintNumbersWhile_NonPositive_PrintsNothing(int n)
    {
        var sw = new StringWriter();
        Console.SetOut(sw);
        Task2_PrintNumbersWhile.PrintNumbersWhile(n);
        Assert.True(string.IsNullOrEmpty(sw.ToString()));
    }
}