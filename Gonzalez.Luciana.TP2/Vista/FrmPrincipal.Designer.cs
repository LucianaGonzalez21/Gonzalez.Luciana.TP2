
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnVerPartida = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearSala
            // 
            this.btnCrearSala.Location = new System.Drawing.Point(44, 47);
            this.btnCrearSala.Name = "btnCrearSala";
            this.btnCrearSala.Size = new System.Drawing.Size(111, 68);
            this.btnCrearSala.TabIndex = 0;
            this.btnCrearSala.Text = "Crear Sala";
            this.btnCrearSala.UseVisualStyleBackColor = true;
            this.btnCrearSala.Click += new System.EventHandler(this.btnCrearSala_Click);
            // 
            // btnVerJugadores
            // 
            this.btnVerJugadores.Location = new System.Drawing.Point(307, 47);
            this.btnVerJugadores.Name = "btnVerJugadores";
            this.btnVerJugadores.Size = new System.Drawing.Size(111, 68);
            this.btnVerJugadores.TabIndex = 1;
            this.btnVerJugadores.Text = "Ver Jugadores";
            this.btnVerJugadores.UseVisualStyleBackColor = true;
            this.btnVerJugadores.Click += new System.EventHandler(this.btnVerJugadores_Click);
            // 
            // btnRegistrarJugador
            // 
            this.btnRegistrarJugador.Location = new System.Drawing.Point(173, 47);
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
            this.dgvSalas.Location = new System.Drawing.Point(44, 169);
            this.dgvSalas.Name = "dgvSalas";
            this.dgvSalas.RowHeadersWidth = 51;
            this.dgvSalas.RowTemplate.Height = 29;
            this.dgvSalas.Size = new System.Drawing.Size(438, 188);
            this.dgvSalas.TabIndex = 3;
            this.dgvSalas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPartidas_CellClick);
            this.dgvSalas.Click += new System.EventHandler(this.dgvPartidas_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(44, 132);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(56, 28);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Salas";
            // 
            // btnVerPartida
            // 
            this.btnVerPartida.Location = new System.Drawing.Point(498, 169);
            this.btnVerPartida.Name = "btnVerPartida";
            this.btnVerPartida.Size = new System.Drawing.Size(111, 33);
            this.btnVerPartida.TabIndex = 5;
            this.btnVerPartida.Text = "Comenzar Partida";
            this.btnVerPartida.UseVisualStyleBackColor = true;
            this.btnVerPartida.Click += new System.EventHandler(this.btnVerPartida_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(445, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 68);
            this.button1.TabIndex = 6;
            this.button1.Text = "Mayores Ganadores";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 415);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVerPartida);
            this.Controls.Add(this.lblTitulo);
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
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnVerPartida;
        private System.Windows.Forms.Button button1;
    }
}