using PokemonComponent;

namespace Componente_de_pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear repositorio en memoria
            var repository = new InMemoryPokemonRepository();

            // Crear instancia del manejador de Pokémon
            var manager = new PokemonManager(repository);

            // Agregar Pokémon
            manager.RegisterPokemon(new Pokemon(1, "Pikachu", "Electric", 10, 50, 30));
            manager.RegisterPokemon(new Pokemon(2, "Charmander", "Fire", 8, 40, 25));


            var foundPokemon = manager.FindPokemonById(1);
            Console.WriteLine($"Encontrado: {foundPokemon.Name}, Tipo: {foundPokemon.Type}");



            // Ahora puedes buscar el Pokémon por su ID
            foreach (var pokemon in repository.GetAllPokemons())
            {
                Console.WriteLine($"ID: {pokemon.Id}, Nombre: {pokemon.Name}, Tipo: {pokemon.Type}");
            }

        }
    }
}
