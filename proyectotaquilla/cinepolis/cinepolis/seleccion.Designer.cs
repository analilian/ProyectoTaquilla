namespace cinepolis
{
    partial class seleccion
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
            this.lbl_selecciondeventana = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btn_usuario = new System.Windows.Forms.Button();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.btn_cerrarsesion = new System.Windows.Forms.Button();
            this.btn_reportes = new System.Windows.Forms.Button();
            this.btn_mantenimientocine = new System.Windows.Forms.Button();
            this.btn_ayuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_selecciondeventana
            // 
            this.lbl_selecciondeventana.AutoSize = true;
            this.lbl_selecciondeventana.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selecciondeventana.Location = new System.Drawing.Point(141, 9);
            this.lbl_selecciondeventana.Name = "lbl_selecciondeventana";
            this.lbl_selecciondeventana.Size = new System.Drawing.Size(624, 54);
            this.lbl_selecciondeventana.TabIndex = 2;
            this.lbl_selecciondeventana.Text = "SELECCIÓN DE VENTANA ";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::cinepolis.Properties.Resources.FONDO_ICONO;
            this.button1.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(333, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 146);
            this.button1.TabIndex = 13;
            this.button1.Text = "MANTENIMIENTO DE EMPLEADO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_usuario
            // 
            this.btn_usuario.BackColor = System.Drawing.Color.Transparent;
            this.btn_usuario.BackgroundImage = global::cinepolis.Properties.Resources.User_Clients_icon;
            this.btn_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_usuario.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usuario.Location = new System.Drawing.Point(890, 324);
            this.btn_usuario.Name = "btn_usuario";
            this.btn_usuario.Size = new System.Drawing.Size(30, 30);
            this.btn_usuario.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btn_usuario, "Configuracion de Usuario");
            this.btn_usuario.UseVisualStyleBackColor = false;
            this.btn_usuario.Click += new System.EventHandler(this.button6_Click);
            // 
            // pic_logo
            // 
            this.pic_logo.BackgroundImage = global::cinepolis.Properties.Resources._13672487_10208834486171149_1624040466_n;
            this.pic_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_logo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_logo.Location = new System.Drawing.Point(817, 9);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(94, 72);
            this.pic_logo.TabIndex = 10;
            this.pic_logo.TabStop = false;
            // 
            // btn_cerrarsesion
            // 
            this.btn_cerrarsesion.BackgroundImage = global::cinepolis.Properties.Resources.FONDO_ICONO;
            this.btn_cerrarsesion.Location = new System.Drawing.Point(12, 12);
            this.btn_cerrarsesion.Name = "btn_cerrarsesion";
            this.btn_cerrarsesion.Size = new System.Drawing.Size(94, 23);
            this.btn_cerrarsesion.TabIndex = 6;
            this.btn_cerrarsesion.Text = "Cerrar Sesión";
            this.btn_cerrarsesion.UseVisualStyleBackColor = true;
            this.btn_cerrarsesion.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_reportes
            // 
            this.btn_reportes.BackgroundImage = global::cinepolis.Properties.Resources.FONDO_ICONO;
            this.btn_reportes.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reportes.Location = new System.Drawing.Point(615, 106);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.Size = new System.Drawing.Size(257, 146);
            this.btn_reportes.TabIndex = 5;
            this.btn_reportes.Text = "REPORTES";
            this.btn_reportes.UseVisualStyleBackColor = true;
            this.btn_reportes.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_mantenimientocine
            // 
            this.btn_mantenimientocine.BackgroundImage = global::cinepolis.Properties.Resources.FONDO_ICONO;
            this.btn_mantenimientocine.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mantenimientocine.Location = new System.Drawing.Point(58, 106);
            this.btn_mantenimientocine.Name = "btn_mantenimientocine";
            this.btn_mantenimientocine.Size = new System.Drawing.Size(257, 146);
            this.btn_mantenimientocine.TabIndex = 4;
            this.btn_mantenimientocine.Text = "MANTENIMIENTO DE CINE ";
            this.btn_mantenimientocine.UseVisualStyleBackColor = true;
            this.btn_mantenimientocine.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.BackColor = System.Drawing.Color.Transparent;
            this.btn_ayuda.BackgroundImage = global::cinepolis.Properties.Resources.ayuda3;
            this.btn_ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ayuda.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ayuda.Location = new System.Drawing.Point(3, 325);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(30, 30);
            this.btn_ayuda.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btn_ayuda, "Menu de Ayuda");
            this.btn_ayuda.UseVisualStyleBackColor = false;
            this.btn_ayuda.Click += new System.EventHandler(this.button1_Click);
            // 
            // seleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(923, 358);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_usuario);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.btn_cerrarsesion);
            this.Controls.Add(this.btn_reportes);
            this.Controls.Add(this.btn_mantenimientocine);
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.lbl_selecciondeventana);
            this.Name = "seleccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.seleccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_selecciondeventana;
        private System.Windows.Forms.Button btn_ayuda;
        private System.Windows.Forms.Button btn_mantenimientocine;
        private System.Windows.Forms.Button btn_reportes;
        private System.Windows.Forms.Button btn_cerrarsesion;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Button btn_usuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}