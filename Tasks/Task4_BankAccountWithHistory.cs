namespace Tasks;

public class Transaction
{
    public DateTime Timestamp { get; }
    public decimal Amount { get; }
    public string Type { get; }

    public Transaction(DateTime timestamp, decimal amount, string type)
    {
        Timestamp = timestamp;
        Amount = amount;
        Type = type;
    }
}

public class BankAccountWithHistory
{
    private decimal balance;
    private readonly List<Transaction> history = new List<Transaction>();

    public decimal Balance => balance;
    public IReadOnlyList<Transaction> History => history.AsReadOnly();

    public BankAccountWithHistory(decimal initialBalance)
    {
        /* TODO:
        * 1. Если initialBalance < 0 — бросить ArgumentException.
        * 2. Инициализировать balance и history = new List<Transaction>().
        * 3. Добавить в history начальную транзакцию с типом "Deposit" и суммой initialBalance (Timestamp — сейчас).
        */
        throw new NotImplementedException();
    }

    public void Deposit(decimal amount)
    {
        /* TODO:
        * 1. Если amount <= 0 — ArgumentException.
        * 2. Увеличить balance, добавить Transaction с текущим временем, type="Deposit".
        */
        throw new NotImplementedException();
    }

    public void Withdraw(decimal amount)
    {
        /* TODO:
        * 1. Если amount <= 0 — ArgumentException.
        * 2. Если amount > balance — InvalidOperationException.
        * 3. Уменьшить balance, добавить Transaction с текущим временем, type="Withdraw".
        */
        throw new NotImplementedException();
    }

    public decimal SumDepositsByDate(DateTime date)
    {
        /* TODO:
        * 1. Использовать LINQ (Where+Sum): найти транзакции типа "Deposit", у которых Timestamp.Date == date.Date.
        * 2. Вернуть сумму их Amount. Если нет — вернуть 0.
        */
        throw new NotImplementedException();
    }
}