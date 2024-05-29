using System;
using System.Windows.Forms;

public class LoginForm : Form
{
    private TextBox emailTextBox;
    private TextBox passwordTextBox;
    private Button loginButton;

    public LoginForm()
    {
        this.Text = "Login";
        InitializeComponents();
    }

    private void InitializeComponents()
    {
        emailTextBox = new TextBox { PlaceholderText = "Email" };
        passwordTextBox = new TextBox { PlaceholderText = "Password", UseSystemPasswordChar = true };
        loginButton = new Button { Text = "Login" };

        loginButton.Click += LoginButton_Click;

        Controls.Add(emailTextBox);
        Controls.Add(passwordTextBox);
        Controls.Add(loginButton);
    }

    private void LoginButton_Click(object sender, EventArgs e)
    {
        string email = emailTextBox.Text;
        string password = passwordTextBox.Text;
        
        // Authentication logic goes here
        MessageBox.Show("Login successful!");
    }
}
