<?php
session_start();

if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    $username = htmlspecialchars($_POST['username']);
    $password = htmlspecialchars($_POST['password']);
    $role = $_POST['role'];
    $_SESSION['username'] = $username;
    $_SESSION['role'] = $role;

    header('Location: courses.php');
    exit();
}
include 'includes/header.php';
?>
<div class="container">
    <h2>Реєстрація</h2>
    <form method="post">
        <label for="username">Ім'я користувача:</label>
        <input type="text" id="username" name="username" required>
        
        <label for="password">Пароль:</label>
        <input type="password" id="password" name="password" required>
        
        <label for="role">Роль:</label>
        <select id="role" name="role" required>
            <option value="student">Студент</option>
            <option value="teacher">Викладач</option>
        </select>
        
        <input type="submit" value="Зареєструватися">
    </form>
</div>
<?php include 'includes/footer.php'; ?>
