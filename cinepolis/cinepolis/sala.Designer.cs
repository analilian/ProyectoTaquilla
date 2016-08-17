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
            this.button2 = new System.Windows.Forms.Button();
            this.btn_desactivar = new System.Windows.Forms.Button();
            this.txt_buscar_sala = new System.Windows.Forms.TextBox();
            this.btn_activar = new System.Windows.Forms.Button();
            this.lbl_buscar_sala = new System.Windows.Forms.Label();
            this.btn_buscar_sala = new System.Windows.Forms.Button();
            this.btn_eliminar_sala = new System.Windows.Forms.Button();
            this.btn_actualizar_sala = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_sala = new System.Windows.Forms.Label();
            this.txt_sala = new System.Windows.Forms.TextBox();
            this.dgv_sala = new System.Windows.Forms.DataGridView();
            this.tprelacion = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_salacine = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_relacion_sala = new System.Windows.Forms.ComboBox();
            this.cbo_relacion_cine = new System.Windows.Forms.ComboBox();
            this.lbl_titulo_mantenimiento_cine = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_ayuda = new System.Windows.Forms.Button();
            this.tbc_clasificacion.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sala)).BeginInit();
            this.tprelacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_salacine)).BeginInit();
            this.SuspendLayout();
            // 
            // tbc_clasificacion
            // 
            this.tbc_clasificacion.Controls.Add(this.tabPage1);
            this.tbc_clasificacion.Controls.Add(this.tprelacion);
            this.tbc_clasificacion.Location = new System.Drawing.Point(2, 53);
            this.tbc_clasificacion.Name = "tbc_clasificacion";
            this.tbc_clasificacion.SelectedIndex = 0;
            this.tbc_clasificacion.Size = new System.Drawing.Size(724, 387);
            this.tbc_clasificacion.TabIndex = 65;
            this.tbc_clasificacion.SelectedIndexChanged += new System.EventHandler(this.tbc_clasificacion_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.btn_desactivar);
            this.tabPage1.Controls.Add(this.txt_buscar_sala);
            this.tabPage1.Controls.Add(this.btn_activar);
            this.tabPage1.Controls.Add(this.lbl_buscar_sala);
            this.tabPage1.Controls.Add(this.btn_buscar_sala);
            this.tabPage1.Controls.Add(this.btn_eliminar_sala);
            this.tabPage1.Controls.Add(this.btn_actualizar_sala);
            this.tabPage1.Controls.Add(this.btn_guardar);
            this.tabPage1.Controls.Add(this.lbl_sala);
            this.tabPage1.Controls.Add(this.txt_sala);
            this.tabPage1.Controls.Add(this.dgv_sala);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(716, 361);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mantenimiento de Sala";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::cinepolis.Properties.Resources.Button_Refresh_icon1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(257, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 65);
            this.button2.TabIndex = 103;
            this.toolTip1.SetToolTip(this.button2, "Actualizar");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_desactivar
            // 
            this.btn_desactivar.BackgroundImage = global::cinepolis.Properties.Resources.Button_Close_icon;
            this.btn_desactivar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_desactivar.FlatAppearance.BorderSize = 0;
            this.btn_desactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_desactivar.Location = new System.Drawing.Point(392, 6);
            this.btn_desactivar.Name = "btn_desactivar";
            this.btn_desactivar.Size = new System.Drawing.Size(65, 65);
            this.btn_desactivar.TabIndex = 102;
            this.toolTip1.SetToolTip(this.btn_desactivar, "Desactivar Iconos y Celdas");
            this.btn_desactivar.UseVisualStyleBackColor = true;
            this.btn_desactivar.Click += new System.EventHandler(this.btn_desactivar_Click);
            // 
            // txt_buscar_sala
            // 
            this.txt_buscar_sala.Location = new System.Drawing.Point(115, 106);
            this.txt_buscar_sala.MaxLength = 100;
            this.txt_buscar_sala.Name = "txt_buscar_sala";
            this.txt_buscar_sala.Size = new System.Drawing.Size(288, 20);
            this.txt_buscar_sala.TabIndex = 91;
            // 
            // btn_activar
            // 
            this.btn_activar.BackgroundImage = global::cinepolis.Properties.Resources.File_New_icon;
            this.btn_activar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_activar.FlatAppearance.BorderSize = 0;
            this.btn_activar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_activar.Location = new System.Drawing.Point(328, 6);
            this.btn_activar.Name = "btn_activar";
            this.btn_activar.Size = new System.Drawing.Size(65, 65);
            this.btn_activar.TabIndex = 101;
            this.toolTip1.SetToolTip(this.btn_activar, "Activar Iconos y Celdas");
            this.btn_activar.UseVisualStyleBackColor = true;
            this.btn_activar.Click += new System.EventHandler(this.btn_activar_Click);
            // 
            // lbl_buscar_sala
            // 
            this.lbl_buscar_sala.AutoSize = true;
            this.lbl_buscar_sala.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar_sala.Location = new System.Drawing.Point(8, 103);
            this.lbl_buscar_sala.Name = "lbl_buscar_sala";
            this.lbl_buscar_sala.Size = new System.Drawing.Size(92, 21);
            this.lbl_buscar_sala.TabIndex = 90;
            this.lbl_buscar_sala.Text = "Busqueda:";
            // 
            // btn_buscar_sala
            // 
            this.btn_buscar_sala.BackgroundImage = global::cinepolis.Properties.Resources.Zoom_icon;
            this.btn_buscar_sala.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_sala.FlatAppearance.BorderSize = 0;
            this.btn_buscar_sala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar_sala.Location = new System.Drawing.Point(455, 6);
            this.btn_buscar_sala.Name = "btn_buscar_sala";
            this.btn_buscar_sala.Size = new System.Drawing.Size(65, 65);
            this.btn_buscar_sala.TabIndex = 88;
            this.toolTip1.SetToolTip(this.btn_buscar_sala, "Buscar");
            this.btn_buscar_sala.UseVisualStyleBackColor = true;
            this.btn_buscar_sala.Click += new System.EventHandler(this.btn_buscar_sala_Click);
            // 
            // btn_eliminar_sala
            // 
            this.btn_eliminar_sala.BackgroundImage = global::cinepolis.Properties.Resources.File_Delete_icon;
            this.btn_eliminar_sala.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar_sala.FlatAppearance.BorderSize = 0;
            this.btn_eliminar_sala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar_sala.Location = new System.Drawing.Point(647, 6);
            this.btn_eliminar_sala.Name = "btn_eliminar_sala";
            this.btn_eliminar_sala.Size = new System.Drawing.Size(65, 65);
            this.btn_eliminar_sala.TabIndex = 87;
            this.toolTip1.SetToolTip(this.btn_eliminar_sala, "Borrar");
            this.btn_eliminar_sala.UseVisualStyleBackColor = true;
            this.btn_eliminar_sala.Click += new System.EventHandler(this.btn_eliminar_sala_Click);
            // 
            // btn_actualizar_sala
            // 
            this.btn_actualizar_sala.BackgroundImage = global::cinepolis.Properties.Resources.moddificar;
            this.btn_actualizar_sala.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_actualizar_sala.FlatAppearance.BorderSize = 0;
            this.btn_actualizar_sala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar_sala.Location = new System.Drawing.Point(520, 6);
            this.btn_actualizar_sala.Name = "btn_actualizar_sala";
            this.btn_actualizar_sala.Size = new System.Drawing.Size(65, 65);
            this.btn_actualizar_sala.TabIndex = 86;
            this.toolTip1.SetToolTip(this.btn_actualizar_sala, "Modificar");
            this.btn_actualizar_sala.UseVisualStyleBackColor = true;
            this.btn_actualizar_sala.Click += new System.EventHandler(this.btn_actualizar_sala_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImage = global::cinepolis.Properties.Resources.Save_icon;
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Location = new System.Drawing.Point(584, 6);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(65, 65);
            this.btn_guardar.TabIndex = 60;
            this.toolTip1.SetToolTip(this.btn_guardar, "Guardar");
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_sala
            // 
            this.lbl_sala.AutoSize = true;
            this.lbl_sala.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sala.Location = new System.Drawing.Point(8, 69);
            this.lbl_sala.Name = "lbl_sala";
            this.lbl_sala.Size = new System.Drawing.Size(77, 21);
            this.lbl_sala.TabIndex = 58;
            this.lbl_sala.Text = "Nombre:";
            // 
            // txt_sala
            // 
            this.txt_sala.Location = new System.Drawing.Point(105, 72);
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
            this.dgv_sala.Size = new System.Drawing.Size(690, 219);
            this.dgv_sala.TabIndex = 55;
            // 
            // tprelacion
            // 
            this.tprelacion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tprelacion.Controls.Add(this.button1);
            this.tprelacion.Controls.Add(this.dgv_salacine);
            this.tprelacion.Controls.Add(this.label2);
            this.tprelacion.Controls.Add(this.label1);
            this.tprelacion.Controls.Add(this.cbo_relacion_sala);
            this.tprelacion.Controls.Add(this.cbo_relacion_cine);
            this.tprelacion.Location = new System.Drawing.Point(4, 22);
            this.tprelacion.Name = "tprelacion";
            this.tprelacion.Padding = new System.Windows.Forms.Padding(3);
            this.tprelacion.Size = new System.Drawing.Size(716, 361);
            this.tprelacion.TabIndex = 1;
            this.tprelacion.Text = "Relacionar Sala - Cine";
            this.toolTip1.SetToolTip(this.tprelacion, "Agregar Sala al Cine");
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::cinepolis.Properties.Resources.Button_Add_icon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(536, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 52);
            this.button1.TabIndex = 66;
            this.toolTip1.SetToolTip(this.button1, "Regresar");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dgv_salacine
            // 
            this.dgv_salacine.AllowUserToAddRows = false;
            this.dgv_salacine.AllowUserToDeleteRows = false;
            this.dgv_salacine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_salacine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_salacine.Location = new System.Drawing.Point(6, 105);
            this.dgv_salacine.Name = "dgv_salacine";
            this.dgv_salacine.ReadOnly = true;
            this.dgv_salacine.Size = new System.Drawing.Size(704, 250);
            this.dgv_salacine.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 21);
            this.label2.TabIndex = 60;
            this.label2.Text = "Sala:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 59;
            this.label1.Text = "Cine:";
            // 
            // cbo_relacion_sala
            // 
            this.cbo_relacion_sala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_relacion_sala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_relacion_sala.FormattingEnabled = true;
            this.cbo_relacion_sala.Location = new System.Drawing.Point(275, 40);
            this.cbo_relacion_sala.Name = "cbo_relacion_sala";
            this.cbo_relacion_sala.Size = new System.Drawing.Size(121, 21);
            this.cbo_relacion_sala.TabIndex = 1;
            // 
            // cbo_relacion_cine
            // 
            this.cbo_relacion_cine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_relacion_cine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_relacion_cine.FormattingEnabled = true;
            this.cbo_relacion_cine.Location = new System.Drawing.Point(77, 40);
            this.cbo_relacion_cine.Name = "cbo_relacion_cine";
            this.cbo_relacion_cine.Size = new System.Drawing.Size(121, 21);
            this.cbo_relacion_cine.TabIndex = 0;
            // 
            // lbl_titulo_mantenimiento_cine
            // 
            this.lbl_titulo_mantenimiento_cine.AutoSize = true;
            this.lbl_titulo_mantenimiento_cine.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_mantenimiento_cine.Location = new System.Drawing.Point(190, 7);
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
            this.btn_regresar.FlatAppearance.BorderSize = 0;
            this.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regresar.Location = new System.Drawing.Point(5, 7);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(57, 40);
            this.btn_regresar.TabIndex = 64;
            this.toolTip1.SetToolTip(this.btn_regresar, "Regresar");
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.BackColor = System.Drawing.Color.Transparent;
            this.btn_ayuda.BackgroundImage = global::cinepolis.Properties.Resources.ayuda3;
            this.btn_ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ayuda.FlatAppearance.BorderSize = 0;
            this.btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ayuda.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ayuda.Location = new System.Drawing.Point(697, 1);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(30, 30);
            this.btn_ayuda.TabIndex = 66;
            this.toolTip1.SetToolTip(this.btn_ayuda, "Menu de Ayuda");
            this.btn_ayuda.UseVisualStyleBackColor = false;
            this.btn_ayuda.Click += new System.EventHandler(this.btn_ayuda_Click);
            // 
            // sala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(730, 446);
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.tbc_clasificacion);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.lbl_titulo_mantenimiento_cine);
            this.MaximizeBox = false;
            this.Name = "sala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sala";
            this.Load += new System.EventHandler(this.sala_Load);
            this.tbc_clasificacion.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sala)).EndInit();
            this.tprelacion.ResumeLayout(false);
            this.tprelacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_salacine)).EndInit();
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
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Label lbl_titulo_mantenimiento_cine;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_eliminar_sala;
        private System.Windows.Forms.Button btn_actualizar_sala;
        private System.Windows.Forms.Button btn_buscar_sala;
        private System.Windows.Forms.TextBox txt_buscar_sala;
        private System.Windows.Forms.Label lbl_buscar_sala;
        private System.Windows.Forms.TabPage tprelacion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv_salacine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_relacion_sala;
        private System.Windows.Forms.ComboBox cbo_relacion_cine;
        private System.Windows.Forms.Button btn_desactivar;
        private System.Windows.Forms.Button btn_activar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_ayuda;
    }
}