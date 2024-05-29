using System;
using System.Windows.Forms;
using System.Collections.Generic;

public class CourseManagementForm : Form
{
    private TextBox courseNameTextBox;
    private TextBox courseDescriptionTextBox;
    private Button createCourseButton;
    private ListBox coursesListBox;

    private List<Course> courses;

    public CourseManagementForm()
    {
        this.Text = "Course Management";
        courses = new List<Course>();
        InitializeComponents();
    }

    private void InitializeComponents()
    {
        courseNameTextBox = new TextBox { PlaceholderText = "Course Name" };
        courseDescriptionTextBox = new TextBox { PlaceholderText = "Course Description" };
        createCourseButton = new Button { Text = "Create Course" };
        coursesListBox = new ListBox();

        createCourseButton.Click += CreateCourseButton_Click;

        Controls.Add(courseNameTextBox);
        Controls.Add(courseDescriptionTextBox);
        Controls.Add(createCourseButton);
        Controls.Add(coursesListBox);
    }

    private void CreateCourseButton_Click(object sender, EventArgs e)
    {
        string courseName = courseNameTextBox.Text;
        string courseDescription = courseDescriptionTextBox.Text;
        
        var instructor = new Instructor("Jane Smith", "jane.smith@example.com"); // Example instructor
        var course = new Course(courseName, instructor);
        
        courses.Add(course);
        coursesListBox.Items.Add(courseName);

        MessageBox.Show("Course created successfully!");
    }
}

