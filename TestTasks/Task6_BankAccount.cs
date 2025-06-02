namespace TestTasks;

public class BankAccount
{
    private decimal balance;
    public decimal Balance => balance;

    public BankAccount(decimal initialBalance)
    {
        // TODO: инициализировать balance, если initialBalance < 0 – бросить ArgumentException
        throw new NotImplementedException();
    }

    public void Deposit(decimal amount)
    {
        // TODO: если amount <= 0, бросить ArgumentException, иначе увеличить balance
        throw new NotImplementedException();
    }

    public void Withdraw(decimal amount)
    {
        // TODO: если amount <= 0, бросить ArgumentException
        //       если amount > balance, бросить InvalidOperationException
        //       иначе уменьшить balance
        throw new NotImplementedException();
    }
}