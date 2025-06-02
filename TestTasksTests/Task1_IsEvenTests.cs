using TestTasks;

namespace TestTasksTests;

public class Task1_IsEvenTests
{
    [Theory]
    [InlineData(0, true)]
    [InlineData(7, false)]
    [InlineData(-12, true)]
    public void IsEven_ReturnsExpected(int input, bool expected)
    {
        bool actual = Task1_IsEven.IsEven(input);
        Assert.Equal(expected, actual);
    }
}