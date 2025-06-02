using TestTasks;

namespace TestTasksTests;

public class Task6_BankAccountTests
{
    [Fact]
    public void Constructor_ValidInitialBalance_SetsBalance()
    {
        var account = new BankAccount(100m);
        Assert.Equal(100m, account.Balance);
    }

    [Fact]
    public void Constructor_NegativeInitial_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new BankAccount(-10m));
    }

    [Fact]
    public void Deposit_ValidAmount_IncreasesBalance()
    {
        var account = new BankAccount(100m);
        account.Deposit(50m);
        Assert.Equal(150m, account.Balance);
    }

    [Fact]
    public void Deposit_NonPositive_ThrowsArgumentException()
    {
        var account = new BankAccount(100m);
        Assert.Throws<ArgumentException>(() => account.Deposit(0m));
    }

    [Fact]
    public void Withdraw_ValidAmount_DecreasesBalance()
    {
        var account = new BankAccount(100m);
        account.Withdraw(30m);
        Assert.Equal(70m, account.Balance);
    }

    [Fact]
    public void Withdraw_AmountGreaterThanBalance_ThrowsInvalidOperationException()
    {
        var account = new BankAccount(100m);
        Assert.Throws<InvalidOperationException>(() => account.Withdraw(200m));
    }

    [Fact]
    public void Withdraw_NonPositive_ThrowsArgumentException()
    {
        var account = new BankAccount(100m);
        Assert.Throws<ArgumentException>(() => account.Withdraw(-5m));
    }
}