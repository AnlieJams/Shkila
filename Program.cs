using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Group
{
    private List<Student> students = new List<Student>();


    public Student this[int index]
    {
        get
        {
            if (index >= 0 && index < students.Count)
            {
                return students[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Индекс выходит за пределы группы, бож.");
            }
        }
    }

    public void AddStudent(Student student)
    {
        students.Add(student);
    }
}

class Program
{
    static void Main()
    {
        Group g = new Group();

        Student s1 = new Student { Name = "Шкила 1", Age = 20 };
        Student s2 = new Student { Name = "Шкила 2", Age = 21 };
        Student s3 = new Student { Name = "Шкила 3", Age = 22 };
        Student s4 = new Student { Name = "Шкила 4", Age = 23 };

        g.AddStudent(s1);
        g.AddStudent(s2);
        g.AddStudent(s3);
        g.AddStudent(s4);

        Console.WriteLine(g[0].Name);
    }
}
