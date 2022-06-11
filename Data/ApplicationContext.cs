using Microsoft.EntityFrameworkCore;
using PokeDex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokeDex.Data
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext>options) : base(options) 
        { }
        public DbSet<Pokemons>Pokemons { get; set; }
    }
}
