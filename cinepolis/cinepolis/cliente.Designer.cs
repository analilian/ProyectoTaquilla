namespace cinepolis
{
    partial class cliente
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
            this.btn_ayuda = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_desactivar = new System.Windows.Forms.Button();
            this.btn_activar = new System.Windows.Forms.Button();
            this.dgv_ingresarusuario = new System.Windows.Forms.DataGridView();
            this.lbl_buscar_usuario = new System.Windows.Forms.Label();
            this.txt_buscar_usuario = new System.Windows.Forms.TextBox();
            this.lbl_mantenimientodeusuario = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.btn_cerrarsesion = new System.Windows.Forms.Button();
            this.lbl_nombreusuario = new System.Windows.Forms.Label();
            this.btn_eliminar_usuario = new System.Windows.Forms.Button();
            this.lbl_passusuario = new System.Windows.Forms.Label();
            this.btn_buscar_usuario = new System.Windows.Forms.Button();
            this.lbl_nivelusuario = new System.Windows.Forms.Label();
            this.bttn_actualizar_usuario = new System.Windows.Forms.Button();
            this.btn_agregarusuario = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_uempleado = new System.Windows.Forms.Label();
            this.txt_dpi = new System.Windows.Forms.TextBox();
            this.txt_nom1 = new System.Windows.Forms.TextBox();
            this.txt_nom2 = new System.Windows.Forms.TextBox();
            this.txt_ape1 = new System.Windows.Forms.TextBox();
            this.txt_ape2 = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.cbo_peli = new System.Windows.Forms.ComboBox();
            this.cbo_tarjeta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ingresarusuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.BackColor = System.Drawing.Color.Transparent;
            this.btn_ayuda.BackgroundImage = global::cinepolis.Properties.Resources.ayuda3;
            this.btn_ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ayuda.FlatAppearance.BorderSize = 0;
            this.btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ayuda.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ayuda.Location = new System.Drawing.Point(822, 6);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(30, 30);
            this.btn_ayuda.TabIndex = 128;
            this.btn_ayuda.UseVisualStyleBackColor = false;
            this.btn_ayuda.Click += new System.EventHandler(this.btn_ayuda_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::cinepolis.Properties.Resources.Button_Refresh_icon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(412, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 65);
            this.button1.TabIndex = 127;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_desactivar
            // 
            this.btn_desactivar.BackgroundImage = global::cinepolis.Properties.Resources.Button_Close_icon;
            this.btn_desactivar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_desactivar.FlatAppearance.BorderSize = 0;
            this.btn_desactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_desactivar.Location = new System.Drawing.Point(534, 70);
            this.btn_desactivar.Name = "btn_desactivar";
            this.btn_desactivar.Size = new System.Drawing.Size(59, 65);
            this.btn_desactivar.TabIndex = 126;
            this.btn_desactivar.UseVisualStyleBackColor = true;
            this.btn_desactivar.Click += new System.EventHandler(this.btn_desactivar_Click);
            // 
            // btn_activar
            // 
            this.btn_activar.BackgroundImage = global::cinepolis.Properties.Resources.File_New_icon;
            this.btn_activar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_activar.FlatAppearance.BorderSize = 0;
            this.btn_activar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_activar.Location = new System.Drawing.Point(475, 70);
            this.btn_activar.Name = "btn_activar";
            this.btn_activar.Size = new System.Drawing.Size(59, 65);
            this.btn_activar.TabIndex = 125;
            this.btn_activar.UseVisualStyleBackColor = true;
            this.btn_activar.Click += new System.EventHandler(this.btn_activar_Click);
            // 
            // dgv_ingresarusuario
            // 
            this.dgv_ingresarusuario.AllowUserToAddRows = false;
            this.dgv_ingresarusuario.AllowUserToDeleteRows = false;
            this.dgv_ingresarusuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ingresarusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ingresarusuario.Location = new System.Drawing.Point(19, 290);
            this.dgv_ingresarusuario.Name = "dgv_ingresarusuario";
            this.dgv_ingresarusuario.ReadOnly = true;
            this.dgv_ingresarusuario.Size = new System.Drawing.Size(807, 163);
            this.dgv_ingresarusuario.TabIndex = 114;
            // 
            // lbl_buscar_usuario
            // 
            this.lbl_buscar_usuario.AutoSize = true;
            this.lbl_buscar_usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar_usuario.Location = new System.Drawing.Point(38, 262);
            this.lbl_buscar_usuario.Name = "lbl_buscar_usuario";
            this.lbl_buscar_usuario.Size = new System.Drawing.Size(65, 21);
            this.lbl_buscar_usuario.TabIndex = 124;
            this.lbl_buscar_usuario.Text = "Buscar:";
            // 
            // txt_buscar_usuario
            // 
            this.txt_buscar_usuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_buscar_usuario.Location = new System.Drawing.Point(107, 262);
            this.txt_buscar_usuario.MaxLength = 100;
            this.txt_buscar_usuario.Name = "txt_buscar_usuario";
            this.txt_buscar_usuario.Size = new System.Drawing.Size(391, 20);
            this.txt_buscar_usuario.TabIndex = 123;
            // 
            // lbl_mantenimientodeusuario
            // 
            this.lbl_mantenimientodeusuario.AutoSize = true;
            this.lbl_mantenimientodeusuario.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mantenimientodeusuario.Location = new System.Drawing.Point(170, 13);
            this.lbl_mantenimientodeusuario.Name = "lbl_mantenimientodeusuario";
            this.lbl_mantenimientodeusuario.Size = new System.Drawing.Size(478, 39);
            this.lbl_mantenimientodeusuario.TabIndex = 107;
            this.lbl_mantenimientodeusuario.Text = "MANTENIMIENTO DE USUARIO ";
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackgroundImage = global::cinepolis.Properties.Resources.Button_Previous_icon;
            this.btn_regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_regresar.FlatAppearance.BorderSize = 0;
            this.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regresar.Location = new System.Drawing.Point(3, 35);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(64, 52);
            this.btn_regresar.TabIndex = 106;
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // btn_cerrarsesion
            // 
            this.btn_cerrarsesion.BackgroundImage = global::cinepolis.Properties.Resources.FONDO_ICONO;
            this.btn_cerrarsesion.Location = new System.Drawing.Point(3, 6);
            this.btn_cerrarsesion.Name = "btn_cerrarsesion";
            this.btn_cerrarsesion.Size = new System.Drawing.Size(94, 23);
            this.btn_cerrarsesion.TabIndex = 105;
            this.btn_cerrarsesion.Text = "Cerrar Sesión";
            this.btn_cerrarsesion.UseVisualStyleBackColor = true;
            // 
            // lbl_nombreusuario
            // 
            this.lbl_nombreusuario.AutoSize = true;
            this.lbl_nombreusuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreusuario.Location = new System.Drawing.Point(43, 115);
            this.lbl_nombreusuario.Name = "lbl_nombreusuario";
            this.lbl_nombreusuario.Size = new System.Drawing.Size(40, 21);
            this.lbl_nombreusuario.TabIndex = 108;
            this.lbl_nombreusuario.Text = "DPI:";
            // 
            // btn_eliminar_usuario
            // 
            this.btn_eliminar_usuario.BackgroundImage = global::cinepolis.Properties.Resources.File_Delete_icon;
            this.btn_eliminar_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar_usuario.FlatAppearance.BorderSize = 0;
            this.btn_eliminar_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar_usuario.Location = new System.Drawing.Point(783, 69);
            this.btn_eliminar_usuario.Name = "btn_eliminar_usuario";
            this.btn_eliminar_usuario.Size = new System.Drawing.Size(65, 65);
            this.btn_eliminar_usuario.TabIndex = 119;
            this.btn_eliminar_usuario.UseVisualStyleBackColor = true;
            this.btn_eliminar_usuario.Click += new System.EventHandler(this.btn_eliminar_usuario_Click);
            // 
            // lbl_passusuario
            // 
            this.lbl_passusuario.AutoSize = true;
            this.lbl_passusuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passusuario.Location = new System.Drawing.Point(2, 145);
            this.lbl_passusuario.Name = "lbl_passusuario";
            this.lbl_passusuario.Size = new System.Drawing.Size(81, 21);
            this.lbl_passusuario.TabIndex = 109;
            this.lbl_passusuario.Text = "Nombre :";
            // 
            // btn_buscar_usuario
            // 
            this.btn_buscar_usuario.BackgroundImage = global::cinepolis.Properties.Resources.Zoom_icon;
            this.btn_buscar_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_usuario.FlatAppearance.BorderSize = 0;
            this.btn_buscar_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar_usuario.Location = new System.Drawing.Point(592, 70);
            this.btn_buscar_usuario.Name = "btn_buscar_usuario";
            this.btn_buscar_usuario.Size = new System.Drawing.Size(65, 65);
            this.btn_buscar_usuario.TabIndex = 122;
            this.btn_buscar_usuario.UseVisualStyleBackColor = true;
            this.btn_buscar_usuario.Click += new System.EventHandler(this.btn_buscar_usuario_Click);
            // 
            // lbl_nivelusuario
            // 
            this.lbl_nivelusuario.AutoSize = true;
            this.lbl_nivelusuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nivelusuario.Location = new System.Drawing.Point(-1, 203);
            this.lbl_nivelusuario.Name = "lbl_nivelusuario";
            this.lbl_nivelusuario.Size = new System.Drawing.Size(87, 21);
            this.lbl_nivelusuario.TabIndex = 110;
            this.lbl_nivelusuario.Text = "Direccion:";
            // 
            // bttn_actualizar_usuario
            // 
            this.bttn_actualizar_usuario.BackgroundImage = global::cinepolis.Properties.Resources.Edit_Document_icon;
            this.bttn_actualizar_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_actualizar_usuario.FlatAppearance.BorderSize = 0;
            this.bttn_actualizar_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_actualizar_usuario.Location = new System.Drawing.Point(656, 69);
            this.bttn_actualizar_usuario.Name = "bttn_actualizar_usuario";
            this.bttn_actualizar_usuario.Size = new System.Drawing.Size(65, 65);
            this.bttn_actualizar_usuario.TabIndex = 121;
            this.bttn_actualizar_usuario.UseVisualStyleBackColor = true;
            this.bttn_actualizar_usuario.Click += new System.EventHandler(this.bttn_actualizar_usuario_Click);
            // 
            // btn_agregarusuario
            // 
            this.btn_agregarusuario.BackgroundImage = global::cinepolis.Properties.Resources.Save_icon;
            this.btn_agregarusuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregarusuario.FlatAppearance.BorderSize = 0;
            this.btn_agregarusuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarusuario.Location = new System.Drawing.Point(719, 70);
            this.btn_agregarusuario.Name = "btn_agregarusuario";
            this.btn_agregarusuario.Size = new System.Drawing.Size(65, 65);
            this.btn_agregarusuario.TabIndex = 115;
            this.btn_agregarusuario.UseVisualStyleBackColor = true;
            this.btn_agregarusuario.Click += new System.EventHandler(this.btn_agregarusuario_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 118;
            this.label2.Text = "Apellido:";
            // 
            // lbl_uempleado
            // 
            this.lbl_uempleado.AutoSize = true;
            this.lbl_uempleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uempleado.Location = new System.Drawing.Point(-1, 230);
            this.lbl_uempleado.Name = "lbl_uempleado";
            this.lbl_uempleado.Size = new System.Drawing.Size(67, 21);
            this.lbl_uempleado.TabIndex = 116;
            this.lbl_uempleado.Text = "Correo:";
            // 
            // txt_dpi
            // 
            this.txt_dpi.Location = new System.Drawing.Point(89, 117);
            this.txt_dpi.MaxLength = 13;
            this.txt_dpi.Name = "txt_dpi";
            this.txt_dpi.Size = new System.Drawing.Size(191, 20);
            this.txt_dpi.TabIndex = 129;
            this.txt_dpi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dpi_KeyPress);
            // 
            // txt_nom1
            // 
            this.txt_nom1.Location = new System.Drawing.Point(89, 146);
            this.txt_nom1.Name = "txt_nom1";
            this.txt_nom1.Size = new System.Drawing.Size(191, 20);
            this.txt_nom1.TabIndex = 130;
            // 
            // txt_nom2
            // 
            this.txt_nom2.Location = new System.Drawing.Point(286, 148);
            this.txt_nom2.Name = "txt_nom2";
            this.txt_nom2.Size = new System.Drawing.Size(191, 20);
            this.txt_nom2.TabIndex = 131;
            // 
            // txt_ape1
            // 
            this.txt_ape1.Location = new System.Drawing.Point(89, 175);
            this.txt_ape1.Name = "txt_ape1";
            this.txt_ape1.Size = new System.Drawing.Size(191, 20);
            this.txt_ape1.TabIndex = 132;
            // 
            // txt_ape2
            // 
            this.txt_ape2.Location = new System.Drawing.Point(286, 176);
            this.txt_ape2.Name = "txt_ape2";
            this.txt_ape2.Size = new System.Drawing.Size(191, 20);
            this.txt_ape2.TabIndex = 133;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(89, 203);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(388, 20);
            this.txt_direccion.TabIndex = 134;
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(89, 230);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(388, 20);
            this.txt_correo.TabIndex = 135;
            // 
            // cbo_peli
            // 
            this.cbo_peli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_peli.FormattingEnabled = true;
            this.cbo_peli.Location = new System.Drawing.Point(592, 147);
            this.cbo_peli.Name = "cbo_peli";
            this.cbo_peli.Size = new System.Drawing.Size(147, 21);
            this.cbo_peli.TabIndex = 136;
            // 
            // cbo_tarjeta
            // 
            this.cbo_tarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_tarjeta.FormattingEnabled = true;
            this.cbo_tarjeta.Location = new System.Drawing.Point(592, 203);
            this.cbo_tarjeta.Name = "cbo_tarjeta";
            this.cbo_tarjeta.Size = new System.Drawing.Size(147, 21);
            this.cbo_tarjeta.TabIndex = 137;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(517, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 138;
            this.label1.Text = "Pelicula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(521, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 139;
            this.label3.Text = "Tarjeta:";
            // 
            // cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(861, 496);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_tarjeta);
            this.Controls.Add(this.cbo_peli);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_ape2);
            this.Controls.Add(this.txt_ape1);
            this.Controls.Add(this.txt_nom2);
            this.Controls.Add(this.txt_nom1);
            this.Controls.Add(this.txt_dpi);
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_desactivar);
            this.Controls.Add(this.btn_activar);
            this.Controls.Add(this.dgv_ingresarusuario);
            this.Controls.Add(this.lbl_buscar_usuario);
            this.Controls.Add(this.txt_buscar_usuario);
            this.Controls.Add(this.lbl_mantenimientodeusuario);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.btn_cerrarsesion);
            this.Controls.Add(this.lbl_nombreusuario);
            this.Controls.Add(this.btn_eliminar_usuario);
            this.Controls.Add(this.lbl_passusuario);
            this.Controls.Add(this.btn_buscar_usuario);
            this.Controls.Add(this.lbl_nivelusuario);
            this.Controls.Add(this.bttn_actualizar_usuario);
            this.Controls.Add(this.btn_agregarusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_uempleado);
            this.MaximizeBox = false;
            this.Name = "cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cliente";
            this.Load += new System.EventHandler(this.cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ingresarusuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ayuda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_desactivar;
        private System.Windows.Forms.Button btn_activar;
        private System.Windows.Forms.DataGridView dgv_ingresarusuario;
        private System.Windows.Forms.Label lbl_buscar_usuario;
        private System.Windows.Forms.TextBox txt_buscar_usuario;
        private System.Windows.Forms.Label lbl_mantenimientodeusuario;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Button btn_cerrarsesion;
        private System.Windows.Forms.Label lbl_nombreusuario;
        private System.Windows.Forms.Button btn_eliminar_usuario;
        private System.Windows.Forms.Label lbl_passusuario;
        private System.Windows.Forms.Button btn_buscar_usuario;
        private System.Windows.Forms.Label lbl_nivelusuario;
        private System.Windows.Forms.Button bttn_actualizar_usuario;
        private System.Windows.Forms.Button btn_agregarusuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_uempleado;
        private System.Windows.Forms.TextBox txt_dpi;
        private System.Windows.Forms.TextBox txt_nom1;
        private System.Windows.Forms.TextBox txt_nom2;
        private System.Windows.Forms.TextBox txt_ape1;
        private System.Windows.Forms.TextBox txt_ape2;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.ComboBox cbo_peli;
        private System.Windows.Forms.ComboBox cbo_tarjeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}