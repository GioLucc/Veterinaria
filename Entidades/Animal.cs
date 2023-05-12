using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Animal
    {
        private string especie;
        private string raza;
        private float peso;
        private char sexo;

        public Animal(string especie, string raza, float peso, char sexo)
        {
            this.especie = especie;
            this.raza = raza;
            this.peso = peso;
            this.especie = especie;
            this.sexo = sexo;
        }

        public string Especie { get => especie; set => especie = value; }
        public string Raza { get => raza; set => raza = value; }
        public float Peso { get => peso; set => peso = value; }
        public char Sexo { get => sexo; set => sexo = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"◉ Especie: {especie}");
            sb.AppendLine($"◉ Raza: {raza}");
            sb.AppendLine($"◉ Peso: {peso}");
            sb.AppendLine($"◉ Sexo: {sexo}");

            return sb.ToString();
        }


    }
}
