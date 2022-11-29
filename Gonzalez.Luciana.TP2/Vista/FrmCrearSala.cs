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
    public partial class FrmCrearSala : Form
    {
        Jugador jugadorUno;
        Jugador jugadorDos;
        Sala sala;
        public FrmCrearSala()
        {
            InitializeComponent();
        }

        public Jugador JugadorUno { get => jugadorUno; }
        public Jugador JugadorDos { get => jugadorDos; }
        public Sala Sala { get => sala; }

        private void FrmCrearSala_Load(object sender, EventArgs e)
        {

        }

        private void dgvListaJugadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (SonJugadoresValidos())
            {
                sala = new Sala(jugadorUno, jugadorDos);
                DialogResult = DialogResult.OK;
                this.Close(); 
            }
            else
            {
                lblError.Text = "Debe elegir dos jugadores distintos";
                lblError.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            FrmElegirJugador frmElegirJugador = new FrmElegirJugador();
            DialogResult resultado = frmElegirJugador.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                jugadorUno = frmElegirJugador.JugadorElegido;
                lblJugadorUno.Text = jugadorUno.Nombre;
                lblJugadorUno.Visible = true;
            }
        }

        private void btnElegirJugadorDos_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            FrmElegirJugador frmElegirJugador = new FrmElegirJugador();
            DialogResult resultado = frmElegirJugador.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                jugadorDos = frmElegirJugador.JugadorElegido;
                lblJugadorDos.Text = jugadorDos.Nombre;
                lblJugadorDos.Visible = true;
            }
        }

        private bool SonJugadoresValidos()
        {
            if (jugadorUno is not null && jugadorDos is not null
                && jugadorUno != jugadorDos)
            {
                return true;
            }
            return false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Esta seguro que desea cancelar?", "Cancelar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
