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
    }
}
