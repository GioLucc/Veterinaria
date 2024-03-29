﻿using Entidades.Archivos_y_Serializadores;
using System;
using System.Collections.Generic;
using System.Data;
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
                comm.CommandText = "INSERT INTO Persona (Nombre, Apellido, Dni, Edad)" +
                   "VALUES (@Nombre, @Apellido, @Dni, @Edad) ; SELECT SCOPE_IDENTITY()";
                comm.Parameters.AddWithValue("@Nombre", veterinario.Nombre);
                comm.Parameters.AddWithValue("@Apellido", veterinario.Apellido);
                comm.Parameters.AddWithValue("@Dni", veterinario.Dni);
                comm.Parameters.AddWithValue("@Edad", veterinario.Edad);
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
                comm.CommandText = "INSERT INTO Usuario (NombreUsuario, Contrasenia, Activo, Sueldo, IdPersona)" +
                   "VALUES (@NombreUsuario, @Contrasenia, @Activo, @Sueldo, @IdPersona) ; SELECT SCOPE_IDENTITY()";
                comm.Parameters.AddWithValue("@NombreUsuario", veterinario.NombreUsuario);
                comm.Parameters.AddWithValue("@Contrasenia", veterinario.ContraseniaUsuario);
                comm.Parameters.AddWithValue("@Activo", veterinario.Activo);
                comm.Parameters.AddWithValue("@Sueldo", veterinario.Sueldo);
                comm.Parameters.AddWithValue("@IdPersona", idPersona);
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
                command.CommandText = "INSERT INTO Veterinario (Especialidad, Atendiendo, IdUsuario) " +
                           "VALUES (@Especialidad, @Atendiendo, @IdUsuario)";
                command.Parameters.AddWithValue("@Especialidad", veterinario.Especialidad);
                command.Parameters.AddWithValue("@Atendiendo", veterinario.Atendiendo);
                command.Parameters.AddWithValue("@IdUsuario", idUsuario);


                command.ExecuteNonQuery();
            }

            connection.Close();             
        }
        //public DataTable ExecuteQuery(string connectionString, string query)
        //{
        //    DataTable dataTable = new DataTable();

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();

        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
        //            {
        //                adapter.Fill(dataTable);
        //            }
        //        }
        //    }

        //    return dataTable;
        //}

        public List<Veterinario> TraerVeterinarios()
        {
            DataTable dataTable = new DataTable();

            List<Veterinario> veterinarios = new List<Veterinario>();

            using (SqlConnection connection = ObtenerConexion())
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "select * from Veterinario " + // Si no le pones los espacios te concatena la siguiente linea
                    "INNER JOIN Usuario AS U ON U.IdUsuario = Veterinario.IdUsuario " +
                    "INNER JOIN Persona AS P ON P.Id = U.IdPersona";


                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }

            }

            foreach (DataRow item in dataTable.Rows)
            {
                int id = Convert.ToInt32(item["IdPersona"]);
                string nombre = item["Nombre"].ToString();
                string apellido = item["Apellido"].ToString();
                int dni = Convert.ToInt32(item["Dni"]);
                int edad = Convert.ToInt32(item["Edad"]);
                string nombreUsuario = item["NombreUsuario"].ToString();
                string contraseniaUsuario = item["Contrasenia"].ToString();
                bool activo = Convert.ToBoolean(item["Activo"]);
                float sueldo = Convert.ToSingle(item["Sueldo"]);
                string especialidad = item["Especialidad"].ToString();
                bool atendiendo = Convert.ToBoolean(item["Atendiendo"]);

                Veterinario veterinario = new Veterinario((short)id, nombre, apellido, dni, edad, nombreUsuario, contraseniaUsuario, activo, sueldo, especialidad, atendiendo);
                veterinarios.Add(veterinario);
                
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
