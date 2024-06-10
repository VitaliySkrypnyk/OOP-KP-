<?php
session_start();
if (!isset($_SESSION['username'])) {
    header('Location: login.php');
    exit();
}

if (isset($_GET['id'])) {
    $id = $_GET['id'];
    if (isset($_SESSION['courses'][$id])) {
        unset($_SESSION['courses'][$id]);
    }
    header('Location: dashboard.php');
    exit();
}
?>
