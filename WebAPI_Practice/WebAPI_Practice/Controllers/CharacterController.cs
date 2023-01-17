using Microsoft.AspNetCore.Mvc;
using WebAPI_Practice.Models;
using WebAPI_Practice.Services;
using WebAPI_Practice.Services.CharacterService;

namespace WebAPI_Practice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : Controller
    { 
        private readonly ICharacterService _CharacterService;
        public CharacterController(ICharacterService characterService)
        {
            _CharacterService = characterService;
        }
        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<Character>>>> Get()
        {
            return Ok(await _CharacterService.GetAllCharacters());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<Character>>> GetSingle(int id)
        {
            return Ok(await _CharacterService.GetCharacterById(id));
        }
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Character>>>> AddCharacter(Character newCharacter)
        {
            _CharacterService.AddCharacter(newCharacter);
            return Ok(await _CharacterService.GetAllCharacters());
        }
        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<List<Character>>>> DelCharacter(int id)
        {
            _CharacterService.DelCharacterById(id);
            return Ok(await _CharacterService.GetAllCharacters());
        }
    }
} 
