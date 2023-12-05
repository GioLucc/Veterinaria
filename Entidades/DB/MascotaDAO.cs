using System;
using System.Collections.Generic;
using System.Data;
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
            using (SqlConnection connection = new SqlConnection(ConexionDB.ConnectionString))

            {
                connection.Open();

                var query = $"INSERT INTO Mascota (nombreAnimal,apellidoDueño,edad,especie,raza,peso,sexo,fechaDeNacimiento) VALUES (@nombreAnimal, @apellidoDueño, @edad, @especie, @raza, @peso, @sexo, @fechaDeNacimiento)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@nombreAnimal", mascota.NombreAnimal);
                    command.Parameters.AddWithValue("@apellidoDueño", mascota.ApellidoDueño);
                    command.Parameters.AddWithValue("@edad", mascota.Edad);
                    command.Parameters.AddWithValue("@especie", mascota.Especie);
                    command.Parameters.AddWithValue("@raza", mascota.Raza);
                    command.Parameters.AddWithValue("@peso", mascota.Peso);
                    command.Parameters.AddWithValue("@sexo", mascota.Sexo);
                    command.Parameters.AddWithValue("@fechaDeNacimiento", mascota.FechaDeNacimiento);

                    command.ExecuteNonQuery(); // Ejecutar la consulta de inserción
                }

            }

        }

        public List<Veterinario> TraerMascotas()
        {
            DataTable dataTable = new DataTable();

            List<Veterinario> veterinarios = new List<Veterinario>();

            using (SqlConnection connection = ObtenerConexion())
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "select * from Veterinario as v " +
                      "INNER JOIN Usuario AS u ON u.id = v.idUsuario " +
                      "INNER JOIN Persona AS p ON p.idPersona = u.idPersona";


                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            foreach (DataRow item in dataTable.Rows)
            {
                int id = Convert.ToInt32(item["idPersona"]);
                string nombre = item["nombre"].ToString();
                string apellido = item["apellido"].ToString();
                int dni = Convert.ToInt32(item["dni"]);
                int edad = Convert.ToInt32(item["edad"]);
                string nombreUsuario = item["nombreUsuario"].ToString();
                string contraseniaUsuario = item["contraseniaUsuario"].ToString();
                bool activo = Convert.ToBoolean(item["activo"]);
                float sueldo = Convert.ToSingle(item["sueldo"]);
                string especialidad = item["especialidad"].ToString();
                bool atendiendo = Convert.ToBoolean(item["atendiendo"]);

                Veterinario veterinario = new Veterinario((short)id, nombre, apellido, dni, edad, nombreUsuario, contraseniaUsuario, activo, sueldo, especialidad, atendiendo);
                veterinarios.Add(veterinario);

            }

            return veterinarios;
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

                            string nombreAnimal = reader.GetString(reader.GetOrdinal("NombreAnimal"));
                            string apellidoDueño = reader.GetString(reader.GetOrdinal("ApellidoDueño"));
                            int edad = reader.GetInt32(reader.GetOrdinal("Edad"));
                            string especie = reader.GetString(reader.GetOrdinal("Especie"));
                            string raza = reader.GetString(reader.GetOrdinal("Raza"));
                            float peso = reader.GetFloat(reader.GetOrdinal("Peso"));
                            char sexo = reader.GetChar(reader.GetOrdinal("Sexo"));
                            DateTime fechaDeNacimiento = reader.GetDateTime(reader.GetOrdinal("FechaDeNacimiento"));

                            // Crear una instancia de Mascota con los valores obtenidos
                            Mascota mascota = new Mascota(especie, raza, peso, sexo,nombreAnimal, apellidoDueño, idMascota, fechaDeNacimiento);
                            return mascota;
                        }
                    }
                }

                connection.Close();
            }

            return null;
        }

        public void ActualizarMascota(int idMascota, string nombreAnimal, string apellidoDueño, int edad, string especie, string raza, float peso, char sexo, DateTime fechaDeNacimiento)
        {
            using (SqlConnection connection = ObtenerConexion())
            {
                connection.Open();

                // Crear la consulta SQL para actualizar los datos de la mascota en la base de datos
                string query = "UPDATE Mascotas SET nombreAnimal = @NombreAnimal, " +
                                "apellidoDueño = @ApellidoDueño, edad = @Edad, especie = @Especie, raza = @Raza, " +
                                "peso = @Peso, sexo = @Sexo, fechaDeNacimiento = @FechaDeNacimiento WHERE idMascota = @IdMascota";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Evitar inyecciones
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
        //funciones SQL, y consultas
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




