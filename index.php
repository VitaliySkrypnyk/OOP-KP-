<?php
session_start();
if (isset($_SESSION['username'])) {
    header('Location: dashboard.php');
    exit();
}
include 'includes/header.php';
?>
<div class="container">
    <div class="logo">
        <img src="img/logo.png" alt="Logo">
    </div>
    <h1>Платформа дистанційного навчання</h1>
    <div class="subtitle">
        Виконав: Скрипник Віталій Сергійович 612 ПСТ
    </div>
</div>
<?php include 'includes/footer.php'; ?>
