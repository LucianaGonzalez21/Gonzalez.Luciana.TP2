using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmPrincipal : Form
    {
        Sala sala;
        List<Carta> mazo;
        string rutaArchivo;
        int indiceListaSalas;
        public FrmPrincipal()
        {
            InitializeComponent();
            rutaArchivo = $"{AppDomain.CurrentDomain.BaseDirectory}" + @"mazoCartas.json";
            mazo = Serializador.Leer<List<Carta>>(rutaArchivo);
        }

        private void btnRegistrarJugador_Click(object sender, EventArgs e)
        {
            FrmAgregarJugador frmAgregarJugador = new FrmAgregarJugador();

            DialogResult respuesta = frmAgregarJugador.ShowDialog();

            if (respuesta == DialogResult.OK)
            {
                try
                {
                    SqlJugador.Guardar(frmAgregarJugador.NuevoJugador);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void btnCrearSala_Click(object sender, EventArgs e)
        {
            FrmCrearSala frmCrearSala = new FrmCrearSala();
            DialogResult respuesta = frmCrearSala.ShowDialog();

            if (respuesta == DialogResult.OK)
            {
                try
                {
                    SqlSala.Guardar(frmCrearSala.Sala);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
                finally
                {
                    RefrescarDataGridView();
                }
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            RefrescarDataGridView();
        }

        private void RefrescarDataGridView()
        {
            dgvSalas.DataSource = null;
            dgvSalas.DataSource = SqlSala.Leer();
            dgvSalas.Columns["J1"].Visible = false;
            dgvSalas.Columns["J2"].Visible = false;
            dgvSalas.Update();
            dgvSalas.Refresh();
        }

        private void btnVerPartida_Click(object sender, EventArgs e)
        {
            if (sala is not null)
            {
                if (Administrador.ValidarJugadoresEstenLibresParaJugar(sala.J1, sala.J2))
                {
                    sala.Mazo = mazo;
                    FrmPartida frmPartida = new FrmPartida(sala);
                    frmPartida.Show();
                }
                else
                {                   
                    lblError.Text = MostrarMensajeErrorJugadorOcupado(sala.J1, sala.J2);
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Text = "Para comenzar una partida, primero debe elegir una sala";
                lblError.Visible = true;
            }
        }

        private void dgvPartidas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indiceListaSalas = dgvSalas.CurrentRow.Index;
            sala = SqlSala.Leer()[indiceListaSalas];
            lblError.Visible = false;
        }

        private void dgvPartidas_Click(object sender, EventArgs e)
        {

        }

        private void btnVerJugadores_Click(object sender, EventArgs e)
        {
            try
            {
                string listaJugadores = Administrador.MostrarListaJugadoresOrdenados();
                Estadisticas frmEstadisticas = new Estadisticas("Jugadores ordenados por nombre", listaJugadores);
                frmEstadisticas.ShowDialog();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string jugadoresQueMasGanaron = Administrador.MostrarJugadoresConMasPartidasGanadas();
                Estadisticas estadisticas = new Estadisticas("Jugadores con mayor cantidad de partidas ganadas", jugadoresQueMasGanaron);
                estadisticas.ShowDialog();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnPartidasGanadas_Click(object sender, EventArgs e)
        {
            try
            {
                string jugadoresConPartidasGanadas = Administrador.MostrarJugadoresPorPartidasGanadas();
                Estadisticas estadisticas = new Estadisticas("Partidas ganadas de cada jugador", jugadoresConPartidasGanadas);
                estadisticas.ShowDialog();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnPartidasPerdidas_Click(object sender, EventArgs e)
        {
            try
            {
                string jugadoresConPartidasPerdidas = Administrador.MostrarJugadoresPorPartidasPerdidas();
                Estadisticas estadisticas = new Estadisticas("Partidas perdidas de cada jugador", jugadoresConPartidasPerdidas);
                estadisticas.ShowDialog();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private string MostrarMensajeErrorJugadorOcupado(Jugador j1, Jugador j2)
        {
            if (j1.EstaJugando && j2.EstaJugando)
            {
                return $"{j1.Nombre} y {j2.Nombre} ya se encuentran jugando";
            }
            else if (j1.EstaJugando)
            {
                return $"{j1.Nombre} se encuentra en una partida";
            }
            else
            {
                return $"{j2.Nombre} se encuentra en una partida";
            }
        }

        private void btnPuntajesMaximos_Click(object sender, EventArgs e)
        {
            try
            {
                string jugadoresConMayorPuntaje = Administrador.MostrarJugadoresConMayorPuntaje();
                Estadisticas estadisticas = new Estadisticas("Jugadores que tienen el maximo puntaje", jugadoresConMayorPuntaje);
                estadisticas.ShowDialog();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
