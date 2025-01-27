   using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonComponent
{
    public interface IPokemonRepository
    {
       void AddPokemon(Pokemon pokemon);
       Pokemon GetPokemonById(int id);
       IEnumerable<Pokemon> GetAllPokemons();
    }
}
