namespace TestTasksDifficult;

public class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
    public DateTime HireDate { get; set; }
}

public static class Task7_GetHighPaidRecentEmployees
{
    public static List<string> GetHighPaidRecentEmployees(
        List<Employee> employees,
        string department,
        double minSalary,
        int hiredWithinMonths)
    {
         /* TODO:
         * 1. Если employees == null или department == null/пустая — ArgumentNullException.
         * 2. Отфильтровать по Department == department.
         * 3. Отфильтровать по Salary >= minSalary.
         * 4. Отфильтровать по HireDate: сотрудник должен быть принят не ранее, чем
         *    текущая дата минус hiredWithinMonths месяцев. (использовать DateTime.Now).
         * 5. Отсортировать результат по Salary по убыванию.
         * 6. Вернуть список имён (Name) сотрудников в таком порядке.
         * 7. Если никто не удовлетворяет условиям — вернуть пустой List<string>.
         */
        throw new NotImplementedException();
    }
}