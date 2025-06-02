using Tasks;

namespace TasksTests;

public class Task3_PasswordManagerTests
{
    [Fact]
    public void AddOrUpdateAndGetPassword_WorksCorrectly()
    {
        var pm = PasswordManager.Instance;
        pm.AddOrUpdate("admin", "12345");
        Assert.Equal("12345", pm.GetPassword("admin"));
    }

    [Fact]
    public void AddOrUpdate_InvalidKey_ThrowsArgumentException()
    {
        var pm = PasswordManager.Instance;
        Assert.Throws<ArgumentException>(() => pm.AddOrUpdate(null, "pass"));
        Assert.Throws<ArgumentException>(() => pm.AddOrUpdate("", "pass"));
    }

    [Fact]
    public void GetPassword_InvalidKey_ThrowsArgumentException()
    {
        var pm = PasswordManager.Instance;
        Assert.Throws<ArgumentException>(() => pm.GetPassword(null));
        Assert.Throws<ArgumentException>(() => pm.GetPassword(""));
    }

    [Fact]
    public void GetPassword_NonExistentKey_ThrowsKeyNotFoundException()
    {
        var pm = PasswordManager.Instance;
        Assert.Throws<KeyNotFoundException>(() => pm.GetPassword("no_such"));
    }

    [Fact]
    public void Instance_IsSingleton()
    {
        var pm1 = PasswordManager.Instance;
        var pm2 = PasswordManager.Instance;
        Assert.Same(pm1, pm2);
    }
}