namespace Entidades
{
    public class Persona
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

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}