using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonComponent
{
    public class InMemoryPokemonRepository : IPokemonRepository
    {
        private readonly List<Pokemon> _pokemons = new List<Pokemon>();

        public void AddPokemon(Pokemon pokemon)
        {
            _pokemons.Add(pokemon);
        }

        public Pokemon GetPokemonById(int id)
        {
            return _pokemons.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Pokemon> GetAllPokemons()
        {
            return _pokemons;
        }
    }
}
