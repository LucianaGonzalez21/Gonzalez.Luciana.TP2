using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SqlSala
    {
        static string connectionStriing;
        static SqlCommand command;
        static SqlConnection connection;

        static SqlSala()
        {
            connectionStriing = @"Data Source = DESKTOP-K99V528; Database = TRUCO; Trusted_Connection=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionStriing);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static List<Sala> Leer()
        {
            List<Sala> jugadores = new List<Sala>();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM SALAS_DB";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    jugadores.Add(new Sala
                        (int.Parse(dataReader["ID_SALA"].ToString()),
                        Administrador.ObtenerJugadorPorNombre(dataReader["JUGADOR_UNO"].ToString()),
                        (Administrador.ObtenerJugadorPorNombre(dataReader["JUGADOR_DOS"].ToString()))));
                }

                return jugadores;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void Guardar(Sala sala)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO SALAS_DB (JUGADOR_UNO, JUGADOR_DOS)" +
                    $"  VALUES (@JUGADOR_UNO, @JUGADOR_DOS)";
                command.Parameters.AddWithValue("@JUGADOR_UNO", sala.J1.Nombre);
                command.Parameters.AddWithValue("@JUGADOR_DOS", sala.J2.Nombre);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
