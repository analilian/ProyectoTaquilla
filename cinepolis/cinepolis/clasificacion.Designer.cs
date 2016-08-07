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
            this.tbc_clasificacion = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_descrip_clasificacion = new System.Windows.Forms.Label();
            this.txt_descrip_clasificacion = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_clasificacion = new System.Windows.Forms.Label();
            this.txt_clasificacion = new System.Windows.Forms.TextBox();
            this.dgv_clasificacion = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_modbuscar = new System.Windows.Forms.Button();
            this.txt_modbuscar = new System.Windows.Forms.TextBox();
            this.lbl_modbuscar = new System.Windows.Forms.Label();
            this.lbl_mod_descrip_clasificacion = new System.Windows.Forms.Label();
            this.txt_mod_descrip_clasificacion = new System.Windows.Forms.TextBox();
            this.lbl_mod_clasificacion = new System.Windows.Forms.Label();
            this.txt_mod_clasificacion = new System.Windows.Forms.TextBox();
            this.dgv_mod_clasificacion = new System.Windows.Forms.DataGridView();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_mod_guardar = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.lbl_codigo_buscar = new System.Windows.Forms.Label();
            this.dgv_borrarclasificacion = new System.Windows.Forms.DataGridView();
            this.lbl_titulo_mantenimiento_cine = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbc_clasificacion.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clasificacion)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mod_clasificacion)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_borrarclasificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // tbc_clasificacion
            // 
            this.tbc_clasificacion.Controls.Add(this.tabPage1);
            this.tbc_clasificacion.Controls.Add(this.tabPage2);
            this.tbc_clasificacion.Controls.Add(this.tabPage3);
            this.tbc_clasificacion.Location = new System.Drawing.Point(5, 92);
            this.tbc_clasificacion.Name = "tbc_clasificacion";
            this.tbc_clasificacion.SelectedIndex = 0;
            this.tbc_clasificacion.Size = new System.Drawing.Size(721, 348);
            this.tbc_clasificacion.TabIndex = 59;
            this.tbc_clasificacion.SelectedIndexChanged += new System.EventHandler(this.tbc_clasificacion_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.lbl_descrip_clasificacion);
            this.tabPage1.Controls.Add(this.txt_descrip_clasificacion);
            this.tabPage1.Controls.Add(this.btn_guardar);
            this.tabPage1.Controls.Add(this.lbl_clasificacion);
            this.tabPage1.Controls.Add(this.txt_clasificacion);
            this.tabPage1.Controls.Add(this.dgv_clasificacion);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(713, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar Clasificación";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lbl_descrip_clasificacion
            // 
            this.lbl_descrip_clasificacion.AutoSize = true;
            this.lbl_descrip_clasificacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descrip_clasificacion.Location = new System.Drawing.Point(17, 52);
            this.lbl_descrip_clasificacion.Name = "lbl_descrip_clasificacion";
            this.lbl_descrip_clasificacion.Size = new System.Drawing.Size(104, 21);
            this.lbl_descrip_clasificacion.TabIndex = 62;
            this.lbl_descrip_clasificacion.Text = "Descripción:";
            // 
            // txt_descrip_clasificacion
            // 
            this.txt_descrip_clasificacion.Location = new System.Drawing.Point(142, 52);
            this.txt_descrip_clasificacion.MaxLength = 100;
            this.txt_descrip_clasificacion.Multiline = true;
            this.txt_descrip_clasificacion.Name = "txt_descrip_clasificacion";
            this.txt_descrip_clasificacion.Size = new System.Drawing.Size(288, 78);
            this.txt_descrip_clasificacion.TabIndex = 61;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImage = global::cinepolis.Properties.Resources.Save_icon;
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.Location = new System.Drawing.Point(513, 23);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(90, 73);
            this.btn_guardar.TabIndex = 60;
            this.toolTip1.SetToolTip(this.btn_guardar, "Guardar");
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_clasificacion
            // 
            this.lbl_clasificacion.AutoSize = true;
            this.lbl_clasificacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clasificacion.Location = new System.Drawing.Point(17, 23);
            this.lbl_clasificacion.Name = "lbl_clasificacion";
            this.lbl_clasificacion.Size = new System.Drawing.Size(112, 21);
            this.lbl_clasificacion.TabIndex = 58;
            this.lbl_clasificacion.Text = "Clasificación:";
            // 
            // txt_clasificacion
            // 
            this.txt_clasificacion.Location = new System.Drawing.Point(142, 26);
            this.txt_clasificacion.MaxLength = 20;
            this.txt_clasificacion.Name = "txt_clasificacion";
            this.txt_clasificacion.Size = new System.Drawing.Size(288, 20);
            this.txt_clasificacion.TabIndex = 56;
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
            this.dgv_clasificacion.Size = new System.Drawing.Size(690, 180);
            this.dgv_clasificacion.TabIndex = 55;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.btn_modbuscar);
            this.tabPage2.Controls.Add(this.txt_modbuscar);
            this.tabPage2.Controls.Add(this.lbl_modbuscar);
            this.tabPage2.Controls.Add(this.lbl_mod_descrip_clasificacion);
            this.tabPage2.Controls.Add(this.txt_mod_descrip_clasificacion);
            this.tabPage2.Controls.Add(this.lbl_mod_clasificacion);
            this.tabPage2.Controls.Add(this.txt_mod_clasificacion);
            this.tabPage2.Controls.Add(this.dgv_mod_clasificacion);
            this.tabPage2.Controls.Add(this.btn_actualizar);
            this.tabPage2.Controls.Add(this.btn_mod_guardar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(713, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar Clasificación";
            // 
            // btn_modbuscar
            // 
            this.btn_modbuscar.BackgroundImage = global::cinepolis.Properties.Resources.Zoom_icon;
            this.btn_modbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_modbuscar.Location = new System.Drawing.Point(425, 87);
            this.btn_modbuscar.Name = "btn_modbuscar";
            this.btn_modbuscar.Size = new System.Drawing.Size(52, 46);
            this.btn_modbuscar.TabIndex = 92;
            this.toolTip1.SetToolTip(this.btn_modbuscar, "Buscar");
            this.btn_modbuscar.UseVisualStyleBackColor = true;
            this.btn_modbuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_modbuscar
            // 
            this.txt_modbuscar.Location = new System.Drawing.Point(177, 101);
            this.txt_modbuscar.MaxLength = 100;
            this.txt_modbuscar.Name = "txt_modbuscar";
            this.txt_modbuscar.Size = new System.Drawing.Size(242, 20);
            this.txt_modbuscar.TabIndex = 91;
            // 
            // lbl_modbuscar
            // 
            this.lbl_modbuscar.AutoSize = true;
            this.lbl_modbuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_modbuscar.Location = new System.Drawing.Point(106, 98);
            this.lbl_modbuscar.Name = "lbl_modbuscar";
            this.lbl_modbuscar.Size = new System.Drawing.Size(65, 21);
            this.lbl_modbuscar.TabIndex = 90;
            this.lbl_modbuscar.Text = "Buscar:";
            this.lbl_modbuscar.Click += new System.EventHandler(this.lbl_modbuscar_Click);
            // 
            // lbl_mod_descrip_clasificacion
            // 
            this.lbl_mod_descrip_clasificacion.AutoSize = true;
            this.lbl_mod_descrip_clasificacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mod_descrip_clasificacion.Location = new System.Drawing.Point(6, 35);
            this.lbl_mod_descrip_clasificacion.Name = "lbl_mod_descrip_clasificacion";
            this.lbl_mod_descrip_clasificacion.Size = new System.Drawing.Size(104, 21);
            this.lbl_mod_descrip_clasificacion.TabIndex = 89;
            this.lbl_mod_descrip_clasificacion.Text = "Descripción:";
            // 
            // txt_mod_descrip_clasificacion
            // 
            this.txt_mod_descrip_clasificacion.Location = new System.Drawing.Point(131, 35);
            this.txt_mod_descrip_clasificacion.MaxLength = 100;
            this.txt_mod_descrip_clasificacion.Multiline = true;
            this.txt_mod_descrip_clasificacion.Name = "txt_mod_descrip_clasificacion";
            this.txt_mod_descrip_clasificacion.Size = new System.Drawing.Size(288, 39);
            this.txt_mod_descrip_clasificacion.TabIndex = 88;
            // 
            // lbl_mod_clasificacion
            // 
            this.lbl_mod_clasificacion.AutoSize = true;
            this.lbl_mod_clasificacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mod_clasificacion.Location = new System.Drawing.Point(6, 6);
            this.lbl_mod_clasificacion.Name = "lbl_mod_clasificacion";
            this.lbl_mod_clasificacion.Size = new System.Drawing.Size(112, 21);
            this.lbl_mod_clasificacion.TabIndex = 87;
            this.lbl_mod_clasificacion.Text = "Clasificación:";
            // 
            // txt_mod_clasificacion
            // 
            this.txt_mod_clasificacion.Location = new System.Drawing.Point(131, 9);
            this.txt_mod_clasificacion.MaxLength = 20;
            this.txt_mod_clasificacion.Name = "txt_mod_clasificacion";
            this.txt_mod_clasificacion.Size = new System.Drawing.Size(288, 20);
            this.txt_mod_clasificacion.TabIndex = 86;
            // 
            // dgv_mod_clasificacion
            // 
            this.dgv_mod_clasificacion.AllowUserToAddRows = false;
            this.dgv_mod_clasificacion.AllowUserToDeleteRows = false;
            this.dgv_mod_clasificacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_mod_clasificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mod_clasificacion.Location = new System.Drawing.Point(24, 136);
            this.dgv_mod_clasificacion.Name = "dgv_mod_clasificacion";
            this.dgv_mod_clasificacion.ReadOnly = true;
            this.dgv_mod_clasificacion.Size = new System.Drawing.Size(635, 180);
            this.dgv_mod_clasificacion.TabIndex = 61;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackgroundImage = global::cinepolis.Properties.Resources.Button_Refresh_icon;
            this.btn_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_actualizar.Location = new System.Drawing.Point(492, 21);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(75, 73);
            this.btn_actualizar.TabIndex = 85;
            this.toolTip1.SetToolTip(this.btn_actualizar, "Actualizar");
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_mod_guardar
            // 
            this.btn_mod_guardar.BackgroundImage = global::cinepolis.Properties.Resources.Save_icon;
            this.btn_mod_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_mod_guardar.Location = new System.Drawing.Point(592, 21);
            this.btn_mod_guardar.Name = "btn_mod_guardar";
            this.btn_mod_guardar.Size = new System.Drawing.Size(90, 73);
            this.btn_mod_guardar.TabIndex = 66;
            this.toolTip1.SetToolTip(this.btn_mod_guardar, "Reguardar");
            this.btn_mod_guardar.UseVisualStyleBackColor = true;
            this.btn_mod_guardar.Click += new System.EventHandler(this.btn_mod_guardar_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage3.Controls.Add(this.btn_borrar);
            this.tabPage3.Controls.Add(this.btn_buscar);
            this.tabPage3.Controls.Add(this.txt_buscar);
            this.tabPage3.Controls.Add(this.lbl_codigo_buscar);
            this.tabPage3.Controls.Add(this.dgv_borrarclasificacion);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(713, 322);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Borrar Clasificación";
            // 
            // btn_borrar
            // 
            this.btn_borrar.BackgroundImage = global::cinepolis.Properties.Resources.File_Delete_icon;
            this.btn_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_borrar.Location = new System.Drawing.Point(558, 16);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(71, 52);
            this.btn_borrar.TabIndex = 60;
            this.toolTip1.SetToolTip(this.btn_borrar, "Eliminar");
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = global::cinepolis.Properties.Resources.Zoom_icon;
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.Location = new System.Drawing.Point(418, 16);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(78, 52);
            this.btn_buscar.TabIndex = 59;
            this.toolTip1.SetToolTip(this.btn_buscar, "Buscar");
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(185, 33);
            this.txt_buscar.MaxLength = 100;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(178, 20);
            this.txt_buscar.TabIndex = 58;
            // 
            // lbl_codigo_buscar
            // 
            this.lbl_codigo_buscar.AutoSize = true;
            this.lbl_codigo_buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo_buscar.Location = new System.Drawing.Point(114, 32);
            this.lbl_codigo_buscar.Name = "lbl_codigo_buscar";
            this.lbl_codigo_buscar.Size = new System.Drawing.Size(65, 21);
            this.lbl_codigo_buscar.TabIndex = 57;
            this.lbl_codigo_buscar.Text = "Buscar:";
            // 
            // dgv_borrarclasificacion
            // 
            this.dgv_borrarclasificacion.AllowUserToAddRows = false;
            this.dgv_borrarclasificacion.AllowUserToDeleteRows = false;
            this.dgv_borrarclasificacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_borrarclasificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_borrarclasificacion.Location = new System.Drawing.Point(6, 77);
            this.dgv_borrarclasificacion.Name = "dgv_borrarclasificacion";
            this.dgv_borrarclasificacion.ReadOnly = true;
            this.dgv_borrarclasificacion.Size = new System.Drawing.Size(696, 238);
            this.dgv_borrarclasificacion.TabIndex = 56;
            this.dgv_borrarclasificacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_borrar_categoria_CellContentClick);
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
            // clasificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(730, 446);
            this.Controls.Add(this.tbc_clasificacion);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.lbl_titulo_mantenimiento_cine);
            this.Name = "clasificacion";
            this.Text = "clasificacion";
            this.Load += new System.EventHandler(this.clasificacion_Load);
            this.tbc_clasificacion.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clasificacion)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mod_clasificacion)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_borrarclasificacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_clasificacion;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label lbl_clasificacion;
        private System.Windows.Forms.TextBox txt_clasificacion;
        private System.Windows.Forms.DataGridView dgv_clasificacion;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_mod_guardar;
        private System.Windows.Forms.DataGridView dgv_mod_clasificacion;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label lbl_codigo_buscar;
        private System.Windows.Forms.DataGridView dgv_borrarclasificacion;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Label lbl_titulo_mantenimiento_cine;
        private System.Windows.Forms.Label lbl_descrip_clasificacion;
        private System.Windows.Forms.TextBox txt_descrip_clasificacion;
        private System.Windows.Forms.Label lbl_mod_descrip_clasificacion;
        private System.Windows.Forms.TextBox txt_mod_descrip_clasificacion;
        private System.Windows.Forms.Label lbl_mod_clasificacion;
        private System.Windows.Forms.TextBox txt_mod_clasificacion;
        private System.Windows.Forms.Button btn_modbuscar;
        private System.Windows.Forms.TextBox txt_modbuscar;
        private System.Windows.Forms.Label lbl_modbuscar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}