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
    public partial class FrmAgregarJugador : Form
    {
        Jugador jugador;
        public FrmAgregarJugador()
        {
            InitializeComponent();
        }

        public Jugador NuevoJugador { get => jugador; }

        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            if (ValidarNombre())
            {
                jugador = new Jugador(txtNombre.Text);
                
                if (Administrador.EsJugadorExistente(jugador) == false)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    lblError.Text = "El nombre ya se encuentra registrado";
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Text = "Nombre no valido";
                lblError.Visible = true;
            }

        }

        private bool ValidarNombre()
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                return false;
            }
            return true;
        }

        private void FrmAgregarJugador_Load(object sender, EventArgs e)
        {

        }
    }
}
