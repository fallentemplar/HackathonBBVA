namespace EMPADI
{
    partial class ResumenOperacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.campo_tipoOperacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.texto_cuenta = new System.Windows.Forms.TextBox();
            this.texto_nombre = new System.Windows.Forms.TextBox();
            this.texto_importeI = new System.Windows.Forms.TextBox();
            this.texto_importeD = new System.Windows.Forms.TextBox();
            this.texto_Cambio = new System.Windows.Forms.TextBox();
            this.texto_Motivo = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.boton_mPrincipal = new System.Windows.Forms.Button();
            this.boton_continuar = new System.Windows.Forms.Button();
            this.boton_regresar = new System.Windows.Forms.Button();
            this.boton_salir = new System.Windows.Forms.Button();
            this.boton_cambiarCuenta = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // campo_tipoOperacion
            // 
            this.campo_tipoOperacion.AutoSize = true;
            this.campo_tipoOperacion.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campo_tipoOperacion.ForeColor = System.Drawing.Color.Navy;
            this.campo_tipoOperacion.Location = new System.Drawing.Point(383, 47);
            this.campo_tipoOperacion.Name = "campo_tipoOperacion";
            this.campo_tipoOperacion.Size = new System.Drawing.Size(309, 28);
            this.campo_tipoOperacion.TabIndex = 1;
            this.campo_tipoOperacion.Text = "Depósito en efectivo o cheques";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(42, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Comprueba los datos y oprime \"Continuar\"";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkViolet;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(12, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(206, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Numero de cuenta / tarjeta";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // texto_cuenta
            // 
            this.texto_cuenta.Enabled = false;
            this.texto_cuenta.Location = new System.Drawing.Point(224, 151);
            this.texto_cuenta.Name = "texto_cuenta";
            this.texto_cuenta.Size = new System.Drawing.Size(273, 20);
            this.texto_cuenta.TabIndex = 9;
            this.texto_cuenta.Text = "1514090515140654";
            // 
            // texto_nombre
            // 
            this.texto_nombre.Enabled = false;
            this.texto_nombre.Location = new System.Drawing.Point(224, 178);
            this.texto_nombre.Name = "texto_nombre";
            this.texto_nombre.Size = new System.Drawing.Size(273, 20);
            this.texto_nombre.TabIndex = 10;
            this.texto_nombre.Text = "Rodrigo Díaz de Vivar";
            // 
            // texto_importeI
            // 
            this.texto_importeI.Enabled = false;
            this.texto_importeI.Location = new System.Drawing.Point(224, 204);
            this.texto_importeI.Name = "texto_importeI";
            this.texto_importeI.Size = new System.Drawing.Size(273, 20);
            this.texto_importeI.TabIndex = 11;
            this.texto_importeI.Text = "$500.00";
            // 
            // texto_importeD
            // 
            this.texto_importeD.Enabled = false;
            this.texto_importeD.Location = new System.Drawing.Point(224, 230);
            this.texto_importeD.Name = "texto_importeD";
            this.texto_importeD.Size = new System.Drawing.Size(273, 20);
            this.texto_importeD.TabIndex = 12;
            this.texto_importeD.Text = "$500.00";
            // 
            // texto_Cambio
            // 
            this.texto_Cambio.Enabled = false;
            this.texto_Cambio.Location = new System.Drawing.Point(224, 256);
            this.texto_Cambio.Name = "texto_Cambio";
            this.texto_Cambio.Size = new System.Drawing.Size(273, 20);
            this.texto_Cambio.TabIndex = 13;
            // 
            // texto_Motivo
            // 
            this.texto_Motivo.Enabled = false;
            this.texto_Motivo.Location = new System.Drawing.Point(224, 282);
            this.texto_Motivo.Name = "texto_Motivo";
            this.texto_Motivo.Size = new System.Drawing.Size(273, 20);
            this.texto_Motivo.TabIndex = 14;
            this.texto_Motivo.Text = "Pago de préstamo";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DarkViolet;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(12, 178);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(206, 20);
            this.textBox2.TabIndex = 15;
            this.textBox2.Text = "Nombre de titular";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.DarkViolet;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(12, 204);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(206, 20);
            this.textBox3.TabIndex = 16;
            this.textBox3.Text = "Importe ingresado";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.DarkViolet;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(12, 230);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(206, 20);
            this.textBox4.TabIndex = 17;
            this.textBox4.Text = "Importe depositado";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.DarkViolet;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(12, 256);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(206, 20);
            this.textBox5.TabIndex = 18;
            this.textBox5.Text = "Cambio";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.DarkViolet;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.textBox6.ForeColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(12, 282);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(206, 20);
            this.textBox6.TabIndex = 19;
            this.textBox6.Text = "Motivo de pago";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // boton_mPrincipal
            // 
            this.boton_mPrincipal.BackColor = System.Drawing.Color.RoyalBlue;
            this.boton_mPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boton_mPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_mPrincipal.Location = new System.Drawing.Point(12, 556);
            this.boton_mPrincipal.Name = "boton_mPrincipal";
            this.boton_mPrincipal.Size = new System.Drawing.Size(206, 65);
            this.boton_mPrincipal.TabIndex = 21;
            this.boton_mPrincipal.Text = "Menú principal";
            this.boton_mPrincipal.UseVisualStyleBackColor = false;
            // 
            // boton_continuar
            // 
            this.boton_continuar.BackColor = System.Drawing.Color.Lime;
            this.boton_continuar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boton_continuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_continuar.Location = new System.Drawing.Point(508, 444);
            this.boton_continuar.Name = "boton_continuar";
            this.boton_continuar.Size = new System.Drawing.Size(206, 65);
            this.boton_continuar.TabIndex = 22;
            this.boton_continuar.Text = "Continuar";
            this.boton_continuar.UseVisualStyleBackColor = false;
            this.boton_continuar.Click += new System.EventHandler(this.boton_continuar_Click);
            // 
            // boton_regresar
            // 
            this.boton_regresar.BackColor = System.Drawing.Color.RoyalBlue;
            this.boton_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boton_regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_regresar.Location = new System.Drawing.Point(508, 342);
            this.boton_regresar.Name = "boton_regresar";
            this.boton_regresar.Size = new System.Drawing.Size(206, 65);
            this.boton_regresar.TabIndex = 23;
            this.boton_regresar.Text = "Regresar";
            this.boton_regresar.UseVisualStyleBackColor = false;
            // 
            // boton_salir
            // 
            this.boton_salir.BackColor = System.Drawing.Color.Gray;
            this.boton_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boton_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_salir.Location = new System.Drawing.Point(508, 556);
            this.boton_salir.Name = "boton_salir";
            this.boton_salir.Size = new System.Drawing.Size(206, 65);
            this.boton_salir.TabIndex = 24;
            this.boton_salir.Text = "Salir";
            this.boton_salir.UseVisualStyleBackColor = false;
            this.boton_salir.Click += new System.EventHandler(this.boton_salir_Click);
            // 
            // boton_cambiarCuenta
            // 
            this.boton_cambiarCuenta.BackColor = System.Drawing.Color.RoyalBlue;
            this.boton_cambiarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boton_cambiarCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_cambiarCuenta.Location = new System.Drawing.Point(12, 444);
            this.boton_cambiarCuenta.Name = "boton_cambiarCuenta";
            this.boton_cambiarCuenta.Size = new System.Drawing.Size(206, 65);
            this.boton_cambiarCuenta.TabIndex = 20;
            this.boton_cambiarCuenta.Text = "Cambiar numero de cuenta / tarjeta";
            this.boton_cambiarCuenta.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EMPADI.Properties.Resources.BBVA_logo2;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ResumenOperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 651);
            this.Controls.Add(this.boton_salir);
            this.Controls.Add(this.boton_regresar);
            this.Controls.Add(this.boton_continuar);
            this.Controls.Add(this.boton_mPrincipal);
            this.Controls.Add(this.boton_cambiarCuenta);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.texto_Motivo);
            this.Controls.Add(this.texto_Cambio);
            this.Controls.Add(this.texto_importeD);
            this.Controls.Add(this.texto_importeI);
            this.Controls.Add(this.texto_nombre);
            this.Controls.Add(this.texto_cuenta);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.campo_tipoOperacion);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ResumenOperacion";
            this.Text = "Resumen Operación";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label campo_tipoOperacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox texto_cuenta;
        private System.Windows.Forms.TextBox texto_nombre;
        private System.Windows.Forms.TextBox texto_importeI;
        private System.Windows.Forms.TextBox texto_importeD;
        private System.Windows.Forms.TextBox texto_Cambio;
        private System.Windows.Forms.TextBox texto_Motivo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button boton_cambiarCuenta;
        private System.Windows.Forms.Button boton_mPrincipal;
        private System.Windows.Forms.Button boton_continuar;
        private System.Windows.Forms.Button boton_regresar;
        private System.Windows.Forms.Button boton_salir;
    }
}

