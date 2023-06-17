using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Recepcionista<T> : Usuario , IUtilidades<T> where T : Mascota
    {
        public bool Alta(T elementoAAgregar)
        {  
            bool retorno = true;

            foreach (Mascota elemento in Sistema.AnimalDomesticos)
            {
                if (elemento.NombreAnimal == elementoAAgregar.NombreAnimal 
                    && elemento.ApellidoDueño == elementoAAgregar.ApellidoDueño)
                {
                    retorno = false;
                }
            }
            if (retorno)
            {
                Sistema.AnimalDomesticos.Add(elementoAAgregar);
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

        public void CrearNuevoTurno(string malestar, Mascota animal, DateTime fecha, string prioridadAtencion)
        {
            Veterinario vetProvisorio = new Veterinario("", "");

            switch (prioridadAtencion)
            {
                case "Normal":
                    Turno turnoACrear = new Turno(fecha, animal, vetProvisorio, malestar, Turno.PrioridadAtencion.Normal, Turno.EstadoDeTurno.SinVeterinario);
                    Sistema.turnos.Add(turnoACrear);
                    break;
                case "Medio":
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
