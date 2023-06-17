using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.DB
{
    public class MascotaDAO : ConexionDB
    {

        public static void Agregar(Mascota mascota)
        {
            
            using (SqlConnection connection = ObtenerConexion())
            {
                connection.Open();

                var query = $"INSERT INTO Mascota (idMascota, nombreAnimal,apellidoDueño,edad,especie,raza,peso,sexo,fechaDeNacimiento) VALUES (@idMascota, @nombreAnimal, @apellidoDueño, @edad, @especie, @raza, @peso, @sexo, @fechaDeNacimiento)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@idMascota", mascota.IdMascota);
                    command.Parameters.AddWithValue("@nombreAnimal", mascota.NombreAnimal);
                    command.Parameters.AddWithValue("@apellidoDueño", mascota.ApellidoDueño);
                    command.Parameters.AddWithValue("@edad", mascota.Edad);
                    command.Parameters.AddWithValue("@especie", mascota.Especie);
                    command.Parameters.AddWithValue("@raza", mascota.Raza);
                    command.Parameters.AddWithValue("@peso", mascota.Peso);
                    command.Parameters.AddWithValue("@sexo", sexo);
                    command.Parameters.AddWithValue("@fechaDeNacimiento", fechaDeNacimiento);
                }

            }
        }

        public void AgregarMascota(List<string> historialClinico, int idMascota, string nombreAnimal, string apellidoDueño, int edad, string especie, string raza, float peso, char sexo, DateTime fechaDeNacimiento)
        {
            using (SqlConnection connection = ObtenerConexion())
            {
                connection.Open();

                // Crear la consulta SQL para agregar una mascota a la base de datos
                string query = "INSERT INTO Mascotas (HistorialClinico, IdMascota, NombreAnimal, ApellidoDueño, Edad, Especie, Raza, Peso, Sexo, FechaDeNacimiento) " +
                                "VALUES (@HistorialClinico, @IdMascota, @NombreAnimal, @ApellidoDueño, @Edad, @Especie, @Raza, @Peso, @Sexo, @FechaDeNacimiento)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Asignar los parámetros
                    command.Parameters.AddWithValue("@HistorialClinico", string.Join(",", historialClinico));
                    command.Parameters.AddWithValue("@IdMascota", idMascota);
                    command.Parameters.AddWithValue("@NombreAnimal", nombreAnimal);
                    command.Parameters.AddWithValue("@ApellidoDueño", apellidoDueño);
                    command.Parameters.AddWithValue("@Edad", edad);
                    command.Parameters.AddWithValue("@Especie", especie);
                    command.Parameters.AddWithValue("@Raza", raza);
                    command.Parameters.AddWithValue("@Peso", peso);
                    command.Parameters.AddWithValue("@Sexo", sexo);
                    command.Parameters.AddWithValue("@FechaDeNacimiento", fechaDeNacimiento);

                    // Ejecutar la consulta
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public Mascota ObtenerMascota(int idMascota)
        {
            using (SqlConnection connection = ObtenerConexion())
            {
                connection.Open();

                // Crear la consulta SQL para obtener los datos de la mascota
                string query = "SELECT * FROM Mascotas WHERE IdMascota = @IdMascota";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Asignar el parámetro
                    command.Parameters.AddWithValue("@IdMascota", idMascota);

                    // Ejecutar la consulta y obtener el resultado
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Obtener los valores de las columnas de la mascota
                            string[] historialClinicoArray = reader.GetString(reader.GetOrdinal("HistorialClinico")).Split(',');
                            List<string> historialClinico = new List<string>(historialClinicoArray);
                            string nombreAnimal = reader.GetString(reader.GetOrdinal("NombreAnimal"));
                            string apellidoDueño = reader.GetString(reader.GetOrdinal("ApellidoDueño"));
                            int edad = reader.GetInt32(reader.GetOrdinal("Edad"));
                            string especie = reader.GetString(reader.GetOrdinal("Especie"));
                            string raza = reader.GetString(reader.GetOrdinal("Raza"));
                            float peso = reader.GetFloat(reader.GetOrdinal("Peso"));
                            char sexo = reader.GetChar(reader.GetOrdinal("Sexo"));
                            DateTime fechaDeNacimiento = reader.GetDateTime(reader.GetOrdinal("FechaDeNacimiento"));

                            // Crear una instancia de Mascota con los valores obtenidos
                            Mascota mascota = new Mascota(idMascota, nombreAnimal, apellidoDueño, edad, especie, raza, peso, sexo, fechaDeNacimiento);
                            return mascota;
                        }
                    }
                }

                connection.Close();
            }

            return null;
        }

        public void ActualizarMascota(List<string> historialClinico, int idMascota, string nombreAnimal, string apellidoDueño, int edad, string especie, string raza, float peso, char sexo, DateTime fechaDeNacimiento)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                // Crear la consulta SQL para actualizar los datos de la mascota en la base de datos
                string query = "UPDATE Mascotas SET HistorialClinico = @HistorialClinico, NombreAnimal = @NombreAnimal, " +
                                "ApellidoDueño = @ApellidoDueño, Edad = @Edad, Especie = @Especie, Raza = @Raza, " +
                                "Peso = @Peso, Sexo = @Sexo, FechaDeNacimiento = @FechaDeNacimiento WHERE IdMascota = @IdMascota";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Asignar los parámetros
                    command.Parameters.AddWithValue("@HistorialClinico", string.Join(",", historialClinico));
                    command.Parameters.AddWithValue("@IdMascota", idMascota);
                    command.Parameters.AddWithValue("@NombreAnimal", nombreAnimal);
                    command.Parameters.AddWithValue("@ApellidoDueño", apellidoDueño);
                    command.Parameters.AddWithValue("@Edad", edad);
                    command.Parameters.AddWithValue("@Especie", especie);
                    command.Parameters.AddWithValue("@Raza", raza);
                    command.Parameters.AddWithValue("@Peso", peso);
                    command.Parameters.AddWithValue("@Sexo", sexo);
                    command.Parameters.AddWithValue("@FechaDeNacimiento", fechaDeNacimiento);

                    // Ejecutar la consulta
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public void EliminarMascota(int idMascota)
        {
            using (SqlConnection connection = ObtenerConexion())
            {
                connection.Open();

                // Crear la consulta SQL para eliminar la mascota de la base de datos
                string query = "DELETE FROM Mascotas WHERE IdMascota = @IdMascota";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Asignar el parámetro
                    command.Parameters.AddWithValue("@IdMascota", idMascota);

                    // Ejecutar la consulta
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
    }
}
}
}
