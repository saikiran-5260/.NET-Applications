using WebAPI_Practice.Models;
using WebAPI_Practice.Services.CharacterService;

namespace WebAPI_Practice.Services
{
    public class CharacterServices : ICharacterService
    {
        private static List<Character> Characters = new List<Character> {
            new Character(),
            new Character(){Id=1,Name="Praveen",HitPoints =100,Strength= 30,Defence=20,Intelligence=10}
        };

        public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter)
        {
            var serviceResponse = new ServiceResponse<List<Character>>();
            Characters.Add(newCharacter);
            serviceResponse.Data = Characters;
            return serviceResponse;
        }

        public async Task<ServiceResponse<Character>> DelCharacterById(int id)
        {
            var serviceResponse = new ServiceResponse<Character>();
            var character = Characters.FirstOrDefault(c => c.Id == id);
            Characters.Remove(character);
            serviceResponse.Data = character;
            return serviceResponse; 
        }

     

        public async Task<ServiceResponse<Character>> GetCharacterById(int id)
        {
            var serviceResponse = new ServiceResponse<Character>();
            var character = Characters.FirstOrDefault(c=>c.Id == id);   
            serviceResponse.Data = character;
            return serviceResponse;
          
        }

        public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
        {
            var serviceResponse = new ServiceResponse<List<Character>>();
            serviceResponse.Data = Characters;
            return serviceResponse;
        }
    }
}
