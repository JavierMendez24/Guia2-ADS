using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cinema.Models;

namespace cinema.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes/Persona
        public ActionResult Persona()
        {
            var cliente = new Cliente() { Id = 1, Nombre = "Fulano", Edad = 23, DUI = "12345678-9", Direccion = "Una casa a la par de la otra", Telefono = "2424-2424" };
            return View(cliente);
        }
    }
}