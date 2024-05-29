using System;
using System.Windows.Forms;

public class RegistrationForm : Form
{
    private TextBox nameTextBox;
    private TextBox emailTextBox;
    private TextBox passwordTextBox;
    private ComboBox roleComboBox;
    private Button registerButton;

    public RegistrationForm()
    {
        this.Text = "Register";
        InitializeComponents();
    }

    private void InitializeComponents()
    {
        nameTextBox = new TextBox { PlaceholderText = "Name" };
        emailTextBox = new TextBox { PlaceholderText = "Email" };
        passwordTextBox = new TextBox { PlaceholderText = "Password", UseSystemPasswordChar = true };
        roleComboBox = new ComboBox();
        roleComboBox.Items.Add("Student");
        roleComboBox.Items.Add("Instructor");
        registerButton = new Button { Text = "Register" };

        registerButton.Click += RegisterButton_Click;

        Controls.Add(nameTextBox);
        Controls.Add(emailTextBox);
        Controls.Add(passwordTextBox);
        Controls.Add(roleComboBox);
        Controls.Add(registerButton);
    }

    private void RegisterButton_Click(object sender, EventArgs e)
    {
        string name = nameTextBox.Text;
        string email = emailTextBox.Text;
        string password = passwordTextBox.Text;
        string role = roleComboBox.SelectedItem.ToString();

        // Registration logic goes here
        MessageBox.Show("Registration successful!");
    }
}
