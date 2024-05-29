[Test]
public void UserCreationTest()
{
    var user = new User
    {
        Id = 1,
        Name = "John Doe",
        Email = "john.doe@example.com",
        Role = Role.Student
    };

    Assert.AreEqual(1, user.Id);
    Assert.AreEqual("John Doe", user.Name);
    Assert.AreEqual("john.doe@example.com", user.Email);
    Assert.AreEqual(Role.Student, user.Role);
}
 [Test]
public void CourseCreationTest()
{
    var instructor = new User { Id = 2, Name = "Jane Smith", Email = "jane.smith@example.com", Role = Role.Instructor };
    var course = new Course
    {
        Id = 1,
        Title = "C# Programming",
        Description = "Learn the basics of C# programming",
        Instructor = instructor
    };

    Assert.AreEqual(1, course.Id);
    Assert.AreEqual("C# Programming", course.Title);
    Assert.AreEqual("Learn the basics of C# programming", course.Description);
    Assert.AreEqual(instructor, course.Instructor);
}
 [Test]
public void LessonCreationTest()
{
    var course = new Course { Id = 1, Title = "C# Programming", Description = "Learn the basics of C# programming" };
    var lesson = new Lesson
    {
        Id = 1,
        Title = "Introduction to C#",
        Description = "An introduction to C# programming language",
        Course = course,
        Content = "This is the content of the lesson."
    };

    Assert.AreEqual(1, lesson.Id);
    Assert.AreEqual("Introduction to C#", lesson.Title);
    Assert.AreEqual("An introduction to C# programming language", lesson.Description);
    Assert.AreEqual(course, lesson.Course);
    Assert.AreEqual("This is the content of the lesson.", lesson.Content);
}
 [Test]
public void TestCreationTest()
{
    var course = new Course { Id = 1, Title = "C# Programming", Description = "Learn the basics of C# programming" };
    var test = new Test
    {
        Id = 1,
        Title = "C# Basics Test",
        Course = course,
    };

    var question1 = new Question
    {
        Id = 1,
        Text = "What is C#?",
        Options = new List<string> { "A programming language", "A database", "An operating system", "A web browser" },
        CorrectAnswer = "A programming language"
    };

    test.Questions.Add(question1);

    Assert.AreEqual(1, test.Id);
    Assert.AreEqual("C# Basics Test", test.Title);
    Assert.AreEqual(course, test.Course);
    Assert.AreEqual(1, test.Questions.Count);
    Assert.AreEqual("What is C#?", test.Questions[0].Text);
}

