using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Entidades.Archivos_y_Serializadores
{
    internal class ArchivoJSON<T> : IArchivos<T>
    {
        public void Escribir(string path, T elemento)
        {
            throw new NotImplementedException();
        }

        public void Leer(string path)
        {
            throw new NotImplementedException();
        }
    }
}
