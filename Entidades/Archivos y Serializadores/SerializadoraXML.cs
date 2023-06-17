using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades.Archivos_y_Serializadores
{
    public class SerializadoraXML<T> : IArchivos<T>
    {
        public void Escribir(string path, T objeto)
        {


            string rutaCarpeta = (@"E:\\C# UTNFra\\CSharp-UTNFra\\Veterinaria\\ArchivosTexto");
            string rutaArchivo = Path.Combine(rutaCarpeta, "Objeto.xml");

            if (!Directory.Exists(rutaCarpeta))
            {
                Directory.CreateDirectory(rutaCarpeta);
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(rutaArchivo,true))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    ser.Serialize(sw, objeto);
                }
            }        
        }

        public void Leer(string path)
        {
            throw new NotImplementedException();
        }
    }
}
