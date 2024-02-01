using CourseRegistration.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseRegistration.Controllers;

public class InstructorsController : Controller
{
    public IActionResult Index()
    {
        return View(Instructor.Instructors);
    }
}

