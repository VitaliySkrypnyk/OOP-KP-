using System;
using System.Windows.Forms;

public class CourseViewForm : Form
{
    private ListBox coursesListBox;
    private Button viewCourseButton;
    private Label courseDetailsLabel;

    public CourseViewForm()
    {
        this.Text = "View Courses";
        InitializeComponents();
    }

    private void InitializeComponents()
    {
        coursesListBox = new ListBox();
        viewCourseButton = new Button { Text = "View Course" };
        courseDetailsLabel = new Label();

        viewCourseButton.Click += ViewCourseButton_Click;

        Controls.Add(coursesListBox);
        Controls.Add(viewCourseButton);
        Controls.Add(courseDetailsLabel);
    }

    private void ViewCourseButton_Click(object sender, EventArgs e)
    {
        string selectedCourse = coursesListBox.SelectedItem.ToString();
        
        // Retrieve course details logic
        courseDetailsLabel.Text = $"Details of {selectedCourse}";
    }
}
