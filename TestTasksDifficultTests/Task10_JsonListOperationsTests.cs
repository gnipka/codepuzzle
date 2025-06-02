using TestTasksDifficult;

namespace TestTasksDifficultTests;

public class TestTasksDifficultTask10_JsonListOperationsTests
{
    [Fact]
    public void SerializeDeserialize_ProductList_WorksCorrectly()
    {
        var products = new List<Product>
        {
            new Product { Id = 1, Name = "A", Price = 5.0m },
            new Product { Id = 2, Name = "B", Price = 3.5m }
        };
        var json = Task10_JsonListOperations.SerializeProductList(products);
        var result = Task10_JsonListOperations.DeserializeProductList(json);
        Assert.Equal(2, result.Count);
        Assert.Equal(1, result[0].Id);
        Assert.Equal("A", result[0].Name);
    }

    [Fact]
    public void DeserializeProductList_InvalidJson_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => Task10_JsonListOperations.DeserializeProductList("not a json"));
    }

    [Fact]
    public void SerializeProductList_Null_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() => Task10_JsonListOperations.SerializeProductList(null));
    }

    [Fact]
    public void GetProductsCheaperThan_FiltersCorrectly()
    {
        var products = new List<Product>
        {
            new Product { Id = 1, Name = "A", Price = 5.0m },
            new Product { Id = 2, Name = "B", Price = 10.0m }
        };
        var result = Task10_JsonListOperations.GetProductsCheaperThan(products, 6m);
        Assert.Single(result);
        Assert.Equal(1, result[0].Id);
    }
}