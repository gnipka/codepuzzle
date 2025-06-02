using Tasks;

namespace TasksTests;

public class Task7_GetHighPaidRecentEmployeesTests
{
    [Fact]
    public void GetHighPaidRecentEmployees_FiltersCorrectly()
    {
        var now = DateTime.Now;
        var employees = new List<Employee>
        {
            new Employee { Name="Ivan", Department="IT", Salary=1000, HireDate=now.AddMonths(-1) },
            new Employee { Name="Anna", Department="IT", Salary=800, HireDate=now.AddMonths(-2) },
            new Employee { Name="Petr", Department="HR", Salary=1200, HireDate=now.AddMonths(-3) },
            new Employee { Name="Olga", Department="IT", Salary=1100, HireDate=now.AddMonths(-5) }
        };
        var result = Task7_GetHighPaidRecentEmployees.GetHighPaidRecentEmployees(employees, "IT", 900, 4);
        Assert.Equal(new List<string> { "Ivan" }, result);
    }

    [Fact]
    public void GetHighPaidRecentEmployees_NullEmployees_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() => Task7_GetHighPaidRecentEmployees.GetHighPaidRecentEmployees(null, "IT", 900, 4));
    }

    [Fact]
    public void GetHighPaidRecentEmployees_InvalidDepartment_ThrowsArgumentException()
    {
        var employees = new List<Employee>();
        Assert.Throws<ArgumentException>(() => Task7_GetHighPaidRecentEmployees.GetHighPaidRecentEmployees(employees, "", 900, 4));
    }
}