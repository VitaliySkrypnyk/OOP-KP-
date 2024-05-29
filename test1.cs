using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
public class PlatformTests
{
    [Test]
    public void UserCreationTest()
    {
        var student = new Student("John Doe", "john.doe@example.com");
        var instructor = new Instructor("Jane Smith", "jane.smith@example.com");

        Assert.AreEqual("John Doe", student.Name);
        Assert.AreEqual("john.doe@example.com", student.Email);
        Assert.AreEqual("Jane Smith", instructor.Name);
        Assert.AreEqual("jane.smith@example.com", instructor.Email);
    }

    [Test]
    public void CourseCreationTest()
    {
        var instructor = new Instructor("Jane Smith", "jane.smith@example.com");
        var course = new Course("C# Programming", instructor);

        Assert.AreEqual("C# Programming", course.Name);
        Assert.AreEqual(instructor, course.Instructor);
    }
    [Test]
    public void StudentEnrollmentTest()
    {
        var instructor = new Instructor("Jane Smith", "jane.smith@example.com");
        var course = new Course("C# Programming", instructor);
        var student = new Student("John Doe", "john.doe@example.com");

        student.Enroll(course);
        course.AddStudent(student);

        Assert.Contains(course, student.Courses);
        Assert.Contains(student, course.Students);
    }
    [Test]
    public void InstructorAssignmentTest()
    {
        var instructor = new Instructor("Jane Smith", "jane.smith@example.com");
        var course = new Course("C# Programming", instructor);

        instructor.AssignCourse(course);

        Assert.Contains(course, instructor.CoursesTaught);
    }
}
