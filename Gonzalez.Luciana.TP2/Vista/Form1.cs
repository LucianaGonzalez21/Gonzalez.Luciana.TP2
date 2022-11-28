using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Vista
{
    public partial class FrmPartida : Form , IHilos , IPartidaFinalizada
    {
        public Action<string> mostrarNotificacion;
        Partida partida;
        CancellationTokenSource cancellationTokenSource;
        CancellationToken cancellationToken;
        Sala sala;
        string historialPartida;

        public FrmPartida(Sala sala)
        {
            InitializeComponent();
            mostrarNotificacion = ActualizarRichTextBox;
            this.sala = sala;
        }

        public Partida Partida { get => partida; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarRichTextBox(string texto)
        {
            if (rtbPartida.InvokeRequired)
            {
                Action<string> delegado = ActualizarRichTextBox;
                object[] parametros = new object[] { texto };
                rtbPartida.BeginInvoke(delegado, parametros);
            }
            else
            {
                if (rtbPartida.IsDisposed == false)
                {
                    rtbPartida.Text += texto;
                    rtbPartida.SelectionStart = rtbPartida.Text.Length;
                    rtbPartida.ScrollToCaret();
                    historialPartida = rtbPartida.Text;
                }
            }
        }

        //metodo manejador
        private void AnunciarGanador(string nombreGanador)
        {
            if (lblAnunciarGanador.InvokeRequired)
            {
                Action<string> delegado = AnunciarGanador;
                object[] parametros = new object[] { nombreGanador };
                lblAnunciarGanador.BeginInvoke(delegado, parametros);
            }
            else
            {
                lblAnunciarGanador.Text = $"El ganador de la partida es: {nombreGanador}";
                lblAnunciarGanador.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Truco truco = new Truco();
            partida = new Partida(sala, 3, truco, mostrarNotificacion);

            sala.J1.EventoEsGanador += AnunciarGanador;
            sala.J2.EventoEsGanador += AnunciarGanador;

            IniciarHilo();
        }

        public void IniciarHilo()
        {
            cancellationTokenSource = new CancellationTokenSource();
            cancellationToken = cancellationTokenSource.Token;

            Task.Run(() => partida.JugarPartida(), cancellationToken);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FinalizarPartida(sala.J1);
            FinalizarPartida(sala.J2);
            partida.GuardarHistorialPartida(historialPartida);
            cancellationTokenSource.Cancel();
        }

        public void FinalizarPartida(Jugador j)
        {
            j.EstaJugando = false;
            SqlJugador.ModificarPartidasYEstadoDeJugador(j);
        }

    }
}
