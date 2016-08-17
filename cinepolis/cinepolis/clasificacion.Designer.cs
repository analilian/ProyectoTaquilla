namespace cinepolis
{
    partial class clasificacion
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
            this.txt_modbuscar = new System.Windows.Forms.TextBox();
            this.lbl_modbuscar = new System.Windows.Forms.Label();
            this.btn_eliminar_pelicula = new System.Windows.Forms.Button();
            this.btn_buscar_pelicula = new System.Windows.Forms.Button();
            this.bttn_actualizar_pelicula = new System.Windows.Forms.Button();
            this.lbl_descrip_clasificacion = new System.Windows.Forms.Label();
            this.txt_descrip_clasificacion = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_clasificacion = new System.Windows.Forms.Label();
            this.txt_clasificacion = new System.Windows.Forms.TextBox();
            this.dgv_clasificacion = new System.Windows.Forms.DataGridView();
            this.lbl_titulo_mantenimiento_cine = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_desactivar = new System.Windows.Forms.Button();
            this.btn_activar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_ayuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clasificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_modbuscar
            // 
            this.txt_modbuscar.Location = new System.Drawing.Point(204, 254);
            this.txt_modbuscar.MaxLength = 100;
            this.txt_modbuscar.Name = "txt_modbuscar";
            this.txt_modbuscar.Size = new System.Drawing.Size(242, 20);
            this.txt_modbuscar.TabIndex = 94;
            // 
            // lbl_modbuscar
            // 
            this.lbl_modbuscar.AutoSize = true;
            this.lbl_modbuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_modbuscar.Location = new System.Drawing.Point(133, 251);
            this.lbl_modbuscar.Name = "lbl_modbuscar";
            this.lbl_modbuscar.Size = new System.Drawing.Size(65, 21);
            this.lbl_modbuscar.TabIndex = 93;
            this.lbl_modbuscar.Text = "Buscar:";
            // 
            // btn_eliminar_pelicula
            // 
            this.btn_eliminar_pelicula.BackgroundImage = global::cinepolis.Properties.Resources.File_Delete_icon;
            this.btn_eliminar_pelicula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar_pelicula.Location = new System.Drawing.Point(661, 66);
            this.btn_eliminar_pelicula.Name = "btn_eliminar_pelicula";
            this.btn_eliminar_pelicula.Size = new System.Drawing.Size(65, 65);
            this.btn_eliminar_pelicula.TabIndex = 90;
            this.toolTip1.SetToolTip(this.btn_eliminar_pelicula, "Eliminar");
            this.btn_eliminar_pelicula.UseVisualStyleBackColor = true;
            this.btn_eliminar_pelicula.Click += new System.EventHandler(this.btn_eliminar_pelicula_Click);
            // 
            // btn_buscar_pelicula
            // 
            this.btn_buscar_pelicula.BackgroundImage = global::cinepolis.Properties.Resources.Zoom_icon;
            this.btn_buscar_pelicula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_pelicula.Location = new System.Drawing.Point(469, 67);
            this.btn_buscar_pelicula.Name = "btn_buscar_pelicula";
            this.btn_buscar_pelicula.Size = new System.Drawing.Size(65, 65);
            this.btn_buscar_pelicula.TabIndex = 92;
            this.toolTip1.SetToolTip(this.btn_buscar_pelicula, "Buscar");
            this.btn_buscar_pelicula.UseVisualStyleBackColor = true;
            this.btn_buscar_pelicula.Click += new System.EventHandler(this.btn_buscar_pelicula_Click);
            // 
            // bttn_actualizar_pelicula
            // 
            this.bttn_actualizar_pelicula.BackgroundImage = global::cinepolis.Properties.Resources.moddificar;
            this.bttn_actualizar_pelicula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_actualizar_pelicula.Location = new System.Drawing.Point(533, 66);
            this.bttn_actualizar_pelicula.Name = "bttn_actualizar_pelicula";
            this.bttn_actualizar_pelicula.Size = new System.Drawing.Size(65, 65);
            this.bttn_actualizar_pelicula.TabIndex = 91;
            this.toolTip1.SetToolTip(this.bttn_actualizar_pelicula, "Modificar");
            this.bttn_actualizar_pelicula.UseVisualStyleBackColor = true;
            this.bttn_actualizar_pelicula.Click += new System.EventHandler(this.bttn_actualizar_pelicula_Click);
            // 
            // lbl_descrip_clasificacion
            // 
            this.lbl_descrip_clasificacion.AutoSize = true;
            this.lbl_descrip_clasificacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descrip_clasificacion.Location = new System.Drawing.Point(12, 180);
            this.lbl_descrip_clasificacion.Name = "lbl_descrip_clasificacion";
            this.lbl_descrip_clasificacion.Size = new System.Drawing.Size(104, 21);
            this.lbl_descrip_clasificacion.TabIndex = 62;
            this.lbl_descrip_clasificacion.Text = "Descripción:";
            // 
            // txt_descrip_clasificacion
            // 
            this.txt_descrip_clasificacion.Location = new System.Drawing.Point(137, 180);
            this.txt_descrip_clasificacion.MaxLength = 100;
            this.txt_descrip_clasificacion.Multiline = true;
            this.txt_descrip_clasificacion.Name = "txt_descrip_clasificacion";
            this.txt_descrip_clasificacion.Size = new System.Drawing.Size(560, 46);
            this.txt_descrip_clasificacion.TabIndex = 61;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImage = global::cinepolis.Properties.Resources.Save_icon;
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.Location = new System.Drawing.Point(597, 68);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(65, 65);
            this.btn_guardar.TabIndex = 60;
            this.toolTip1.SetToolTip(this.btn_guardar, "Guardar");
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_clasificacion
            // 
            this.lbl_clasificacion.AutoSize = true;
            this.lbl_clasificacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clasificacion.Location = new System.Drawing.Point(12, 151);
            this.lbl_clasificacion.Name = "lbl_clasificacion";
            this.lbl_clasificacion.Size = new System.Drawing.Size(112, 21);
            this.lbl_clasificacion.TabIndex = 58;
            this.lbl_clasificacion.Text = "Clasificación:";
            // 
            // txt_clasificacion
            // 
            this.txt_clasificacion.Location = new System.Drawing.Point(137, 154);
            this.txt_clasificacion.MaxLength = 20;
            this.txt_clasificacion.Name = "txt_clasificacion";
            this.txt_clasificacion.Size = new System.Drawing.Size(207, 20);
            this.txt_clasificacion.TabIndex = 56;
            // 
            // dgv_clasificacion
            // 
            this.dgv_clasificacion.AllowUserToAddRows = false;
            this.dgv_clasificacion.AllowUserToDeleteRows = false;
            this.dgv_clasificacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_clasificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clasificacion.Location = new System.Drawing.Point(14, 289);
            this.dgv_clasificacion.Name = "dgv_clasificacion";
            this.dgv_clasificacion.ReadOnly = true;
            this.dgv_clasificacion.Size = new System.Drawing.Size(704, 145);
            this.dgv_clasificacion.TabIndex = 55;
            // 
            // lbl_titulo_mantenimiento_cine
            // 
            this.lbl_titulo_mantenimiento_cine.AutoSize = true;
            this.lbl_titulo_mantenimiento_cine.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_mantenimiento_cine.Location = new System.Drawing.Point(99, 26);
            this.lbl_titulo_mantenimiento_cine.Name = "lbl_titulo_mantenimiento_cine";
            this.lbl_titulo_mantenimiento_cine.Size = new System.Drawing.Size(535, 36);
            this.lbl_titulo_mantenimiento_cine.TabIndex = 57;
            this.lbl_titulo_mantenimiento_cine.Text = "MANTENIMIENTO DE CLASIFICACIÓN";
            this.lbl_titulo_mantenimiento_cine.Click += new System.EventHandler(this.lbl_titulo_mantenimiento_cine_Click);
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackgroundImage = global::cinepolis.Properties.Resources.Button_Previous_icon;
            this.btn_regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_regresar.Location = new System.Drawing.Point(5, 7);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(57, 40);
            this.btn_regresar.TabIndex = 58;
            this.toolTip1.SetToolTip(this.btn_regresar, "Regresar");
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // btn_desactivar
            // 
            this.btn_desactivar.BackgroundImage = global::cinepolis.Properties.Resources.Button_Close_icon;
            this.btn_desactivar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_desactivar.Location = new System.Drawing.Point(405, 67);
            this.btn_desactivar.Name = "btn_desactivar";
            this.btn_desactivar.Size = new System.Drawing.Size(65, 65);
            this.btn_desactivar.TabIndex = 102;
            this.toolTip1.SetToolTip(this.btn_desactivar, "Desactivar Iconos y Celdas");
            this.btn_desactivar.UseVisualStyleBackColor = true;
            this.btn_desactivar.Click += new System.EventHandler(this.btn_desactivar_Click);
            // 
            // btn_activar
            // 
            this.btn_activar.BackgroundImage = global::cinepolis.Properties.Resources.File_New_icon;
            this.btn_activar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_activar.Location = new System.Drawing.Point(341, 67);
            this.btn_activar.Name = "btn_activar";
            this.btn_activar.Size = new System.Drawing.Size(65, 65);
            this.btn_activar.TabIndex = 101;
            this.toolTip1.SetToolTip(this.btn_activar, "Activar Iconos y Celdas");
            this.btn_activar.UseVisualStyleBackColor = true;
            this.btn_activar.Click += new System.EventHandler(this.btn_activar_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::cinepolis.Properties.Resources.Button_Refresh_icon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(276, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 65);
            this.button1.TabIndex = 103;
            this.toolTip1.SetToolTip(this.button1, "Actualizar");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.BackColor = System.Drawing.Color.Transparent;
            this.btn_ayuda.BackgroundImage = global::cinepolis.Properties.Resources.ayuda3;
            this.btn_ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ayuda.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ayuda.Location = new System.Drawing.Point(696, 5);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(30, 30);
            this.btn_ayuda.TabIndex = 104;
            this.toolTip1.SetToolTip(this.btn_ayuda, "Menu de Ayuda");
            this.btn_ayuda.UseVisualStyleBackColor = false;
            this.btn_ayuda.Click += new System.EventHandler(this.btn_ayuda_Click);
            // 
            // clasificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(730, 446);
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_desactivar);
            this.Controls.Add(this.btn_activar);
            this.Controls.Add(this.dgv_clasificacion);
            this.Controls.Add(this.txt_modbuscar);
            this.Controls.Add(this.lbl_modbuscar);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.btn_eliminar_pelicula);
            this.Controls.Add(this.btn_buscar_pelicula);
            this.Controls.Add(this.lbl_titulo_mantenimiento_cine);
            this.Controls.Add(this.bttn_actualizar_pelicula);
            this.Controls.Add(this.txt_clasificacion);
            this.Controls.Add(this.lbl_descrip_clasificacion);
            this.Controls.Add(this.lbl_clasificacion);
            this.Controls.Add(this.txt_descrip_clasificacion);
            this.Controls.Add(this.btn_guardar);
            this.MaximizeBox = false;
            this.Name = "clasificacion";
            this.Text = "clasificacion";
            this.Load += new System.EventHandler(this.clasificacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clasificacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label lbl_clasificacion;
        private System.Windows.Forms.TextBox txt_clasificacion;
        private System.Windows.Forms.DataGridView dgv_clasificacion;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Label lbl_titulo_mantenimiento_cine;
        private System.Windows.Forms.Label lbl_descrip_clasificacion;
        private System.Windows.Forms.TextBox txt_descrip_clasificacion;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_eliminar_pelicula;
        private System.Windows.Forms.Button btn_buscar_pelicula;
        private System.Windows.Forms.Button bttn_actualizar_pelicula;
        private System.Windows.Forms.TextBox txt_modbuscar;
        private System.Windows.Forms.Label lbl_modbuscar;
        private System.Windows.Forms.Button btn_desactivar;
        private System.Windows.Forms.Button btn_activar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_ayuda;
    }
}