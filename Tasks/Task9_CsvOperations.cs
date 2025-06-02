namespace Tasks;

// Чтение, фильтрация и запись CSV
// CSV-файл employees.csv, где каждая строка имеет формат: Name,Department,Salary
// Пример содержимого:
// Ivan,IT,1000
// Anna,HR,1200
// Petr,IT,900
// Olga,Finance,1100

public class CsvEmployee
{
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
}

public static class Task9_CsvOperations
{
    public static List<CsvEmployee> ReadEmployeesFromCsv(string pathCsv)
    {
         /* TODO:
         * - Если pathCsv == null/пустая строка — ArgumentException.
         * - Если файла нет — вернуть пустой список.
         * - Иначе считать все строки (File.ReadAllLines).
         * - Пропустить первую строку с заголовками (Name,Department,Salary).
         * - Для каждой следующей строки разбить через ',' и создать Employee
         *   (Name:string, Department:string, Salary:double).
         * - Если какая-то строка невалидна (не 3 колонки или Salary не число) — пропустить её (не бросать).
         * - Вернуть список успешно распаршенных Employee.
         */
        throw new NotImplementedException();
    }

    public static void WriteHighSalaryToCsv(
        string inputCsvPath,
        string outputCsvPath,
        double minSalary)
    {
        /* TODO:
        * - Прочитать список из первого метода ReadEmployeesFromCsv(inputCsvPath).
        * - Использовать LINQ: отфильтровать те, у кого Salary >= minSalary.
        * - Создать новый CSV-файл по пути outputCsvPath.
        * - Записать строку-заголовок "Name,Department,Salary".
        * - Для каждого отфильтрованного Employee добавить строку "Name,Department,Salary".
        * - Если inputCsvPath == null или outputCsvPath == null/пустая строка — ArgumentException.
        */
        throw new NotImplementedException();
    }
}