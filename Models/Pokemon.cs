﻿namespace PokemonBlazor.Models
{
    public class Pokemon
    {
        public int id { get; set; }
        public string name { get; set; }
        public int height { get; set; }
        public int weight { get; set; }
        public Sprites sprites { get; set; }
        public List<Stat> stats { get; set; }
        public List<Type> types { get; set; }

        //public List<Ability> abilities { get; set; }
        //public int base_experience { get; set; }
        //public Cries cries { get; set; }
        //public List<Form> forms { get; set; }
        //public List<GameIndex> game_indices { get; set; }
        //public List<HeldItem> held_items { get; set; }
        //public bool is_default { get; set; }
        //public string location_area_encounters { get; set; }
        //public List<Move> moves { get; set; }
        //public int order { get; set; }
        //public List<PastAbility> past_abilities { get; set; }
        //public List<object> past_types { get; set; }
        //public Species species { get; set; }
        
        
    }
}
