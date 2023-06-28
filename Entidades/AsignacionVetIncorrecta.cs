using Entidades.Archivos_y_Serializadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AsignacionVetIncorrecta : Exception
    {
        public AsignacionVetIncorrecta()
        {
        }

        public AsignacionVetIncorrecta(string mensaje) : base(mensaje)
        {

            
        } 
    }
}
