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
            this.btn_agregarusuario = new System.Windows.Forms.Button();
            this.bttn_actualizar_usuario = new System.Windows.Forms.Button();
            this.btn_buscar_usuario = new System.Windows.Forms.Button();
            this.btn_eliminar_usuario = new System.Windows.Forms.Button();
            this.btn_desactivar = new System.Windows.Forms.Button();
            this.btn_activar = new System.Windows.Forms.Button();
            this.lbl_buscar_usuario = new System.Windows.Forms.Label();
            this.txt_buscar_usuario = new System.Windows.Forms.TextBox();
            this.txt_confirmar = new System.Windows.Forms.TextBox();
            this.txt_pasusuario = new System.Windows.Forms.TextBox();
            this.txt_nombreusuario = new System.Windows.Forms.TextBox();
            this.cbo_elegirempleado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_uempleado = new System.Windows.Forms.Label();
            this.dgv_ingresarusuario = new System.Windows.Forms.DataGridView();
            this.cbo_nivelsusario = new System.Windows.Forms.ComboBox();
            this.lbl_nivelusuario = new System.Windows.Forms.Label();
            this.lbl_passusuario = new System.Windows.Forms.Label();
            this.lbl_nombreusuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ingresarusuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_mantenimientodeusuario
            // 
            this.lbl_mantenimientodeusuario.AutoSize = true;
            this.lbl_mantenimientodeusuario.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mantenimientodeusuario.Location = new System.Drawing.Point(170, 9);
            this.lbl_mantenimientodeusuario.Name = "lbl_mantenimientodeusuario";
            this.lbl_mantenimientodeusuario.Size = new System.Drawing.Size(478, 39);
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
            // btn_agregarusuario
            // 
            this.btn_agregarusuario.BackgroundImage = global::cinepolis.Properties.Resources.Save_icon;
            this.btn_agregarusuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregarusuario.Location = new System.Drawing.Point(720, 46);
            this.btn_agregarusuario.Name = "btn_agregarusuario";
            this.btn_agregarusuario.Size = new System.Drawing.Size(65, 65);
            this.btn_agregarusuario.TabIndex = 35;
            this.toolTip1.SetToolTip(this.btn_agregarusuario, "Guardar");
            this.btn_agregarusuario.UseVisualStyleBackColor = true;
            this.btn_agregarusuario.Click += new System.EventHandler(this.button3_Click);
            // 
            // bttn_actualizar_usuario
            // 
            this.bttn_actualizar_usuario.BackgroundImage = global::cinepolis.Properties.Resources.Button_Refresh_icon;
            this.bttn_actualizar_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_actualizar_usuario.Location = new System.Drawing.Point(653, 45);
            this.bttn_actualizar_usuario.Name = "bttn_actualizar_usuario";
            this.bttn_actualizar_usuario.Size = new System.Drawing.Size(65, 65);
            this.bttn_actualizar_usuario.TabIndex = 52;
            this.toolTip1.SetToolTip(this.bttn_actualizar_usuario, "Actualizar");
            this.bttn_actualizar_usuario.UseVisualStyleBackColor = true;
            this.bttn_actualizar_usuario.Click += new System.EventHandler(this.bttn_actualizar_usuario_Click);
            // 
            // btn_buscar_usuario
            // 
            this.btn_buscar_usuario.BackgroundImage = global::cinepolis.Properties.Resources.Zoom_icon;
            this.btn_buscar_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_usuario.Location = new System.Drawing.Point(586, 46);
            this.btn_buscar_usuario.Name = "btn_buscar_usuario";
            this.btn_buscar_usuario.Size = new System.Drawing.Size(65, 65);
            this.btn_buscar_usuario.TabIndex = 53;
            this.toolTip1.SetToolTip(this.btn_buscar_usuario, "Buscar");
            this.btn_buscar_usuario.UseVisualStyleBackColor = true;
            this.btn_buscar_usuario.Click += new System.EventHandler(this.btn_buscar_usuario_Click);
            // 
            // btn_eliminar_usuario
            // 
            this.btn_eliminar_usuario.BackgroundImage = global::cinepolis.Properties.Resources.File_Delete_icon;
            this.btn_eliminar_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar_usuario.Location = new System.Drawing.Point(787, 45);
            this.btn_eliminar_usuario.Name = "btn_eliminar_usuario";
            this.btn_eliminar_usuario.Size = new System.Drawing.Size(65, 65);
            this.btn_eliminar_usuario.TabIndex = 40;
            this.toolTip1.SetToolTip(this.btn_eliminar_usuario, "Eliminar");
            this.btn_eliminar_usuario.UseVisualStyleBackColor = true;
            this.btn_eliminar_usuario.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btn_desactivar
            // 
            this.btn_desactivar.BackgroundImage = global::cinepolis.Properties.Resources.Button_Close_icon;
            this.btn_desactivar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_desactivar.Location = new System.Drawing.Point(525, 46);
            this.btn_desactivar.Name = "btn_desactivar";
            this.btn_desactivar.Size = new System.Drawing.Size(59, 65);
            this.btn_desactivar.TabIndex = 102;
            this.toolTip1.SetToolTip(this.btn_desactivar, "Desactivar Iconos y Celdas");
            this.btn_desactivar.UseVisualStyleBackColor = true;
            this.btn_desactivar.Click += new System.EventHandler(this.btn_desactivar_Click);
            // 
            // btn_activar
            // 
            this.btn_activar.BackgroundImage = global::cinepolis.Properties.Resources.File_New_icon;
            this.btn_activar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_activar.Location = new System.Drawing.Point(461, 46);
            this.btn_activar.Name = "btn_activar";
            this.btn_activar.Size = new System.Drawing.Size(59, 65);
            this.btn_activar.TabIndex = 101;
            this.toolTip1.SetToolTip(this.btn_activar, "Activar Iconos y Celdas");
            this.btn_activar.UseVisualStyleBackColor = true;
            this.btn_activar.Click += new System.EventHandler(this.btn_activar_Click);
            // 
            // lbl_buscar_usuario
            // 
            this.lbl_buscar_usuario.AutoSize = true;
            this.lbl_buscar_usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar_usuario.Location = new System.Drawing.Point(38, 258);
            this.lbl_buscar_usuario.Name = "lbl_buscar_usuario";
            this.lbl_buscar_usuario.Size = new System.Drawing.Size(65, 21);
            this.lbl_buscar_usuario.TabIndex = 55;
            this.lbl_buscar_usuario.Text = "Buscar:";
            this.lbl_buscar_usuario.Click += new System.EventHandler(this.lbl_buscar_usuario_Click);
            // 
            // txt_buscar_usuario
            // 
            this.txt_buscar_usuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_buscar_usuario.Location = new System.Drawing.Point(96, 258);
            this.txt_buscar_usuario.MaxLength = 100;
            this.txt_buscar_usuario.Name = "txt_buscar_usuario";
            this.txt_buscar_usuario.Size = new System.Drawing.Size(391, 20);
            this.txt_buscar_usuario.TabIndex = 54;
            // 
            // txt_confirmar
            // 
            this.txt_confirmar.Location = new System.Drawing.Point(109, 171);
            this.txt_confirmar.MaxLength = 20;
            this.txt_confirmar.Name = "txt_confirmar";
            this.txt_confirmar.PasswordChar = '*';
            this.txt_confirmar.Size = new System.Drawing.Size(312, 20);
            this.txt_confirmar.TabIndex = 38;
            // 
            // txt_pasusuario
            // 
            this.txt_pasusuario.Location = new System.Drawing.Point(129, 137);
            this.txt_pasusuario.MaxLength = 20;
            this.txt_pasusuario.Name = "txt_pasusuario";
            this.txt_pasusuario.PasswordChar = '*';
            this.txt_pasusuario.Size = new System.Drawing.Size(292, 20);
            this.txt_pasusuario.TabIndex = 32;
            this.txt_pasusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pasusuario_KeyPress);
            // 
            // txt_nombreusuario
            // 
            this.txt_nombreusuario.Location = new System.Drawing.Point(95, 107);
            this.txt_nombreusuario.MaxLength = 20;
            this.txt_nombreusuario.Name = "txt_nombreusuario";
            this.txt_nombreusuario.Size = new System.Drawing.Size(326, 20);
            this.txt_nombreusuario.TabIndex = 31;
            this.txt_nombreusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombreusuario_KeyPress);
            // 
            // cbo_elegirempleado
            // 
            this.cbo_elegirempleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_elegirempleado.FormattingEnabled = true;
            this.cbo_elegirempleado.Location = new System.Drawing.Point(286, 201);
            this.cbo_elegirempleado.Name = "cbo_elegirempleado";
            this.cbo_elegirempleado.Size = new System.Drawing.Size(97, 21);
            this.cbo_elegirempleado.TabIndex = 40;
            this.cbo_elegirempleado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 39;
            this.label2.Text = "Confirmar:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lbl_uempleado
            // 
            this.lbl_uempleado.AutoSize = true;
            this.lbl_uempleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uempleado.Location = new System.Drawing.Point(186, 198);
            this.lbl_uempleado.Name = "lbl_uempleado";
            this.lbl_uempleado.Size = new System.Drawing.Size(94, 21);
            this.lbl_uempleado.TabIndex = 37;
            this.lbl_uempleado.Text = "Empleado:";
            this.lbl_uempleado.Click += new System.EventHandler(this.lbl_uempleado_Click);
            // 
            // dgv_ingresarusuario
            // 
            this.dgv_ingresarusuario.AllowUserToAddRows = false;
            this.dgv_ingresarusuario.AllowUserToDeleteRows = false;
            this.dgv_ingresarusuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ingresarusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ingresarusuario.Location = new System.Drawing.Point(19, 286);
            this.dgv_ingresarusuario.Name = "dgv_ingresarusuario";
            this.dgv_ingresarusuario.ReadOnly = true;
            this.dgv_ingresarusuario.Size = new System.Drawing.Size(807, 163);
            this.dgv_ingresarusuario.TabIndex = 34;
            this.dgv_ingresarusuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_empleados_CellContentClick);
            // 
            // cbo_nivelsusario
            // 
            this.cbo_nivelsusario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_nivelsusario.FormattingEnabled = true;
            this.cbo_nivelsusario.Location = new System.Drawing.Point(65, 202);
            this.cbo_nivelsusario.Name = "cbo_nivelsusario";
            this.cbo_nivelsusario.Size = new System.Drawing.Size(113, 21);
            this.cbo_nivelsusario.TabIndex = 33;
            this.cbo_nivelsusario.SelectedIndexChanged += new System.EventHandler(this.cbo_nivelsusario_SelectedIndexChanged);
            // 
            // lbl_nivelusuario
            // 
            this.lbl_nivelusuario.AutoSize = true;
            this.lbl_nivelusuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nivelusuario.Location = new System.Drawing.Point(12, 199);
            this.lbl_nivelusuario.Name = "lbl_nivelusuario";
            this.lbl_nivelusuario.Size = new System.Drawing.Size(47, 21);
            this.lbl_nivelusuario.TabIndex = 30;
            this.lbl_nivelusuario.Text = "Role:";
            this.lbl_nivelusuario.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_passusuario
            // 
            this.lbl_passusuario.AutoSize = true;
            this.lbl_passusuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passusuario.Location = new System.Drawing.Point(12, 137);
            this.lbl_passusuario.Name = "lbl_passusuario";
            this.lbl_passusuario.Size = new System.Drawing.Size(111, 21);
            this.lbl_passusuario.TabIndex = 29;
            this.lbl_passusuario.Text = "Contraseña :";
            this.lbl_passusuario.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbl_nombreusuario
            // 
            this.lbl_nombreusuario.AutoSize = true;
            this.lbl_nombreusuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreusuario.Location = new System.Drawing.Point(12, 104);
            this.lbl_nombreusuario.Name = "lbl_nombreusuario";
            this.lbl_nombreusuario.Size = new System.Drawing.Size(77, 21);
            this.lbl_nombreusuario.TabIndex = 28;
            this.lbl_nombreusuario.Text = "Nombre:";
            this.lbl_nombreusuario.Click += new System.EventHandler(this.lbl_nombreusuario_Click);
            // 
            // usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(854, 461);
            this.Controls.Add(this.btn_desactivar);
            this.Controls.Add(this.btn_activar);
            this.Controls.Add(this.dgv_ingresarusuario);
            this.Controls.Add(this.lbl_buscar_usuario);
            this.Controls.Add(this.txt_buscar_usuario);
            this.Controls.Add(this.lbl_mantenimientodeusuario);
            this.Controls.Add(this.txt_confirmar);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.txt_pasusuario);
            this.Controls.Add(this.btn_cerrarsesion);
            this.Controls.Add(this.txt_nombreusuario);
            this.Controls.Add(this.lbl_nombreusuario);
            this.Controls.Add(this.btn_eliminar_usuario);
            this.Controls.Add(this.lbl_passusuario);
            this.Controls.Add(this.btn_buscar_usuario);
            this.Controls.Add(this.lbl_nivelusuario);
            this.Controls.Add(this.bttn_actualizar_usuario);
            this.Controls.Add(this.cbo_nivelsusario);
            this.Controls.Add(this.cbo_elegirempleado);
            this.Controls.Add(this.btn_agregarusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_uempleado);
            this.MaximizeBox = false;
            this.Name = "usuario";
            this.Text = "usuario";
            this.Load += new System.EventHandler(this.usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ingresarusuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Button btn_cerrarsesion;
        private System.Windows.Forms.Label lbl_mantenimientodeusuario;
        private System.Windows.Forms.ToolTip toolTip1;
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
        private System.Windows.Forms.Button btn_desactivar;
        private System.Windows.Forms.Button btn_activar;
    }
}