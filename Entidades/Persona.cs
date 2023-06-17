using System.Text;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(Usuario))]
    [XmlInclude(typeof(Veterinario))]
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private int dni;
        private int edad;
       
        public Persona(string nombre, string apellido, int dni, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
        }

        public Persona()
        {

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public int Edad { get => edad; set => edad = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"◉ Nombre: {nombre}");
            sb.AppendLine($"◉ Apellido: {apellido}");
            sb.AppendLine($"◉ DNI: {dni}");
            sb.AppendLine($"◉ Edad: {edad}");
            sb.AppendLine("");

            return sb.ToString();
        }

        //public static bool operator ==(Persona persona1, Persona persona2)
        //{
        //    bool resultado = false;

        //    if (persona1.dni == persona2.dni)
        //    {
        //        resultado = true;
        //    }
        //    return resultado;
        //}

        //public static bool operator !=(Persona persona1, Persona persona2)
        //{
        //    return !(persona1 == persona2);
        //}
    }
}