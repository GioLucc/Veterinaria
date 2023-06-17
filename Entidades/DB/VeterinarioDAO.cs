using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Usuario;

namespace Entidades.DB
{
    public sealed class VeterinarioDAO : ConexionDB
    {
        public void AgregarVeterinario(Veterinario veterinario)
        {
            //using (SqlConnection connection = ObtenerConexion())
            // {
            SqlConnection connection = ObtenerConexion();
            connection.Open();

            // Crear la consulta SQL para agregar un veterinario a la base de datos
            string query = "INSERT INTO Veterinario (nombre, apellido, dni, edad, nombreUsuario, clave, idJerarquia, activo, sueldo, especialidad, atendiendo) " +
                           "VALUES (@nombre, @apellido, @dni, @edad, @nombreUsuario, @clave, (SELECT id FROM JerarquiaUsuario WHERE descripcion = @descripcion), @activo, @sueldo, @especialidad, @atendiendo)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@nombre", veterinario.Nombre);
                command.Parameters.AddWithValue("@apellido", veterinario.Apellido);
                command.Parameters.AddWithValue("@dni", veterinario.Dni);
                command.Parameters.AddWithValue("@edad", veterinario.Edad);
                command.Parameters.AddWithValue("@nombreUsuario", veterinario.NombreUsuario);
                command.Parameters.AddWithValue("@clave", veterinario.ContraseniaUsuario);
                command.Parameters.AddWithValue("@activo", veterinario.Activo);
                command.Parameters.AddWithValue("@sueldo", veterinario.Sueldo);
                command.Parameters.AddWithValue("@especialidad", veterinario.Especialidad);
                command.Parameters.AddWithValue("@atendiendo", veterinario.Atendiendo);

                command.ExecuteNonQuery();
            }

            connection.Close();

            // }                    
        }

        public void EliminarVeterinario(Veterinario veterinario)
        {
            using (SqlConnection connection = ObtenerConexion())
            {
                connection.Open();

                // Crear la consulta SQL para eliminar al veterinario de la base de datos
                string query = "DELETE FROM Veterinarios WHERE DNI = @dni";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Asignar el parámetro
                    command.Parameters.AddWithValue("@Id",veterinario.Dni);

                    // Ejecutar la consulta
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public void ActualizarVeterinario(Veterinario veterinario)
        {
            using (SqlConnection connection = ObtenerConexion())
            {
                connection.Open();

                // Crear la consulta SQL para actualizar los datos del veterinario en la base de datos
                string query = "UPDATE Veterinarios SET Nombre = @Nombre, Apellido = @Apellido, Dni = @Dni, Edad = @Edad, " +
                               "NombreUsuario = @NombreUsuario, Clave = @Clave, Jerarquia = @Jerarquia, Activo = @Activo, " +
                               "Sueldo = @Sueldo, Especialidad = @Especialidad, Atendiendo = @Atendiendo " +
                               "WHERE veterinario.Dni = @Dni";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Asignar los parámetros
                    command.Parameters.AddWithValue("@Nombre", veterinario.Nombre);
                    command.Parameters.AddWithValue("@Apellido", veterinario.Apellido);
                    command.Parameters.AddWithValue("@Dni", veterinario.Dni);
                    command.Parameters.AddWithValue("@Edad", veterinario.Edad);
                    command.Parameters.AddWithValue("@NombreUsuario", veterinario.NombreUsuario);
                    command.Parameters.AddWithValue("@Clave", veterinario.ContraseniaUsuario);
                    command.Parameters.AddWithValue("@Activo", veterinario.Activo);
                    command.Parameters.AddWithValue("@Sueldo", veterinario.Sueldo);
                    command.Parameters.AddWithValue("@Especialidad", veterinario.Especialidad);
                    command.Parameters.AddWithValue("@Atendiendo", veterinario.Atendiendo);
                    command.Parameters.AddWithValue("@Id", veterinario.Id);

                    // Ejecutar la consulta
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
    }
}
