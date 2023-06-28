using Entidades.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public class Recepcionista : Usuario , IUtilidades<Mascota>
    {
        public Recepcionista()
        {

        }

        public Recepcionista(short id, string nombre, string apellido, int dni, int edad, string nombreUsuario, string clave, bool activo, float sueldo) : base(id, nombre, apellido, dni, edad, nombreUsuario, clave, activo, sueldo)
        {

        }

        public bool Alta(Mascota elementoAAgregar)
        {  
            bool retorno = true;

            MascotaDAO.Agregar(elementoAAgregar);


            return retorno;            
        }

        public bool Baja(Mascota elementoADarDeBaja)
        {
            return true;
        }

        public bool Modificacion(Mascota elementoModificado)
        {
            return true;
        }

        public void CrearNuevoTurno(string malestar, Mascota animal, DateTime fecha, string prioridadAtencion)
        {
            Veterinario vetProvisorio = new Veterinario("", "");

            switch (prioridadAtencion)
            {
                case "Normal":
                    Turno turnoACrear = new Turno(fecha, animal, vetProvisorio, malestar, Turno.PrioridadAtencion.Normal, Turno.EstadoDeTurno.SinVeterinario);
                    Sistema.turnos.Add(turnoACrear);
                    break;
                case "Media":
                    Turno turnoACrearMedio = new Turno(fecha, animal, vetProvisorio, malestar, Turno.PrioridadAtencion.Media, Turno.EstadoDeTurno.SinVeterinario);
                    Sistema.turnos.Add(turnoACrearMedio);
                    break;

                default:
                    Turno turnoACrearUrgente = new Turno(fecha, animal, vetProvisorio, malestar, Turno.PrioridadAtencion.Urgente, Turno.EstadoDeTurno.SinVeterinario);
                    Sistema.turnos.Add(turnoACrearUrgente);
                    break;
            }
        }

        public void CrearNuevoTurno(string malestar, Mascota animal, DateTime fecha, string prioridadAtencion, Veterinario veterinario)
        {

            switch (prioridadAtencion)
            {
                case "Normal":
                    Turno turnoACrear = new Turno(fecha, animal, veterinario, malestar, Turno.PrioridadAtencion.Normal, Turno.EstadoDeTurno.SinVeterinario);
                    Sistema.turnos.Add(turnoACrear);
                    break;
                case "Medio":
                    Turno turnoACrearMedio = new Turno(fecha, animal, veterinario, malestar, Turno.PrioridadAtencion.Media, Turno.EstadoDeTurno.SinVeterinario);
                    Sistema.turnos.Add(turnoACrearMedio);
                    break;

                default:
                    Turno turnoACrearUrgente = new Turno(fecha, animal, veterinario, malestar, Turno.PrioridadAtencion.Urgente, Turno.EstadoDeTurno.SinVeterinario);
                    Sistema.turnos.Add(turnoACrearUrgente);
                    break;
            }
        }
    }
}
