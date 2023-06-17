using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    public sealed class Veterinario : Usuario

    {
        private String especialidad;
        private List<String> diasDeTrabajo;
        private bool atendiendo;

        public Veterinario()
        {

        }

        public Veterinario(string nombre, string especialidad)
     : base(0, nombre, "", 0, 0, string.Empty, string.Empty, Usuario.Jerarquia.Veterinario, true, 0f)
        {
            this.Especialidad = especialidad;
            this.Atendiendo = false; // Valor predeterminado para el estado de atendiendo
        }


        public Veterinario(short id, string nombre, string apellido, int dni, int edad, string nombreUsuario, string clave, Usuario.Jerarquia jerarquia, bool activo, float sueldo, string especialidad, bool atendiendo) : base(id, nombre, apellido, dni, edad, nombreUsuario, clave, jerarquia, activo, sueldo)
        {
            diasDeTrabajo = new List<String>();
            this.especialidad = especialidad;
            this.atendiendo = atendiendo;
        } 

        

        public string Especialidad { get => especialidad; set => especialidad = value; }
        public bool Atendiendo { get => atendiendo; set => atendiendo = value; }

        
    }
}
