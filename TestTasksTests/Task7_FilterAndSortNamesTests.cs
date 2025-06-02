using TestTasks;

namespace TestTasksTests;

public class Task7_FilterAndSortNamesTests
{
    [Fact]
    public void FilterAndSortNames_ValidList_ReturnsFilteredAndSorted()
    {
        var input = new List<string> { "Bob", "Alice", "Eve", "Daniel" };
        var result = Task7_FilterAndSortNames.FilterAndSortNames(input);
        Assert.Equal(new List<string> { "Alice", "Daniel" }, result);
    }

    [Fact]
    public void FilterAndSortNames_NoNamesLongerThanThree_ReturnsEmpty()
    {
        var input = new List<string> { "A", "Ab", "Abc" };
        var result = Task7_FilterAndSortNames.FilterAndSortNames(input);
        Assert.Empty(result);
    }

    [Fact]
    public void FilterAndSortNames_Null_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() => Task7_FilterAndSortNames.FilterAndSortNames(null));
    }
}