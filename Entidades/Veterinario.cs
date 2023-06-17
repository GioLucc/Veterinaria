using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    public class Veterinario : Usuario

    {
        private String especialidad;
        private bool atendiendo;

        public Veterinario()
        {

        }

        public Veterinario(string nombre, string especialidad)
     : base(0, nombre, "", 0, 0, string.Empty, string.Empty, true, 0f)
        {
            this.Especialidad = especialidad;
            this.Atendiendo = false; // Valor predeterminado para el estado de atendiendo
        }


        public Veterinario(short id, string nombre, string apellido, int dni, int edad, string nombreUsuario, string clave, bool activo, float sueldo, string especialidad, bool atendiendo) : base(id, nombre, apellido, dni, edad, nombreUsuario, clave, activo, sueldo)
        {
            this.especialidad = especialidad;
            this.atendiendo = atendiendo;
        } 

        

        public string Especialidad { get => especialidad; set => especialidad = value; }
        public bool Atendiendo { get => atendiendo; set => atendiendo = value; }

        
    }
}
