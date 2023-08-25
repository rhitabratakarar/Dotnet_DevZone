using Microsoft.AspNetCore.Mvc;

namespace mvctute.Controllers;
public class LoginController : Controller
{
    private readonly ILogger<LoginController> _logger;
    public LoginController(ILogger<LoginController> logger)
    {
        this._logger = logger;
    }
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    [HttpGet]
    public IActionResult FirstPage()
    {
        mvctute.Models.DataTransferObject dto = new();
        return View(dto);
    }
    [HttpPost]
    public IActionResult FirstPage([FromBody]mvctute.Models.DataTransferObject dto)
    {
        return View(dto);
    }
}