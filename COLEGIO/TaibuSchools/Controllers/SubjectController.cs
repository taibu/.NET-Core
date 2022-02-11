using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TaibuSchools.Models;

namespace TaibuSchools.Controllers;

public class SubjectController : Controller
{
    private readonly ILogger<SubjectController> _logger;

    public SubjectController(ILogger<SubjectController> logger)
    {
        _logger = logger;
    }

    public IActionResult AddSubject()
    {
        return View();
    }

    public IActionResult ViewSubjects()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
