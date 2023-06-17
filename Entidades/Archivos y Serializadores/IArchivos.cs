using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Archivos_y_Serializadores
{
    internal interface IArchivos<T>
    {
        public void Leer(string path);
        public void Escribir(string path, T datoAEscribir);
    }
}
