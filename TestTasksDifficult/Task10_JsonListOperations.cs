namespace TestTasksDifficult;

// Сериализация списка объектов в JSON и десериализация

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public static class Task10_JsonListOperations
{
    public static string SerializeProductList(List<Product> products)
    {
        /* TODO:
        * 1. Если products == null — бросить ArgumentNullException.
        * 2. Использовать System.Text.Json для сериализации списка в JSON-строку.
        * 3. Вернуть полученную строку.
        */
        throw new NotImplementedException();
    }

    public static List<Product> DeserializeProductList(string json)
    {
        /* TODO:
        * 1. Если json == null/пустая строка — бросить ArgumentException.
        * 2. Пытаться десериализовать в List<Product>.
        * 3. Если в процессе десериализации возникает JsonException или полученный объект == null — бросить ArgumentException.
        * 4. Вернуть лист продуктов.
        */
        throw new NotImplementedException();
    }

    public static List<Product> GetProductsCheaperThan(List<Product> products, decimal maxPrice)
    {
        /* TODO:
        * 1. Если products == null — ArgumentNullException.
        * 2. Отфильтровать продукты с Price < maxPrice (LINQ Where).
        * 3. Вернуть новый список.
        */
        throw new NotImplementedException();
    }
}