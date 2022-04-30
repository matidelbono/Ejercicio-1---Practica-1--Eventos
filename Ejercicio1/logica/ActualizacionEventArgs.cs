using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    public class ActualizacionEventArgs:EventArgs
    {
        public string NombreNuevo{ get; set; }
        public int TotalLetrasDiferentes { get; set; }
    }

}
