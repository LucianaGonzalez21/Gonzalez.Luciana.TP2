
namespace Vista
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCrearSala = new System.Windows.Forms.Button();
            this.btnVerJugadores = new System.Windows.Forms.Button();
            this.btnRegistrarJugador = new System.Windows.Forms.Button();
            this.dgvSalas = new System.Windows.Forms.DataGridView();
            this.lblTituloSalas = new System.Windows.Forms.Label();
            this.btnVerPartida = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblTituloEstadisticas = new System.Windows.Forms.Label();
            this.btnPartidasGanadas = new System.Windows.Forms.Button();
            this.btnPartidasPerdidas = new System.Windows.Forms.Button();
            this.btnPuntajesMaximos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearSala
            // 
            this.btnCrearSala.Location = new System.Drawing.Point(47, 312);
            this.btnCrearSala.Name = "btnCrearSala";
            this.btnCrearSala.Size = new System.Drawing.Size(111, 68);
            this.btnCrearSala.TabIndex = 0;
            this.btnCrearSala.Text = "Crear Sala";
            this.btnCrearSala.UseVisualStyleBackColor = true;
            this.btnCrearSala.Click += new System.EventHandler(this.btnCrearSala_Click);
            // 
            // btnVerJugadores
            // 
            this.btnVerJugadores.Location = new System.Drawing.Point(308, 312);
            this.btnVerJugadores.Name = "btnVerJugadores";
            this.btnVerJugadores.Size = new System.Drawing.Size(111, 68);
            this.btnVerJugadores.TabIndex = 1;
            this.btnVerJugadores.Text = "Ver Jugadores";
            this.btnVerJugadores.UseVisualStyleBackColor = true;
            this.btnVerJugadores.Click += new System.EventHandler(this.btnVerJugadores_Click);
            // 
            // btnRegistrarJugador
            // 
            this.btnRegistrarJugador.Location = new System.Drawing.Point(179, 312);
            this.btnRegistrarJugador.Name = "btnRegistrarJugador";
            this.btnRegistrarJugador.Size = new System.Drawing.Size(111, 68);
            this.btnRegistrarJugador.TabIndex = 2;
            this.btnRegistrarJugador.Text = "Registrar Jugador";
            this.btnRegistrarJugador.UseVisualStyleBackColor = true;
            this.btnRegistrarJugador.Click += new System.EventHandler(this.btnRegistrarJugador_Click);
            // 
            // dgvSalas
            // 
            this.dgvSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalas.Location = new System.Drawing.Point(44, 58);
            this.dgvSalas.Name = "dgvSalas";
            this.dgvSalas.RowHeadersWidth = 51;
            this.dgvSalas.RowTemplate.Height = 29;
            this.dgvSalas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalas.Size = new System.Drawing.Size(438, 188);
            this.dgvSalas.TabIndex = 3;
            this.dgvSalas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPartidas_CellClick);
            this.dgvSalas.Click += new System.EventHandler(this.dgvPartidas_Click);
            // 
            // lblTituloSalas
            // 
            this.lblTituloSalas.AutoSize = true;
            this.lblTituloSalas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTituloSalas.Location = new System.Drawing.Point(44, 21);
            this.lblTituloSalas.Name = "lblTituloSalas";
            this.lblTituloSalas.Size = new System.Drawing.Size(56, 28);
            this.lblTituloSalas.TabIndex = 4;
            this.lblTituloSalas.Text = "Salas";
            // 
            // btnVerPartida
            // 
            this.btnVerPartida.Location = new System.Drawing.Point(498, 58);
            this.btnVerPartida.Name = "btnVerPartida";
            this.btnVerPartida.Size = new System.Drawing.Size(111, 33);
            this.btnVerPartida.TabIndex = 5;
            this.btnVerPartida.Text = "Comenzar ";
            this.btnVerPartida.UseVisualStyleBackColor = true;
            this.btnVerPartida.Click += new System.EventHandler(this.btnVerPartida_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 68);
            this.button1.TabIndex = 6;
            this.button1.Text = "Mayores Ganadores";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(44, 264);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(100, 20);
            this.lblError.TabIndex = 7;
            this.lblError.Text = "mensaje error";
            this.lblError.Visible = false;
            // 
            // lblTituloEstadisticas
            // 
            this.lblTituloEstadisticas.AutoSize = true;
            this.lblTituloEstadisticas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTituloEstadisticas.Location = new System.Drawing.Point(48, 402);
            this.lblTituloEstadisticas.Name = "lblTituloEstadisticas";
            this.lblTituloEstadisticas.Size = new System.Drawing.Size(111, 28);
            this.lblTituloEstadisticas.TabIndex = 8;
            this.lblTituloEstadisticas.Text = "Estadisticas";
            // 
            // btnPartidasGanadas
            // 
            this.btnPartidasGanadas.Location = new System.Drawing.Point(173, 453);
            this.btnPartidasGanadas.Name = "btnPartidasGanadas";
            this.btnPartidasGanadas.Size = new System.Drawing.Size(111, 68);
            this.btnPartidasGanadas.TabIndex = 9;
            this.btnPartidasGanadas.Text = "Partidas Ganadas";
            this.btnPartidasGanadas.UseVisualStyleBackColor = true;
            this.btnPartidasGanadas.Click += new System.EventHandler(this.btnPartidasGanadas_Click);
            // 
            // btnPartidasPerdidas
            // 
            this.btnPartidasPerdidas.Location = new System.Drawing.Point(307, 453);
            this.btnPartidasPerdidas.Name = "btnPartidasPerdidas";
            this.btnPartidasPerdidas.Size = new System.Drawing.Size(111, 68);
            this.btnPartidasPerdidas.TabIndex = 10;
            this.btnPartidasPerdidas.Text = "Partidas Perdidas";
            this.btnPartidasPerdidas.UseVisualStyleBackColor = true;
            this.btnPartidasPerdidas.Click += new System.EventHandler(this.btnPartidasPerdidas_Click);
            // 
            // btnPuntajesMaximos
            // 
            this.btnPuntajesMaximos.Location = new System.Drawing.Point(444, 453);
            this.btnPuntajesMaximos.Name = "btnPuntajesMaximos";
            this.btnPuntajesMaximos.Size = new System.Drawing.Size(111, 68);
            this.btnPuntajesMaximos.TabIndex = 11;
            this.btnPuntajesMaximos.Text = "Puntajes Maximos";
            this.btnPuntajesMaximos.UseVisualStyleBackColor = true;
            this.btnPuntajesMaximos.Click += new System.EventHandler(this.btnPuntajesMaximos_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 545);
            this.Controls.Add(this.btnPuntajesMaximos);
            this.Controls.Add(this.btnPartidasPerdidas);
            this.Controls.Add(this.btnPartidasGanadas);
            this.Controls.Add(this.lblTituloEstadisticas);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVerPartida);
            this.Controls.Add(this.lblTituloSalas);
            this.Controls.Add(this.dgvSalas);
            this.Controls.Add(this.btnRegistrarJugador);
            this.Controls.Add(this.btnVerJugadores);
            this.Controls.Add(this.btnCrearSala);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearSala;
        private System.Windows.Forms.Button btnVerJugadores;
        private System.Windows.Forms.Button btnRegistrarJugador;
        private System.Windows.Forms.DataGridView dgvSalas;
        private System.Windows.Forms.Label lblTituloSalas;
        private System.Windows.Forms.Button btnVerPartida;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblTituloEstadisticas;
        private System.Windows.Forms.Button btnPartidasGanadas;
        private System.Windows.Forms.Button btnPartidasPerdidas;
        private System.Windows.Forms.Button btnPuntajesMaximos;
    }
}