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
    public partial class Estadisticas : Form
    {
        string titulo;
        string estadisticas;
        public Estadisticas(string titulo, string estadisticas)
        {
            InitializeComponent();
            this.titulo = titulo;
            this.estadisticas = estadisticas;
        }

        private void Estadistticas_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = titulo;
            rtbEstadisticas.Text = estadisticas;
        }
    }
}
