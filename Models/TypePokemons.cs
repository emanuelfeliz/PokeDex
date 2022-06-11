using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PokeDex.Models
{
    public class TypePokemons
    {
        [Required(ErrorMessage = "Pokemon type required")]
        public string TypePokemon { get; set; }


    }
}
