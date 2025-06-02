using TestTasksDifficult;

namespace TestTasksDifficultTests;

public class Task9_CsvOperationsTests
{
    [Fact]
    public void ReadEmployeesFromCsv_ValidFile_ReturnsList()
    {
        string tempPath = Path.GetTempFileName();
        File.WriteAllText(tempPath, "Name,Department,Salary\nIvan,IT,1000\nAnna,HR,1200");
        var result = Task9_CsvOperations.ReadEmployeesFromCsv(tempPath);
        Assert.Equal(2, result.Count);
        Assert.Equal("Ivan", result[0].Name);
        File.Delete(tempPath);
    }

    [Fact]
    public void ReadEmployeesFromCsv_InvalidLines_IgnoresThem()
    {
        string tempPath = Path.GetTempFileName();
        File.WriteAllText(tempPath, "Name,Department,Salary\nBad,Data\nPetr,IT,abc");
        var result = Task9_CsvOperations.ReadEmployeesFromCsv(tempPath);
        Assert.Empty(result);
        File.Delete(tempPath);
    }

    [Fact]
    public void ReadEmployeesFromCsv_NonExistent_ReturnsEmpty()
    {
        var result = Task9_CsvOperations.ReadEmployeesFromCsv("no_such.csv");
        Assert.Empty(result);
    }

    [Fact]
    public void WriteHighSalaryToCsv_FiltersAndWritesCorrectly()
    {
        string input = Path.GetTempFileName();
        string output = Path.GetTempFileName();
        File.WriteAllText(input, "Name,Department,Salary\nIvan,IT,1000\nAnna,HR,1200");
        Task9_CsvOperations.WriteHighSalaryToCsv(input, output, 1100);
        var lines = File.ReadAllLines(output);
        Assert.Equal(new[] { "Name,Department,Salary", "Anna,HR,1200" }, lines);
        File.Delete(input);
        File.Delete(output);
    }
}