using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Truco
    {
        public void RepartirCartas(List<Carta> mazo, Jugador j1, Jugador j2)
        {
            List<Carta> mazoAuxiliar = mazo;
            for (int i = 0; i < 3; i++)
            {
                RepartirCartasAJugador(mazoAuxiliar, j1);
                RepartirCartasAJugador(mazoAuxiliar, j2);
            }
        }

        private void RepartirCartasAJugador(List<Carta> mazo, Jugador j)
        {
            Random cartaRandom = new Random();
            int indice;          

            indice = cartaRandom.Next(1, mazo.Count);
            j.Cartas.Add(mazo[indice]);
            mazo.RemoveAt(indice);
        }

        public Carta DefinirCartaGanadora(Carta c1, Carta c2)
        {
            if (c1 is not null && c2 is not null)
            {
                if (c1.Peso > c2.Peso)
                {
                    return c1;
                }
                else if (c1.Peso < c2.Peso)
                {
                    return c2;
                }
            }
            return null;
        }

        public int ContarPuntosEnvido(Carta c1, Carta c2)
        {
            if(c1 is null || c2 is null)
            {
                return 0;
            }

            int puntosEnvido = 20;

            if (((c1.Numero == 10
                   || c1.Numero == 11
                   || c1.Numero == 12) &&
                     (c2.Numero == 10
                   || c2.Numero == 11
                   || c2.Numero == 12)))
            {
                puntosEnvido += 0;
            }
            else if (c2.Numero == 10
                  || c2.Numero == 11
                  || c2.Numero == 12)
            {
                puntosEnvido += c1.Numero;
            }
            else if (c1.Numero == 10
                  || c1.Numero == 11
                  || c1.Numero == 12)
            {
                puntosEnvido += c2.Numero;               
            }
            else
            {
                puntosEnvido += c1.Numero + c2.Numero;
            }

            return puntosEnvido;
        }
    }
}
