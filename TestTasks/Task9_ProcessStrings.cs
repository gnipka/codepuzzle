namespace TestTasks;

public static class Task9_ProcessStrings
{
    public static List<string> ProcessStrings(List<string> inputs, Func<string, string> processor)
    {
        // TODO: если inputs == null или processor == null, бросить ArgumentNullException
        // Вернуть новый список, применив processor к каждому элементу inputs
        throw new NotImplementedException();
    }

    // Sample processors
    public static string ToUpperCase(string s)
    {
        return s.ToUpper();
    }

    public static string AddPrefix(string s)
    {
        return "Prefix_" + s;
    }
}