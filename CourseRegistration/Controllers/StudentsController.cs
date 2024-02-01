using CourseRegistration.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseRegistration.Controllers;

public class StudentsController : Controller
{
    public IActionResult Index()
    {
        return View(Student.Students);
    }
}

