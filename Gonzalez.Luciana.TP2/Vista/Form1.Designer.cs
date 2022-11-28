
namespace Vista
{
    partial class FrmPartida
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPartida));
            this.rtbPartida = new System.Windows.Forms.RichTextBox();
            this.lblAnunciarGanador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbPartida
            // 
            this.rtbPartida.Location = new System.Drawing.Point(12, 12);
            this.rtbPartida.Name = "rtbPartida";
            this.rtbPartida.Size = new System.Drawing.Size(576, 319);
            this.rtbPartida.TabIndex = 2;
            this.rtbPartida.Text = "";
            // 
            // lblAnunciarGanador
            // 
            this.lblAnunciarGanador.AutoSize = true;
            this.lblAnunciarGanador.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblAnunciarGanador.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAnunciarGanador.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblAnunciarGanador.Location = new System.Drawing.Point(12, 350);
            this.lblAnunciarGanador.Name = "lblAnunciarGanador";
            this.lblAnunciarGanador.Size = new System.Drawing.Size(80, 27);
            this.lblAnunciarGanador.TabIndex = 3;
            this.lblAnunciarGanador.Text = "label1";
            this.lblAnunciarGanador.Visible = false;
            // 
            // FrmPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(599, 450);
            this.Controls.Add(this.lblAnunciarGanador);
            this.Controls.Add(this.rtbPartida);
            this.DoubleBuffered = true;
            this.Name = "FrmPartida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Partida";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbPartida;
        private System.Windows.Forms.Label lblAnunciarGanador;
    }
}

