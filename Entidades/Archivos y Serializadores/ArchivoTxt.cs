using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;


namespace Entidades.Archivos_y_Serializadores
{
    public class ArchivoTxt : IArchivos<string>
    {
        public void Logger(Exception ex)
        {
            string error;
            try
            {
                StackTrace stackTrace = new StackTrace(ex);
                StackFrame[] stackFrames = stackTrace.GetFrames();

                if (stackFrames.Length > 0)
                {
                    // Obtener el primer marco de la pila de llamadas (el más reciente)
                    StackFrame topFrame = stackFrames[0];

                    // Obtener el método y la clase donde ocurrió la excepción
                    string methodName = topFrame.GetMethod().Name;
                    string className = topFrame.GetMethod().DeclaringType.FullName;

                    // Imprimir la información
                    error = $"La excepción ocurrió en el método {methodName} de la clase {className}.";

                    this.Escribir(error,"a");
                }
            }
            catch
            {
                
            }
        }

        public void Leer(string path)
        {

        }

        public void Escribir(string datoAEscribir, string path)
        {
            string horaError = DateTime.Now.ToString();
            string rutaCarpeta = (@"E:\\C# UTNFra\\CSharp-UTNFra\\Veterinaria\\ArchivosTexto");
            string rutaArchivo = Path.Combine(rutaCarpeta, "Logger.txt");

            if (!Directory.Exists(rutaCarpeta))
            {
                Directory.CreateDirectory(rutaCarpeta);
            }
            try
            {
                
                using (StreamWriter sw1 = new StreamWriter(rutaArchivo,true))
                {
                    sw1.WriteLine(horaError + " " + datoAEscribir);
                }
            }
            catch
            {
                throw new Exception("Hubo un problema al intentar escribir en el archivo");
            }
        }
    }


}
