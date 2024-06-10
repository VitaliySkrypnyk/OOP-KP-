<?php
session_start();

if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    $username = $_POST['username'];
    $password = $_POST['password'];

    if (isset($_SESSION['users'])) {
        foreach ($_SESSION['users'] as $user) {
            if ($user['username'] == $username && password_verify($password, $user['password'])) {
                $_SESSION['username'] = $username;
                header('Location: dashboard.php');
                exit();
            }
        }
    }
    $error = "Невірне ім'я користувача або пароль";
}

include 'includes/header.php';
?>
<div class="container">
    <h1>Вхід</h1>
    <form action="login.php" method="post">
        <label for="username">Ім'я користувача:</label>
        <input type="text" id="username" name="username" required>
        <label for="password">Пароль:</label>
        <input type="password" id="password" name="password" required>
        <input type="submit" value="Увійти">
    </form>
    <?php if (isset($error)) echo "<p style='color:red;'>$error</p>"; ?>
</div>
<?php include 'includes/footer.php'; ?>
