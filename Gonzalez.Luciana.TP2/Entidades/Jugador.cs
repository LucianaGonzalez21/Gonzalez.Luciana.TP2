using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Jugador
    {
        private string nombre;
        private int partidasJugadas;
        private int partidasGanadas;
        private List<Carta> cartas;
        private int puntosPartida;
        private bool esGanador;
        private bool estaJugando;

        //delegado y evento para anunciar ganador
        public delegate void DelegadoEsGanador(string nombreGanador);
        public event DelegadoEsGanador EventoEsGanador;

        public Jugador(string nombre)
        {
            this.Nombre=nombre;
            this.Cartas = new List<Carta>();
        }

        public Jugador(string nombre, int partidasJugadas, int partidasGanadas, bool estaActivo) : this(nombre)
        {
            this.partidasJugadas = partidasJugadas;
            this.partidasGanadas = partidasGanadas;
            this.EstaJugando = estaActivo;
        }
        public string Nombre { get => nombre; set => nombre=value; }
        public int PartidasJugadas { get => partidasJugadas; set => partidasJugadas=value; }
        public List<Carta> Cartas { get => cartas; set => cartas=value; }
        public int PuntosPartida { get => puntosPartida; set => puntosPartida=value; }
        public int PartidasGanadas { get => partidasGanadas; set => partidasGanadas=value; }
        public bool EsGanador
        {
            get
            {
                return esGanador;
            }
            set
            {
                esGanador = value;
                if (EventoEsGanador is not null && esGanador)
                {
                    EventoEsGanador.Invoke(nombre);
                }
            }
        }

        public bool EstaJugando { get => estaJugando; set => estaJugando=value; }


        public string MostrarCartas()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Carta item in Cartas)
            {
                sb.AppendLine($"{item.Numero} de {item.Palo}");
            }

            return sb.ToString();
        }

        public Carta JugarCarta(int minimoInclusivo, int maximoExclusivo)
        {
            Random indiceCarta = new Random();

            return this.Cartas[indiceCarta.Next(minimoInclusivo, maximoExclusivo)];

        }

        public bool CantarEnvido()
        {
            for (int i = 0; i <this.Cartas.Count; i++)
            {
                for (int j = i + 1; j < this.Cartas.Count; j++)
                {
                    if (this.Cartas[i].Palo == this.Cartas[j].Palo)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public List<Carta> JugarEnvido()
        {
            List<Carta> cartasEnvido = new List<Carta>();

            for (int i = 0; i < Cartas.Count; i++)
            {
                for (int j = i + 1; j < Cartas.Count; j++)
                {
                    if (Cartas[i].Palo == Cartas[j].Palo)
                    {
                        cartasEnvido.Add(Cartas[j]);
                        cartasEnvido.Add(Cartas[i]);
                        return cartasEnvido;
                    }
                }
            }
            return null;
        }

        public bool ResponderJugada()
        {
            Random random = new Random();

            return (random.Next(0, 2) == 1 ? true : false);
        }


        public static bool operator ==(Jugador j1, Jugador j2)
        {
            if (j1 is null || j2 is null)
            {
                return false;
            }

            return j1.Nombre == j2.Nombre;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

        public override bool Equals(object obj)
        {
            Jugador jugador = obj as Jugador;

            return jugador is not null && this == jugador;
        }

        public override int GetHashCode()
        {
            return Nombre.GetHashCode();
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}{Environment.NewLine}" +
                $"Partidas jugadas: {partidasJugadas}{Environment.NewLine}" +
                $"Partidas ganadas: {partidasGanadas}";
        }
    }
}
