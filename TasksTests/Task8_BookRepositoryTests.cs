using Tasks;

namespace TasksTests;

public class Task8_BookRepositoryTests
{
    [Fact]
    public void CreateGetUpdateDelete_WorkCorrectly()
    {
        var repo = new BookRepository();
        var book = repo.Create("Clean Code", "Robert C. Martin");
        Assert.Equal(1, book.Id);
        Assert.Equal("Clean Code", book.Title);
        Assert.Equal("Robert C. Martin", book.Author);

        var fetched = repo.GetById(1);
        Assert.NotNull(fetched);

        bool updated = repo.Update(1, "Clean Architecture", "Robert C. Martin");
        Assert.True(updated);
        Assert.Equal("Clean Architecture", repo.GetById(1).Title);

        bool deleted = repo.Delete(1);
        Assert.True(deleted);
        Assert.Null(repo.GetById(1));
    }

    [Fact]
    public void FindByAuthor_ReturnsCorrectList()
    {
        var repo = new BookRepository();
        repo.Create("Test1", "Author A");
        repo.Create("Test2", "author a");
        repo.Create("Test3", "Other");
        var found = repo.FindByAuthor("author a");
        Assert.Equal(2, found.Count);
    }

    [Fact]
    public void Methods_InvalidArguments_ThrowArgumentException()
    {
        var repo = new BookRepository();
        Assert.Throws<ArgumentException>(() => repo.Create(null, "A"));
        Assert.Throws<ArgumentException>(() => repo.Create("T", null));
        Assert.Throws<ArgumentException>(() => repo.Update(1, null, "A"));
        Assert.Throws<ArgumentException>(() => repo.Update(1, "T", ""));
        Assert.Throws<ArgumentException>(() => repo.FindByAuthor(null));
    }
}