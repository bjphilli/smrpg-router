using System.Collections.Generic;

using SmrpgRouter.DAL;
using SmrpgRouter.Domain;

using Microsoft.AspNetCore.Mvc;

namespace SmrpgRouter.Api.Controllers
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
            List<Character> heroes = _characterRepository.GetAll();
            return Ok(heroes);
        }
    }
}
