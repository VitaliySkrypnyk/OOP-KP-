<?php
session_start();
?>
<!DOCTYPE html>
<html lang="uk">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Платформа дистанційного навчання</title>
    <link rel="stylesheet" href="css/style.css">
</head>
<body>
    <nav>
        <div class="nav-logo">
            <a href="index.php"><img src="img/logo.png" alt="Логотип" class="logo-nav"></a>
        </div>
        <a href="index.php">Головна</a>
        <a href="courses.php">Курси</a>
        <?php if (isset($_SESSION['username'])): ?>
    <div class="nav-username">
        <a href="courses.php" style="color: white; font-weight: bold;"><?php echo $_SESSION['username']; ?></a>
    </div>
<?php endif; ?>

        <?php if (isset($_SESSION['username'])): ?>
            <a href="logout.php">Вихід</a>
        <?php else: ?>
            <a href="register.php">Реєстрація</a>
            <a href="login.php">Вхід</a>
        <?php endif; ?>
    </nav>
