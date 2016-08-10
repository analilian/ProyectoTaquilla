namespace cinepolis
{
    partial class sala
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
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_sala = new System.Windows.Forms.Label();
            this.txt_sala = new System.Windows.Forms.TextBox();
            this.dgv_sala = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_buscmod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_mod = new System.Windows.Forms.Label();
            this.txt_mod = new System.Windows.Forms.TextBox();
            this.dgv_modsala = new System.Windows.Forms.DataGridView();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_mod_guardar = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.lbl_codigo_buscar = new System.Windows.Forms.Label();
            this.dgv_borrarsala = new System.Windows.Forms.DataGridView();
            this.lbl_titulo_mantenimiento_cine = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbc_clasificacion.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sala)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modsala)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_borrarsala)).BeginInit();
            this.SuspendLayout();
            // 
            // tbc_clasificacion
            // 
            this.tbc_clasificacion.Controls.Add(this.tabPage1);
            this.tbc_clasificacion.Controls.Add(this.tabPage2);
            this.tbc_clasificacion.Controls.Add(this.tabPage3);
            this.tbc_clasificacion.Location = new System.Drawing.Point(2, 92);
            this.tbc_clasificacion.Name = "tbc_clasificacion";
            this.tbc_clasificacion.SelectedIndex = 0;
            this.tbc_clasificacion.Size = new System.Drawing.Size(724, 348);
            this.tbc_clasificacion.TabIndex = 65;
            this.tbc_clasificacion.SelectedIndexChanged += new System.EventHandler(this.tbc_clasificacion_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.btn_guardar);
            this.tabPage1.Controls.Add(this.lbl_sala);
            this.tabPage1.Controls.Add(this.txt_sala);
            this.tabPage1.Controls.Add(this.dgv_sala);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(716, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar Sala";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
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
            // lbl_sala
            // 
            this.lbl_sala.AutoSize = true;
            this.lbl_sala.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sala.Location = new System.Drawing.Point(56, 73);
            this.lbl_sala.Name = "lbl_sala";
            this.lbl_sala.Size = new System.Drawing.Size(77, 21);
            this.lbl_sala.TabIndex = 58;
            this.lbl_sala.Text = "Nombre:";
            // 
            // txt_sala
            // 
            this.txt_sala.Location = new System.Drawing.Point(153, 76);
            this.txt_sala.MaxLength = 20;
            this.txt_sala.Name = "txt_sala";
            this.txt_sala.Size = new System.Drawing.Size(288, 20);
            this.txt_sala.TabIndex = 56;
            // 
            // dgv_sala
            // 
            this.dgv_sala.AllowUserToAddRows = false;
            this.dgv_sala.AllowUserToDeleteRows = false;
            this.dgv_sala.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_sala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sala.Location = new System.Drawing.Point(12, 136);
            this.dgv_sala.Name = "dgv_sala";
            this.dgv_sala.ReadOnly = true;
            this.dgv_sala.Size = new System.Drawing.Size(690, 180);
            this.dgv_sala.TabIndex = 55;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.txt_buscmod);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.lbl_mod);
            this.tabPage2.Controls.Add(this.txt_mod);
            this.tabPage2.Controls.Add(this.dgv_modsala);
            this.tabPage2.Controls.Add(this.btn_actualizar);
            this.tabPage2.Controls.Add(this.btn_mod_guardar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(716, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar Sala";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::cinepolis.Properties.Resources.Zoom_icon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(346, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 45);
            this.button1.TabIndex = 90;
            this.toolTip1.SetToolTip(this.button1, "Buscar");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_buscmod
            // 
            this.txt_buscmod.Location = new System.Drawing.Point(145, 86);
            this.txt_buscmod.MaxLength = 100;
            this.txt_buscmod.Name = "txt_buscmod";
            this.txt_buscmod.Size = new System.Drawing.Size(181, 20);
            this.txt_buscmod.TabIndex = 89;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 88;
            this.label1.Text = "Busqueda:";
            // 
            // lbl_mod
            // 
            this.lbl_mod.AutoSize = true;
            this.lbl_mod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mod.Location = new System.Drawing.Point(20, 30);
            this.lbl_mod.Name = "lbl_mod";
            this.lbl_mod.Size = new System.Drawing.Size(77, 21);
            this.lbl_mod.TabIndex = 87;
            this.lbl_mod.Text = "Nombre:";
            // 
            // txt_mod
            // 
            this.txt_mod.Location = new System.Drawing.Point(145, 33);
            this.txt_mod.MaxLength = 20;
            this.txt_mod.Name = "txt_mod";
            this.txt_mod.Size = new System.Drawing.Size(288, 20);
            this.txt_mod.TabIndex = 86;
            this.txt_mod.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dgv_modsala
            // 
            this.dgv_modsala.AllowUserToAddRows = false;
            this.dgv_modsala.AllowUserToDeleteRows = false;
            this.dgv_modsala.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_modsala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_modsala.Location = new System.Drawing.Point(24, 136);
            this.dgv_modsala.Name = "dgv_modsala";
            this.dgv_modsala.ReadOnly = true;
            this.dgv_modsala.Size = new System.Drawing.Size(635, 180);
            this.dgv_modsala.TabIndex = 61;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackgroundImage = global::cinepolis.Properties.Resources.Button_Refresh_icon1;
            this.btn_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_actualizar.Location = new System.Drawing.Point(502, 21);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(84, 73);
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
            this.tabPage3.Controls.Add(this.dgv_borrarsala);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(716, 322);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Borrar Sala";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.BackgroundImage = global::cinepolis.Properties.Resources.File_Delete_icon;
            this.btn_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_borrar.Location = new System.Drawing.Point(558, 16);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(71, 52);
            this.btn_borrar.TabIndex = 60;
            this.toolTip1.SetToolTip(this.btn_borrar, "Borrar");
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = global::cinepolis.Properties.Resources.Zoom_icon;
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.Location = new System.Drawing.Point(415, 16);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(81, 52);
            this.btn_buscar.TabIndex = 59;
            this.toolTip1.SetToolTip(this.btn_buscar, "Buscar");
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(182, 33);
            this.txt_buscar.MaxLength = 100;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(181, 20);
            this.txt_buscar.TabIndex = 58;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            // 
            // lbl_codigo_buscar
            // 
            this.lbl_codigo_buscar.AutoSize = true;
            this.lbl_codigo_buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo_buscar.Location = new System.Drawing.Point(87, 30);
            this.lbl_codigo_buscar.Name = "lbl_codigo_buscar";
            this.lbl_codigo_buscar.Size = new System.Drawing.Size(92, 21);
            this.lbl_codigo_buscar.TabIndex = 57;
            this.lbl_codigo_buscar.Text = "Busqueda:";
            this.lbl_codigo_buscar.Click += new System.EventHandler(this.lbl_codigo_buscar_Click);
            // 
            // dgv_borrarsala
            // 
            this.dgv_borrarsala.AllowUserToAddRows = false;
            this.dgv_borrarsala.AllowUserToDeleteRows = false;
            this.dgv_borrarsala.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_borrarsala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_borrarsala.Location = new System.Drawing.Point(6, 77);
            this.dgv_borrarsala.Name = "dgv_borrarsala";
            this.dgv_borrarsala.ReadOnly = true;
            this.dgv_borrarsala.Size = new System.Drawing.Size(696, 238);
            this.dgv_borrarsala.TabIndex = 56;
            // 
            // lbl_titulo_mantenimiento_cine
            // 
            this.lbl_titulo_mantenimiento_cine.AutoSize = true;
            this.lbl_titulo_mantenimiento_cine.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_mantenimiento_cine.Location = new System.Drawing.Point(189, 11);
            this.lbl_titulo_mantenimiento_cine.Name = "lbl_titulo_mantenimiento_cine";
            this.lbl_titulo_mantenimiento_cine.Size = new System.Drawing.Size(379, 36);
            this.lbl_titulo_mantenimiento_cine.TabIndex = 63;
            this.lbl_titulo_mantenimiento_cine.Text = "MANTENIMIENTO DE SALA";
            this.lbl_titulo_mantenimiento_cine.Click += new System.EventHandler(this.lbl_titulo_mantenimiento_cine_Click);
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackgroundImage = global::cinepolis.Properties.Resources.Button_Previous_icon;
            this.btn_regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_regresar.Location = new System.Drawing.Point(5, 7);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(57, 40);
            this.btn_regresar.TabIndex = 64;
            this.toolTip1.SetToolTip(this.btn_regresar, "Regresar");
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // sala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(730, 446);
            this.Controls.Add(this.tbc_clasificacion);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.lbl_titulo_mantenimiento_cine);
            this.Name = "sala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sala";
            this.Load += new System.EventHandler(this.sala_Load);
            this.tbc_clasificacion.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sala)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modsala)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_borrarsala)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_clasificacion;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label lbl_sala;
        private System.Windows.Forms.TextBox txt_sala;
        private System.Windows.Forms.DataGridView dgv_sala;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbl_mod;
        private System.Windows.Forms.TextBox txt_mod;
        private System.Windows.Forms.DataGridView dgv_modsala;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_mod_guardar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label lbl_codigo_buscar;
        private System.Windows.Forms.DataGridView dgv_borrarsala;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Label lbl_titulo_mantenimiento_cine;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_buscmod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}