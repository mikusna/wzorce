using System;

public class School
{
    public string GetTeacherName()
    {
        Classroom classroom = new Classroom();
        return classroom.GetTeacher().GetName();
    }
}

public class Classroom
{
    public Teacher GetTeacher()
    {
        return new Teacher();
    }
}

public class Teacher
{
    public string GetName()
    {
        return "John Smith";
    }
}

class Program
{
    static void Main(string[] args)
    {
        School school = new School();
        string teacherName = school.GetTeacherName();
        Console.WriteLine(teacherName);
        Console.ReadKey();
    }
}