namespace cinepolis
{
    partial class reportes
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
            this.components = new System.ComponentModel.Container();
            this.lbl_seleccionderepote = new System.Windows.Forms.Label();
            this.btn_peliculataquillera = new System.Windows.Forms.Button();
            this.btn_ganancias = new System.Windows.Forms.Button();
            this.btn_horariosmasusados = new System.Windows.Forms.Button();
            this.btn_puntoscliente = new System.Windows.Forms.Button();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.btn_cerrarsesion = new System.Windows.Forms.Button();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_seleccionderepote
            // 
            this.lbl_seleccionderepote.AutoSize = true;
            this.lbl_seleccionderepote.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seleccionderepote.Location = new System.Drawing.Point(156, 9);
            this.lbl_seleccionderepote.Name = "lbl_seleccionderepote";
            this.lbl_seleccionderepote.Size = new System.Drawing.Size(606, 54);
            this.lbl_seleccionderepote.TabIndex = 3;
            this.lbl_seleccionderepote.Text = "SELECCIÓN DE REPORTE ";
            // 
            // btn_peliculataquillera
            // 
            this.btn_peliculataquillera.BackgroundImage = global::cinepolis.Properties.Resources.FONDO_ICONO;
            this.btn_peliculataquillera.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_peliculataquillera.Location = new System.Drawing.Point(28, 126);
            this.btn_peliculataquillera.Name = "btn_peliculataquillera";
            this.btn_peliculataquillera.Size = new System.Drawing.Size(190, 146);
            this.btn_peliculataquillera.TabIndex = 4;
            this.btn_peliculataquillera.Text = "PELÍCULA MAS TAQUILLERA";
            this.btn_peliculataquillera.UseVisualStyleBackColor = true;
            // 
            // btn_ganancias
            // 
            this.btn_ganancias.BackgroundImage = global::cinepolis.Properties.Resources.FONDO_ICONO;
            this.btn_ganancias.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ganancias.Location = new System.Drawing.Point(249, 126);
            this.btn_ganancias.Name = "btn_ganancias";
            this.btn_ganancias.Size = new System.Drawing.Size(190, 146);
            this.btn_ganancias.TabIndex = 5;
            this.btn_ganancias.Text = "GANANCIAS";
            this.btn_ganancias.UseVisualStyleBackColor = true;
            // 
            // btn_horariosmasusados
            // 
            this.btn_horariosmasusados.BackgroundImage = global::cinepolis.Properties.Resources.FONDO_ICONO;
            this.btn_horariosmasusados.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_horariosmasusados.Location = new System.Drawing.Point(474, 126);
            this.btn_horariosmasusados.Name = "btn_horariosmasusados";
            this.btn_horariosmasusados.Size = new System.Drawing.Size(190, 146);
            this.btn_horariosmasusados.TabIndex = 6;
            this.btn_horariosmasusados.Text = "HORARIOS MAS UTILIZADOS ";
            this.btn_horariosmasusados.UseVisualStyleBackColor = true;
            // 
            // btn_puntoscliente
            // 
            this.btn_puntoscliente.BackgroundImage = global::cinepolis.Properties.Resources.FONDO_ICONO;
            this.btn_puntoscliente.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_puntoscliente.Location = new System.Drawing.Point(693, 126);
            this.btn_puntoscliente.Name = "btn_puntoscliente";
            this.btn_puntoscliente.Size = new System.Drawing.Size(190, 146);
            this.btn_puntoscliente.TabIndex = 7;
            this.btn_puntoscliente.Text = "PUNTOS DE CLIENTES";
            this.btn_puntoscliente.UseVisualStyleBackColor = true;
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackgroundImage = global::cinepolis.Properties.Resources.Button_Previous_icon;
            this.btn_regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_regresar.Location = new System.Drawing.Point(12, 38);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(65, 43);
            this.btn_regresar.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btn_regresar, "Regresar");
            this.btn_regresar.UseMnemonic = false;
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_cerrarsesion
            // 
            this.btn_cerrarsesion.BackgroundImage = global::cinepolis.Properties.Resources.FONDO_ICONO;
            this.btn_cerrarsesion.Location = new System.Drawing.Point(12, 9);
            this.btn_cerrarsesion.Name = "btn_cerrarsesion";
            this.btn_cerrarsesion.Size = new System.Drawing.Size(94, 23);
            this.btn_cerrarsesion.TabIndex = 10;
            this.btn_cerrarsesion.Text = "Cerrar Sesión";
            this.btn_cerrarsesion.UseVisualStyleBackColor = true;
            this.btn_cerrarsesion.Click += new System.EventHandler(this.button6_Click);
            // 
            // pic_logo
            // 
            this.pic_logo.BackgroundImage = global::cinepolis.Properties.Resources._13672487_10208834486171149_1624040466_n;
            this.pic_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_logo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_logo.Location = new System.Drawing.Point(817, 9);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(94, 72);
            this.pic_logo.TabIndex = 12;
            this.pic_logo.TabStop = false;
            // 
            // reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(923, 358);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.btn_cerrarsesion);
            this.Controls.Add(this.btn_puntoscliente);
            this.Controls.Add(this.btn_horariosmasusados);
            this.Controls.Add(this.btn_ganancias);
            this.Controls.Add(this.btn_peliculataquillera);
            this.Controls.Add(this.lbl_seleccionderepote);
            this.MaximizeBox = false;
            this.Name = "reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reportes";
            this.Load += new System.EventHandler(this.reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_seleccionderepote;
        private System.Windows.Forms.Button btn_peliculataquillera;
        private System.Windows.Forms.Button btn_ganancias;
        private System.Windows.Forms.Button btn_horariosmasusados;
        private System.Windows.Forms.Button btn_puntoscliente;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Button btn_cerrarsesion;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}