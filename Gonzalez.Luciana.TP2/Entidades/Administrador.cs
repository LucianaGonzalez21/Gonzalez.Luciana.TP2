using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Administrador
    {
        public static List<Partida> listaPartidas;

        static Administrador()
        {
            listaPartidas = new List<Partida>();
        }

        public static bool EsJugadorExistente(Jugador j)
        {
            if (j is null)
            {
                return false;
            }

            foreach (Jugador jugador in SqlJugador.Leer())
            {
                if (j == jugador)
                {
                    return true;
                }
            }

            return false;
        }

        public static Jugador ObtenerJugadorPorNombre(string nombre)
        {
            if(string.IsNullOrEmpty(nombre) == false)
            {
                foreach(Jugador jugador in SqlJugador.Leer())
                {
                    if(jugador.Nombre == nombre)
                    {
                        return jugador;
                    }
                }
            }
            return null;
        }

        public static string MostrarJugadoresConMasPartidasGanadas()
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                foreach (Jugador j in SqlJugador.FiltrarJugadoresConMasPartidasGanadas())
                {
                    sb.AppendLine($"Nombre: {j.Nombre}");
                    sb.AppendLine($"Partidas ganadas: {j.PartidasGanadas}");
                    sb.AppendLine();
                }
                return sb.ToString();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public static string MostrarJugadoresConMayorPuntaje()
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                foreach (Jugador j in SqlJugador.FiltrarJugadoresPorMayorPuntaje())
                {
                    sb.AppendLine($"Nombre: {j.Nombre}");
                    sb.AppendLine($"Puntaje maximo: {j.MayorPuntaje}");
                    sb.AppendLine();
                }
                return sb.ToString();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public static string MostrarJugadoresPorPartidasGanadas()
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                foreach (Jugador j in SqlJugador.Leer())
                {
                    sb.AppendLine($"Nombre: {j.Nombre}");
                    sb.AppendLine($"Partidas ganadas: {j.PartidasGanadas}");
                    sb.AppendLine();
                }
                return sb.ToString();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public static string MostrarJugadoresPorPartidasPerdidas()
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                foreach (Jugador j in SqlJugador.Leer())
                {
                    sb.AppendLine($"Nombre: {j.Nombre}");
                    sb.AppendLine($"Partidas perdidas: {j.PartidasPerdidas}");
                    sb.AppendLine();
                }
                return sb.ToString();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public static string MostrarJugadoresPorPuntajeMayor()
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                foreach (Jugador j in SqlJugador.Leer())
                {
                    sb.AppendLine($"Nombre: {j.Nombre}");
                    sb.AppendLine($"Partidas perdidas: {j.MayorPuntaje}");
                    sb.AppendLine();
                }
                return sb.ToString();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public static bool ValidarJugadoresEstenLibresParaJugar(Jugador j1, Jugador j2)
        {
            try
            {
                if(j1 is null || j2 is null)
                {
                    throw new ArgumentNullException();
                }

                if (j1.EstaJugando || j2.EstaJugando)
                {
                    return false;
                }
                return true;
            }
            catch (ArgumentNullException exc)
            {
                throw new ArgumentNullException("No se cargaron los jugadores correctamente", exc);
            }
            catch (Exception exc)
            {
                throw new Exception("Error al cargar jugadores", exc);
            }
        }

        public static string MostrarListaJugadoresOrdenados()
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                foreach (Jugador j in SqlJugador.OrdenarJugadoresPorNombre())
                {
                    sb.AppendLine(j.ToString());
                    sb.AppendLine();
                }

                return sb.ToString();
            }
            catch (Exception exc)
            {
                throw new Exception("Error al ordenar la lista de jugadores", exc);
            }
        }
    }
}
