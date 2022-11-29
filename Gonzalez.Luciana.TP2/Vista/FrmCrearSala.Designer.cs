
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrearSala));
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
            this.lblJugadorUno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblJugadorUno.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJugadorUno.Location = new System.Drawing.Point(187, 101);
            this.lblJugadorUno.Name = "lblJugadorUno";
            this.lblJugadorUno.Size = new System.Drawing.Size(52, 24);
            this.lblJugadorUno.TabIndex = 1;
            this.lblJugadorUno.Text = "label1";
            this.lblJugadorUno.Visible = false;
            // 
            // lblJugadorDos
            // 
            this.lblJugadorDos.AutoSize = true;
            this.lblJugadorDos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblJugadorDos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJugadorDos.Location = new System.Drawing.Point(187, 209);
            this.lblJugadorDos.Name = "lblJugadorDos";
            this.lblJugadorDos.Size = new System.Drawing.Size(52, 24);
            this.lblJugadorDos.TabIndex = 2;
            this.lblJugadorDos.Text = "label1";
            this.lblJugadorDos.Visible = false;
            // 
            // lblNombreUno
            // 
            this.lblNombreUno.AutoSize = true;
            this.lblNombreUno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombreUno.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreUno.Location = new System.Drawing.Point(187, 53);
            this.lblNombreUno.Name = "lblNombreUno";
            this.lblNombreUno.Size = new System.Drawing.Size(103, 24);
            this.lblNombreUno.TabIndex = 3;
            this.lblNombreUno.Text = "Jugador Uno";
            // 
            // lblNombreDos
            // 
            this.lblNombreDos.AutoSize = true;
            this.lblNombreDos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombreDos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreDos.Location = new System.Drawing.Point(187, 161);
            this.lblNombreDos.Name = "lblNombreDos";
            this.lblNombreDos.Size = new System.Drawing.Size(102, 24);
            this.lblNombreDos.TabIndex = 4;
            this.lblNombreDos.Text = "Jugador Dos";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightGreen;
            this.btnCancelar.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(287, 302);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 37);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.LightGreen;
            this.btnCrear.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCrear.Location = new System.Drawing.Point(170, 302);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(111, 37);
            this.btnCrear.TabIndex = 6;
            this.btnCrear.Text = "Crear Sala";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnElegirJugadorUno
            // 
            this.btnElegirJugadorUno.BackColor = System.Drawing.Color.LightGreen;
            this.btnElegirJugadorUno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnElegirJugadorUno.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnElegirJugadorUno.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnElegirJugadorUno.Location = new System.Drawing.Point(21, 53);
            this.btnElegirJugadorUno.Name = "btnElegirJugadorUno";
            this.btnElegirJugadorUno.Size = new System.Drawing.Size(119, 91);
            this.btnElegirJugadorUno.TabIndex = 7;
            this.btnElegirJugadorUno.Text = "Elegir Jugador Uno";
            this.btnElegirJugadorUno.UseVisualStyleBackColor = false;
            this.btnElegirJugadorUno.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnElegirJugadorDos
            // 
            this.btnElegirJugadorDos.BackColor = System.Drawing.Color.LightGreen;
            this.btnElegirJugadorDos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnElegirJugadorDos.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnElegirJugadorDos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnElegirJugadorDos.Location = new System.Drawing.Point(21, 161);
            this.btnElegirJugadorDos.Name = "btnElegirJugadorDos";
            this.btnElegirJugadorDos.Size = new System.Drawing.Size(119, 94);
            this.btnElegirJugadorDos.TabIndex = 8;
            this.btnElegirJugadorDos.Text = "Elegir Jugador Dos";
            this.btnElegirJugadorDos.UseVisualStyleBackColor = false;
            this.btnElegirJugadorDos.Click += new System.EventHandler(this.btnElegirJugadorDos_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Black;
            this.lblError.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(21, 271);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(45, 19);
            this.lblError.TabIndex = 9;
            this.lblError.Text = "error";
            this.lblError.Visible = false;
            // 
            // FrmCrearSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCrearSala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Sala";
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