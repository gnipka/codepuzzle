using TestTasks;

namespace TestTasksTests;

public class Task5_PersonStudentTests
{
    [Fact]
    public void Person_GetInfo_ReturnsCorrectString()
    {
        var person = new Task5_PersonStudent.Person("Ivan", 16);
        Assert.Equal("Name: Ivan, Age: 16", person.GetInfo());
    }

    [Fact]
    public void Student_GetInfo_ReturnsCorrectString()
    {
        var student = new Task5_PersonStudent.Student("Anna", 15, "School №10");
        Assert.Equal("Name: Anna, Age: 15, School: School №10", student.GetInfo());
    }
}