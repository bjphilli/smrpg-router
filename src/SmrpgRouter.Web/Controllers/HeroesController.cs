using System.Collections.Generic;

using SmrpgRouter.DAL;
using SmrpgRouter.Entities;

using Microsoft.AspNetCore.Mvc;

namespace SmrpgRouter.Web.Controllers
{
    [Route("api/characters")]
    public class HeroesController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            CharacterRepository repo = new CharacterRepository();
            List<Character> heroes = repo.GetAll();

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
