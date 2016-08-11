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
            this.cbo_cine_region = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_descrip_clasificacion = new System.Windows.Forms.Label();
            this.txt_descrip_clasificacion = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_clasificacion = new System.Windows.Forms.Label();
            this.txt_clasificacion = new System.Windows.Forms.TextBox();
            this.dgv_clasificacion = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_region_mod = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_buscarmod = new System.Windows.Forms.TextBox();
            this.lbl_buscarmod = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dirmod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nommod = new System.Windows.Forms.TextBox();
            this.dgv_mod_clasificacion = new System.Windows.Forms.DataGridView();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_mod_guardar = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.lbl_codigo_buscar = new System.Windows.Forms.Label();
            this.dgv_borrar_categoria = new System.Windows.Forms.DataGridView();
            this.lbl_titulo_mantenimiento_cine = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbc_clasificacion.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clasificacion)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mod_clasificacion)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_borrar_categoria)).BeginInit();
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
            this.tbc_clasificacion.TabIndex = 62;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.cbo_cine_region);
            this.tabPage1.Controls.Add(this.label3);
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
            this.tabPage1.Text = "Agregar Cine";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // cbo_cine_region
            // 
            this.cbo_cine_region.FormattingEnabled = true;
            this.cbo_cine_region.Location = new System.Drawing.Point(142, 78);
            this.cbo_cine_region.Name = "cbo_cine_region";
            this.cbo_cine_region.Size = new System.Drawing.Size(191, 21);
            this.cbo_cine_region.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 75);
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
            this.lbl_descrip_clasificacion.Location = new System.Drawing.Point(17, 52);
            this.lbl_descrip_clasificacion.Name = "lbl_descrip_clasificacion";
            this.lbl_descrip_clasificacion.Size = new System.Drawing.Size(87, 21);
            this.lbl_descrip_clasificacion.TabIndex = 62;
            this.lbl_descrip_clasificacion.Text = "Dirección:";
            // 
            // txt_descrip_clasificacion
            // 
            this.txt_descrip_clasificacion.Location = new System.Drawing.Point(142, 52);
            this.txt_descrip_clasificacion.MaxLength = 100;
            this.txt_descrip_clasificacion.Name = "txt_descrip_clasificacion";
            this.txt_descrip_clasificacion.Size = new System.Drawing.Size(288, 20);
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
            this.lbl_clasificacion.Size = new System.Drawing.Size(77, 21);
            this.lbl_clasificacion.TabIndex = 58;
            this.lbl_clasificacion.Text = "Nombre:";
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
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cbo_region_mod);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.txt_buscarmod);
            this.tabPage2.Controls.Add(this.lbl_buscarmod);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txt_dirmod);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txt_nommod);
            this.tabPage2.Controls.Add(this.dgv_mod_clasificacion);
            this.tabPage2.Controls.Add(this.btn_actualizar);
            this.tabPage2.Controls.Add(this.btn_mod_guardar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(713, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar Cine";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 94;
            this.label4.Text = "Region:";
            // 
            // cbo_region_mod
            // 
            this.cbo_region_mod.FormattingEnabled = true;
            this.cbo_region_mod.Location = new System.Drawing.Point(145, 85);
            this.cbo_region_mod.Name = "cbo_region_mod";
            this.cbo_region_mod.Size = new System.Drawing.Size(191, 21);
            this.cbo_region_mod.TabIndex = 93;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::cinepolis.Properties.Resources.Zoom_icon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(453, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 44);
            this.button1.TabIndex = 92;
            this.toolTip1.SetToolTip(this.button1, "Buscar");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_buscarmod
            // 
            this.txt_buscarmod.Location = new System.Drawing.Point(255, 163);
            this.txt_buscarmod.MaxLength = 100;
            this.txt_buscarmod.Name = "txt_buscarmod";
            this.txt_buscarmod.Size = new System.Drawing.Size(178, 20);
            this.txt_buscarmod.TabIndex = 91;
            // 
            // lbl_buscarmod
            // 
            this.lbl_buscarmod.AutoSize = true;
            this.lbl_buscarmod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscarmod.Location = new System.Drawing.Point(184, 160);
            this.lbl_buscarmod.Name = "lbl_buscarmod";
            this.lbl_buscarmod.Size = new System.Drawing.Size(65, 21);
            this.lbl_buscarmod.TabIndex = 90;
            this.lbl_buscarmod.Text = "Buscar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 89;
            this.label1.Text = "Dirección:";
            // 
            // txt_dirmod
            // 
            this.txt_dirmod.Location = new System.Drawing.Point(145, 59);
            this.txt_dirmod.MaxLength = 100;
            this.txt_dirmod.Name = "txt_dirmod";
            this.txt_dirmod.Size = new System.Drawing.Size(288, 20);
            this.txt_dirmod.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 87;
            this.label2.Text = "Nombre:";
            // 
            // txt_nommod
            // 
            this.txt_nommod.Location = new System.Drawing.Point(145, 33);
            this.txt_nommod.MaxLength = 20;
            this.txt_nommod.Name = "txt_nommod";
            this.txt_nommod.Size = new System.Drawing.Size(288, 20);
            this.txt_nommod.TabIndex = 86;
            // 
            // dgv_mod_clasificacion
            // 
            this.dgv_mod_clasificacion.AllowUserToAddRows = false;
            this.dgv_mod_clasificacion.AllowUserToDeleteRows = false;
            this.dgv_mod_clasificacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_mod_clasificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mod_clasificacion.Location = new System.Drawing.Point(24, 200);
            this.dgv_mod_clasificacion.Name = "dgv_mod_clasificacion";
            this.dgv_mod_clasificacion.ReadOnly = true;
            this.dgv_mod_clasificacion.Size = new System.Drawing.Size(635, 116);
            this.dgv_mod_clasificacion.TabIndex = 61;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackgroundImage = global::cinepolis.Properties.Resources.Button_Refresh_icon;
            this.btn_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_actualizar.Location = new System.Drawing.Point(526, 30);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(60, 58);
            this.btn_actualizar.TabIndex = 85;
            this.toolTip1.SetToolTip(this.btn_actualizar, "Actualizar");
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_mod_guardar
            // 
            this.btn_mod_guardar.BackgroundImage = global::cinepolis.Properties.Resources.Save_icon;
            this.btn_mod_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_mod_guardar.Location = new System.Drawing.Point(592, 30);
            this.btn_mod_guardar.Name = "btn_mod_guardar";
            this.btn_mod_guardar.Size = new System.Drawing.Size(67, 58);
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
            this.tabPage3.Controls.Add(this.dgv_borrar_categoria);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(713, 322);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Borrar Cine";
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
            this.lbl_codigo_buscar.Location = new System.Drawing.Point(15, 32);
            this.lbl_codigo_buscar.Name = "lbl_codigo_buscar";
            this.lbl_codigo_buscar.Size = new System.Drawing.Size(154, 21);
            this.lbl_codigo_buscar.TabIndex = 57;
            this.lbl_codigo_buscar.Text = "Codigo Busqueda:";
            // 
            // dgv_borrar_categoria
            // 
            this.dgv_borrar_categoria.AllowUserToAddRows = false;
            this.dgv_borrar_categoria.AllowUserToDeleteRows = false;
            this.dgv_borrar_categoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_borrar_categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_borrar_categoria.Location = new System.Drawing.Point(6, 77);
            this.dgv_borrar_categoria.Name = "dgv_borrar_categoria";
            this.dgv_borrar_categoria.ReadOnly = true;
            this.dgv_borrar_categoria.Size = new System.Drawing.Size(696, 238);
            this.dgv_borrar_categoria.TabIndex = 56;
            // 
            // lbl_titulo_mantenimiento_cine
            // 
            this.lbl_titulo_mantenimiento_cine.AutoSize = true;
            this.lbl_titulo_mantenimiento_cine.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_mantenimiento_cine.Location = new System.Drawing.Point(99, 26);
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mod_clasificacion)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_borrar_categoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_clasificacion;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lbl_descrip_clasificacion;
        private System.Windows.Forms.TextBox txt_descrip_clasificacion;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label lbl_clasificacion;
        private System.Windows.Forms.TextBox txt_clasificacion;
        private System.Windows.Forms.DataGridView dgv_clasificacion;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_mod_clasificacion;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_mod_guardar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label lbl_codigo_buscar;
        private System.Windows.Forms.DataGridView dgv_borrar_categoria;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Label lbl_titulo_mantenimiento_cine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_dirmod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nommod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_buscarmod;
        private System.Windows.Forms.Label lbl_buscarmod;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_cine_region;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_region_mod;
    }
}