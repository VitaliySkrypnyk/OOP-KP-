<?php
session_start();

if (!isset($_SESSION['username']) || $_SESSION['role'] != 'student') {
    header('Location: index.php');
    exit();
}

$student_year = isset($_SESSION['student_year']) ? $_SESSION['student_year'] : null;

include 'includes/header.php';

if ($student_year !== null && isset($_SESSION['courses'][$student_year]) && count($_SESSION['courses'][$student_year]) > 0) {
    ?>
    <div class="container">
        <h1>Ваші предмети для курсу <?php echo $student_year; ?></h1>
        <ul>
            <?php foreach ($_SESSION['courses'][$student_year] as $subject): ?>
                <li><?php echo htmlspecialchars($subject); ?></li>
            <?php endforeach; ?>
        </ul>
    </div>
    <?php
} else {
    ?>
    <div class="container">
        <h1>Немає доступних предметів для вашого курсу</h1>
    </div>
    <?php
}

include 'includes/footer.php';
