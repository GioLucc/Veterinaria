using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ConfigApp
    {
        private Color primario;
        private Color secundario;

        public ConfigApp(Color primario, Color secundario)
        {
            this.primario = primario;
            this.secundario = secundario;
        }

        private void cambiarTema(Color colorPrimario, Color colorSecundario)
        {
            this.primario = colorPrimario;
            this.secundario = colorSecundario;
        }
    }
}
