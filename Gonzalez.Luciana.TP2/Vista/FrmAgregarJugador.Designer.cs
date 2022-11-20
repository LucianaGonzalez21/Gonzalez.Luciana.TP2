
namespace Vista
{
    partial class FrmAgregarJugador
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
            this.btnAgregarJugador = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregarJugador
            // 
            this.btnAgregarJugador.Location = new System.Drawing.Point(90, 95);
            this.btnAgregarJugador.Name = "btnAgregarJugador";
            this.btnAgregarJugador.Size = new System.Drawing.Size(94, 29);
            this.btnAgregarJugador.TabIndex = 0;
            this.btnAgregarJugador.Text = "Agregar";
            this.btnAgregarJugador.UseVisualStyleBackColor = true;
            this.btnAgregarJugador.Click += new System.EventHandler(this.btnAgregarJugador_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(78, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Ingrese el nombre";
            this.txtNombre.Size = new System.Drawing.Size(131, 27);
            this.txtNombre.TabIndex = 1;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(18, 145);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(41, 20);
            this.lblError.TabIndex = 2;
            this.lblError.Text = "error";
            this.lblError.Visible = false;
            // 
            // FrmAgregarJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 184);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnAgregarJugador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmAgregarJugador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Jugador";
            this.Load += new System.EventHandler(this.FrmAgregarJugador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarJugador;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblError;
    }
}