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
            this.dgv_mostrar_fecha = new System.Windows.Forms.DataGridView();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.lbl_titulo_mantenimiento_Fecha = new System.Windows.Forms.Label();
            this.btn_eliminar_fecha = new System.Windows.Forms.Button();
            this.btn_buscar_fecha = new System.Windows.Forms.Button();
            this.bttn_actualizar_fecha = new System.Windows.Forms.Button();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.txt_buscarmod = new System.Windows.Forms.TextBox();
            this.tbc_horario.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostrar_fecha)).BeginInit();
            this.SuspendLayout();
            // 
            // tbc_horario
            // 
            this.tbc_horario.Controls.Add(this.tabPage1);
            this.tbc_horario.Location = new System.Drawing.Point(5, 65);
            this.tbc_horario.Name = "tbc_horario";
            this.tbc_horario.SelectedIndex = 0;
            this.tbc_horario.Size = new System.Drawing.Size(721, 375);
            this.tbc_horario.TabIndex = 62;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.lbl_buscar);
            this.tabPage1.Controls.Add(this.txt_buscarmod);
            this.tabPage1.Controls.Add(this.btn_eliminar_fecha);
            this.tabPage1.Controls.Add(this.btn_buscar_fecha);
            this.tabPage1.Controls.Add(this.bttn_actualizar_fecha);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.dtp_fecha_fin);
            this.tabPage1.Controls.Add(this.dtp_fecha_inicio);
            this.tabPage1.Controls.Add(this.btn_guardar);
            this.tabPage1.Controls.Add(this.dgv_mostrar_fecha);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(713, 349);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mantenimiento de Fecha";
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
            this.btn_guardar.Location = new System.Drawing.Point(572, 93);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(61, 56);
            this.btn_guardar.TabIndex = 60;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // dgv_mostrar_fecha
            // 
            this.dgv_mostrar_fecha.AllowUserToAddRows = false;
            this.dgv_mostrar_fecha.AllowUserToDeleteRows = false;
            this.dgv_mostrar_fecha.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_mostrar_fecha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mostrar_fecha.Location = new System.Drawing.Point(6, 152);
            this.dgv_mostrar_fecha.Name = "dgv_mostrar_fecha";
            this.dgv_mostrar_fecha.ReadOnly = true;
            this.dgv_mostrar_fecha.Size = new System.Drawing.Size(690, 191);
            this.dgv_mostrar_fecha.TabIndex = 55;
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
            this.lbl_titulo_mantenimiento_Fecha.Location = new System.Drawing.Point(131, 11);
            this.lbl_titulo_mantenimiento_Fecha.Name = "lbl_titulo_mantenimiento_Fecha";
            this.lbl_titulo_mantenimiento_Fecha.Size = new System.Drawing.Size(405, 36);
            this.lbl_titulo_mantenimiento_Fecha.TabIndex = 60;
            this.lbl_titulo_mantenimiento_Fecha.Text = "MANTENIMIENTO DE FECHA";
            // 
            // btn_eliminar_fecha
            // 
            this.btn_eliminar_fecha.BackgroundImage = global::cinepolis.Properties.Resources.File_Delete_icon;
            this.btn_eliminar_fecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar_fecha.Location = new System.Drawing.Point(635, 94);
            this.btn_eliminar_fecha.Name = "btn_eliminar_fecha";
            this.btn_eliminar_fecha.Size = new System.Drawing.Size(61, 55);
            this.btn_eliminar_fecha.TabIndex = 93;
            this.btn_eliminar_fecha.UseVisualStyleBackColor = true;
            this.btn_eliminar_fecha.Click += new System.EventHandler(this.btn_eliminar_fecha_Click);
            // 
            // btn_buscar_fecha
            // 
            this.btn_buscar_fecha.BackgroundImage = global::cinepolis.Properties.Resources.Zoom_icon;
            this.btn_buscar_fecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_fecha.Location = new System.Drawing.Point(443, 95);
            this.btn_buscar_fecha.Name = "btn_buscar_fecha";
            this.btn_buscar_fecha.Size = new System.Drawing.Size(61, 55);
            this.btn_buscar_fecha.TabIndex = 95;
            this.btn_buscar_fecha.UseVisualStyleBackColor = true;
            this.btn_buscar_fecha.Click += new System.EventHandler(this.btn_buscar_fecha_Click);
            // 
            // bttn_actualizar_fecha
            // 
            this.bttn_actualizar_fecha.BackgroundImage = global::cinepolis.Properties.Resources.Button_Refresh_icon;
            this.bttn_actualizar_fecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_actualizar_fecha.Location = new System.Drawing.Point(507, 94);
            this.bttn_actualizar_fecha.Name = "bttn_actualizar_fecha";
            this.bttn_actualizar_fecha.Size = new System.Drawing.Size(61, 56);
            this.bttn_actualizar_fecha.TabIndex = 94;
            this.bttn_actualizar_fecha.UseVisualStyleBackColor = true;
            this.bttn_actualizar_fecha.Click += new System.EventHandler(this.bttn_actualizar_pelicula_Click);
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.Location = new System.Drawing.Point(4, 113);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(65, 21);
            this.lbl_buscar.TabIndex = 97;
            this.lbl_buscar.Text = "Buscar:";
            // 
            // txt_buscarmod
            // 
            this.txt_buscarmod.Location = new System.Drawing.Point(75, 113);
            this.txt_buscarmod.MaxLength = 100;
            this.txt_buscarmod.Name = "txt_buscarmod";
            this.txt_buscarmod.Size = new System.Drawing.Size(340, 20);
            this.txt_buscarmod.TabIndex = 96;
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
            this.Load += new System.EventHandler(this.fecha_Load);
            this.tbc_horario.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostrar_fecha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_horario;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.DataGridView dgv_mostrar_fecha;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Label lbl_titulo_mantenimiento_Fecha;
        private System.Windows.Forms.DateTimePicker dtp_fecha_fin;
        private System.Windows.Forms.DateTimePicker dtp_fecha_inicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.TextBox txt_buscarmod;
        private System.Windows.Forms.Button btn_eliminar_fecha;
        private System.Windows.Forms.Button btn_buscar_fecha;
        private System.Windows.Forms.Button bttn_actualizar_fecha;
    }
}