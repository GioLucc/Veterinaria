using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ConfigApp
    {
        [JsonProperty]
        private bool banderaColor;
        [JsonProperty]
        private Color colorPrimario;
        [JsonProperty]
        private Color colorSecundario;

        public ConfigApp( bool banderaColor, Color colorPrimario,Color colorSecundario)
        {

            this.banderaColor = banderaColor;
            this.colorPrimario = colorPrimario;
            this.colorSecundario = colorSecundario;
    }

        public bool BanderaColor { get => banderaColor; set => banderaColor = value; }
        public Color ColorPrimario { get => colorPrimario; set => colorPrimario = value; }
        public Color ColorSecundario { get => colorSecundario; set => colorSecundario = value; }

        //private void cambiarTema(bool banderaColor, Color color)
        //{
        //    this.color = color;
        //    this.banderaColor = banderaColor;
        //}
    }
}
