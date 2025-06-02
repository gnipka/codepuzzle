using TestTasks;

namespace TestTasksTests;

public class Task9_ProcessStringsTests
{
    [Fact]
    public void ProcessStrings_ValidToUpper_ReturnsUpper()
    {
        var input = new List<string> { "a", "b" };
        var result = Task9_ProcessStrings.ProcessStrings(input, Task9_ProcessStrings.ToUpperCase);
        Assert.Equal(new List<string> { "A", "B" }, result);
    }

    [Fact]
    public void ProcessStrings_ValidAddPrefix_ReturnsPrefixed()
    {
        var input = new List<string> { "x", "y" };
        var result = Task9_ProcessStrings.ProcessStrings(input, Task9_ProcessStrings.AddPrefix);
        Assert.Equal(new List<string> { "Prefix_x", "Prefix_y" }, result);
    }

    [Fact]
    public void ProcessStrings_NullInputs_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() => Task9_ProcessStrings.ProcessStrings(null, Task9_ProcessStrings.ToUpperCase));
    }

    [Fact]
    public void ProcessStrings_NullProcessor_ThrowsArgumentNullException()
    {
        var input = new List<string> { "a" };
        Assert.Throws<ArgumentNullException>(() => Task9_ProcessStrings.ProcessStrings(input, null));
    }
}