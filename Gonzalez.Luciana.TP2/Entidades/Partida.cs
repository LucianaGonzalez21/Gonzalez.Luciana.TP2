using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Partida
    {
        int id;
        private Sala sala;
        private int rondas; //3 rondas
        private string historialPartida;
        private Truco truco;
        private Action<string> mostrarNotificacion;
        private Random random;

        public string JugadorUno { get => sala.J1.Nombre; }
        public string JugadorDos { get => sala.J2.Nombre; }
        public int Rondas { get => rondas; set => rondas=value; }
        public string HistorialPartida { get => historialPartida; set => historialPartida=value; }
        public Truco Truco { get => truco; set => truco=value; }

        public Partida(Sala sala, int rondas, Truco truco, Action<string> mostrarNotificacion)
        {
            this.sala = sala;
            this.random = new Random();
            this.Rondas=rondas;
            this.Truco=truco;
            this.mostrarNotificacion = mostrarNotificacion;
        }

        public static bool operator ==(Partida p1, Partida p2)
        {
            if (p1 is null || p2 is null)
            {
                return false;
            }

            return p1.JugadorUno == p2.JugadorUno && p1.JugadorDos == p2.JugadorDos;
        }

        public static bool operator !=(Partida p1, Partida p2)
        {
            return !(p1 == p2);
        }

        public Jugador DefinirQuienEsMano(Jugador j1, Jugador j2, int flag)
        {
            if (j1 is not null && j2 is not null && (flag == 0 || flag == 1))
            {
                if (flag == 0)
                {
                    return j1;
                }
                else
                {
                    return j2;
                }
            }
            return null;
        }

        private int GenerarNumeroRandom()
        {
            return random.Next(1000, 3000);
        }

        public Jugador DefinirJugadorDos(Jugador jugadorMano)
        {
            if (jugadorMano is not null)
            {
                return jugadorMano == sala.J1 ? sala.J2 : sala.J1;
            }
            return null;
        }

        public void IniciarHilo()
        {
            Task.Run(() => JugarPartida());
        }

        public void JugarPartida()
        {
            InicializarEstadoJugadores(sala.J1);
            InicializarEstadoJugadores(sala.J2);

            mostrarNotificacion.Invoke($"**Comienzo de la partida**{Environment.NewLine}");
            Thread.Sleep(GenerarNumeroRandom());

            int flagCambioDeMano = 0;
            Jugador jugadorMano = null;
            Jugador jugadorDos = null;

            for (int i = 1; i< 4; i++)
            {
                mostrarNotificacion.Invoke($"{Environment.NewLine}Ronda {i}{Environment.NewLine}");
                Thread.Sleep(GenerarNumeroRandom());

                jugadorMano = DefinirQuienEsMano(sala.J1, sala.J2, flagCambioDeMano);
                jugadorDos = DefinirJugadorDos(jugadorMano);

                //InicializarEstadoJugadores(jugadorMano);
                //InicializarEstadoJugadores(jugadorDos);

                mostrarNotificacion.Invoke($"Jugador mano: {jugadorMano.Nombre}{Environment.NewLine}Jugador 2: " +
                    $"{jugadorDos.Nombre}{Environment.NewLine}");
                Thread.Sleep(GenerarNumeroRandom());

                //repartir cartas
                truco.RepartirCartas(sala.Mazo, jugadorMano, jugadorDos);

                //mostrar las cartas de cada jugador
                mostrarNotificacion.Invoke($"{Environment.NewLine}Cartas de {jugadorMano.Nombre}{Environment.NewLine}{jugadorMano.MostrarCartas()}" +
                    $"{Environment.NewLine}Cartas de {jugadorDos.Nombre}{Environment.NewLine}{jugadorDos.MostrarCartas()}");
                Thread.Sleep(GenerarNumeroRandom());

                //aca comienza el juego
                if (jugadorMano.CantarEnvido() && jugadorDos.ResponderJugada())
                {
                    //se canta envido
                    mostrarNotificacion.Invoke($"El jugador {jugadorMano.Nombre} canto envido y {jugadorDos.Nombre} acepto{Environment.NewLine}");
                    Thread.Sleep(GenerarNumeroRandom());
                    JugarConEnvido(jugadorMano, jugadorDos);
                }
                else if (jugadorMano.CantarEnvido() && jugadorDos.ResponderJugada() == false)
                {
                    //j1 canta envido, j2 no acepta
                    mostrarNotificacion.Invoke($"{jugadorMano.Nombre} canto envido pero  {jugadorDos.Nombre} no acepto{Environment.NewLine}");
                    Thread.Sleep(GenerarNumeroRandom());
                    jugadorMano.PuntosPartida++;
                    JugarSinEnvido(jugadorMano, jugadorDos);
                }
                else //no se canta envido
                {
                    JugarSinEnvido(jugadorMano, jugadorDos);
                }

                mostrarNotificacion.Invoke($"{Environment.NewLine}Puntos de {jugadorMano.Nombre}: {jugadorMano.PuntosPartida}{Environment.NewLine}");
                mostrarNotificacion.Invoke($"Puntos de {jugadorDos.Nombre}: {jugadorDos.PuntosPartida}{Environment.NewLine}");
                Thread.Sleep(GenerarNumeroRandom());

                flagCambioDeMano = CambiarDeMano(flagCambioDeMano);
            }

            //definir ganador
            DefinirGanadorDeLaPartida(jugadorMano, jugadorDos);

            //cambiar estado de jugador
            FinalizarPartida(jugadorMano);
            FinalizarPartida(jugadorDos);
            ModificarEstadoJugador(jugadorMano);
            ModificarEstadoJugador(jugadorDos);

        }

        public void InicializarEstadoJugadores(Jugador j)
        {
            j.EstaJugando = true;
            SqlJugador.ModificarPartidasYEstadoDeJugador(j);
        }

        public void FinalizarPartida(Jugador j)
        {
            if (j is not null)
            {
                j.PartidasJugadas++;
                j.EstaJugando = false;
                if (j.PuntosPartida > j.MayorPuntaje)
                {
                    j.MayorPuntaje = j.PuntosPartida;
                }
                SqlJugador.ModificarPartidasYEstadoDeJugador(j);
            }
        }

        public void ModificarEstadoJugador(Jugador j)
        {
            if (j is not null)
            {
                SqlJugador.ModificarPartidasYEstadoDeJugador(j);
            }
        }

        public void DefinirGanadorDeLaPartida(Jugador j1, Jugador j2)
        {
            if (j1.PuntosPartida > j2.PuntosPartida)
            {
                j1.EsGanador = true;
                j1.PartidasGanadas++;
                j2.PartidasPerdidas++;
            }
            else if (j1.PuntosPartida < j2.PuntosPartida)
            {
                j2.EsGanador = true;
                j2.PartidasGanadas++;
                j1.PartidasPerdidas++;
            }
        }

        public void JugarSinEnvido(Jugador jugadorMano, Jugador jugadorDos)
        {
            int maximoNumeroDeCartas = 3;

            for (int i = 0; i < 3; i++)
            {
                mostrarNotificacion.Invoke($"{Environment.NewLine}{jugadorMano.Nombre} jugo la carta: ");

                Carta cartaJugadorUno = jugadorMano.JugarCarta(0, maximoNumeroDeCartas);

                mostrarNotificacion.Invoke(MostrarCartaJugada(cartaJugadorUno));
                Thread.Sleep(GenerarNumeroRandom());

                mostrarNotificacion.Invoke($"{Environment.NewLine}{jugadorDos.Nombre} jugo la carta: ");

                Carta cartaJugadorDos = jugadorDos.JugarCarta(0, maximoNumeroDeCartas);

                mostrarNotificacion.Invoke(MostrarCartaJugada(cartaJugadorDos));
                Thread.Sleep(GenerarNumeroRandom());

                Carta cartaGanadora = Truco.DefinirCartaGanadora(cartaJugadorUno, cartaJugadorDos);

                if (cartaGanadora == cartaJugadorUno)
                {
                    InformarGanador(jugadorMano, "mano");
                    jugadorMano.PuntosPartida += 1;
                }
                else if (cartaGanadora == cartaJugadorDos)
                {
                    InformarGanador(jugadorDos, "mano");
                    jugadorDos.PuntosPartida += 1;
                }
                else
                {
                    mostrarNotificacion.Invoke($"{Environment.NewLine}Hubo empate{Environment.NewLine}");
                    Thread.Sleep(GenerarNumeroRandom());
                    jugadorMano.PuntosPartida += 1;
                    jugadorDos.PuntosPartida += 1;
                }

                EliminarCartaJugadas(jugadorMano, cartaJugadorUno);
                EliminarCartaJugadas(jugadorDos, cartaJugadorDos);

                maximoNumeroDeCartas--;
            }
        }

        public void JugarConEnvido(Jugador jugadorMano, Jugador jugadorDos)
        {
            int puntosEnvidoJugadorMano = 0;
            int puntosEnvidoJugadorNoMano = 0;

            List<Carta> cartasEnvidoJugadorMano = jugadorMano.JugarEnvido();
            List<Carta> cartasEnvidoJugadorDos = jugadorDos.JugarEnvido();

            //mostrar las cartas del envido
            mostrarNotificacion.Invoke(MostrarCartasDeEnvido(jugadorMano, cartasEnvidoJugadorMano));
            Thread.Sleep(GenerarNumeroRandom());
            mostrarNotificacion.Invoke(MostrarCartasDeEnvido(jugadorDos, cartasEnvidoJugadorDos));
            Thread.Sleep(GenerarNumeroRandom());

            //mostrar los puntos de cada jugador
            if (cartasEnvidoJugadorMano is not null && cartasEnvidoJugadorMano.Count > 0)
            {
                puntosEnvidoJugadorMano = Truco.ContarPuntosEnvido(cartasEnvidoJugadorMano[0], cartasEnvidoJugadorMano[1]);
                mostrarNotificacion.Invoke($"Puntos envido {jugadorMano.Nombre}: {puntosEnvidoJugadorMano}{Environment.NewLine}");
                Thread.Sleep(GenerarNumeroRandom());
            }

            if (cartasEnvidoJugadorDos is not null && cartasEnvidoJugadorDos.Count > 0)
            {
                puntosEnvidoJugadorNoMano = Truco.ContarPuntosEnvido(cartasEnvidoJugadorDos[0], cartasEnvidoJugadorDos[1]);
                mostrarNotificacion.Invoke($"Puntos envido {jugadorDos.Nombre}: {puntosEnvidoJugadorNoMano}{Environment.NewLine}");
                Thread.Sleep(GenerarNumeroRandom());
            }

            //recorrer cartas para eliminar las que jugo en el envido
            if (cartasEnvidoJugadorMano is not null && cartasEnvidoJugadorMano.Count > 0)
            {
                EliminarCartaJugadas(jugadorMano, cartasEnvidoJugadorMano[0]);
                EliminarCartaJugadas(jugadorMano, cartasEnvidoJugadorMano[1]);
            }

            if (cartasEnvidoJugadorDos is not null && cartasEnvidoJugadorDos.Count > 0)
            {
                EliminarCartaJugadas(jugadorDos, cartasEnvidoJugadorDos[0]);
                EliminarCartaJugadas(jugadorDos, cartasEnvidoJugadorDos[1]);
            }

            //definir ganador envido
            if (puntosEnvidoJugadorMano > puntosEnvidoJugadorNoMano)
            {
                InformarGanador(jugadorMano, "envido");
                jugadorMano.PuntosPartida += 2;
            }
            else if (puntosEnvidoJugadorMano < puntosEnvidoJugadorNoMano)
            {
                InformarGanador(jugadorDos, "envido");
                jugadorDos.PuntosPartida += 2;
            }
            else
            {
                mostrarNotificacion.Invoke($"Hubo un empate en el envido{Environment.NewLine}");
                Thread.Sleep(GenerarNumeroRandom());
            }

            //jugar la ultima carta
            mostrarNotificacion.Invoke($"{Environment.NewLine}{jugadorMano.Nombre} jugo la carta: {MostrarCartaJugada(jugadorMano.Cartas[0])}");
            Thread.Sleep(GenerarNumeroRandom());
            mostrarNotificacion.Invoke($"{Environment.NewLine}{jugadorDos.Nombre} jugo la carta: {MostrarCartaJugada(jugadorDos.Cartas[0])}");
            Thread.Sleep(GenerarNumeroRandom());

            Carta cartaGanadora = truco.DefinirCartaGanadora(jugadorMano.Cartas[0], jugadorDos.Cartas[0]);

            if (cartaGanadora == jugadorMano.Cartas[0])
            {
                InformarGanador(jugadorMano, "mano");
                jugadorMano.PuntosPartida += 1;
            }
            else
            {
                InformarGanador(jugadorDos, "mano");
                jugadorDos.PuntosPartida += 1;
            }

            //eliminar las cartas que queden
            jugadorMano.Cartas.Clear();
            jugadorDos.Cartas.Clear();
        }

        private void InformarGanador(Jugador ganador, string jugada)
        {
            if (ganador is not null)
            {
                mostrarNotificacion.Invoke($"{Environment.NewLine}Ganador {jugada}: {ganador.Nombre}{Environment.NewLine}");
                Thread.Sleep(GenerarNumeroRandom());
            }
        }

        public int CambiarDeMano(int flag)
        {
            return (flag == 0) ? 1 : 0;
        }

        public string MostrarCartaJugada(Carta c)
        {
            return $"{c.Numero} de {c.Palo}";
        }

        public string MostrarCartasDeEnvido(Jugador j, List<Carta> cartasEnvido)
        {
            if (cartasEnvido is null || cartasEnvido.Count == 0)
            {
                return $"El jugador {j.Nombre} no cuenta con envido{Environment.NewLine}";
            }

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cartas de {j.Nombre}: ");
            foreach (Carta carta in cartasEnvido)
            {
                sb.AppendLine(MostrarCartaJugada(carta));
            }

            return sb.ToString();
        }

        public void EliminarCartaJugadas(Jugador j, Carta c)
        {
            if (j is not null && c is not null)
            {
                for (int i = 0; i < j.Cartas.Count; i++)
                {
                    if (j.Cartas[i] == c)
                    {
                        j.Cartas.RemoveAt(i);
                        break;
                    }
                }
            }
        }
        public void GuardarHistorialPartida(string historial)
        {
            try
            {
                StreamWriter historialPartida = new StreamWriter($"{AppDomain.CurrentDomain.BaseDirectory}" + @"HistorialPartida", true);
                historialPartida.WriteLine(historial);
                historialPartida.Close();
            }
            catch(DirectoryNotFoundException exc)
            {
                throw new DirectoryNotFoundException("No se encontró el archivo", exc);
            }
            catch(Exception exc)
            {
                throw new Exception("Error al guardar el historial de la partida", exc);
            }
        }

    }
}
