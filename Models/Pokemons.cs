using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace PokeDex.Models
{
    public class Pokemons
    {
        [Key]
        public int PokemonID { get; set; }

        [Required(ErrorMessage = "Pokemon name required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Pokemon picture required")]
        public string Picture { get; set; }

        [Required(ErrorMessage = "Pokemon region required")]
        public string Region { get; set; }

        [Required(ErrorMessage = "Pokemon type required")]
        public string Primary { get; set; }

        [Required(ErrorMessage = "Pokemon type required")]
        public string Secondary { get; set; }


      


    }
}
