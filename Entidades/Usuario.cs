using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    
    public class Usuario : Persona
    {
        public enum Jerarquia
        {
            Administrador,
            Recepcionista,
            Veterinario,
        }
        private short id;
        private string nombreUsuario;
        private string contraseniaUsuario;
        private bool activo;
        private float sueldo;
        private Jerarquia jerarquiaUsuario;

        public Usuario()
        {

        }

        public Usuario(short id, string nombre, string apellido, int dni, int edad, string nombreUsuario, string clave, Jerarquia jerarquia, bool activo, float sueldo) : base(nombre, apellido, dni, edad)
        {
            this.id = id;
            this.nombreUsuario = nombreUsuario;
            this.ContraseniaUsuario = clave;

            this.jerarquiaUsuario = jerarquia;
            this.activo = activo;
            this.sueldo = sueldo;
        }

        public short Id { get => id; set => id = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string ContraseniaUsuario { get => contraseniaUsuario; set => contraseniaUsuario = value; }

        public bool Activo { get => activo; set => activo = value; }
        public float Sueldo { get => sueldo; set => sueldo = value; }
        public Jerarquia JerarquiaUsuario { get => jerarquiaUsuario; set => jerarquiaUsuario = value; }

        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"◉ ID: {Id}");
            sb.AppendLine($"◉ Nombre de Usuario: {NombreUsuario}");
            sb.AppendLine($"◉ Contraseña: {ContraseniaUsuario}");
            sb.AppendLine($"◉ Jerarquía: {jerarquiaUsuario}");
            sb.AppendLine($"◉ Activo: {Activo}");
            sb.AppendLine($"◉ Sueldo: {Sueldo:C}");
            sb.AppendLine("");

            return sb.ToString();
        }

        public string MostrarInformacionTurno()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"◉ ID: {Id}");
            sb.AppendLine(base.ToString());
            sb.AppendLine("");

            return sb.ToString();
        }
    }
}
