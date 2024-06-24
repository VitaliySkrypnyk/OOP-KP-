using Microsoft.AspNetCore.Mvc;

public class CourseController : Controller
{
    public IActionResult Dashboard()
    {
        return View();
    }

    public IActionResult AddCourse()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddCourse(string courseName)
    {
        
        return RedirectToAction("Courses");
    }

    public IActionResult EditCourse(int id)
    {
        
        return View();
    }

    [HttpPost]
    public IActionResult EditCourse(int id, string courseName)
    {
        
        return RedirectToAction("Courses");
    }

    public IActionResult DeleteCourse(int id)
    {
       
        return RedirectToAction("Courses");
    }

    public IActionResult Courses()
    {

        return View();
    }
}
