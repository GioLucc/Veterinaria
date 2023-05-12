using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario:Persona
    {
        private short id;
        private string nombreUsuario;
        private string contraseniaUsuario;
        private bool administrador;
        private Jerarquia jerarquia;
        private bool activo;



        public Usuario(short id, string nombre, string apellido, int dni, int edad, string nombreUsuario, string clave, bool administrador, Jerarquia jerarquia, bool activo) : base(nombre,apellido,dni,edad)
        {
            this.id = id;
            this.nombreUsuario = nombreUsuario;
            this.ContraseniaUsuario = clave;
            this.administrador = administrador;
            this.jerarquia = jerarquia;
            this.activo = activo;
        }

        public short Id { get => id; set => id = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string ContraseniaUsuario { get => contraseniaUsuario; set => contraseniaUsuario = value; }
        public bool Administrador { get => administrador; set => administrador = value; }
        public Jerarquia Jerarquia { get => jerarquia; set => jerarquia = value; }
        public bool Activo { get => activo; set => activo = value; }
    }
}
