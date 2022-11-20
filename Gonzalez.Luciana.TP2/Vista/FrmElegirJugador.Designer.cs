
namespace Vista
{
    partial class FrmElegirJugador
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
            this.dgvJugadores = new System.Windows.Forms.DataGridView();
            this.btnElegir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblJugador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJugadores
            // 
            this.dgvJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJugadores.Location = new System.Drawing.Point(35, 33);
            this.dgvJugadores.Name = "dgvJugadores";
            this.dgvJugadores.RowHeadersWidth = 51;
            this.dgvJugadores.RowTemplate.Height = 29;
            this.dgvJugadores.Size = new System.Drawing.Size(300, 188);
            this.dgvJugadores.TabIndex = 0;
            this.dgvJugadores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJugadores_CellClick);
            // 
            // btnElegir
            // 
            this.btnElegir.Location = new System.Drawing.Point(126, 290);
            this.btnElegir.Name = "btnElegir";
            this.btnElegir.Size = new System.Drawing.Size(94, 29);
            this.btnElegir.TabIndex = 1;
            this.btnElegir.Text = "Elegir";
            this.btnElegir.UseVisualStyleBackColor = true;
            this.btnElegir.Click += new System.EventHandler(this.btnElegir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(241, 290);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 29);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(35, 238);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 28);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Jugador:";
            // 
            // lblJugador
            // 
            this.lblJugador.AutoSize = true;
            this.lblJugador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJugador.Location = new System.Drawing.Point(133, 238);
            this.lblJugador.Name = "lblJugador";
            this.lblJugador.Size = new System.Drawing.Size(81, 28);
            this.lblJugador.TabIndex = 4;
            this.lblJugador.Text = "nombre";
            // 
            // FrmElegirJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 331);
            this.Controls.Add(this.lblJugador);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnElegir);
            this.Controls.Add(this.dgvJugadores);
            this.Name = "FrmElegirJugador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elegir Jugador";
            this.Load += new System.EventHandler(this.FrmElegirJugador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJugadores;
        private System.Windows.Forms.Button btnElegir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblJugador;
    }
}