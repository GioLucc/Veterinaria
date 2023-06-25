using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Turno
    {
        public enum PrioridadAtencion
        {
            Urgente,
            Media,
            Normal,
        }
        public enum EstadoDeTurno
        {
            SinVeterinario,
            VeterinarioAsignado,
            EnAtencion,
            Atendido,
            Pagado,
        }

        private DateTime fecha;
        private Mascota mascota;
        private Veterinario veterinario;
        private String malestarActual;
        private PrioridadAtencion urgenciaAtencion;
        private EstadoDeTurno estadoTurno;
        private float costoDeTurno;

        public Turno()
        {

        }

        public Turno(DateTime fecha, Mascota mascota, string malestarActual, PrioridadAtencion urgenciaAtencion, EstadoDeTurno estadoTurno)
        {
            Fecha = fecha;
            Mascota = mascota;
            this.malestarActual = malestarActual;
            this.urgenciaAtencion = urgenciaAtencion;
            this.estadoTurno = estadoTurno;
            costoDeTurno = 2500;
        }

        public Turno(DateTime fecha, Mascota mascota, Veterinario veterinario, string malestarActual, PrioridadAtencion urgenciaAtencion, EstadoDeTurno estadoTurno) : this(fecha, mascota, malestarActual, urgenciaAtencion, estadoTurno)
        {
            this.veterinario = veterinario;
        }


        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Mascota Mascota { get => mascota; set => mascota = value; }
        public Veterinario Veterinario { get => veterinario; set => veterinario = value; }
        public string MalestarActual { get => malestarActual; set => malestarActual = value; }
        public PrioridadAtencion UrgenciaAtencion { get => urgenciaAtencion; set => urgenciaAtencion = value; }
        public EstadoDeTurno EstadoTurno { get => estadoTurno; set => estadoTurno = value; }
        public string Nombre
        {
            get => this.mascota.NombreAnimal;
        }
        public string Apellido
        {
            get => this.mascota.ApellidoDueño;
        }
        public int Edad
        {
            get => this.mascota.Edad;
        }
        public string NombreVet
        {
            get => this.veterinario.Nombre;
        }
        public string EspecialidadVet
        {
            get => this.veterinario.Especialidad;
        }
        public float CostoDeTurno
        {
            get => costoDeTurno;
            set => costoDeTurno = value;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ToString());
            sb.AppendLine($"{Fecha.Date}");
            sb.AppendLine("");
            sb.AppendLine(Mascota.ToString());
            sb.AppendLine("");
            sb.AppendLine($"");

            sb.AppendLine("");

            return sb.ToString();
        }

        public static Dictionary<String,String> BuscarEnfermedadPorGravedad(String malestarMascota)
        {
            bool banderaEncontrada = false;
            Dictionary<string, string> enfermedadEncontrada = new Dictionary<string, string>();
            if (malestarMascota is not null)
            {
                String? malestarSeleccionado = malestarMascota;

                foreach (var kvp in Sistema.malestaresPorGravedad)
                {
                    List<String> malestares = kvp.Value;
                    if (malestares.Contains(malestarSeleccionado))
                    {
                        foreach (string item in malestares)
                        {
                            if(item == malestarSeleccionado)
                            {
                                enfermedadEncontrada[kvp.Key] = item;
                                banderaEncontrada |= true;
                                break;
                            }
                            
                        }                    
                    }
                }  
                
                if(banderaEncontrada == false)
                {
                    enfermedadEncontrada["0"] = "0";
                }
            }

            return enfermedadEncontrada;
        }

    }
}
