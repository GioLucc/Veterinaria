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
            string query = "INSERT INTO Veterinarios (Id, Nombre, Apellido, Dni, Edad, NombreUsuario, Clave, Jerarquia, Activo, Sueldo, Especialidad, Atendiendo) " +
                    "VALUES (@Id, @Nombre, @Apellido, @Dni, @Edad, @NombreUsuario, @Clave, @Jerarquia, @Activo, @Sueldo, @Especialidad, @Atendiendo)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Asignar los parámetros
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Apellido", apellido);
                command.Parameters.AddWithValue("@Dni", dni);
                command.Parameters.AddWithValue("@Edad", edad);
                command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                command.Parameters.AddWithValue("@Clave", clave);
                command.Parameters.AddWithValue("@Jerarquia", jerarquia);
                command.Parameters.AddWithValue("@Activo", activo);
                command.Parameters.AddWithValue("@Sueldo", sueldo);
                command.Parameters.AddWithValue("@Especialidad", especialidad);
                command.Parameters.AddWithValue("@Atendiendo", atendiendo);

                // Ejecutar la consulta
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
                    command.Parameters.AddWithValue("@Jerarquia", veterinario.JerarquiaUsuario);
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
