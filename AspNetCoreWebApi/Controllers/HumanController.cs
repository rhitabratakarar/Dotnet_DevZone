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

        [HttpDelete]
        [Route("delete")]
        public IActionResult DeleteExistingHuman(HumanIdDto humanIdDTO)
        {
            int id = humanIdDTO.Id;
            Human humanToRemove = this._context.Humans.Single<Human>(h => h.Id == id);
            this._context.Remove(humanToRemove);
            this._context.SaveChanges();
            return Ok();
        }

        [HttpPut]
        [Route("update/{id}")]
        public IActionResult UpdateExistingUser([FromRoute]int id, [FromBody]HumanDTO updatedHumanInformation)
        {
            Human humanToUpdate = this._context.Humans.Single<Human>(h => h.Id == id);
            humanToUpdate.Name = updatedHumanInformation.Name;
            humanToUpdate.Age = updatedHumanInformation.Age;
            humanToUpdate.BirthPlace = updatedHumanInformation.BirthPlace;
            this._context.SaveChanges();
            return Ok();
        }
    }
}
