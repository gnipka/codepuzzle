using TestTasksDifficult;

namespace TestTasksDifficultTests;

public class Task2_MergeAndSortTests
{
    [Fact]
    public void MergeAndSort_ValidArrays_ReturnsSorted()
    {
        var result = Task2_MergeAndSort.MergeAndSort(new[] { 3, 1 }, new[] { 2, 4 });
        Assert.Equal(new[] { 1, 2, 3, 4 }, result);
    }

    [Fact]
    public void MergeAndSort_DuplicatesAndNegatives_ReturnsCorrect()
    {
        var result = Task2_MergeAndSort.MergeAndSort(new int[0], new[] { 5, 5, -1 });
        Assert.Equal(new[] { -1, 5, 5 }, result);
    }

    [Fact]
    public void MergeAndSort_Null_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() => Task2_MergeAndSort.MergeAndSort(null, new int[0]));
    }
}