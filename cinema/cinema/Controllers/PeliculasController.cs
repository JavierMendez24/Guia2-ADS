using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cinema.Models;

namespace cinema.Controllers
{
    public class PeliculasController : Controller
    {
        // GET: Peliculas/Aleatorias
        public ActionResult Aleatorias()
        {
            var pelicula = new Pelicula() {Id = 1, Nombre = "Shrek", Genero = "Comedia", Año_Lanzamiento = 2001, Clasificacion = "PG" };

            return View(pelicula);
        }
    }
}