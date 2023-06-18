﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class HistorialMedico
    {
        private DateTime fecha;
        private string malestar;
        private string tratamientoAplicado;
        private string veterinarioQueAtendio;

        public HistorialMedico(DateTime fecha, string malestar, string tratamientoAplicado, string veterinarioQueAtendio)
        {
            this.fecha = fecha;
            this.malestar = malestar;
            this.tratamientoAplicado = tratamientoAplicado;
            this.veterinarioQueAtendio = veterinarioQueAtendio;
        }

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Malestar { get => malestar; set => malestar = value; }
        public string TratamientoAplicado { get => tratamientoAplicado; set => tratamientoAplicado = value; }
        public string VeterinarioQueAtendio { get => veterinarioQueAtendio; set => veterinarioQueAtendio = value; }



        //public void AgregarConsulta(DateTime fechaConsulta, string anotaciones)
        //{

        //}


    }
}
