namespace Tasks;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
}

public class BookRepository
{
    private readonly List<Book> storage = new List<Book>();
    private int nextId = 1;

    // Create: добавить книгу (Title, Author), присвоить ей уникальный Id, вернуть новую Book
    public Book Create(string title, string author)
    {
        /* TODO:
        * 1. Если title или author == null/пустяя строка — ArgumentException.
        * 2. Создать Book с полями Id = nextId, Title=title, Author=author.
        * 3. Увеличить nextId.
        * 4. Добавить в storage и вернуть объект Book.
        */
        throw new NotImplementedException();
    }

    // Read: получить книгу по Id
    public Book GetById(int id)
    {
        /*
         * TODO:
         * 1. Найти в storage книгу с таким Id. Если не найдено — вернуть null.
         * 2. Иначе вернуть эту книгу.
         */
        throw new NotImplementedException();
    }

    // Update: изменить Title и Author для книги с заданным Id
    public bool Update(int id, string newTitle, string newAuthor)
    {
        /* TODO:
        * 1. Если newTitle или newAuthor == null/пустая строка — ArgumentException.
        * 2. Найти книгу в storage. Если не найдено — вернуть false.
        * 3. Иначе обновить Title и Author, вернуть true.
        */
        throw new NotImplementedException();

    }

    // Delete: удалить книгу по Id
    public bool Delete(int id)
    {
        /* TODO:
        * 1. Найти книгу в storage. Если не найдено — вернуть false.
        * 2. Иначе удалить её из списка и вернуть true.
        */
        throw new NotImplementedException();
    }

    // Доп. LINQ-метод: найти все книги по автору (поиск по подстроке, например)
    public List<Book> FindByAuthor(string authorSubstring)
    {
        /* TODO:
        * 1. Если authorSubstring == null/пустая строка — ArgumentException.
        * 2. Использовать LINQ: найти все Book, у которых поле Author 
            *    содержит authorSubstring (регистр не критичен).
        * 3. Вернуть список найденных. Если ничего не найдено — вернуть пустой список.
        */
        throw new NotImplementedException();
    }
}