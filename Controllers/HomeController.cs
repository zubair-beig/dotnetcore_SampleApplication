using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace myApp.Controllers
{

[Route("api/[Controller]/[Action]")]
public class HomeController : Controller
{
    public HomeController()
    {

    }
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

}


}