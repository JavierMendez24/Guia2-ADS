using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cinema.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public int Edad { get; set; }
        public String Telefono { get; set; }
        public String DUI { get; set; }
        public String Direccion { get; set; }
    }
}