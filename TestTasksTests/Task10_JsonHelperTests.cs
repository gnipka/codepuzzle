using TestTasks;

namespace TestTasksTests;

public class Task10_JsonHelperTests
{
    [Fact]
    public void SerializeAndDeserialize_ValidProduct_WorksCorrectly()
    {
        var product = new Product { Id = 1, Name = "Book", Price = 9.99m };
        var json = JsonHelper.SerializeProduct(product);
        var result = JsonHelper.DeserializeProduct(json);
        Assert.Equal(product.Id, result.Id);
        Assert.Equal(product.Name, result.Name);
        Assert.Equal(product.Price, result.Price);
    }

    [Fact]
    public void DeserializeProduct_InvalidJson_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => JsonHelper.DeserializeProduct("not a json"));
    }

    [Fact]
    public void SerializeProduct_Null_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => JsonHelper.SerializeProduct(null));
    }
}