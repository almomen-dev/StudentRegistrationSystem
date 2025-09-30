using Microsoft.AspNetCore.Mvc;

public class AccountController : Controller
{

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

   
    [HttpPost]
    public IActionResult Login(string username, string password)
    {
        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            ViewBag.ErrorMessage = "Username and password are required.";
            return View();
        }

        if (username == "admin" && password == "admin")
            return RedirectToAction("Index", "Home");

        ViewBag.ErrorMessage = "Invalid username or password.";
        return View();
    }

  
    [HttpGet]
    public IActionResult Registration()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Registration(string uname, string email, string password)
    {
        if (string.IsNullOrEmpty(uname) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
        {
            ViewBag.ErrorMessage = "All fields are required.";
            return View();
        }
       
        return RedirectToAction("Login");
    }
}
