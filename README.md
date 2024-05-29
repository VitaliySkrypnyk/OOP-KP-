# OOP-KP-
# Платформа дистанційного навчання

Цей проект являє собою платформу дистанційного навчання, розроблену з використанням об'єктно-орієнтованої парадигми програмування (ООП) на мові програмування C#. Платформа надає можливість створення курсів, реєстрації студентів, проведення уроків та тестів, а також взаємодії між студентами та викладачами.

## Основні можливості

- Реєстрація користувачів (студентів та викладачів).
- Створення та управління курсами.
- Додавання та перегляд уроків.
- Створення та проходження тестів.
- Управління користувачами та їх ролями.

## Класи та їх призначення

- **CourseManagementForm:** Інтерфейс для управління курсами (створення, редагування та видалення курсів).
- **CourseViewForm:** Інтерфейс для перегляду деталей та змісту конкретного курсу.
- **LessonViewForm:** Інтерфейс для перегляду уроків, включаючи їх контент та матеріали.
- **Login:** Форма для введення облікових даних користувача та авторизації на платформі.
- **RegistrationForm:** Форма для реєстрації нових користувачів на платформі.
- **PlatformTests:** Набір тестів для перевірки функціональності всієї платформи.
- **UserCreationTest:** Тест для перевірки створення об'єкта користувача з правильними властивостями.
- **TestViewForm:** Інтерфейс для перегляду та проходження тестів на платформі.

## Вимоги до системи

- .NET Framework 4.7.2 або вище
- Visual Studio 2019 або новіше
- SQL Server або будь-яка інша сумісна база даних

## Інсталяція

1. **Клонування репозиторію**
    ```bash
    git clone https://github.com/VitaliySkrypnyk/OOP-KP-.git
    cd online-learning-platform
    ```
    
2. **Міграція бази даних**
    
      ```powershell
      Update-Database
      ```

## Використання


1. **Реєстрація та авторизація**
    - Можливiсть реєстрації або увійти з існуючими обліковими даними.

2. **Управління курсами та уроками**
    - Викладачі можуть створювати та редагувати курси, додавати уроки та тести.
    - Студенти можуть реєструватися на курси, переглядати уроки та проходити тести.

## Тестування

Проект включає набір тестів для перевірки основної функціональності. Для запуску тестів:

1. **Встановлення NUnit та NUnit3TestAdapter**
    
      ```powershell
      Install-Package NUnit
      Install-Package NUnit3TestAdapter
      ```

## Вітаю та дякую за увагу!

---

Цей додаток подібний до Google Classroom та Google Meet, що дозволяє проводити онлайн-уроки, надавати доступ до навчальних матеріалів та організовувати інтерактивне навчання.
