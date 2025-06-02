using TestTasks;

namespace TestTasksTests;

public class Task3_CreateArrayUpToTests
{
    [Fact]
    public void CreateArrayUpTo_ValidN_ReturnsArray()
    {
        var result = Task3_CreateArrayUpTo.CreateArrayUpTo(4);
        Assert.Equal(new[] {1, 2, 3, 4}, result);
    }

    [Fact]
    public void CreateArrayUpTo_One_ReturnsSingleElement()
    {
        var result = Task3_CreateArrayUpTo.CreateArrayUpTo(1);
        Assert.Equal(new[] {1}, result);
    }

    [Fact]
    public void CreateArrayUpTo_NonPositive_ReturnsEmpty()
    {
        var result0 = Task3_CreateArrayUpTo.CreateArrayUpTo(0);
        Assert.Empty(result0);
        var resultNeg = Task3_CreateArrayUpTo.CreateArrayUpTo(-5);
        Assert.Empty(resultNeg);
    }
}