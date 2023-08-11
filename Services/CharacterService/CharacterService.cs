using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Models;

namespace dotnet_rpg.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character>(){
            new Character(),
            new Character{Id =1,Name = "Luffy"}
        };
        public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter)
        {
            var serviceResponse = new ServiceResponse<List<Character>>();
            characters.Add(newCharacter);
            serviceResponse.Data = characters;
            return serviceResponse;
        }

        public async Task<ServiceResponse<Character>> GetCharacterById(int id)
        {
            var serviceResponse = new ServiceResponse<Character>();
            var character = characters.FirstOrDefault(c => c.Id == id);
            // if (character is not null)
            // {
            //     serviceResponse.Data = character;
            //     return serviceResponse;
            // }
            // else
            // {
            //     throw new Exception("Character does not exist");
            // }
            serviceResponse.Data = character;
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Character>>> GetCharacters()
        {
            var serviceResponse = new ServiceResponse<List<Character>>
            {
                Data = characters
            };
            return serviceResponse;
        }
    }
}