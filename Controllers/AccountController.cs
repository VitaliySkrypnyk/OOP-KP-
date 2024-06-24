using Microsoft.AspNetCore.Mvc;

public class AccountController : Controller
{
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(string username, string password)
    {
        
        return RedirectToAction("Index", "Home");
    }

    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(string username, string password)
    {
        
        return RedirectToAction("Login");
    }

    public IActionResult Logout()
    {
        
        return RedirectToAction("Index", "Home");
    }
}
