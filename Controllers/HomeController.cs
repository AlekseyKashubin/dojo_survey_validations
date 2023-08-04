using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dojo_survey_validations.Models;

namespace dojo_survey_validations.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;


public static List<Result> SurveyList = new List<Result>();
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }


[HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }


[HttpPost("results/create")]
    public IActionResult Create(Result newResult)
    {
        if(ModelState.IsValid)
        {
            SurveyList.Add(newResult);
            return RedirectToAction("AllResults");
        }else{
            return View("Index");
        }
        
        
    }

    [HttpGet("allresults")]
    public IActionResult AllResults()
    {
        return View("AllResults", SurveyList);
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
