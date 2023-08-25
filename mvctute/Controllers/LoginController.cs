using Microsoft.AspNetCore.Mvc;
using mvctute.Services;
using mvctute.DTO;

namespace mvctute.Controllers;
public class LoginController : Controller
{
    private readonly ILogger<LoginController> _logger;
    private readonly ILoginService _service;
    public LoginController(ILogger<LoginController> logger, ILoginService service)
    {
        this._logger = logger;
        this._service = service;
    }
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index([FromBody] LoginDTO loginDTO)
    {
        bool isValid = this._service.PerformLogin(loginDTO.Email!, loginDTO.Password!);
        if(isValid)
        {
            return Redirect("/Home/Index");
        }
        else
        {
            return View();
        }
    }
}