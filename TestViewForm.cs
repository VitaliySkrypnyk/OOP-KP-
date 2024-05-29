using System;
using System.Windows.Forms;

public class TestViewForm : Form
{
    private ListBox testsListBox;
    private Button takeTestButton;

    public TestViewForm()
    {
        this.Text = "Take Test";
        InitializeComponents();
    }

    private void InitializeComponents()
    {
        testsListBox = new ListBox();
        takeTestButton = new Button { Text = "Take Test" };

        takeTestButton.Click += TakeTestButton_Click;

        Controls.Add(testsListBox);
        Controls.Add(takeTestButton);
    }

    private void TakeTestButton_Click(object sender, EventArgs e)
    {
        string selectedTest = testsListBox.SelectedItem.ToString();
        
        // Start test logic
        MessageBox.Show($"Starting test: {selectedTest}");
    }
}

