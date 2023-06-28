using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades.Archivos_y_Serializadores
{
    public class SerializadoraXML<T> : IArchivos<T>
    {
        [Serializable]
        public class DiccionarioSerializable<TKey, TValue>
        {
            public TKey Clave { get; set; }
            public TValue Valor { get; set; }
        }
        public void Escribir(string path, T objeto)
        {
            string rutaCarpeta = @"E:\C# UTNFra\CSharp-UTNFra\Veterinaria\ArchivosTexto";
            string rutaArchivo = Path.Combine(rutaCarpeta, "Enfermedades.xml");

            if (!Directory.Exists(rutaCarpeta))
            {
                Directory.CreateDirectory(rutaCarpeta);
            }

            // Convertir el diccionario a una lista de DiccionarioSerializable
            List<DiccionarioSerializable<string, List<string>>> listaSerializable = new List<DiccionarioSerializable<string, List<string>>>();
            foreach (var kvp in (Dictionary<string, List<string>>)Convert.ChangeType(objeto, typeof(Dictionary<string, List<string>>)))
            {
                listaSerializable.Add(new DiccionarioSerializable<string, List<string>>
                {
                    Clave = kvp.Key,
                    Valor = kvp.Value
                });
            }

            using (StreamWriter sw = new StreamWriter(rutaArchivo))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<DiccionarioSerializable<string, List<string>>>));
                ser.Serialize(sw, listaSerializable);
            }
        }

        public T Leer(string path)
        {

            string rutaCarpeta = @"E:\C# UTNFra\CSharp-UTNFra\Veterinaria\ArchivosTexto";
            string rutaArchivo = Path.Combine(rutaCarpeta, "Enfermedades.xml");

            T objetoDeserializado = default(T);

            try
            {
                using (StreamReader sr = new StreamReader(rutaArchivo))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    objetoDeserializado = (T)ser.Deserialize(sr);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al deserializar el archivo XML: " + ex.Message);
            }

            return objetoDeserializado;
        }


        public Dictionary<string, List<string>> LeerMalestar(string path)
        {
            string rutaCarpeta = @"E:\C# UTNFra\CSharp-UTNFra\Veterinaria\ArchivosTexto";
            string rutaArchivo = Path.Combine(rutaCarpeta, "Enfermedades.xml");

            Dictionary<string, List<string>> objetoDeserializado = new Dictionary<string, List<string>>();

            try
            {
                using (StreamReader sr = new StreamReader(rutaArchivo))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<DiccionarioSerializable<string, List<string>>>));
                    var listaSerializable = (List<DiccionarioSerializable<string, List<string>>>)ser.Deserialize(sr);

                    foreach (var diccionarioSerializable in listaSerializable)
                    {
                        objetoDeserializado[diccionarioSerializable.Clave] = diccionarioSerializable.Valor;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al deserializar el archivo XML: " + ex.Message);
            }

            return objetoDeserializado;
        }

    }
}
