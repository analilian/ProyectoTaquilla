namespace cinepolis
{
    partial class cine
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
            this.tbc_clasificacion = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_buscarmod = new System.Windows.Forms.TextBox();
            this.lbl_buscarmod = new System.Windows.Forms.Label();
            this.btn_eliminar_pelicula = new System.Windows.Forms.Button();
            this.btn_buscar_pelicula = new System.Windows.Forms.Button();
            this.bttn_actualizar_pelicula = new System.Windows.Forms.Button();
            this.cbo_cine_region = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_descrip_clasificacion = new System.Windows.Forms.Label();
            this.txt_descrip_cine = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_clasificacion = new System.Windows.Forms.Label();
            this.txt_nombre_cine = new System.Windows.Forms.TextBox();
            this.dgv_clasificacion = new System.Windows.Forms.DataGridView();
            this.lbl_titulo_mantenimiento_cine = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_telefono_empleado = new System.Windows.Forms.Button();
            this.tbc_clasificacion.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clasificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // tbc_clasificacion
            // 
            this.tbc_clasificacion.Controls.Add(this.tabPage1);
            this.tbc_clasificacion.Location = new System.Drawing.Point(5, 65);
            this.tbc_clasificacion.Name = "tbc_clasificacion";
            this.tbc_clasificacion.SelectedIndex = 0;
            this.tbc_clasificacion.Size = new System.Drawing.Size(721, 375);
            this.tbc_clasificacion.TabIndex = 62;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.btn_telefono_empleado);
            this.tabPage1.Controls.Add(this.txt_buscarmod);
            this.tabPage1.Controls.Add(this.lbl_buscarmod);
            this.tabPage1.Controls.Add(this.btn_eliminar_pelicula);
            this.tabPage1.Controls.Add(this.btn_buscar_pelicula);
            this.tabPage1.Controls.Add(this.bttn_actualizar_pelicula);
            this.tabPage1.Controls.Add(this.cbo_cine_region);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lbl_descrip_clasificacion);
            this.tabPage1.Controls.Add(this.txt_descrip_cine);
            this.tabPage1.Controls.Add(this.btn_guardar);
            this.tabPage1.Controls.Add(this.lbl_clasificacion);
            this.tabPage1.Controls.Add(this.txt_nombre_cine);
            this.tabPage1.Controls.Add(this.dgv_clasificacion);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(713, 349);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mantenimiento de Cine";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txt_buscarmod
            // 
            this.txt_buscarmod.Location = new System.Drawing.Point(88, 104);
            this.txt_buscarmod.MaxLength = 100;
            this.txt_buscarmod.Name = "txt_buscarmod";
            this.txt_buscarmod.Size = new System.Drawing.Size(243, 20);
            this.txt_buscarmod.TabIndex = 94;
            // 
            // lbl_buscarmod
            // 
            this.lbl_buscarmod.AutoSize = true;
            this.lbl_buscarmod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscarmod.Location = new System.Drawing.Point(17, 101);
            this.lbl_buscarmod.Name = "lbl_buscarmod";
            this.lbl_buscarmod.Size = new System.Drawing.Size(65, 21);
            this.lbl_buscarmod.TabIndex = 93;
            this.lbl_buscarmod.Text = "Buscar:";
            // 
            // btn_eliminar_pelicula
            // 
            this.btn_eliminar_pelicula.BackgroundImage = global::cinepolis.Properties.Resources.File_Delete_icon;
            this.btn_eliminar_pelicula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar_pelicula.Location = new System.Drawing.Point(579, 77);
            this.btn_eliminar_pelicula.Name = "btn_eliminar_pelicula";
            this.btn_eliminar_pelicula.Size = new System.Drawing.Size(61, 55);
            this.btn_eliminar_pelicula.TabIndex = 90;
            this.toolTip1.SetToolTip(this.btn_eliminar_pelicula, "Eliminar");
            this.btn_eliminar_pelicula.UseVisualStyleBackColor = true;
            this.btn_eliminar_pelicula.Click += new System.EventHandler(this.btn_eliminar_pelicula_Click);
            // 
            // btn_buscar_pelicula
            // 
            this.btn_buscar_pelicula.BackgroundImage = global::cinepolis.Properties.Resources.Zoom_icon;
            this.btn_buscar_pelicula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_pelicula.Location = new System.Drawing.Point(387, 78);
            this.btn_buscar_pelicula.Name = "btn_buscar_pelicula";
            this.btn_buscar_pelicula.Size = new System.Drawing.Size(61, 55);
            this.btn_buscar_pelicula.TabIndex = 92;
            this.toolTip1.SetToolTip(this.btn_buscar_pelicula, "Buscar");
            this.btn_buscar_pelicula.UseVisualStyleBackColor = true;
            this.btn_buscar_pelicula.Click += new System.EventHandler(this.btn_buscar_pelicula_Click);
            // 
            // bttn_actualizar_pelicula
            // 
            this.bttn_actualizar_pelicula.BackgroundImage = global::cinepolis.Properties.Resources.Button_Refresh_icon;
            this.bttn_actualizar_pelicula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_actualizar_pelicula.Location = new System.Drawing.Point(451, 77);
            this.bttn_actualizar_pelicula.Name = "bttn_actualizar_pelicula";
            this.bttn_actualizar_pelicula.Size = new System.Drawing.Size(61, 56);
            this.bttn_actualizar_pelicula.TabIndex = 91;
            this.toolTip1.SetToolTip(this.bttn_actualizar_pelicula, "Actualizar");
            this.bttn_actualizar_pelicula.UseVisualStyleBackColor = true;
            this.bttn_actualizar_pelicula.Click += new System.EventHandler(this.bttn_actualizar_pelicula_Click);
            // 
            // cbo_cine_region
            // 
            this.cbo_cine_region.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_cine_region.FormattingEnabled = true;
            this.cbo_cine_region.Location = new System.Drawing.Point(142, 59);
            this.cbo_cine_region.Name = "cbo_cine_region";
            this.cbo_cine_region.Size = new System.Drawing.Size(191, 21);
            this.cbo_cine_region.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 63;
            this.label3.Text = "Region:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_descrip_clasificacion
            // 
            this.lbl_descrip_clasificacion.AutoSize = true;
            this.lbl_descrip_clasificacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descrip_clasificacion.Location = new System.Drawing.Point(17, 33);
            this.lbl_descrip_clasificacion.Name = "lbl_descrip_clasificacion";
            this.lbl_descrip_clasificacion.Size = new System.Drawing.Size(87, 21);
            this.lbl_descrip_clasificacion.TabIndex = 62;
            this.lbl_descrip_clasificacion.Text = "Dirección:";
            // 
            // txt_descrip_cine
            // 
            this.txt_descrip_cine.Location = new System.Drawing.Point(142, 33);
            this.txt_descrip_cine.MaxLength = 100;
            this.txt_descrip_cine.Name = "txt_descrip_cine";
            this.txt_descrip_cine.Size = new System.Drawing.Size(288, 20);
            this.txt_descrip_cine.TabIndex = 61;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImage = global::cinepolis.Properties.Resources.Save_icon;
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.Location = new System.Drawing.Point(515, 78);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(61, 55);
            this.btn_guardar.TabIndex = 60;
            this.toolTip1.SetToolTip(this.btn_guardar, "Guardar");
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_clasificacion
            // 
            this.lbl_clasificacion.AutoSize = true;
            this.lbl_clasificacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clasificacion.Location = new System.Drawing.Point(17, 4);
            this.lbl_clasificacion.Name = "lbl_clasificacion";
            this.lbl_clasificacion.Size = new System.Drawing.Size(77, 21);
            this.lbl_clasificacion.TabIndex = 58;
            this.lbl_clasificacion.Text = "Nombre:";
            // 
            // txt_nombre_cine
            // 
            this.txt_nombre_cine.Location = new System.Drawing.Point(142, 7);
            this.txt_nombre_cine.MaxLength = 20;
            this.txt_nombre_cine.Name = "txt_nombre_cine";
            this.txt_nombre_cine.Size = new System.Drawing.Size(288, 20);
            this.txt_nombre_cine.TabIndex = 56;
            // 
            // dgv_clasificacion
            // 
            this.dgv_clasificacion.AllowUserToAddRows = false;
            this.dgv_clasificacion.AllowUserToDeleteRows = false;
            this.dgv_clasificacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_clasificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clasificacion.Location = new System.Drawing.Point(12, 136);
            this.dgv_clasificacion.Name = "dgv_clasificacion";
            this.dgv_clasificacion.ReadOnly = true;
            this.dgv_clasificacion.Size = new System.Drawing.Size(690, 193);
            this.dgv_clasificacion.TabIndex = 55;
            // 
            // lbl_titulo_mantenimiento_cine
            // 
            this.lbl_titulo_mantenimiento_cine.AutoSize = true;
            this.lbl_titulo_mantenimiento_cine.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_mantenimiento_cine.Location = new System.Drawing.Point(155, 9);
            this.lbl_titulo_mantenimiento_cine.Name = "lbl_titulo_mantenimiento_cine";
            this.lbl_titulo_mantenimiento_cine.Size = new System.Drawing.Size(379, 36);
            this.lbl_titulo_mantenimiento_cine.TabIndex = 60;
            this.lbl_titulo_mantenimiento_cine.Text = "MANTENIMIENTO DE CINE";
            this.lbl_titulo_mantenimiento_cine.Click += new System.EventHandler(this.lbl_titulo_mantenimiento_cine_Click);
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackgroundImage = global::cinepolis.Properties.Resources.Button_Previous_icon;
            this.btn_regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_regresar.Location = new System.Drawing.Point(5, 7);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(57, 40);
            this.btn_regresar.TabIndex = 61;
            this.toolTip1.SetToolTip(this.btn_regresar, "Regresar");
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // btn_telefono_empleado
            // 
            this.btn_telefono_empleado.BackColor = System.Drawing.Color.Transparent;
            this.btn_telefono_empleado.BackgroundImage = global::cinepolis.Properties.Resources.telefono;
            this.btn_telefono_empleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_telefono_empleado.Location = new System.Drawing.Point(640, 76);
            this.btn_telefono_empleado.Name = "btn_telefono_empleado";
            this.btn_telefono_empleado.Size = new System.Drawing.Size(61, 55);
            this.btn_telefono_empleado.TabIndex = 96;
            this.toolTip1.SetToolTip(this.btn_telefono_empleado, "Agregar Telefono de Cine");
            this.btn_telefono_empleado.UseVisualStyleBackColor = false;
            this.btn_telefono_empleado.Click += new System.EventHandler(this.btn_telefono_empleado_Click);
            // 
            // cine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(730, 446);
            this.Controls.Add(this.tbc_clasificacion);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.lbl_titulo_mantenimiento_cine);
            this.Name = "cine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.cine_Load);
            this.tbc_clasificacion.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clasificacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_clasificacion;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lbl_descrip_clasificacion;
        private System.Windows.Forms.TextBox txt_descrip_cine;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label lbl_clasificacion;
        private System.Windows.Forms.TextBox txt_nombre_cine;
        private System.Windows.Forms.DataGridView dgv_clasificacion;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Label lbl_titulo_mantenimiento_cine;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_cine_region;
        private System.Windows.Forms.Button btn_eliminar_pelicula;
        private System.Windows.Forms.Button btn_buscar_pelicula;
        private System.Windows.Forms.Button bttn_actualizar_pelicula;
        private System.Windows.Forms.TextBox txt_buscarmod;
        private System.Windows.Forms.Label lbl_buscarmod;
        private System.Windows.Forms.Button btn_telefono_empleado;
    }
}