namespace EMPADI
{
    partial class PantallaElegirComprobante
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
            this.campo_telefono = new System.Windows.Forms.TextBox();
            this.boton_enviarT = new System.Windows.Forms.Button();
            this.opcionComprobante = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // campo_telefono
            // 
            this.campo_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campo_telefono.Location = new System.Drawing.Point(13, 190);
            this.campo_telefono.Multiline = true;
            this.campo_telefono.Name = "campo_telefono";
            this.campo_telefono.Size = new System.Drawing.Size(177, 55);
            this.campo_telefono.TabIndex = 2;
            // 
            // boton_enviarT
            // 
            this.boton_enviarT.Location = new System.Drawing.Point(13, 252);
            this.boton_enviarT.Name = "boton_enviarT";
            this.boton_enviarT.Size = new System.Drawing.Size(177, 55);
            this.boton_enviarT.TabIndex = 3;
            this.boton_enviarT.Text = "Enviar comprobante por teléfono";
            this.boton_enviarT.UseVisualStyleBackColor = true;
            // 
            // opcionComprobante
            // 
            this.opcionComprobante.AutoSize = true;
            this.opcionComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcionComprobante.Location = new System.Drawing.Point(261, 84);
            this.opcionComprobante.Name = "opcionComprobante";
            this.opcionComprobante.Size = new System.Drawing.Size(244, 37);
            this.opcionComprobante.TabIndex = 4;
            this.opcionComprobante.Text = "Elija una opción";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EMPADI.Properties.Resources.BBVA_logo2;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(268, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 250);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(524, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Imprimir comprobante";
            // 
            // PantallaElegirComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 651);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.opcionComprobante);
            this.Controls.Add(this.boton_enviarT);
            this.Controls.Add(this.campo_telefono);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PantallaElegirComprobante";
            this.Text = "PantallaElegirComprobante";
            this.Load += new System.EventHandler(this.PantallaElegirComprobante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox campo_telefono;
        private System.Windows.Forms.Button boton_enviarT;
        private System.Windows.Forms.Label opcionComprobante;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}