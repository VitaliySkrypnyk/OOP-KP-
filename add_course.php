<?php
session_start();
if (!isset($_SESSION['username'])) {
    header('Location: login.php');
    exit();
}

if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    $course_name = $_POST['course_name'];
    if (!empty($course_name)) {
        $_SESSION['courses'][] = [
            'name' => $course_name
        ];
        header('Location: dashboard.php');
        exit();
    } else {
        $error = "Введіть назву курсу";
    }
}

include 'includes/header.php';
?>
<div class="container">
    <h1>Додати новий курс</h1>
    <form action="add_course.php" method="post">
        <label for="course_name">Назва курсу:</label>
        <input type="text" id="course_name" name="course_name" required>
        <input type="submit" value="Додати курс">
    </form>
    <?php if (isset($error)) echo "<p style='color:red;'>$error</p>"; ?>
</div>
<?php include 'includes/footer.php'; ?>
