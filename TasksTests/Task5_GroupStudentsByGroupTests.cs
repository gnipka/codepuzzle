using Tasks;

namespace TasksTests;

public class Task5_GroupStudentsByGroupTests
{
    [Fact]
    public void GroupStudentsByGroup_FiltersAndGroupsCorrectly()
    {
        var students = new List<Student>
        {
            new Student { Name = "Ivan", Group = "A", GPA = 5.5 },
            new Student { Name = "Anna", Group = "B", GPA = 3.2 },
            new Student { Name = "Petr", Group = "A", GPA = 8.1 },
            new Student { Name = "Olga", Group = "B", GPA = 6.0 }
        };
        var dict = Task5_GroupStudentsByGroup.GroupStudentsByGroup(students);
        Assert.Equal(2, dict.Count);
        Assert.True(dict.ContainsKey("A"));
        Assert.True(dict.ContainsKey("B"));
        var groupA = dict["A"];
        Assert.Equal(new[] {8.1, 5.5}, groupA.Select(s => s.GPA));
        var groupB = dict["B"];
        Assert.Single(groupB);
        Assert.Equal(6.0, groupB.First().GPA);
    }

    [Fact]
    public void GroupStudentsByGroup_Null_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() => Task5_GroupStudentsByGroup.GroupStudentsByGroup(null));
    }
}