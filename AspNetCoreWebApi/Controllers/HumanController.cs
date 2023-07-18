using Microsoft.AspNetCore.Mvc;
using AspNetCoreWebApi.Models;
using AspNetCoreWebApi.Data;
using AspNetCoreWebApi.DTO;

namespace AspNetCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    public class HumanController : Controller
    {
        private readonly HumanContext _context;
        public HumanController(HumanContext dbContext)
        {
            this._context = dbContext;
        }

        [HttpGet]
        [Route("all")]
        public IList<Human> GetAllHumans()
        {
            return this._context.Humans.ToList<Human>();
        }

        [HttpPost]
        [Route("add")]
        public IActionResult CreateNewHuman(HumanDTO human)
        {
            Human newHuman = new Human()
            {
                Name = human.Name,
                Age = human.Age,
                BirthPlace = human.BirthPlace
            };
            this._context.Humans.Add(newHuman);
            this._context.SaveChanges();

            return Ok();
        }
    }
}
