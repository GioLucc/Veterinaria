using Entidades.Archivos_y_Serializadores;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Usuario;

namespace Entidades.DB
{
    public sealed class VeterinarioDAO : ConexionDB
    {
        public Decimal AgregarPersona(Veterinario veterinario, SqlCommand comm)
        {
            Decimal retorno = 0;
            ArchivoTxt logg = new ArchivoTxt();

            try
            {
                comm.CommandText = "INSERT INTO Persona (nombre, apellido, dni, edad)" +
                   "VALUES (@nombre, @apellido, @dni, @edad) ; SELECT SCOPE_IDENTITY()";
                comm.Parameters.AddWithValue("@nombre", veterinario.Nombre);
                comm.Parameters.AddWithValue("@apellido", veterinario.Apellido);
                comm.Parameters.AddWithValue("@dni", veterinario.Dni);
                comm.Parameters.AddWithValue("@edad", veterinario.Edad);
                var idPersona = comm.ExecuteScalar();

                if (idPersona is not null)
                {
                    retorno = (Decimal)idPersona;
                }
            }
            catch(Exception ex)
            {
                logg.Logger(ex);
            }
            return retorno;

        }
        
        public Decimal AgregarUsuario(Veterinario veterinario, SqlCommand comm, int idPersona)
        {
            Decimal retorno = 0;
            ArchivoTxt logg = new ArchivoTxt();

            try
            {
                comm.CommandText = "INSERT INTO Usuario (nombreUsuario, contraseniaUsuario, activo, sueldo, idPersona)" +
                   "VALUES (@nombreUsuario, @contrasenia, @activo, @sueldo, @idPersona) ; SELECT SCOPE_IDENTITY()";
                comm.Parameters.AddWithValue("@nombreUsuario", veterinario.NombreUsuario);
                comm.Parameters.AddWithValue("@contrasenia", veterinario.ContraseniaUsuario);
                comm.Parameters.AddWithValue("@activo", veterinario.Activo);
                comm.Parameters.AddWithValue("@sueldo", veterinario.Sueldo);
                comm.Parameters.AddWithValue("@idPersona", idPersona);
                var idUsuario = comm.ExecuteScalar();

                if (idUsuario is not null)
                {
                    retorno = (Decimal)idUsuario;
                }
            }
            catch(Exception ex)
            {
                logg.Logger(ex);
            }
            return retorno;

        }

        public void AgregarVeterinario(Veterinario veterinario)
        {
            SqlConnection connection = ObtenerConexion();
            connection.Open();

            using (SqlCommand command = connection.CreateCommand())
            {
                int idPersona = (int)this.AgregarPersona(veterinario,command);
                int idUsuario = (int)this.AgregarUsuario(veterinario, command, idPersona);
                command.CommandText = "INSERT INTO Veterinario (especialidad, atendiendo,idUsuario) " +
                           "VALUES (@especialidad, @atendiendo,@idUsuario)";
                command.Parameters.AddWithValue("@especialidad", veterinario.Especialidad);
                command.Parameters.AddWithValue("@atendiendo", veterinario.Atendiendo);
                command.Parameters.AddWithValue("@idUsuario", idUsuario);


                command.ExecuteNonQuery();
            }

            connection.Close();             
        }

        public List<Veterinario> TraerVeterinarios()
        {
            List<Veterinario> veterinarios = new List<Veterinario>();

            using (SqlConnection connection = ObtenerConexion())
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = command.CommandText = "select * from Veterinario as v " +
                      "INNER JOIN Usuario AS u ON u.id = v.idUsuario " +
                      "INNER JOIN Persona AS p ON p.idPersona = u.idPersona";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(reader.GetOrdinal("p.idPersona"));
                            string nombre = reader.GetString(reader.GetOrdinal("p.nombre"));
                            string apellido = reader.GetString(reader.GetOrdinal("p.apellido"));
                            int dni = reader.GetInt32(reader.GetOrdinal("p.dni"));
                            int edad = reader.GetInt32(reader.GetOrdinal("p.edad"));
                            string nombreUsuario = reader.GetString(reader.GetOrdinal("u.nombreUsuario"));
                            string contraseniaUsuario = reader.GetString(reader.GetOrdinal("u.contraseniaUsuario"));
                            bool activo = reader.GetBoolean(reader.GetOrdinal("u.activo"));
                            float sueldo = reader.GetFloat(reader.GetOrdinal("u.sueldo"));
                            string especialidad = reader.GetString(reader.GetOrdinal("v.especialidad"));
                            bool atendiendo = reader.GetBoolean(reader.GetOrdinal("v.atendiendo"));

                            Veterinario veterinario = new Veterinario((short)id, nombre, apellido, dni, edad, nombreUsuario, contraseniaUsuario, activo, sueldo, especialidad, atendiendo);
                            veterinarios.Add(veterinario);

                        }
                    }
                }
            }

            return veterinarios;
        }
        public void EliminarVeterinario(Veterinario veterinario)
        {
            using (SqlConnection connection = ObtenerConexion())
            {
                connection.Open();

                // Crear la consulta SQL para eliminar al veterinario de la base de datos
                string query = "DELETE FROM Veterinarios WHERE dni = @dni";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Asignar el parámetro
                    command.Parameters.AddWithValue("@dni",veterinario.Dni);

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
