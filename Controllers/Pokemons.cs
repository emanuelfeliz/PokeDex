using Microsoft.AspNetCore.Mvc;
using PokeDex.Data;
using PokeDex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace PokeDex.Controllers
{
    public class Pokemons : Controller
    {

        private readonly ApplicationContext context;

        public Pokemons(ApplicationContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var result = context.Pokemons.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Pokemons pokemons)
        {
            if (ModelState.IsValid)
            {
                var poke = new Pokemons()
                {
                    Name = pokemons.Name,
                    Picture = pokemons.Picture,

                };
                context.Pokemons.Add(poke);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                TempData["error"] = "Empty field Can't Submit";
                return View(pokemons);
            }
            
        }
    }
}
