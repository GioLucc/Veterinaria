using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mascota
    {
        private List<String> historialClinico;
        private int idMascota;
        private string nombreAnimal;
        private string apellidoDueño;
        private int edad;
        private string especie;
        private string raza;
        private float peso;
        private char sexo;
        DateTime fechaDeNacimiento;

        public Mascota()
        {

        }

        public Mascota(string especie, string raza, float peso, char sexo)
        {
            this.especie = especie;
            this.raza = raza;
            this.peso = peso;
            this.especie = especie;
            this.sexo = sexo;
        }
        public Mascota(string especie, string raza, float peso, char sexo, string nombreAnimal, string apellidoDueño, int idMascota, DateTime fechaDeNacimiento) : this(especie, raza, peso, sexo)
        {

            this.nombreAnimal = nombreAnimal;
            this.fechaDeNacimiento = fechaDeNacimiento.Date;
            this.edad = Sistema.CalcularEdad(fechaDeNacimiento);
            this.apellidoDueño = apellidoDueño;
            this.idMascota = idMascota;
            historialClinico = new List<String>(); // Clase historia medica
        }

        public string Especie { get => especie; set => especie = value; }
        public string Raza { get => raza; set => raza = value; }
        public float Peso { get => peso; set => peso = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public List<string> HistorialClinico { get => historialClinico; set => historialClinico = value; }
        public int IdMascota { get => idMascota; set => idMascota = value; }
        public string NombreAnimal { get => nombreAnimal; set => nombreAnimal = value; }
        public string ApellidoDueño { get => apellidoDueño; set => apellidoDueño = value; }
        public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
        public int Edad { get => edad; set => edad = value; }

        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"◉ Especie: {especie}");
            sb.AppendLine($"◉ Raza: {raza}");
            sb.AppendLine($"◉ Peso: {peso}");
            sb.AppendLine($"◉ Sexo: {sexo}");
            sb.AppendLine($"◉ Nombre: {nombreAnimal}");
            sb.AppendLine($"◉ Nombre del Dueño: {apellidoDueño}");
            sb.AppendLine($"◉ ID Dueño: {idMascota}");
            sb.AppendLine($"◉ Fecha De Nacimiento: {this.fechaDeNacimiento.Date}");
            sb.AppendLine($"◉ Edad: {edad}");
            sb.AppendLine("");

            return sb.ToString();
        }




    



    }
}
