using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SqlJugador
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static SqlJugador()
        {
            try
            {
                connectionString = @"Data Source = DESKTOP-K99V528; Database = TRUCO; Trusted_Connection=True";
                command = new SqlCommand();
                connection = new SqlConnection(connectionString);
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Jugador> Leer()
        {
            List<Jugador> jugadores = new List<Jugador>();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM JUGADORES_DB";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    jugadores.Add(new Jugador
                        (dataReader["NOMBRE"].ToString(),
                        int.Parse(dataReader["PARTIDAS_JUGADAS"].ToString()),
                        int.Parse(dataReader["PARTIDAS_GANADAS"].ToString()),
                        ConvertirEstado(dataReader["ESTA_JUGANDO"].ToString())));
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

        private static bool ConvertirEstado(string dato)
        {
            if (dato.ToLower() == "false")
            {
                return false;
            }
            return true;
        }

        private static int ConvertirEstado(bool dato)
        {
            if (dato)
            {
                return 1;
            }
            return 0;
        }

        public static void Guardar(Jugador jugador)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO JUGADORES_DB (NOMBRE, PARTIDAS_JUGADAS, PARTIDAS_GANADAS, ESTA_JUGANDO)" +
                    $"  VALUES (@NOMBRE, @PARTIDAS_JUGADAS, @PARTIDAS_GANADAS, @ESTA_JUGANDO)";
                command.Parameters.AddWithValue("@NOMBRE", jugador.Nombre);
                command.Parameters.AddWithValue("@PARTIDAS_JUGADAS", jugador.PartidasJugadas);
                command.Parameters.AddWithValue("@PARTIDAS_GANADAS", jugador.PartidasGanadas);
                command.Parameters.AddWithValue("@ESTA_JUGANDO", ConvertirEstado(jugador.EstaJugando));

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

        public static void ModificarPartidasYEstadoDeJugador(Jugador jugador)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "UPDATE JUGADORES_DB SET PARTIDAS_JUGADAS = @PARTIDAS_JUGADAS, PARTIDAS_GANADAS = @PARTIDAS_GANADAS, ESTA_JUGANDO = @ESTA_JUGANDO WHERE NOMBRE = @NOMBRE";
                command.Parameters.AddWithValue("@NOMBRE", jugador.Nombre);
                command.Parameters.AddWithValue("@PARTIDAS_JUGADAS", jugador.PartidasJugadas);
                command.Parameters.AddWithValue("@PARTIDAS_GANADAS", jugador.PartidasGanadas);
                command.Parameters.AddWithValue("@ESTA_JUGANDO", jugador.EstaJugando);

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

        public static List<Jugador> FiltrarJugadoresConMasPartidasGanadas()
        {
            List<Jugador> jugadores = new List<Jugador>();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM JUGADORES_DB WHERE PARTIDAS_GANADAS = (SELECT MAX(PARTIDAS_GANADAS) FROM JUGADORES_DB)";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    jugadores.Add(new Jugador
                        (dataReader["NOMBRE"].ToString(),
                        int.Parse(dataReader["PARTIDAS_JUGADAS"].ToString()),
                        int.Parse(dataReader["PARTIDAS_GANADAS"].ToString()),
                        ConvertirEstado(dataReader["ESTA_JUGANDO"].ToString())));
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

        public static List<Jugador> OrdenarJugadoresPorNombre()
        {
            List<Jugador> jugadores = new List<Jugador>();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM JUGADORES_DB ORDER BY NOMBRE";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    jugadores.Add(new Jugador
                        (dataReader["NOMBRE"].ToString(),
                        int.Parse(dataReader["PARTIDAS_JUGADAS"].ToString()),
                        int.Parse(dataReader["PARTIDAS_GANADAS"].ToString()),
                        ConvertirEstado(dataReader["ESTA_JUGANDO"].ToString())));
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
    }
}
