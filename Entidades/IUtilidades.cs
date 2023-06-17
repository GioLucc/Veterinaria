using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IUtilidades <T>
    {
        bool Alta(T elementoAAgregar);

        bool Baja(T elementoADarDeBaja);

        bool Modificacion(T elementoModificado);
    }
}
