using CourseRegistration.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseRegistration.Controllers;

public class CoursesController : Controller
{
    public IActionResult Index()
    {
        return View(Course.Courses);
    }
}

