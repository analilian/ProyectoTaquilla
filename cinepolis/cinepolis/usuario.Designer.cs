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
            this.components = new System.ComponentModel.Container();
            this.lbl_mantenimientodeusuario = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.btn_cerrarsesion = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_nombreusuario = new System.Windows.Forms.Label();
            this.lbl_passusuario = new System.Windows.Forms.Label();
            this.lbl_nivelusuario = new System.Windows.Forms.Label();
            this.txt_nombreusuario = new System.Windows.Forms.TextBox();
            this.txt_pasusuario = new System.Windows.Forms.TextBox();
            this.cbo_nivelsusario = new System.Windows.Forms.ComboBox();
            this.dgv_ingresarusuario = new System.Windows.Forms.DataGridView();
            this.btn_agregarusuario = new System.Windows.Forms.Button();
            this.lbl_uempleado = new System.Windows.Forms.Label();
            this.txt_confirmar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_elegirempleado = new System.Windows.Forms.ComboBox();
            this.bttn_actualizar_usuario = new System.Windows.Forms.Button();
            this.btn_buscar_usuario = new System.Windows.Forms.Button();
            this.btn_eliminar_usuario = new System.Windows.Forms.Button();
            this.txt_buscar_usuario = new System.Windows.Forms.TextBox();
            this.lbl_buscar_usuario = new System.Windows.Forms.Label();
            this.lbl_modificar = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ingresarusuario)).BeginInit();
            this.lbl_modificar.SuspendLayout();
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
            this.lbl_mantenimientodeusuario.Click += new System.EventHandler(this.lbl_mantenimientodeusuario_Click);
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackgroundImage = global::cinepolis.Properties.Resources.Button_Previous_icon;
            this.btn_regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_regresar.Location = new System.Drawing.Point(3, 31);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(66, 48);
            this.btn_regresar.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btn_regresar, "Regresar");
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
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.lbl_buscar_usuario);
            this.tabPage1.Controls.Add(this.txt_buscar_usuario);
            this.tabPage1.Controls.Add(this.txt_confirmar);
            this.tabPage1.Controls.Add(this.txt_pasusuario);
            this.tabPage1.Controls.Add(this.txt_nombreusuario);
            this.tabPage1.Controls.Add(this.btn_eliminar_usuario);
            this.tabPage1.Controls.Add(this.btn_buscar_usuario);
            this.tabPage1.Controls.Add(this.bttn_actualizar_usuario);
            this.tabPage1.Controls.Add(this.cbo_elegirempleado);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lbl_uempleado);
            this.tabPage1.Controls.Add(this.btn_agregarusuario);
            this.tabPage1.Controls.Add(this.dgv_ingresarusuario);
            this.tabPage1.Controls.Add(this.cbo_nivelsusario);
            this.tabPage1.Controls.Add(this.lbl_nivelusuario);
            this.tabPage1.Controls.Add(this.lbl_passusuario);
            this.tabPage1.Controls.Add(this.lbl_nombreusuario);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(822, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mantenimiento de Usuario";
            // 
            // lbl_nombreusuario
            // 
            this.lbl_nombreusuario.AutoSize = true;
            this.lbl_nombreusuario.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreusuario.Location = new System.Drawing.Point(39, 18);
            this.lbl_nombreusuario.Name = "lbl_nombreusuario";
            this.lbl_nombreusuario.Size = new System.Drawing.Size(59, 16);
            this.lbl_nombreusuario.TabIndex = 28;
            this.lbl_nombreusuario.Text = "Nombre:";
            // 
            // lbl_passusuario
            // 
            this.lbl_passusuario.AutoSize = true;
            this.lbl_passusuario.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passusuario.Location = new System.Drawing.Point(39, 51);
            this.lbl_passusuario.Name = "lbl_passusuario";
            this.lbl_passusuario.Size = new System.Drawing.Size(82, 16);
            this.lbl_passusuario.TabIndex = 29;
            this.lbl_passusuario.Text = "Contraseña :";
            this.lbl_passusuario.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbl_nivelusuario
            // 
            this.lbl_nivelusuario.AutoSize = true;
            this.lbl_nivelusuario.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nivelusuario.Location = new System.Drawing.Point(451, 15);
            this.lbl_nivelusuario.Name = "lbl_nivelusuario";
            this.lbl_nivelusuario.Size = new System.Drawing.Size(37, 16);
            this.lbl_nivelusuario.TabIndex = 30;
            this.lbl_nivelusuario.Text = "Role:";
            this.lbl_nivelusuario.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_nombreusuario
            // 
            this.txt_nombreusuario.Location = new System.Drawing.Point(104, 14);
            this.txt_nombreusuario.MaxLength = 20;
            this.txt_nombreusuario.Name = "txt_nombreusuario";
            this.txt_nombreusuario.Size = new System.Drawing.Size(314, 20);
            this.txt_nombreusuario.TabIndex = 31;
            this.txt_nombreusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombreusuario_KeyPress);
            // 
            // txt_pasusuario
            // 
            this.txt_pasusuario.Location = new System.Drawing.Point(126, 49);
            this.txt_pasusuario.MaxLength = 20;
            this.txt_pasusuario.Name = "txt_pasusuario";
            this.txt_pasusuario.PasswordChar = '*';
            this.txt_pasusuario.Size = new System.Drawing.Size(292, 20);
            this.txt_pasusuario.TabIndex = 32;
            this.txt_pasusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pasusuario_KeyPress);
            // 
            // cbo_nivelsusario
            // 
            this.cbo_nivelsusario.FormattingEnabled = true;
            this.cbo_nivelsusario.Location = new System.Drawing.Point(494, 14);
            this.cbo_nivelsusario.Name = "cbo_nivelsusario";
            this.cbo_nivelsusario.Size = new System.Drawing.Size(113, 21);
            this.cbo_nivelsusario.TabIndex = 33;
            // 
            // dgv_ingresarusuario
            // 
            this.dgv_ingresarusuario.AllowUserToAddRows = false;
            this.dgv_ingresarusuario.AllowUserToDeleteRows = false;
            this.dgv_ingresarusuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ingresarusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ingresarusuario.Location = new System.Drawing.Point(12, 182);
            this.dgv_ingresarusuario.Name = "dgv_ingresarusuario";
            this.dgv_ingresarusuario.ReadOnly = true;
            this.dgv_ingresarusuario.Size = new System.Drawing.Size(807, 163);
            this.dgv_ingresarusuario.TabIndex = 34;
            this.dgv_ingresarusuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_empleados_CellContentClick);
            // 
            // btn_agregarusuario
            // 
            this.btn_agregarusuario.BackgroundImage = global::cinepolis.Properties.Resources.Save_icon;
            this.btn_agregarusuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregarusuario.Location = new System.Drawing.Point(643, 121);
            this.btn_agregarusuario.Name = "btn_agregarusuario";
            this.btn_agregarusuario.Size = new System.Drawing.Size(61, 56);
            this.btn_agregarusuario.TabIndex = 35;
            this.toolTip1.SetToolTip(this.btn_agregarusuario, "Guardar");
            this.btn_agregarusuario.UseVisualStyleBackColor = true;
            this.btn_agregarusuario.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbl_uempleado
            // 
            this.lbl_uempleado.AutoSize = true;
            this.lbl_uempleado.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uempleado.Location = new System.Drawing.Point(625, 14);
            this.lbl_uempleado.Name = "lbl_uempleado";
            this.lbl_uempleado.Size = new System.Drawing.Size(71, 16);
            this.lbl_uempleado.TabIndex = 37;
            this.lbl_uempleado.Text = "Empleado:";
            // 
            // txt_confirmar
            // 
            this.txt_confirmar.Location = new System.Drawing.Point(126, 80);
            this.txt_confirmar.MaxLength = 20;
            this.txt_confirmar.Name = "txt_confirmar";
            this.txt_confirmar.PasswordChar = '*';
            this.txt_confirmar.Size = new System.Drawing.Size(292, 20);
            this.txt_confirmar.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Confirmar:";
            // 
            // cbo_elegirempleado
            // 
            this.cbo_elegirempleado.FormattingEnabled = true;
            this.cbo_elegirempleado.Location = new System.Drawing.Point(702, 11);
            this.cbo_elegirempleado.Name = "cbo_elegirempleado";
            this.cbo_elegirempleado.Size = new System.Drawing.Size(97, 21);
            this.cbo_elegirempleado.TabIndex = 40;
            this.cbo_elegirempleado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bttn_actualizar_usuario
            // 
            this.bttn_actualizar_usuario.BackgroundImage = global::cinepolis.Properties.Resources.Button_Refresh_icon;
            this.bttn_actualizar_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_actualizar_usuario.Location = new System.Drawing.Point(576, 120);
            this.bttn_actualizar_usuario.Name = "bttn_actualizar_usuario";
            this.bttn_actualizar_usuario.Size = new System.Drawing.Size(61, 56);
            this.bttn_actualizar_usuario.TabIndex = 52;
            this.toolTip1.SetToolTip(this.bttn_actualizar_usuario, "Actualizar");
            this.bttn_actualizar_usuario.UseVisualStyleBackColor = true;
            this.bttn_actualizar_usuario.Click += new System.EventHandler(this.bttn_actualizar_usuario_Click);
            // 
            // btn_buscar_usuario
            // 
            this.btn_buscar_usuario.BackgroundImage = global::cinepolis.Properties.Resources.Zoom_icon;
            this.btn_buscar_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_usuario.Location = new System.Drawing.Point(509, 121);
            this.btn_buscar_usuario.Name = "btn_buscar_usuario";
            this.btn_buscar_usuario.Size = new System.Drawing.Size(61, 55);
            this.btn_buscar_usuario.TabIndex = 53;
            this.toolTip1.SetToolTip(this.btn_buscar_usuario, "Buscar");
            this.btn_buscar_usuario.UseVisualStyleBackColor = true;
            this.btn_buscar_usuario.Click += new System.EventHandler(this.btn_buscar_usuario_Click);
            // 
            // btn_eliminar_usuario
            // 
            this.btn_eliminar_usuario.BackgroundImage = global::cinepolis.Properties.Resources.File_Delete_icon;
            this.btn_eliminar_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar_usuario.Location = new System.Drawing.Point(710, 120);
            this.btn_eliminar_usuario.Name = "btn_eliminar_usuario";
            this.btn_eliminar_usuario.Size = new System.Drawing.Size(61, 55);
            this.btn_eliminar_usuario.TabIndex = 40;
            this.toolTip1.SetToolTip(this.btn_eliminar_usuario, "Eliminar");
            this.btn_eliminar_usuario.UseVisualStyleBackColor = true;
            this.btn_eliminar_usuario.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // txt_buscar_usuario
            // 
            this.txt_buscar_usuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_buscar_usuario.Location = new System.Drawing.Point(97, 141);
            this.txt_buscar_usuario.MaxLength = 100;
            this.txt_buscar_usuario.Name = "txt_buscar_usuario";
            this.txt_buscar_usuario.Size = new System.Drawing.Size(391, 20);
            this.txt_buscar_usuario.TabIndex = 54;
            // 
            // lbl_buscar_usuario
            // 
            this.lbl_buscar_usuario.AutoSize = true;
            this.lbl_buscar_usuario.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar_usuario.Location = new System.Drawing.Point(39, 141);
            this.lbl_buscar_usuario.Name = "lbl_buscar_usuario";
            this.lbl_buscar_usuario.Size = new System.Drawing.Size(52, 16);
            this.lbl_buscar_usuario.TabIndex = 55;
            this.lbl_buscar_usuario.Text = "Buscar:";
            // 
            // lbl_modificar
            // 
            this.lbl_modificar.Controls.Add(this.tabPage1);
            this.lbl_modificar.Location = new System.Drawing.Point(12, 85);
            this.lbl_modificar.Name = "lbl_modificar";
            this.lbl_modificar.SelectedIndex = 0;
            this.lbl_modificar.Size = new System.Drawing.Size(830, 377);
            this.lbl_modificar.TabIndex = 13;
            // 
            // usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(854, 461);
            this.Controls.Add(this.lbl_modificar);
            this.Controls.Add(this.lbl_mantenimientodeusuario);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.btn_cerrarsesion);
            this.Name = "usuario";
            this.Text = "usuario";
            this.Load += new System.EventHandler(this.usuario_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ingresarusuario)).EndInit();
            this.lbl_modificar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Button btn_cerrarsesion;
        private System.Windows.Forms.Label lbl_mantenimientodeusuario;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lbl_buscar_usuario;
        private System.Windows.Forms.TextBox txt_buscar_usuario;
        private System.Windows.Forms.TextBox txt_confirmar;
        private System.Windows.Forms.TextBox txt_pasusuario;
        private System.Windows.Forms.TextBox txt_nombreusuario;
        private System.Windows.Forms.Button btn_eliminar_usuario;
        private System.Windows.Forms.Button btn_buscar_usuario;
        private System.Windows.Forms.Button bttn_actualizar_usuario;
        private System.Windows.Forms.ComboBox cbo_elegirempleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_uempleado;
        private System.Windows.Forms.Button btn_agregarusuario;
        private System.Windows.Forms.DataGridView dgv_ingresarusuario;
        private System.Windows.Forms.ComboBox cbo_nivelsusario;
        private System.Windows.Forms.Label lbl_nivelusuario;
        private System.Windows.Forms.Label lbl_passusuario;
        private System.Windows.Forms.Label lbl_nombreusuario;
        private System.Windows.Forms.TabControl lbl_modificar;
    }
}