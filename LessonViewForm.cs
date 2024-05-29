using System;
using System.Windows.Forms;

public class LessonViewForm : Form
{
    private ListBox lessonsListBox;
    private Button viewLessonButton;
    private Label lessonContentLabel;

    public LessonViewForm()
    {
        this.Text = "View Lessons";
        InitializeComponents();
    }

    private void InitializeComponents()
    {
        lessonsListBox = new ListBox();
        viewLessonButton = new Button { Text = "View Lesson" };
        lessonContentLabel = new Label();

        viewLessonButton.Click += ViewLessonButton_Click;

        Controls.Add(lessonsListBox);
        Controls.Add(viewLessonButton);
        Controls.Add(lessonContentLabel);
    }

    private void ViewLessonButton_Click(object sender, EventArgs e)
    {
        string selectedLesson = lessonsListBox.SelectedItem.ToString();
        
        // Retrieve lesson content logic
        lessonContentLabel.Text = $"Content of {selectedLesson}";
    }
}
