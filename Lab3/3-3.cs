using System;
using System.Collections.Generic;

class Student : IComparable<Student>
{
    public string Name { get; set; }
    public int Grade { get; set; }

    public int CompareTo(Student other)
    {
        return this.Grade.CompareTo(other.Grade);
    }

    public override string ToString()
    {
        return $"{Name}, Grade: {Grade}";
    }
}

class Program3
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Anna", Grade = 88 },
            new Student { Name = "Bohdan", Grade = 75 },
            new Student { Name = "Kateryna", Grade = 92 }
        };

        students.Sort();

        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }
}
