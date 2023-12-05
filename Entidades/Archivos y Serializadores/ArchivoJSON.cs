using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Entidades.Archivos_y_Serializadores
{
    public class ArchivoJSON<T> : IArchivos<T>
    {
        static string path;

        public T Leer(string path)
        {
            T info = default;
            string rutaCarpeta = (@"F:\\C# UTNFra\\CSharp-UTNFra\\Veterinaria\\ArchivosTexto");
            string rutaArchivo = Path.Combine(rutaCarpeta, path);

            try
            {
                string contenido = File.ReadAllText(rutaArchivo);
                info = JsonConvert.DeserializeObject<T>(contenido);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al leer el archivo JSON: " + ex.Message);
            }

            return info;
        }

        public void Escribir(string path, T datoAEscribir)
        {
            string rutaCarpeta = (@"F:\\C# UTNFra\\CSharp-UTNFra\\Veterinaria\\ArchivosTexto");
            string rutaArchivo = Path.Combine(rutaCarpeta, "config.json");
            path = rutaArchivo;

            if (!Directory.Exists(rutaCarpeta))
            {
                Directory.CreateDirectory(rutaCarpeta);
            }

            try
            {
                string contenido = JsonConvert.SerializeObject(datoAEscribir);
                File.WriteAllText(path, contenido);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al escribir en el archivo JSON: " + ex.Message);
            }
        }  
    }
}
