namespace Tasks;

public class Task6_MergeDictionaries
{
    public static Dictionary<TKey, TValue> MergeDictionaries<TKey, TValue>(
        Dictionary<TKey, TValue> first,
        Dictionary<TKey, TValue> second,
        Func<TValue, TValue, TValue> conflictResolver)
    {
        /* TODO:
        * 1. Если first, second или conflictResolver == null — бросить ArgumentNullException.
        * 2. Объединить две словаря:
        *    – Для ключей, которые есть только в одном словаре, просто взять соответствующие пары <ключ,значение>.
        *    – Если ключ есть и в first, и во second, то нужно вызвать conflictResolver(valueFromFirst, valueFromSecond) 
            *      и подставить результат в объединённый словарь.
        * 3. Вернуть итоговый Dictionary<TKey, TValue>.
        */
        throw new NotImplementedException();
    }
}