using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Menus
    {
        public string Identificador { get; set; }
        public int HoraInicio { get; set; }
        public int HoraFin { get; set; }

        public string Nombre { get; set; }

        public Menus()
        {
            new List<Platillos>();
        }

        public Menus(string nombre)
        {
            Nombre = nombre;
            Nombre = "Nuevo Menu";
        }
    }
}
