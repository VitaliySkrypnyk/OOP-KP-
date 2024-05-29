using System;
using System.Collections.Generic;

// Абстрактний клас User
public abstract class User
{
    public string Name { get; set; }
    public string Email { get; set; }

    protected User(string name, string email)
    {
        Name = name;
        Email = email;
    }
}

// Клас Student, що наслідується від User
public class Student : User
{
    public List<Course> Courses { get; set; }

    public Student(string name, string email) : base(name, email)
    {
        Courses = new List<Course>();
    }

    public void Enroll(Course course)
    {
        Courses.Add(course);
    }
}

// Клас Instructor, що наслідується від User
public class Instructor : User
{
    public List<Course> CoursesTaught { get; set; }

    public Instructor(string name, string email) : base(name, email)
    {
        CoursesTaught = new List<Course>();
    }

    public void AssignCourse(Course course)
    {
        CoursesTaught.Add(course);
    }
}

// Клас Course
public class Course
{
    public string Name { get; set; }
    public Instructor Instructor { get; set; }
    public List<Student> Students { get; set; }

    public Course(string name, Instructor instructor)
    {
        Name = name;
        Instructor = instructor;
        Students = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }
}

 
