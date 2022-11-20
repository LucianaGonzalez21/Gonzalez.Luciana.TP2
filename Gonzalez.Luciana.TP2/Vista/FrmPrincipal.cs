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
        public FrmPrincipal()
        {
            InitializeComponent();
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
                catch (Exception)
                {
                    MessageBox.Show("Ocurrio un error");
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
                catch (Exception)
                {
                    MessageBox.Show("Ocurrio un error");
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
                string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string rutaArchivo = Path.Combine(rutaEscritorio, "mazoCartas.json");
                mazo = Serializador.Leer<List<Carta>>(rutaArchivo);
                sala.Mazo = mazo;
                FrmPartida frmPartida = new FrmPartida(sala);
                frmPartida.Show();
            }
            else
            {
                MessageBox.Show("elegir primero la sala");
            }
        }

        private void dgvPartidas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSalas.SelectedRows.Count > 0)
            {
                sala = (Sala)dgvSalas.CurrentRow.DataBoundItem;
            }

        }

        private void dgvPartidas_Click(object sender, EventArgs e)
        {

        }

        private void btnVerJugadores_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                foreach (Jugador j in SqlJugador.OrdenarJugadoresPorNombre())
                {
                    sb.AppendLine(j.ToString());
                    sb.AppendLine();
                }

                MessageBox.Show(sb.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                foreach (Jugador j in SqlJugador.FiltrarJugadoresConMasPartidasGanadas())
                {
                    sb.AppendLine(j.ToString());
                    sb.AppendLine();
                }

                MessageBox.Show(sb.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error");
            }

        }
    }
}
