using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TaibuSchools.Models;

namespace TaibuSchools.Controllers;

public class DepartmentController : Controller
{
    private readonly ILogger<DepartmentController> _logger;

    public DepartmentController(ILogger<DepartmentController> logger)
    {
        _logger = logger;
    }

    public IActionResult AddDepartment()
    {
        return View();
    }

    public IActionResult ViewDepartments()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
