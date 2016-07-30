namespace cinepolis
{
    partial class usuario
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
            this.lbl_mantenimientodeusuario = new System.Windows.Forms.Label();
            this.tbc_usuario = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_nivelusuario = new System.Windows.Forms.Label();
            this.lbl_passusuario = new System.Windows.Forms.Label();
            this.lbl_nombreusuario = new System.Windows.Forms.Label();
            this.lbl_ingresarusuario = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_borrarusuario = new System.Windows.Forms.Label();
            this.txt_nombreusuario = new System.Windows.Forms.TextBox();
            this.txt_pasusuario = new System.Windows.Forms.TextBox();
            this.cbo_nivelsusario = new System.Windows.Forms.ComboBox();
            this.dgv_empleados = new System.Windows.Forms.DataGridView();
            this.dgv_borrarusuario = new System.Windows.Forms.DataGridView();
            this.txt_buscarusuario = new System.Windows.Forms.TextBox();
            this.lbl_codigobusqueda = new System.Windows.Forms.Label();
            this.btn_agregarusuario = new System.Windows.Forms.Button();
            this.btn_eleminarusuario = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.btn_cerrarsesion = new System.Windows.Forms.Button();
            this.tbc_usuario.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_borrarusuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_mantenimientodeusuario
            // 
            this.lbl_mantenimientodeusuario.AutoSize = true;
            this.lbl_mantenimientodeusuario.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mantenimientodeusuario.Location = new System.Drawing.Point(103, 9);
            this.lbl_mantenimientodeusuario.Name = "lbl_mantenimientodeusuario";
            this.lbl_mantenimientodeusuario.Size = new System.Drawing.Size(736, 54);
            this.lbl_mantenimientodeusuario.TabIndex = 12;
            this.lbl_mantenimientodeusuario.Text = "MANTENIMIENTO DE USUARIO ";
            // 
            // tbc_usuario
            // 
            this.tbc_usuario.Controls.Add(this.tabPage1);
            this.tbc_usuario.Controls.Add(this.tabPage2);
            this.tbc_usuario.Location = new System.Drawing.Point(12, 113);
            this.tbc_usuario.Name = "tbc_usuario";
            this.tbc_usuario.SelectedIndex = 0;
            this.tbc_usuario.Size = new System.Drawing.Size(827, 336);
            this.tbc_usuario.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.btn_agregarusuario);
            this.tabPage1.Controls.Add(this.dgv_empleados);
            this.tabPage1.Controls.Add(this.cbo_nivelsusario);
            this.tabPage1.Controls.Add(this.txt_pasusuario);
            this.tabPage1.Controls.Add(this.txt_nombreusuario);
            this.tabPage1.Controls.Add(this.lbl_nivelusuario);
            this.tabPage1.Controls.Add(this.lbl_passusuario);
            this.tabPage1.Controls.Add(this.lbl_nombreusuario);
            this.tabPage1.Controls.Add(this.lbl_ingresarusuario);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(819, 310);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingresar Usuario";
            // 
            // lbl_nivelusuario
            // 
            this.lbl_nivelusuario.AutoSize = true;
            this.lbl_nivelusuario.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nivelusuario.Location = new System.Drawing.Point(6, 119);
            this.lbl_nivelusuario.Name = "lbl_nivelusuario";
            this.lbl_nivelusuario.Size = new System.Drawing.Size(104, 16);
            this.lbl_nivelusuario.TabIndex = 30;
            this.lbl_nivelusuario.Text = "Nivel de usuario:";
            this.lbl_nivelusuario.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_passusuario
            // 
            this.lbl_passusuario.AutoSize = true;
            this.lbl_passusuario.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passusuario.Location = new System.Drawing.Point(6, 93);
            this.lbl_passusuario.Name = "lbl_passusuario";
            this.lbl_passusuario.Size = new System.Drawing.Size(82, 16);
            this.lbl_passusuario.TabIndex = 29;
            this.lbl_passusuario.Text = "Contraseña :";
            this.lbl_passusuario.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbl_nombreusuario
            // 
            this.lbl_nombreusuario.AutoSize = true;
            this.lbl_nombreusuario.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreusuario.Location = new System.Drawing.Point(6, 68);
            this.lbl_nombreusuario.Name = "lbl_nombreusuario";
            this.lbl_nombreusuario.Size = new System.Drawing.Size(59, 16);
            this.lbl_nombreusuario.TabIndex = 28;
            this.lbl_nombreusuario.Text = "Nombre:";
            // 
            // lbl_ingresarusuario
            // 
            this.lbl_ingresarusuario.AutoSize = true;
            this.lbl_ingresarusuario.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ingresarusuario.Location = new System.Drawing.Point(151, 3);
            this.lbl_ingresarusuario.Name = "lbl_ingresarusuario";
            this.lbl_ingresarusuario.Size = new System.Drawing.Size(487, 54);
            this.lbl_ingresarusuario.TabIndex = 14;
            this.lbl_ingresarusuario.Text = "INGRESAR USUARIO ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.btn_eleminarusuario);
            this.tabPage2.Controls.Add(this.btn_buscar);
            this.tabPage2.Controls.Add(this.lbl_codigobusqueda);
            this.tabPage2.Controls.Add(this.txt_buscarusuario);
            this.tabPage2.Controls.Add(this.dgv_borrarusuario);
            this.tabPage2.Controls.Add(this.lbl_borrarusuario);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(819, 310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Borrar Usuario";
            // 
            // lbl_borrarusuario
            // 
            this.lbl_borrarusuario.AutoSize = true;
            this.lbl_borrarusuario.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_borrarusuario.Location = new System.Drawing.Point(202, 3);
            this.lbl_borrarusuario.Name = "lbl_borrarusuario";
            this.lbl_borrarusuario.Size = new System.Drawing.Size(439, 54);
            this.lbl_borrarusuario.TabIndex = 15;
            this.lbl_borrarusuario.Text = "BORRAR USUARIO ";
            this.lbl_borrarusuario.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_nombreusuario
            // 
            this.txt_nombreusuario.Location = new System.Drawing.Point(123, 60);
            this.txt_nombreusuario.Name = "txt_nombreusuario";
            this.txt_nombreusuario.Size = new System.Drawing.Size(299, 20);
            this.txt_nombreusuario.TabIndex = 31;
            // 
            // txt_pasusuario
            // 
            this.txt_pasusuario.Location = new System.Drawing.Point(123, 89);
            this.txt_pasusuario.Name = "txt_pasusuario";
            this.txt_pasusuario.Size = new System.Drawing.Size(299, 20);
            this.txt_pasusuario.TabIndex = 32;
            // 
            // cbo_nivelsusario
            // 
            this.cbo_nivelsusario.FormattingEnabled = true;
            this.cbo_nivelsusario.Location = new System.Drawing.Point(123, 119);
            this.cbo_nivelsusario.Name = "cbo_nivelsusario";
            this.cbo_nivelsusario.Size = new System.Drawing.Size(299, 21);
            this.cbo_nivelsusario.TabIndex = 33;
            // 
            // dgv_empleados
            // 
            this.dgv_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_empleados.Location = new System.Drawing.Point(9, 154);
            this.dgv_empleados.Name = "dgv_empleados";
            this.dgv_empleados.Size = new System.Drawing.Size(792, 150);
            this.dgv_empleados.TabIndex = 34;
            // 
            // dgv_borrarusuario
            // 
            this.dgv_borrarusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_borrarusuario.Location = new System.Drawing.Point(6, 143);
            this.dgv_borrarusuario.Name = "dgv_borrarusuario";
            this.dgv_borrarusuario.Size = new System.Drawing.Size(792, 150);
            this.dgv_borrarusuario.TabIndex = 35;
            // 
            // txt_buscarusuario
            // 
            this.txt_buscarusuario.Location = new System.Drawing.Point(143, 83);
            this.txt_buscarusuario.Name = "txt_buscarusuario";
            this.txt_buscarusuario.Size = new System.Drawing.Size(299, 20);
            this.txt_buscarusuario.TabIndex = 36;
            // 
            // lbl_codigobusqueda
            // 
            this.lbl_codigobusqueda.AutoSize = true;
            this.lbl_codigobusqueda.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigobusqueda.Location = new System.Drawing.Point(78, 87);
            this.lbl_codigobusqueda.Name = "lbl_codigobusqueda";
            this.lbl_codigobusqueda.Size = new System.Drawing.Size(55, 16);
            this.lbl_codigobusqueda.TabIndex = 37;
            this.lbl_codigobusqueda.Text = "Codigo:";
            // 
            // btn_agregarusuario
            // 
            this.btn_agregarusuario.BackgroundImage = global::cinepolis.Properties.Resources.guardar;
            this.btn_agregarusuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregarusuario.Location = new System.Drawing.Point(615, 59);
            this.btn_agregarusuario.Name = "btn_agregarusuario";
            this.btn_agregarusuario.Size = new System.Drawing.Size(96, 89);
            this.btn_agregarusuario.TabIndex = 35;
            this.btn_agregarusuario.UseVisualStyleBackColor = true;
            this.btn_agregarusuario.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_eleminarusuario
            // 
            this.btn_eleminarusuario.BackgroundImage = global::cinepolis.Properties.Resources.borrar;
            this.btn_eleminarusuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eleminarusuario.Location = new System.Drawing.Point(654, 68);
            this.btn_eleminarusuario.Name = "btn_eleminarusuario";
            this.btn_eleminarusuario.Size = new System.Drawing.Size(75, 57);
            this.btn_eleminarusuario.TabIndex = 39;
            this.btn_eleminarusuario.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = global::cinepolis.Properties.Resources.buscar;
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.Location = new System.Drawing.Point(491, 68);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(80, 56);
            this.btn_buscar.TabIndex = 38;
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackgroundImage = global::cinepolis.Properties.Resources.volver;
            this.btn_regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_regresar.Location = new System.Drawing.Point(3, 31);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(66, 48);
            this.btn_regresar.TabIndex = 11;
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_cerrarsesion
            // 
            this.btn_cerrarsesion.BackgroundImage = global::cinepolis.Properties.Resources.FONDO_ICONO;
            this.btn_cerrarsesion.Location = new System.Drawing.Point(3, 2);
            this.btn_cerrarsesion.Name = "btn_cerrarsesion";
            this.btn_cerrarsesion.Size = new System.Drawing.Size(94, 23);
            this.btn_cerrarsesion.TabIndex = 10;
            this.btn_cerrarsesion.Text = "Cerrar Sesión";
            this.btn_cerrarsesion.UseVisualStyleBackColor = true;
            this.btn_cerrarsesion.Click += new System.EventHandler(this.button1_Click);
            // 
            // usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(854, 461);
            this.Controls.Add(this.tbc_usuario);
            this.Controls.Add(this.lbl_mantenimientodeusuario);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.btn_cerrarsesion);
            this.Name = "usuario";
            this.Text = "usuario";
            this.tbc_usuario.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_borrarusuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Button btn_cerrarsesion;
        private System.Windows.Forms.Label lbl_mantenimientodeusuario;
        private System.Windows.Forms.TabControl tbc_usuario;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lbl_ingresarusuario;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbl_passusuario;
        private System.Windows.Forms.Label lbl_nombreusuario;
        private System.Windows.Forms.Label lbl_borrarusuario;
        private System.Windows.Forms.Label lbl_nivelusuario;
        private System.Windows.Forms.Button btn_agregarusuario;
        private System.Windows.Forms.DataGridView dgv_empleados;
        private System.Windows.Forms.ComboBox cbo_nivelsusario;
        private System.Windows.Forms.TextBox txt_pasusuario;
        private System.Windows.Forms.TextBox txt_nombreusuario;
        private System.Windows.Forms.Button btn_eleminarusuario;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lbl_codigobusqueda;
        private System.Windows.Forms.TextBox txt_buscarusuario;
        private System.Windows.Forms.DataGridView dgv_borrarusuario;
    }
}