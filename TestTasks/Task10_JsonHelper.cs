namespace TestTasks;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public static class JsonHelper
{
    public static string SerializeProduct(Product p)
    {
        // TODO: сериализовать Product в JSON-строку. Если p == null, бросить ArgumentException
        throw new NotImplementedException();
    }

    public static Product DeserializeProduct(string json)
    {
        // TODO: если json == null или невалидный JSON – бросить ArgumentException
        // Иначе десериализовать и вернуть Product
        throw new NotImplementedException();
    }
}