using System.Reflection.Emit;
using System.Xml.Linq;

namespace PokemonComponent
{
    public class Pokemon
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Level { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }

        public Pokemon(int id, string name, string type, int level, int attack, int defense)
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.Level = level;
            this.Attack = attack;
            this.Defense = defense;
        }
    }
}
