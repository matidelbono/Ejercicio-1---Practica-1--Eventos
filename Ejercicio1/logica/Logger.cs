using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    public  class Logger:Persona
    {
        public string  ImprimirActualizacion(string NombreActual, string NombreNuevo)
        {
            return ($"el Nombre fue modificado de{NombreActual} a {NombreNuevo}");
        }
}
}

