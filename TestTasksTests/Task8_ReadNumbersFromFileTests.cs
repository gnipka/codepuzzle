using TestTasks;

namespace TestTasksTests;

public class Task8_ReadNumbersFromFileTests
{
    [Fact]
    public void ReadNumbersFromFile_ValidFile_ReturnsArray()
    {
        string tempPath = Path.GetTempFileName();
        File.WriteAllText(tempPath, "1 2 3 4 5");
        var result = Task8_ReadNumbersFromFile.ReadNumbersFromFile(tempPath);
        Assert.Equal(new[] { 1, 2, 3, 4, 5 }, result);
        File.Delete(tempPath);
    }

    [Fact]
    public void ReadNumbersFromFile_BadData_ReturnsEmptyArray()
    {
        string tempPath = Path.GetTempFileName();
        File.WriteAllText(tempPath, "10 twenty 30");
        var result = Task8_ReadNumbersFromFile.ReadNumbersFromFile(tempPath);
        Assert.Empty(result);
        File.Delete(tempPath);
    }

    [Fact]
    public void ReadNumbersFromFile_NonExistent_ReturnsEmptyArray()
    {
        var result = Task8_ReadNumbersFromFile.ReadNumbersFromFile("no_such_file.txt");
        Assert.Empty(result);
    }

    [Fact]
    public void ReadNumbersFromFile_EmptyLine_ReturnsEmptyArray()
    {
        string tempPath = Path.GetTempFileName();
        File.WriteAllText(tempPath, "");
        var result = Task8_ReadNumbersFromFile.ReadNumbersFromFile(tempPath);
        Assert.Empty(result);
        File.Delete(tempPath);
    }
}