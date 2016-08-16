namespace cinepolis
{
    partial class empleado
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
            this.lbl_titulo_mantenimiento_cine = new System.Windows.Forms.Label();
            this.btn_telefono_empleado = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.lbl_codigo_buscar = new System.Windows.Forms.Label();
            this.btn_eliminar_Empleado = new System.Windows.Forms.Button();
            this.btn_buscar_empleado = new System.Windows.Forms.Button();
            this.bttn_actualizar_Empleado = new System.Windows.Forms.Button();
            this.dgv_emplados_modificar = new System.Windows.Forms.DataGridView();
            this.dtp_fecha_nac = new System.Windows.Forms.DateTimePicker();
            this.cbo_cine = new System.Windows.Forms.ComboBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_cine = new System.Windows.Forms.Label();
            this.cbo_puesto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_dpi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_apellido2 = new System.Windows.Forms.TextBox();
            this.txt_apellido1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre2 = new System.Windows.Forms.TextBox();
            this.txt_nombre1 = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_regresar = new System.Windows.Forms.Button();
            this.btn_cerrarsesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emplados_modificar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo_mantenimiento_cine
            // 
            this.lbl_titulo_mantenimiento_cine.AutoSize = true;
            this.lbl_titulo_mantenimiento_cine.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_mantenimiento_cine.Location = new System.Drawing.Point(209, 9);
            this.lbl_titulo_mantenimiento_cine.Name = "lbl_titulo_mantenimiento_cine";
            this.lbl_titulo_mantenimiento_cine.Size = new System.Drawing.Size(469, 36);
            this.lbl_titulo_mantenimiento_cine.TabIndex = 13;
            this.lbl_titulo_mantenimiento_cine.Text = "MANTENIMIENTO DE EMPLEADO";
            this.lbl_titulo_mantenimiento_cine.Click += new System.EventHandler(this.lbl_titulo_mantenimiento_cine_Click);
            // 
            // btn_telefono_empleado
            // 
            this.btn_telefono_empleado.BackColor = System.Drawing.Color.Transparent;
            this.btn_telefono_empleado.BackgroundImage = global::cinepolis.Properties.Resources.telefono;
            this.btn_telefono_empleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_telefono_empleado.Location = new System.Drawing.Point(831, 59);
            this.btn_telefono_empleado.Name = "btn_telefono_empleado";
            this.btn_telefono_empleado.Size = new System.Drawing.Size(61, 55);
            this.btn_telefono_empleado.TabIndex = 95;
            this.toolTip1.SetToolTip(this.btn_telefono_empleado, "Agregar Telefono de Empleado");
            this.btn_telefono_empleado.UseVisualStyleBackColor = false;
            this.btn_telefono_empleado.Click += new System.EventHandler(this.btn_telefono_empleado_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(132, 295);
            this.txt_buscar.MaxLength = 100;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(329, 20);
            this.txt_buscar.TabIndex = 94;
            // 
            // lbl_codigo_buscar
            // 
            this.lbl_codigo_buscar.AutoSize = true;
            this.lbl_codigo_buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo_buscar.Location = new System.Drawing.Point(61, 295);
            this.lbl_codigo_buscar.Name = "lbl_codigo_buscar";
            this.lbl_codigo_buscar.Size = new System.Drawing.Size(65, 21);
            this.lbl_codigo_buscar.TabIndex = 93;
            this.lbl_codigo_buscar.Text = "Buscar:";
            // 
            // btn_eliminar_Empleado
            // 
            this.btn_eliminar_Empleado.BackgroundImage = global::cinepolis.Properties.Resources.File_Delete_icon;
            this.btn_eliminar_Empleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar_Empleado.Location = new System.Drawing.Point(769, 59);
            this.btn_eliminar_Empleado.Name = "btn_eliminar_Empleado";
            this.btn_eliminar_Empleado.Size = new System.Drawing.Size(61, 55);
            this.btn_eliminar_Empleado.TabIndex = 90;
            this.toolTip1.SetToolTip(this.btn_eliminar_Empleado, "Eliminar");
            this.btn_eliminar_Empleado.UseVisualStyleBackColor = true;
            this.btn_eliminar_Empleado.Click += new System.EventHandler(this.btn_eliminar_pelicula_Click);
            // 
            // btn_buscar_empleado
            // 
            this.btn_buscar_empleado.BackgroundImage = global::cinepolis.Properties.Resources.Zoom_icon;
            this.btn_buscar_empleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_empleado.Location = new System.Drawing.Point(577, 60);
            this.btn_buscar_empleado.Name = "btn_buscar_empleado";
            this.btn_buscar_empleado.Size = new System.Drawing.Size(61, 55);
            this.btn_buscar_empleado.TabIndex = 92;
            this.toolTip1.SetToolTip(this.btn_buscar_empleado, "Buscar");
            this.btn_buscar_empleado.UseVisualStyleBackColor = true;
            this.btn_buscar_empleado.Click += new System.EventHandler(this.btn_buscar_empleado_Click);
            // 
            // bttn_actualizar_Empleado
            // 
            this.bttn_actualizar_Empleado.BackgroundImage = global::cinepolis.Properties.Resources.Button_Refresh_icon;
            this.bttn_actualizar_Empleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_actualizar_Empleado.Location = new System.Drawing.Point(641, 59);
            this.bttn_actualizar_Empleado.Name = "bttn_actualizar_Empleado";
            this.bttn_actualizar_Empleado.Size = new System.Drawing.Size(61, 56);
            this.bttn_actualizar_Empleado.TabIndex = 91;
            this.toolTip1.SetToolTip(this.bttn_actualizar_Empleado, "Actualizar");
            this.bttn_actualizar_Empleado.UseVisualStyleBackColor = true;
            this.bttn_actualizar_Empleado.Click += new System.EventHandler(this.bttn_actualizar_pelicula_Click);
            // 
            // dgv_emplados_modificar
            // 
            this.dgv_emplados_modificar.AllowUserToAddRows = false;
            this.dgv_emplados_modificar.AllowUserToDeleteRows = false;
            this.dgv_emplados_modificar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_emplados_modificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_emplados_modificar.Location = new System.Drawing.Point(6, 320);
            this.dgv_emplados_modificar.Name = "dgv_emplados_modificar";
            this.dgv_emplados_modificar.ReadOnly = true;
            this.dgv_emplados_modificar.Size = new System.Drawing.Size(886, 185);
            this.dgv_emplados_modificar.TabIndex = 73;
            // 
            // dtp_fecha_nac
            // 
            this.dtp_fecha_nac.CustomFormat = "yyyy--MM--dd";
            this.dtp_fecha_nac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha_nac.Location = new System.Drawing.Point(619, 262);
            this.dtp_fecha_nac.Name = "dtp_fecha_nac";
            this.dtp_fecha_nac.Size = new System.Drawing.Size(105, 20);
            this.dtp_fecha_nac.TabIndex = 55;
            this.dtp_fecha_nac.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cbo_cine
            // 
            this.cbo_cine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_cine.FormattingEnabled = true;
            this.cbo_cine.Location = new System.Drawing.Point(515, 228);
            this.cbo_cine.Name = "cbo_cine";
            this.cbo_cine.Size = new System.Drawing.Size(308, 21);
            this.cbo_cine.TabIndex = 54;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImage = global::cinepolis.Properties.Resources.Save_icon;
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.Location = new System.Drawing.Point(706, 60);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(61, 55);
            this.btn_guardar.TabIndex = 53;
            this.toolTip1.SetToolTip(this.btn_guardar, "Guardar");
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_cine
            // 
            this.lbl_cine.AutoSize = true;
            this.lbl_cine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cine.Location = new System.Drawing.Point(432, 229);
            this.lbl_cine.Name = "lbl_cine";
            this.lbl_cine.Size = new System.Drawing.Size(50, 21);
            this.lbl_cine.TabIndex = 48;
            this.lbl_cine.Text = "Cine:";
            // 
            // cbo_puesto
            // 
            this.cbo_puesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_puesto.FormattingEnabled = true;
            this.cbo_puesto.Location = new System.Drawing.Point(515, 197);
            this.cbo_puesto.Name = "cbo_puesto";
            this.cbo_puesto.Size = new System.Drawing.Size(308, 21);
            this.cbo_puesto.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(432, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 46;
            this.label6.Text = "Puesto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(432, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 21);
            this.label5.TabIndex = 45;
            this.label5.Text = "Fecha de nacimiento:";
            // 
            // txt_nit
            // 
            this.txt_nit.Location = new System.Drawing.Point(515, 167);
            this.txt_nit.MaxLength = 10;
            this.txt_nit.Name = "txt_nit";
            this.txt_nit.Size = new System.Drawing.Size(308, 20);
            this.txt_nit.TabIndex = 44;
            this.txt_nit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nit_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(432, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 21);
            this.label4.TabIndex = 43;
            this.label4.Text = "NIT:";
            // 
            // txt_dpi
            // 
            this.txt_dpi.Location = new System.Drawing.Point(515, 135);
            this.txt_dpi.MaxLength = 13;
            this.txt_dpi.Name = "txt_dpi";
            this.txt_dpi.Size = new System.Drawing.Size(308, 20);
            this.txt_dpi.TabIndex = 42;
            this.txt_dpi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dpi_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(432, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 21);
            this.label3.TabIndex = 41;
            this.label3.Text = "DPI:";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(99, 200);
            this.txt_direccion.MaxLength = 20;
            this.txt_direccion.Multiline = true;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(308, 83);
            this.txt_direccion.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 39;
            this.label2.Text = "Dirección:";
            // 
            // txt_apellido2
            // 
            this.txt_apellido2.Location = new System.Drawing.Point(256, 164);
            this.txt_apellido2.Name = "txt_apellido2";
            this.txt_apellido2.Size = new System.Drawing.Size(151, 20);
            this.txt_apellido2.TabIndex = 38;
            this.txt_apellido2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellido2_KeyPress);
            // 
            // txt_apellido1
            // 
            this.txt_apellido1.Location = new System.Drawing.Point(99, 164);
            this.txt_apellido1.MaxLength = 20;
            this.txt_apellido1.Name = "txt_apellido1";
            this.txt_apellido1.Size = new System.Drawing.Size(151, 20);
            this.txt_apellido1.TabIndex = 37;
            this.txt_apellido1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellido1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 36;
            this.label1.Text = "Apellido:";
            // 
            // txt_nombre2
            // 
            this.txt_nombre2.Location = new System.Drawing.Point(256, 138);
            this.txt_nombre2.MaxLength = 20;
            this.txt_nombre2.Name = "txt_nombre2";
            this.txt_nombre2.Size = new System.Drawing.Size(151, 20);
            this.txt_nombre2.TabIndex = 35;
            this.txt_nombre2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre2_KeyPress);
            // 
            // txt_nombre1
            // 
            this.txt_nombre1.Location = new System.Drawing.Point(99, 138);
            this.txt_nombre1.MaxLength = 20;
            this.txt_nombre1.Name = "txt_nombre1";
            this.txt_nombre1.Size = new System.Drawing.Size(151, 20);
            this.txt_nombre1.TabIndex = 34;
            this.txt_nombre1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre1_KeyPress);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(16, 135);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(77, 21);
            this.lbl_nombre.TabIndex = 26;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackgroundImage = global::cinepolis.Properties.Resources.Button_Previous_icon;
            this.btn_regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_regresar.Location = new System.Drawing.Point(12, 41);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(57, 40);
            this.btn_regresar.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btn_regresar, "Regresar");
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // btn_cerrarsesion
            // 
            this.btn_cerrarsesion.BackgroundImage = global::cinepolis.Properties.Resources.FONDO_ICONO;
            this.btn_cerrarsesion.Location = new System.Drawing.Point(12, 12);
            this.btn_cerrarsesion.Name = "btn_cerrarsesion";
            this.btn_cerrarsesion.Size = new System.Drawing.Size(94, 23);
            this.btn_cerrarsesion.TabIndex = 10;
            this.btn_cerrarsesion.Text = "Cerrar Sesión";
            this.btn_cerrarsesion.UseVisualStyleBackColor = true;
            this.btn_cerrarsesion.Click += new System.EventHandler(this.btn_cerrarsesion_Click);
            // 
            // empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(900, 515);
            this.Controls.Add(this.dgv_emplados_modificar);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.btn_telefono_empleado);
            this.Controls.Add(this.lbl_codigo_buscar);
            this.Controls.Add(this.lbl_titulo_mantenimiento_cine);
            this.Controls.Add(this.btn_eliminar_Empleado);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.btn_buscar_empleado);
            this.Controls.Add(this.btn_cerrarsesion);
            this.Controls.Add(this.bttn_actualizar_Empleado);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_nombre1);
            this.Controls.Add(this.dtp_fecha_nac);
            this.Controls.Add(this.txt_nombre2);
            this.Controls.Add(this.cbo_cine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_apellido1);
            this.Controls.Add(this.lbl_cine);
            this.Controls.Add(this.txt_apellido2);
            this.Controls.Add(this.cbo_puesto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nit);
            this.Controls.Add(this.txt_dpi);
            this.Controls.Add(this.label4);
            this.Name = "empleado";
            this.Text = "empleado";
            this.Load += new System.EventHandler(this.empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emplados_modificar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Button btn_cerrarsesion;
        private System.Windows.Forms.Label lbl_titulo_mantenimiento_cine;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_apellido2;
        private System.Windows.Forms.TextBox txt_apellido1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre2;
        private System.Windows.Forms.TextBox txt_nombre1;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_cine;
        private System.Windows.Forms.ComboBox cbo_puesto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_dpi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.ComboBox cbo_cine;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker dtp_fecha_nac;
        private System.Windows.Forms.DataGridView dgv_emplados_modificar;
        private System.Windows.Forms.Button btn_eliminar_Empleado;
        private System.Windows.Forms.Button btn_buscar_empleado;
        private System.Windows.Forms.Button bttn_actualizar_Empleado;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label lbl_codigo_buscar;
        private System.Windows.Forms.Button btn_telefono_empleado;
    }
}