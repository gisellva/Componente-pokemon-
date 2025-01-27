using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonComponent
{
    public  class  PokemonManager:InMemoryPokemonRepository
    {
        private readonly IPokemonRepository _repository;

        public PokemonManager(IPokemonRepository repository)
        { 
         _repository = repository;
        }
        public void RegisterPokemon(Pokemon pokemon) 
        {
         _repository.AddPokemon(pokemon);
        }
        public Pokemon FindPokemonById(int id) 
        {
            return _repository.GetPokemonById(id);
        }
        public IEnumerable<Pokemon>FindAllPokemon()
        {
            return _repository.GetAllPokemons();
        }
    }
}
