<?php
session_start();
if (!isset($_SESSION['username'])) {
    header('Location: login.php');
    exit();
}

if (!isset($_SESSION['courses'])) {
    $_SESSION['courses'] = [];
}

include 'includes/header.php';
?>
<div class="container">
    <h1>Курси</h1>
    <div class="header-buttons">
        <a href="add_course.php">Додати курс</a>
        <a href="logout.php">Вийти</a>
    </div>
    <ul>
        <?php foreach ($_SESSION['courses'] as $id => $course): ?>
            <li>
                <?php echo $course['name']; ?> 
                <a href="edit_course.php?id=<?php echo $id; ?>">Редагувати</a> 
                <a href="delete_course.php?id=<?php echo $id; ?>">Видалити</a>
            </li>
        <?php endforeach; ?>
    </ul>
</div>
<?php include 'includes/footer.php'; ?>
