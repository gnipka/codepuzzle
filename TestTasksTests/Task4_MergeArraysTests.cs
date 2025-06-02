using TestTasks;

namespace TestTasksTests;

public class Task4_MergeArraysTests
{
    [Fact]
    public void MergeArrays_ValidArrays_ReturnsMerged()
    {
        var result = Task4_MergeArrays.MergeArrays(new[] {1, 2}, new[] {3, 4, 5});
        Assert.Equal(new[] {1, 2, 3, 4, 5}, result);
    }

    [Fact]
    public void MergeArrays_EmptyAndSingle_ReturnsSingle()
    {
        var result = Task4_MergeArrays.MergeArrays(new int[0], new[] {9});
        Assert.Equal(new[] {9}, result);
    }

    [Fact]
    public void MergeArrays_Null_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() => Task4_MergeArrays.MergeArrays(null, new int[0]));
    }
}