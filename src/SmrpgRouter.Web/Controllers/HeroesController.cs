using System.Collections.Generic;

using SmrpgRouter.DAL;
using SmrpgRouter.Domain;

using Microsoft.AspNetCore.Mvc;

namespace SmrpgRouter.Web.Controllers
{
    [Route("api/characters")]
    public class HeroesController : Controller
    {
        private readonly CharacterRepository _characterRepository;

        public HeroesController(CharacterRepository characterRepository)
        {
            _characterRepository = characterRepository;
        }

        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            // List<Character> heroes = new List<Character>
            // {
            //     new Character
            //     {
            //         Name = "Mario",
            //         Id = 5
            //     }
            // };

            List<Character> heroes = _characterRepository.GetAll();

            return Ok(heroes);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
