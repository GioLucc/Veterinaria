using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Administrador<T> : Usuario, IUtilidades<T> where T : Usuario
    {
        public bool Alta(T elementoAAgregar)
        {
            bool retorno = true;

            foreach (Usuario elemento in Sistema.usuario)
            {
                if(elemento.Dni == elementoAAgregar.Dni)
                {
                    retorno = false;                  
                }
            }
            if(retorno)
            {
                Sistema.usuario.Add(elementoAAgregar);  
            }

            return retorno;
        }

        public bool Baja(T elementoADarDeBaja)
        {
            return true;
        }

        public bool Modificacion(T elementoModificado)
        {
            return true;
        }
    }
}
