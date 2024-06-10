<?php
session_start();
if (!isset($_SESSION['username'])) {
    header('Location: login.php');
    exit();
}

if (!isset($_SESSION['courses'])) {
    header('Location: dashboard.php');
    exit();
}

if (isset($_GET['id'])) {
    $id = $_GET['id'];
    if (!isset($_SESSION['courses'][$id])) {
        header('Location: dashboard.php');
        exit();
    }

    $course = $_SESSION['courses'][$id];
}

if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    $course_name = $_POST['course_name'];
    if (!empty($course_name)) {
        $_SESSION['courses'][$id]['name'] = $course_name;
        header('Location: dashboard.php');
        exit();
    } else {
        $error = "Введіть назву курсу";
    }
}

include 'includes/header.php';
?>
<div class="container">
    <h1>Редагувати курс</h1>
    <form action="edit_course.php?id=<?php echo $id; ?>" method="post">
        <label for="course_name">Назва курсу:</label>
        <input type="text" id="course_name" name="course_name" value="<?php echo $course['name']; ?>" required>
        <input type="submit" value="Оновити курс">
    </form>
    <?php if (isset($error)) echo "<p style='color:red;'>$error</p>"; ?>
</div>
<?php include 'includes/footer.php'; ?>
