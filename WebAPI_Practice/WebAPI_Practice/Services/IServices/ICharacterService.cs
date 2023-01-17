using WebAPI_Practice.Models;

namespace WebAPI_Practice.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<Character>>> GetAllCharacters();
        Task<ServiceResponse<Character>> GetCharacterById(int id);
        Task<ServiceResponse<List<Character>>> AddCharacter( Character newCharacter);
        Task<ServiceResponse<Character>> DelCharacterById(int id);
    }
}
