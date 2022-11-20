using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmElegirJugador : Form
    {
        Jugador jugador;
        public FrmElegirJugador()
        {
            InitializeComponent();
        }

        public Jugador JugadorElegido { get => jugador; }

        private void FrmElegirJugador_Load(object sender, EventArgs e)
        {
            dgvJugadores.DataSource = SqlJugador.Leer();
            dgvJugadores.Columns["EsGanador"].Visible = false;
            dgvJugadores.Columns["PuntosPartida"].Visible = false;
            dgvJugadores.Columns["EstaJugando"].Visible = false;
        }

        private void dgvJugadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            jugador = (Jugador)dgvJugadores.CurrentRow.DataBoundItem;
            lblJugador.Text = jugador.Nombre;
        }

        private void btnElegir_Click(object sender, EventArgs e)
        {
            if(jugador is null)
            {
                MessageBox.Show("Debe elegir un jugador");
            }
            else
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
