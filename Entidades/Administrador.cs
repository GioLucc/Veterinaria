using Entidades.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Entidades
{
    [Serializable]
    public sealed class Administrador: Usuario, IUtilidades<Usuario>
    {
        private string linkFire = "https://console.firebase.google.com/project/veterinaria-ed4cf/firestore/data/~2Fusuarios~2FDT7oTGUt6wMghwYLS6Tw?hl=es-419";
        private int intentos = 0;
        private string correoElectronico;


        public Administrador()
        {

        }

        public Administrador(short id,string nombre, string apellido, int dni, int edad,string nombreUsuario, string clave, bool activo, float sueldo, string correoElectronico) : base(id,nombre,apellido,dni,edad,nombreUsuario,clave,activo, sueldo)
        {
            this.correoElectronico = correoElectronico;
        }

        public bool Alta(Usuario elementoAAgregar)
        {
            bool retorno = true;
            VeterinarioDAO vetDAO = new VeterinarioDAO();

            vetDAO.AgregarVeterinario((Veterinario)elementoAAgregar);

            return retorno;
        }

        public bool Baja(Usuario elementoADarDeBaja)
        {
            return true;
        }

        public bool Modificacion(Usuario elementoModificado)
        {
            return true;
        }

        //public override Usuario LoguearUsuario(string usuario, string contraseña)
        //{
        //    Usuario usuarioALoguear = new Usuario();

        //    usuarioALoguear = base.LoguearUsuario(usuario, contraseña);
        //    if(usuarioALoguear is null)
        //    {
        //        intentos++;
        //        if(intentos > 2)
        //        {

        //        }



        //    }
            
            



            
        //}
    }
}
