using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    public class CalculoLetras:Persona
    {
        public int ContarLetrasDiferentes(string NombreActual, string NombreNuevo)
        {
            int ContadorDiferentes = 0;
            char[] NombreNuevoEnChar=NombreNuevo.ToCharArray();
            char[] NombreActualEnChar=NombreActual.ToCharArray();
            foreach (var item in NombreNuevoEnChar)
            {
                if (NombreActualEnChar.Contains(item))
                    ContadorDiferentes++;
              
                   

            }
            return ContadorDiferentes;

}
    }
}
