using TestTasksDifficult;

namespace TestTasksDifficultTests;

public class Task4_BankAccountWithHistoryTests
{
    [Fact]
    public void Constructor_InitialDepositRecorded()
    {
        var account = new BankAccountWithHistory(100);
        Assert.Equal(100, account.Balance);
        Assert.Single(account.History);
        var tx = account.History.First();
        Assert.Equal("Deposit", tx.Type);
        Assert.Equal(100, tx.Amount);
    }

    [Fact]
    public void Deposit_AddsTransaction()
    {
        var account = new BankAccountWithHistory(100);
        account.Deposit(50);
        Assert.Equal(150, account.Balance);
        Assert.Equal(2, account.History.Count);
        var tx = account.History.Last();
        Assert.Equal("Deposit", tx.Type);
        Assert.Equal(50, tx.Amount);
    }

    [Fact]
    public void Withdraw_AddsTransactionAndDecreasesBalance()
    {
        var account = new BankAccountWithHistory(100);
        account.Withdraw(30);
        Assert.Equal(70, account.Balance);
        Assert.Equal(2, account.History.Count);
        var tx = account.History.Last();
        Assert.Equal("Withdraw", tx.Type);
        Assert.Equal(30, tx.Amount);
    }

    [Fact]
    public void SumDepositsByDate_ReturnsCorrectSum()
    {
        var account = new BankAccountWithHistory(100);
        account.Deposit(50);
        var today = DateTime.Now.Date;
        decimal sum = account.SumDepositsByDate(today);
        Assert.Equal(150, sum); // initial + this deposit
    }
}