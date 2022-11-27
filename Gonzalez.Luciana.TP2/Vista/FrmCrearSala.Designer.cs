
namespace Vista
{
    partial class FrmCrearSala
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
            this.lblJugadorUno = new System.Windows.Forms.Label();
            this.lblJugadorDos = new System.Windows.Forms.Label();
            this.lblNombreUno = new System.Windows.Forms.Label();
            this.lblNombreDos = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnElegirJugadorUno = new System.Windows.Forms.Button();
            this.btnElegirJugadorDos = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblJugadorUno
            // 
            this.lblJugadorUno.AutoSize = true;
            this.lblJugadorUno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJugadorUno.Location = new System.Drawing.Point(187, 101);
            this.lblJugadorUno.Name = "lblJugadorUno";
            this.lblJugadorUno.Size = new System.Drawing.Size(65, 28);
            this.lblJugadorUno.TabIndex = 1;
            this.lblJugadorUno.Text = "label1";
            this.lblJugadorUno.Visible = false;
            // 
            // lblJugadorDos
            // 
            this.lblJugadorDos.AutoSize = true;
            this.lblJugadorDos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJugadorDos.Location = new System.Drawing.Point(187, 209);
            this.lblJugadorDos.Name = "lblJugadorDos";
            this.lblJugadorDos.Size = new System.Drawing.Size(65, 28);
            this.lblJugadorDos.TabIndex = 2;
            this.lblJugadorDos.Text = "label1";
            this.lblJugadorDos.Visible = false;
            // 
            // lblNombreUno
            // 
            this.lblNombreUno.AutoSize = true;
            this.lblNombreUno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreUno.Location = new System.Drawing.Point(187, 53);
            this.lblNombreUno.Name = "lblNombreUno";
            this.lblNombreUno.Size = new System.Drawing.Size(125, 28);
            this.lblNombreUno.TabIndex = 3;
            this.lblNombreUno.Text = "Jugador Uno";
            // 
            // lblNombreDos
            // 
            this.lblNombreDos.AutoSize = true;
            this.lblNombreDos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreDos.Location = new System.Drawing.Point(187, 161);
            this.lblNombreDos.Name = "lblNombreDos";
            this.lblNombreDos.Size = new System.Drawing.Size(122, 28);
            this.lblNombreDos.TabIndex = 4;
            this.lblNombreDos.Text = "Jugador Dos";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(304, 310);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 29);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(204, 310);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(94, 29);
            this.btnCrear.TabIndex = 6;
            this.btnCrear.Text = "Crear Sala";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnElegirJugadorUno
            // 
            this.btnElegirJugadorUno.Location = new System.Drawing.Point(21, 53);
            this.btnElegirJugadorUno.Name = "btnElegirJugadorUno";
            this.btnElegirJugadorUno.Size = new System.Drawing.Size(119, 53);
            this.btnElegirJugadorUno.TabIndex = 7;
            this.btnElegirJugadorUno.Text = "Elegir Jugador Uno";
            this.btnElegirJugadorUno.UseVisualStyleBackColor = true;
            this.btnElegirJugadorUno.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnElegirJugadorDos
            // 
            this.btnElegirJugadorDos.Location = new System.Drawing.Point(21, 161);
            this.btnElegirJugadorDos.Name = "btnElegirJugadorDos";
            this.btnElegirJugadorDos.Size = new System.Drawing.Size(119, 60);
            this.btnElegirJugadorDos.TabIndex = 8;
            this.btnElegirJugadorDos.Text = "Elegir Jugador Dos";
            this.btnElegirJugadorDos.UseVisualStyleBackColor = true;
            this.btnElegirJugadorDos.Click += new System.EventHandler(this.btnElegirJugadorDos_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblError.Location = new System.Drawing.Point(21, 271);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(47, 23);
            this.lblError.TabIndex = 9;
            this.lblError.Text = "error";
            this.lblError.Visible = false;
            // 
            // FrmCrearSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 351);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnElegirJugadorDos);
            this.Controls.Add(this.btnElegirJugadorUno);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblNombreDos);
            this.Controls.Add(this.lblNombreUno);
            this.Controls.Add(this.lblJugadorDos);
            this.Controls.Add(this.lblJugadorUno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmCrearSala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCrearSala";
            this.Load += new System.EventHandler(this.FrmCrearSala_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblJugadorUno;
        private System.Windows.Forms.Label lblJugadorDos;
        private System.Windows.Forms.Label lblNombreUno;
        private System.Windows.Forms.Label lblNombreDos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnElegirJugadorUno;
        private System.Windows.Forms.Button btnElegirJugadorDos;
        private System.Windows.Forms.Label lblError;
    }
}