namespace TestTasksDifficult;

public class Student
{
    public string Name { get; set; }
    public string Group { get; set; }
    public double GPA { get; set; }
}

public static class Task5_GroupStudentsByGroup
{
    public static Dictionary<string, List<Student>> GroupStudentsByGroup(List<Student> students)
    {
         /* TODO:
         * 1. Если students == null — бросить ArgumentNullException.
         * 2. Отфильтровать студентов с GPA < 4.0 (они не допускаются).
         * 3. Сгруппировать оставшихся по полю Group (LINQ GroupBy).
         * 4. В результате — словарь, где ключ — название группы, значение — список студентов из этой группы,
         *    отсортированных по убыванию GPA (т. е. сначала «хорошие»).
         * 5. Если после фильтрации список пуст — вернуть пустой словарь.
         */
        throw new NotImplementedException();
    }
}