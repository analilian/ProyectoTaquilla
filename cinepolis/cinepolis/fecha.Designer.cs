﻿namespace cinepolis
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
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.txt_buscarmod = new System.Windows.Forms.TextBox();
            this.btn_eliminar_fecha = new System.Windows.Forms.Button();
            this.btn_buscar_fecha = new System.Windows.Forms.Button();
            this.bttn_actualizar_fecha = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.dgv_mostrar_fecha = new System.Windows.Forms.DataGridView();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.lbl_titulo_mantenimiento_Fecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostrar_fecha)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.Location = new System.Drawing.Point(22, 214);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(65, 21);
            this.lbl_buscar.TabIndex = 97;
            this.lbl_buscar.Text = "Buscar:";
            // 
            // txt_buscarmod
            // 
            this.txt_buscarmod.Location = new System.Drawing.Point(93, 214);
            this.txt_buscarmod.MaxLength = 100;
            this.txt_buscarmod.Name = "txt_buscarmod";
            this.txt_buscarmod.Size = new System.Drawing.Size(340, 20);
            this.txt_buscarmod.TabIndex = 96;
            // 
            // btn_eliminar_fecha
            // 
            this.btn_eliminar_fecha.BackgroundImage = global::cinepolis.Properties.Resources.File_Delete_icon;
            this.btn_eliminar_fecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar_fecha.Location = new System.Drawing.Point(667, 55);
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
            this.btn_buscar_fecha.Location = new System.Drawing.Point(475, 56);
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
            this.bttn_actualizar_fecha.Location = new System.Drawing.Point(539, 55);
            this.bttn_actualizar_fecha.Name = "bttn_actualizar_fecha";
            this.bttn_actualizar_fecha.Size = new System.Drawing.Size(61, 56);
            this.bttn_actualizar_fecha.TabIndex = 94;
            this.bttn_actualizar_fecha.UseVisualStyleBackColor = true;
            this.bttn_actualizar_fecha.Click += new System.EventHandler(this.bttn_actualizar_pelicula_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(381, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 21);
            this.label3.TabIndex = 92;
            this.label3.Text = "Fecha de finalización:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 21);
            this.label4.TabIndex = 91;
            this.label4.Text = "Fecha de inicio:";
            // 
            // dtp_fecha_fin
            // 
            this.dtp_fecha_fin.CustomFormat = "yyyy--MM--dd";
            this.dtp_fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha_fin.Location = new System.Drawing.Point(565, 147);
            this.dtp_fecha_fin.Name = "dtp_fecha_fin";
            this.dtp_fecha_fin.Size = new System.Drawing.Size(105, 20);
            this.dtp_fecha_fin.TabIndex = 62;
            // 
            // dtp_fecha_inicio
            // 
            this.dtp_fecha_inicio.CustomFormat = "yyyy--MM--dd";
            this.dtp_fecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha_inicio.Location = new System.Drawing.Point(236, 148);
            this.dtp_fecha_inicio.Name = "dtp_fecha_inicio";
            this.dtp_fecha_inicio.Size = new System.Drawing.Size(105, 20);
            this.dtp_fecha_inicio.TabIndex = 61;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImage = global::cinepolis.Properties.Resources.Save_icon;
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.Location = new System.Drawing.Point(604, 54);
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
            this.dgv_mostrar_fecha.Location = new System.Drawing.Point(5, 243);
            this.dgv_mostrar_fecha.Name = "dgv_mostrar_fecha";
            this.dgv_mostrar_fecha.ReadOnly = true;
            this.dgv_mostrar_fecha.Size = new System.Drawing.Size(713, 191);
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
            // fecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(730, 446);
            this.Controls.Add(this.dgv_mostrar_fecha);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.txt_buscarmod);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.btn_eliminar_fecha);
            this.Controls.Add(this.btn_buscar_fecha);
            this.Controls.Add(this.lbl_titulo_mantenimiento_Fecha);
            this.Controls.Add(this.bttn_actualizar_fecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.dtp_fecha_inicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_fecha_fin);
            this.Name = "fecha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.fecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostrar_fecha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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