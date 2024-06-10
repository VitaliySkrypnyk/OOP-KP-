<?php
session_start();

if (!isset($_SESSION['username'])) {
    header('Location: index.php');
    exit();
}

if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    if (isset($_POST['role'])) {
        $_SESSION['role'] = $_POST['role'];
    }

    if (isset($_SESSION['role']) && $_SESSION['role'] == 'teacher') {
        if (!isset($_SESSION['courses'])) {
            $_SESSION['courses'] = [];
        }

        if (isset($_POST['add_subject']) && !empty($_POST['subject_name']) && !empty($_POST['course_year'])) {
            $subject_name = htmlspecialchars($_POST['subject_name']);
            $course_year = intval($_POST['course_year']);
            if (!isset($_SESSION['courses'][$course_year])) {
                $_SESSION['courses'][$course_year] = [];
            }
            $_SESSION['courses'][$course_year][] = $subject_name;
        } elseif (isset($_POST['delete_subject']) && isset($_POST['course_year']) && isset($_POST['subject_index'])) {
            $course_year = intval($_POST['course_year']);
            $subject_index = intval($_POST['subject_index']);
            if (isset($_SESSION['courses'][$course_year][$subject_index])) {
                array_splice($_SESSION['courses'][$course_year], $subject_index, 1);
            }
        }
    } elseif (isset($_SESSION['role']) && $_SESSION['role'] == 'student') {
        if (isset($_POST['student_year'])) {
            $student_year = intval($_POST['student_year']);
            $_SESSION['student_year'] = $student_year;
        }
    }
}

include 'includes/header.php';
?>

<div class="container">
    <h1>Курси</h1>
    <?php if (!isset($_SESSION['role'])): ?>
        <form method="post">
            <label for="role">Ви студент чи викладач?</label>
            <select id="role" name="role" required>
                <option value="student">Студент</option>
                <option value="teacher">Викладач</option>
            </select>
            <button type="submit">Підтвердити</button>
        </form>
    <?php elseif ($_SESSION['role'] == 'teacher'): ?>
        <form method="post" class="add-subject-form">
            <label for="subject_name">Назва предмету:</label>
            <input type="text" id="subject_name" name="subject_name" required>
            
            <label for="course_year">Курс:</label>
            <select id="course_year" name="course_year" required>
                <option value="1">1 курс</option>
                <option value="2">2 курс</option>
                <option value="3">3 курс</option>
                <option value="4">4 курс</option>
                <option value="5">5 курс</option>
            </select>
            <button type="submit" name="add_subject" class="add-course-button">Додати предмет</button>
        </form>

        <h2>Список предметів:</h2>
        <?php foreach ($_SESSION['courses'] as $course_year => $subjects): ?>
            <h3><?php echo $course_year; ?> курс</h3>
            <ul>
                <?php foreach ($subjects as $index => $subject): ?>
                    <li>
    <div style="display: flex; justify-content: space-between; align-items: center;">
        <span><?php echo htmlspecialchars($subject); ?></span>
        <form method="post" style="margin-left: 10px;">
            <input type="hidden" name="course_year" value="<?php echo $course_year; ?>">
            <input type="hidden" name="subject_index" value="<?php echo $index; ?>">
            <button type="submit" name="delete_subject" class="delete-course-button">Видалити</button>
        </form>
    </div>
</li>

                <?php endforeach; ?>
            </ul>
        <?php endforeach; ?>
    <?php elseif ($_SESSION['role'] == 'student'): ?>
        <?php if (!isset($_SESSION['student_year'])): ?>
            <form method="post" class="select-course-form">
                <label for="student_year">Оберіть курс:</label>
                <select id="student_year" name="student_year" required>
                    <option value="1">1 курс</option>
                    <option value="2">2 курс</option>
                    <option value="3">3 курс</option>
                    <option value="4">4 курс</option>
                    <option value="5">5 курс</option>
                </select>
                <button type="submit">Підтвердити</button>
            </form>
        <?php else: ?>
            <h2>Ваші предмети:</h2>
            <?php 
            $student_year = $_SESSION['student_year'];
            if (isset($_SESSION['courses'][$student_year])): 
            ?>
                <ul>
                    <?php foreach ($_SESSION['courses'][$student_year] as $subject): ?>
                        <li><?php echo htmlspecialchars($subject); ?></li>
                    <?php endforeach; ?>
                </ul>
            <?php else: ?>
                <p>Немає доступних предметів для вашого курсу</p>
            <?php endif; ?>
        <?php endif; ?>
    <?php endif; ?>
</div>

<?php include 'includes/footer.php'; ?>
