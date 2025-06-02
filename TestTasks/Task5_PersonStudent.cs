namespace TestTasks;

public class Task5_PersonStudent
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            // TODO: инициализировать Name и Age
            throw new NotImplementedException();
        }

        public virtual string GetInfo()
        {
            // TODO: вернуть строку "Name: {Name}, Age: {Age}"
            throw new NotImplementedException();
        }
    }

    public class Student : Person
    {
        public string School { get; set; }

        public Student(string name, int age, string school)
            : base(name, age)
        {
            // TODO: инициализировать School
            throw new NotImplementedException();
        }

        public override string GetInfo()
        {
            // TODO: вернуть строку "Name: {Name}, Age: {Age}, School: {School}"
            throw new NotImplementedException();
        }
    }
}