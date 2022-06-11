using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PokeDex.Models
{
    public class Regions
    {
        [Required(ErrorMessage = "Pokemon region required")]
        public string Region { get; set; }
    }
}
