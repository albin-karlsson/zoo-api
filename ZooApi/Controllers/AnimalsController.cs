using Microsoft.AspNetCore.Mvc;
using ZooApi.Database;
using ZooApi.Models;

namespace ZooApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimalsController : ControllerBase
    {
        private readonly AppDbContext context;

        public AnimalsController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<List<AnimalModel>> Get()
        {
            return Ok(context.Animals.ToList());
        }

        [HttpPost]
        public ActionResult Post(AnimalModel animalToCreate)
        {
            context.Animals.Add(animalToCreate);

            context.SaveChanges();

            return Ok();
        }
    }
}
