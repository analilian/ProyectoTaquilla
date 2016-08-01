namespace proyectotaquilla
{
    partial class pago
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtfecha2 = new System.Windows.Forms.MaskedTextBox();
            this.txtFecha1 = new System.Windows.Forms.MaskedTextBox();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.txtNumeroTarjeta = new System.Windows.Forms.TextBox();
            this.lblNumeroTarjeta = new System.Windows.Forms.Label();
            this.txtTarjetaPuntos = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtNombreTarjeta = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.lblNombreTarjeta = new System.Windows.Forms.Label();
            this.chkTarjetaPuntos = new System.Windows.Forms.CheckBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblcorreo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::proyectotaquilla.Properties.Resources.logo1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(30, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 108);
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfirmar.Location = new System.Drawing.Point(476, 259);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 50;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(689, 69);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 49;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(549, 77);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 48;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtfecha2
            // 
            this.txtfecha2.Location = new System.Drawing.Point(811, 22);
            this.txtfecha2.Mask = "00/00/0000";
            this.txtfecha2.Name = "txtfecha2";
            this.txtfecha2.Size = new System.Drawing.Size(100, 20);
            this.txtfecha2.TabIndex = 47;
            this.txtfecha2.ValidatingType = typeof(System.DateTime);
            // 
            // txtFecha1
            // 
            this.txtFecha1.Location = new System.Drawing.Point(689, 22);
            this.txtFecha1.Mask = "00/00/0000";
            this.txtFecha1.Name = "txtFecha1";
            this.txtFecha1.Size = new System.Drawing.Size(100, 20);
            this.txtFecha1.TabIndex = 46;
            this.txtFecha1.ValidatingType = typeof(System.DateTime);
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(549, 26);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(113, 13);
            this.lblFechaVencimiento.TabIndex = 45;
            this.lblFechaVencimiento.Text = "Fecha de Vencimiento";
            // 
            // txtNumeroTarjeta
            // 
            this.txtNumeroTarjeta.Location = new System.Drawing.Point(348, 120);
            this.txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            this.txtNumeroTarjeta.Size = new System.Drawing.Size(157, 20);
            this.txtNumeroTarjeta.TabIndex = 44;
            // 
            // lblNumeroTarjeta
            // 
            this.lblNumeroTarjeta.AutoSize = true;
            this.lblNumeroTarjeta.Location = new System.Drawing.Point(210, 127);
            this.lblNumeroTarjeta.Name = "lblNumeroTarjeta";
            this.lblNumeroTarjeta.Size = new System.Drawing.Size(98, 13);
            this.lblNumeroTarjeta.TabIndex = 43;
            this.lblNumeroTarjeta.Text = "Numedo de Tarjeta";
            // 
            // txtTarjetaPuntos
            // 
            this.txtTarjetaPuntos.Enabled = false;
            this.txtTarjetaPuntos.Location = new System.Drawing.Point(496, 185);
            this.txtTarjetaPuntos.Name = "txtTarjetaPuntos";
            this.txtTarjetaPuntos.Size = new System.Drawing.Size(157, 20);
            this.txtTarjetaPuntos.TabIndex = 42;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(689, 120);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 41;
            // 
            // txtNombreTarjeta
            // 
            this.txtNombreTarjeta.Location = new System.Drawing.Point(348, 69);
            this.txtNombreTarjeta.Name = "txtNombreTarjeta";
            this.txtNombreTarjeta.Size = new System.Drawing.Size(157, 20);
            this.txtNombreTarjeta.TabIndex = 40;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(348, 26);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(157, 20);
            this.txtcorreo.TabIndex = 39;
            // 
            // lblNombreTarjeta
            // 
            this.lblNombreTarjeta.AutoSize = true;
            this.lblNombreTarjeta.Location = new System.Drawing.Point(210, 76);
            this.lblNombreTarjeta.Name = "lblNombreTarjeta";
            this.lblNombreTarjeta.Size = new System.Drawing.Size(95, 13);
            this.lblNombreTarjeta.TabIndex = 38;
            this.lblNombreTarjeta.Text = "Nombre de Tarjeta";
            // 
            // chkTarjetaPuntos
            // 
            this.chkTarjetaPuntos.AutoSize = true;
            this.chkTarjetaPuntos.Location = new System.Drawing.Point(361, 185);
            this.chkTarjetaPuntos.Name = "chkTarjetaPuntos";
            this.chkTarjetaPuntos.Size = new System.Drawing.Size(124, 17);
            this.chkTarjetaPuntos.TabIndex = 37;
            this.chkTarjetaPuntos.Text = "N. Tarjeta de Puntos";
            this.chkTarjetaPuntos.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(549, 124);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(71, 13);
            this.lblTotal.TabIndex = 36;
            this.lblTotal.Text = "Total a Pagar";
            // 
            // lblcorreo
            // 
            this.lblcorreo.AutoSize = true;
            this.lblcorreo.Location = new System.Drawing.Point(210, 29);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(94, 13);
            this.lblcorreo.TabIndex = 35;
            this.lblcorreo.Text = "Correo Electronico";
            // 
            // pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(941, 291);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtfecha2);
            this.Controls.Add(this.txtFecha1);
            this.Controls.Add(this.lblFechaVencimiento);
            this.Controls.Add(this.txtNumeroTarjeta);
            this.Controls.Add(this.lblNumeroTarjeta);
            this.Controls.Add(this.txtTarjetaPuntos);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtNombreTarjeta);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.lblNombreTarjeta);
            this.Controls.Add(this.chkTarjetaPuntos);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblcorreo);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "pago";
            this.Text = "pago";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.MaskedTextBox txtfecha2;
        private System.Windows.Forms.MaskedTextBox txtFecha1;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.TextBox txtNumeroTarjeta;
        private System.Windows.Forms.Label lblNumeroTarjeta;
        private System.Windows.Forms.TextBox txtTarjetaPuntos;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtNombreTarjeta;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label lblNombreTarjeta;
        private System.Windows.Forms.CheckBox chkTarjetaPuntos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblcorreo;

    }
}