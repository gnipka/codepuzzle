using Tasks;

namespace TasksTests;

public class Task6_MergeDictionariesTests
{
    [Fact]
    public void MergeDictionaries_ValidDictionaries_MergesCorrectly()
    {
        var dict1 = new Dictionary<string, decimal> { ["apple"] = 1.2m, ["banana"] = 2.0m };
        var dict2 = new Dictionary<string, decimal> { ["banana"] = 1.8m, ["orange"] = 3.5m };
        Func<decimal, decimal, decimal> avg = (x, y) => (x + y) / 2;
        var merged = Task6_MergeDictionaries.MergeDictionaries(dict1, dict2, avg);
        Assert.Equal(3, merged.Count);
        Assert.Equal(1.2m, merged["apple"]);
        Assert.Equal(1.9m, merged["banana"]);
        Assert.Equal(3.5m, merged["orange"]);
    }

    [Fact]
    public void MergeDictionaries_Null_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() => Task6_MergeDictionaries.MergeDictionaries<string, int>(null, new Dictionary<string, int>(), (x, y) => x));
    }
}