using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mascota : Animal
    {
        private List<String> historialClinico;
        private int idDueño;
        private string nombreMascota;
        private string nombreDueño;
        private string malestarActual;
        private int edad;
        DateTime fechaDeNacimiento;

        public Mascota(string especie, string raza, float peso, char sexo, string enfermedadActual, string nombreMascota, string nombreDueño, int idDueño, DateTime fechaDeNacimiento) : base(especie, raza, peso, sexo)
        {
            this.malestarActual = enfermedadActual;
            this.nombreMascota = nombreMascota;
            this.edad = CalcularEdad();
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.nombreDueño = nombreDueño;
            this.idDueño = idDueño;
            historialClinico = new List<String>(); // Clase historia medica
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ToString());
            sb.AppendLine($"◉ Malestar: {malestarActual}");
            sb.AppendLine($"◉ Nombre: {nombreMascota}");
            sb.AppendLine($"◉ Nombre del Dueño: {nombreDueño}");
            sb.AppendLine($"◉ ID Dueño: {idDueño}");
            sb.AppendLine($"◉ Fecha De Nacimiento: {fechaDeNacimiento.Date}");
            sb.AppendLine($"◉ Edad: {edad}");
            sb.AppendLine("");

            return sb.ToString();
        }

        public int CalcularEdad()
        {
            DateTime fechaNacimiento = this.fechaDeNacimiento;
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - fechaNacimiento.Year;

            if (fechaActual < fechaNacimiento.AddYears(edad))
            {
                edad--;
            }

            return edad;
        }


        public List<string> HistorialClinico { get => historialClinico; set => historialClinico = value; }
        public int IdDueño { get => idDueño; set => idDueño = value; }
        public string NombreMascota { get => nombreMascota; set => nombreMascota = value; }
        public string NombreDueño { get => nombreDueño; set => nombreDueño = value; }
        public string MalestarActual { get => malestarActual; set => malestarActual = value; }
        public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
        public int Edad { get => edad; set => edad = value; }



    }
}
