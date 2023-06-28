using Entidades;
using System.Drawing;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BuscarEnfermedadPorGravedad_ExistingMalestar_ReturnsEnfermedadDictionary()
        {
            // Arrange
            string malestarMascota = "Dolor de cabeza";

            // Act
            Dictionary<string, string> result = Turno.BuscarEnfermedadPorGravedad(malestarMascota);

            // Assert
            Assert.IsTrue(result.ContainsKey("Normal"));
            Assert.AreEqual("Dolor de cabeza", result["Normal"]);
            Assert.IsFalse(result.ContainsKey("Media"));
            Assert.IsFalse(result.ContainsKey("Urgente"));
            Assert.IsFalse(result.ContainsKey("0"));
        }

        [TestMethod]
        public void BuscarEnfermedadPorGravedad_NonExistingMalestar_ReturnsEmptyEnfermedadDictionary()
        {
            // Arrange
            string malestarMascota = "Pulgas y Garrapatas";

            // Act
            Dictionary<string, string> result = Turno.BuscarEnfermedadPorGravedad(malestarMascota);

            // Assert
            Assert.IsFalse(result.ContainsKey("Normal"));
            Assert.IsFalse(result.ContainsKey("Media"));
            Assert.IsFalse(result.ContainsKey("Urgente"));
            Assert.IsTrue(result.ContainsKey("0"));

        }

        [TestMethod]
        public void CrearNuevoTurno_AgregarTurnoConPrioridadMedia_TurnoAgregadoCorrectamente()
        {
            Recepcionista recepcionista = new Recepcionista();
            // Arrange
            string malestar = "Fiebre";
            Mascota animal = new Mascota("NombreMascota", "EspecieMascota");
            DateTime fecha = DateTime.Now;
            string prioridadAtencion = "Media";

            // Act
            recepcionista.CrearNuevoTurno(malestar, animal, fecha, prioridadAtencion);

            // Assert
            Turno turnoAgregado = Sistema.turnos.Last();
            Assert.AreEqual(fecha, turnoAgregado.Fecha);
            Assert.AreEqual(animal, turnoAgregado.Mascota);
            Assert.AreEqual(malestar, turnoAgregado.MalestarActual);
            Assert.AreEqual(Turno.PrioridadAtencion.Media, turnoAgregado.UrgenciaAtencion);
            Assert.AreEqual(Turno.EstadoDeTurno.SinVeterinario, turnoAgregado.EstadoTurno);
        }

        [TestMethod]
        public void CrearNuevoTurno_AgregarTurnoConPrioridadUrgente_TurnoAgregadoIncorrectamente()
        {
            Recepcionista recepcionista = new Recepcionista();

            // Arrange
            string malestar = "Dolor abdominal"; // Cambia el valor del malestar
            Mascota animal = new Mascota("NombreMascota", "EspecieMascota");
            DateTime fecha = DateTime.Now;
            string prioridadAtencion = "Urgente";

            // Act
            recepcionista.CrearNuevoTurno(malestar, animal, fecha, prioridadAtencion);

            // Assert
            Turno turnoAgregado = Sistema.turnos.Last();
            Assert.AreEqual(fecha, turnoAgregado.Fecha);
            Assert.AreEqual(animal, turnoAgregado.Mascota);
            Assert.AreNotEqual("Dolor en la pata", turnoAgregado.MalestarActual);
            Assert.AreNotEqual(Turno.PrioridadAtencion.Media, turnoAgregado.UrgenciaAtencion);
            Assert.AreEqual(Turno.EstadoDeTurno.SinVeterinario, turnoAgregado.EstadoTurno);
        }

        [TestMethod]
     
        public void AgregarConsulta_DeManeraCorrecta()
        {
            HistorialMedico historialMedico = new HistorialMedico();

            string malestar = "Shock anafilactico por picazon abeja";
            string tratamientoAplicado = "Adrenalina subcutánea 0,3-0,5 ml";
            Mascota animal = new Mascota("Mew", "Gato");
            string nombreVeterinario = "Giovanni";


            bool estadoAgregarConsulta = historialMedico.AgregarConsulta(malestar,tratamientoAplicado,animal,nombreVeterinario);

            Assert.IsTrue(estadoAgregarConsulta);

        }

        [TestMethod]
        public void AgregarConsulta_DeManeraIncorrecta()
        {
            HistorialMedico historialMedico = new HistorialMedico();

            string malestar = "";
            string tratamientoAplicado = "";
            Mascota animal = new Mascota("Mew", "Gato");
            string nombreVeterinario = "Giovanni";


            bool estadoAgregarConsulta = historialMedico.AgregarConsulta(malestar,tratamientoAplicado,animal,nombreVeterinario);

            Assert.IsFalse(estadoAgregarConsulta);

        }
    }

}