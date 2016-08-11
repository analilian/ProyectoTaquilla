namespace cinepolis
{
    partial class fecha
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
            this.tbc_horario = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.dgv_mostrar_peliculas = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtp_fecha_fin_mod = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha_inicio_mod = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.btn_buscarmod = new System.Windows.Forms.Button();
            this.txt_buscarmod = new System.Windows.Forms.TextBox();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_mod_guardar = new System.Windows.Forms.Button();
            this.dgv_mod_horario = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.lbl_codigo_buscar = new System.Windows.Forms.Label();
            this.dgv_borrar_horario = new System.Windows.Forms.DataGridView();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.lbl_titulo_mantenimiento_Fecha = new System.Windows.Forms.Label();
            this.tbc_horario.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostrar_peliculas)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mod_horario)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_borrar_horario)).BeginInit();
            this.SuspendLayout();
            // 
            // tbc_horario
            // 
            this.tbc_horario.Controls.Add(this.tabPage1);
            this.tbc_horario.Controls.Add(this.tabPage2);
            this.tbc_horario.Controls.Add(this.tabPage3);
            this.tbc_horario.Location = new System.Drawing.Point(5, 92);
            this.tbc_horario.Name = "tbc_horario";
            this.tbc_horario.SelectedIndex = 0;
            this.tbc_horario.Size = new System.Drawing.Size(721, 348);
            this.tbc_horario.TabIndex = 62;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.dtp_fecha_fin);
            this.tabPage1.Controls.Add(this.dtp_fecha_inicio);
            this.tabPage1.Controls.Add(this.btn_guardar);
            this.tabPage1.Controls.Add(this.dgv_mostrar_peliculas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(713, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(311, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 21);
            this.label3.TabIndex = 92;
            this.label3.Text = "Fecha de finalización:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 21);
            this.label4.TabIndex = 91;
            this.label4.Text = "Fecha de inicio:";
            // 
            // dtp_fecha_fin
            // 
            this.dtp_fecha_fin.CustomFormat = "yyyy--MM--dd";
            this.dtp_fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha_fin.Location = new System.Drawing.Point(495, 12);
            this.dtp_fecha_fin.Name = "dtp_fecha_fin";
            this.dtp_fecha_fin.Size = new System.Drawing.Size(105, 20);
            this.dtp_fecha_fin.TabIndex = 62;
            // 
            // dtp_fecha_inicio
            // 
            this.dtp_fecha_inicio.CustomFormat = "yyyy--MM--dd";
            this.dtp_fecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha_inicio.Location = new System.Drawing.Point(166, 13);
            this.dtp_fecha_inicio.Name = "dtp_fecha_inicio";
            this.dtp_fecha_inicio.Size = new System.Drawing.Size(105, 20);
            this.dtp_fecha_inicio.TabIndex = 61;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImage = global::cinepolis.Properties.Resources.Save_icon;
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.Location = new System.Drawing.Point(304, 57);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(90, 73);
            this.btn_guardar.TabIndex = 60;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // dgv_mostrar_peliculas
            // 
            this.dgv_mostrar_peliculas.AllowUserToAddRows = false;
            this.dgv_mostrar_peliculas.AllowUserToDeleteRows = false;
            this.dgv_mostrar_peliculas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_mostrar_peliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mostrar_peliculas.Location = new System.Drawing.Point(12, 136);
            this.dgv_mostrar_peliculas.Name = "dgv_mostrar_peliculas";
            this.dgv_mostrar_peliculas.ReadOnly = true;
            this.dgv_mostrar_peliculas.Size = new System.Drawing.Size(690, 180);
            this.dgv_mostrar_peliculas.TabIndex = 55;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.dtp_fecha_fin_mod);
            this.tabPage2.Controls.Add(this.dtp_fecha_inicio_mod);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.lbl_buscar);
            this.tabPage2.Controls.Add(this.btn_buscarmod);
            this.tabPage2.Controls.Add(this.txt_buscarmod);
            this.tabPage2.Controls.Add(this.btn_actualizar);
            this.tabPage2.Controls.Add(this.btn_mod_guardar);
            this.tabPage2.Controls.Add(this.dgv_mod_horario);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(713, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar Fecha";
            // 
            // dtp_fecha_fin_mod
            // 
            this.dtp_fecha_fin_mod.CustomFormat = "yyyy--MM--dd";
            this.dtp_fecha_fin_mod.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha_fin_mod.Location = new System.Drawing.Point(520, 19);
            this.dtp_fecha_fin_mod.Name = "dtp_fecha_fin_mod";
            this.dtp_fecha_fin_mod.Size = new System.Drawing.Size(105, 20);
            this.dtp_fecha_fin_mod.TabIndex = 92;
            // 
            // dtp_fecha_inicio_mod
            // 
            this.dtp_fecha_inicio_mod.CustomFormat = "yyyy--MM--dd";
            this.dtp_fecha_inicio_mod.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha_inicio_mod.Location = new System.Drawing.Point(181, 18);
            this.dtp_fecha_inicio_mod.Name = "dtp_fecha_inicio_mod";
            this.dtp_fecha_inicio_mod.Size = new System.Drawing.Size(105, 20);
            this.dtp_fecha_inicio_mod.TabIndex = 91;
            this.dtp_fecha_inicio_mod.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 21);
            this.label1.TabIndex = 90;
            this.label1.Text = "Fecha de finalización:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 21);
            this.label2.TabIndex = 89;
            this.label2.Text = "Fecha de inicio:";
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.Location = new System.Drawing.Point(74, 84);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(65, 21);
            this.lbl_buscar.TabIndex = 88;
            this.lbl_buscar.Text = "Buscar:";
            // 
            // btn_buscarmod
            // 
            this.btn_buscarmod.BackgroundImage = global::cinepolis.Properties.Resources.Zoom_icon;
            this.btn_buscarmod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscarmod.Location = new System.Drawing.Point(378, 62);
            this.btn_buscarmod.Name = "btn_buscarmod";
            this.btn_buscarmod.Size = new System.Drawing.Size(85, 57);
            this.btn_buscarmod.TabIndex = 87;
            this.btn_buscarmod.UseVisualStyleBackColor = true;
            // 
            // txt_buscarmod
            // 
            this.txt_buscarmod.Location = new System.Drawing.Point(145, 84);
            this.txt_buscarmod.MaxLength = 100;
            this.txt_buscarmod.Name = "txt_buscarmod";
            this.txt_buscarmod.Size = new System.Drawing.Size(178, 20);
            this.txt_buscarmod.TabIndex = 86;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackgroundImage = global::cinepolis.Properties.Resources.Button_Refresh_icon;
            this.btn_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_actualizar.Location = new System.Drawing.Point(469, 62);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(66, 57);
            this.btn_actualizar.TabIndex = 85;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_mod_guardar
            // 
            this.btn_mod_guardar.BackgroundImage = global::cinepolis.Properties.Resources.Save_icon;
            this.btn_mod_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_mod_guardar.Location = new System.Drawing.Point(553, 62);
            this.btn_mod_guardar.Name = "btn_mod_guardar";
            this.btn_mod_guardar.Size = new System.Drawing.Size(59, 57);
            this.btn_mod_guardar.TabIndex = 66;
            this.btn_mod_guardar.UseVisualStyleBackColor = true;
            this.btn_mod_guardar.Click += new System.EventHandler(this.btn_mod_guardar_Click);
            // 
            // dgv_mod_horario
            // 
            this.dgv_mod_horario.AllowUserToAddRows = false;
            this.dgv_mod_horario.AllowUserToDeleteRows = false;
            this.dgv_mod_horario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_mod_horario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mod_horario.Location = new System.Drawing.Point(24, 136);
            this.dgv_mod_horario.Name = "dgv_mod_horario";
            this.dgv_mod_horario.ReadOnly = true;
            this.dgv_mod_horario.Size = new System.Drawing.Size(635, 180);
            this.dgv_mod_horario.TabIndex = 61;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage3.Controls.Add(this.btn_borrar);
            this.tabPage3.Controls.Add(this.btn_buscar);
            this.tabPage3.Controls.Add(this.txt_buscar);
            this.tabPage3.Controls.Add(this.lbl_codigo_buscar);
            this.tabPage3.Controls.Add(this.dgv_borrar_horario);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(713, 322);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Borrar Fecha";
            // 
            // btn_borrar
            // 
            this.btn_borrar.BackgroundImage = global::cinepolis.Properties.Resources.File_Delete_icon;
            this.btn_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_borrar.Location = new System.Drawing.Point(558, 16);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(71, 52);
            this.btn_borrar.TabIndex = 60;
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
            this.btn_buscar.UseVisualStyleBackColor = true;
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
            // dgv_borrar_horario
            // 
            this.dgv_borrar_horario.AllowUserToAddRows = false;
            this.dgv_borrar_horario.AllowUserToDeleteRows = false;
            this.dgv_borrar_horario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_borrar_horario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_borrar_horario.Location = new System.Drawing.Point(6, 77);
            this.dgv_borrar_horario.Name = "dgv_borrar_horario";
            this.dgv_borrar_horario.ReadOnly = true;
            this.dgv_borrar_horario.Size = new System.Drawing.Size(696, 238);
            this.dgv_borrar_horario.TabIndex = 56;
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackgroundImage = global::cinepolis.Properties.Resources.Button_Previous_icon;
            this.btn_regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_regresar.Location = new System.Drawing.Point(5, 7);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(57, 40);
            this.btn_regresar.TabIndex = 61;
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // lbl_titulo_mantenimiento_Fecha
            // 
            this.lbl_titulo_mantenimiento_Fecha.AutoSize = true;
            this.lbl_titulo_mantenimiento_Fecha.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_mantenimiento_Fecha.Location = new System.Drawing.Point(99, 26);
            this.lbl_titulo_mantenimiento_Fecha.Name = "lbl_titulo_mantenimiento_Fecha";
            this.lbl_titulo_mantenimiento_Fecha.Size = new System.Drawing.Size(405, 36);
            this.lbl_titulo_mantenimiento_Fecha.TabIndex = 60;
            this.lbl_titulo_mantenimiento_Fecha.Text = "MANTENIMIENTO DE FECHA";
            // 
            // fecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(730, 446);
            this.Controls.Add(this.tbc_horario);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.lbl_titulo_mantenimiento_Fecha);
            this.Name = "fecha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fecha";
            this.Load += new System.EventHandler(this.fecha_Load);
            this.tbc_horario.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostrar_peliculas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mod_horario)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_borrar_horario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_horario;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.DataGridView dgv_mostrar_peliculas;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.Button btn_buscarmod;
        private System.Windows.Forms.TextBox txt_buscarmod;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_mod_guardar;
        private System.Windows.Forms.DataGridView dgv_mod_horario;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label lbl_codigo_buscar;
        private System.Windows.Forms.DataGridView dgv_borrar_horario;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Label lbl_titulo_mantenimiento_Fecha;
        private System.Windows.Forms.DateTimePicker dtp_fecha_fin;
        private System.Windows.Forms.DateTimePicker dtp_fecha_inicio;
        private System.Windows.Forms.DateTimePicker dtp_fecha_fin_mod;
        private System.Windows.Forms.DateTimePicker dtp_fecha_inicio_mod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}