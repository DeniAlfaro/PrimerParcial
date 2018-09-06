using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Platillos
    {
        public string Identificador { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public float Precio { get; set; }

        public Platillos()
        {
            new List<Ingredientes>();
        }

        public Platillos(float precio)
        {
            Precio = precio;
            if (precio <= 50)
            {
                Console.WriteLine("El platillo no se puede vender");
            } else
            {
                Console.WriteLine("El precio del platillo es: " + precio);
            }
            Console.ReadLine();
        }

    }
}
