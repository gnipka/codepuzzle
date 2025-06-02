namespace TestTasksDifficult;

public class PasswordManager
{
    // TODO: приватный конструктор и static-поле instance для Singleton
    
    // TODO: приватное поле Dictionary<string, string> storage;

    // TODO: public static PasswordManager Instance { get; }

    public void AddOrUpdate(string key, string password)
    {
        /* TODO:
        * 1. Если key или password == null/пустая строка — бросить ArgumentException
            * 2. Иначе сохранить/обновить в словарь хранилище.
        */
        throw new NotImplementedException();
    }

    public string GetPassword(string key)
    {
        /* TODO:
        * 1. Если key == null/пустая строка — бросить ArgumentException
            * 2. Если в словаре нет такого ключа — бросить KeyNotFoundException
            * 3. Иначе вернуть соответствующий пароль
            */
        throw new NotImplementedException();
    }
}