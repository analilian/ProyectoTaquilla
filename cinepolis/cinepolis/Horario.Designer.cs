namespace cinepolis
{
    partial class Horario
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
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_horariofin = new System.Windows.Forms.Label();
            this.lbl_horainicio = new System.Windows.Forms.Label();
            this.txt_hora_final = new System.Windows.Forms.TextBox();
            this.txt_horario_inicio = new System.Windows.Forms.TextBox();
            this.dgv_mostrar_peliculas = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_mod_guardar = new System.Windows.Forms.Button();
            this.lbl_mod_horafin = new System.Windows.Forms.Label();
            this.txt_mod_hora_inicio = new System.Windows.Forms.Label();
            this.txt_mod_horafin = new System.Windows.Forms.TextBox();
            this.txt_mod_horainicio = new System.Windows.Forms.TextBox();
            this.dgv_mod_horario = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.lbl_codigo_buscar = new System.Windows.Forms.Label();
            this.dgv_borrar_horario = new System.Windows.Forms.DataGridView();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.lbl_titulo_mantenimiento_cine = new System.Windows.Forms.Label();
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
            this.tbc_horario.Location = new System.Drawing.Point(12, 97);
            this.tbc_horario.Name = "tbc_horario";
            this.tbc_horario.SelectedIndex = 0;
            this.tbc_horario.Size = new System.Drawing.Size(721, 348);
            this.tbc_horario.TabIndex = 59;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.btn_guardar);
            this.tabPage1.Controls.Add(this.lbl_horariofin);
            this.tabPage1.Controls.Add(this.lbl_horainicio);
            this.tabPage1.Controls.Add(this.txt_hora_final);
            this.tabPage1.Controls.Add(this.txt_horario_inicio);
            this.tabPage1.Controls.Add(this.dgv_mostrar_peliculas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(713, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar Horario";
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImage = global::cinepolis.Properties.Resources.guardar;
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.Location = new System.Drawing.Point(294, 57);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(90, 73);
            this.btn_guardar.TabIndex = 60;
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // lbl_horariofin
            // 
            this.lbl_horariofin.AutoSize = true;
            this.lbl_horariofin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horariofin.Location = new System.Drawing.Point(300, 11);
            this.lbl_horariofin.Name = "lbl_horariofin";
            this.lbl_horariofin.Size = new System.Drawing.Size(166, 21);
            this.lbl_horariofin.TabIndex = 59;
            this.lbl_horariofin.Text = "Hora de finalización:";
            // 
            // lbl_horainicio
            // 
            this.lbl_horainicio.AutoSize = true;
            this.lbl_horainicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horainicio.Location = new System.Drawing.Point(8, 11);
            this.lbl_horainicio.Name = "lbl_horainicio";
            this.lbl_horainicio.Size = new System.Drawing.Size(119, 21);
            this.lbl_horainicio.TabIndex = 58;
            this.lbl_horainicio.Text = "Hora de inicio:";
            // 
            // txt_hora_final
            // 
            this.txt_hora_final.Location = new System.Drawing.Point(472, 14);
            this.txt_hora_final.MaxLength = 20;
            this.txt_hora_final.Name = "txt_hora_final";
            this.txt_hora_final.Size = new System.Drawing.Size(151, 20);
            this.txt_hora_final.TabIndex = 57;
            // 
            // txt_horario_inicio
            // 
            this.txt_horario_inicio.Location = new System.Drawing.Point(133, 14);
            this.txt_horario_inicio.MaxLength = 20;
            this.txt_horario_inicio.Name = "txt_horario_inicio";
            this.txt_horario_inicio.Size = new System.Drawing.Size(151, 20);
            this.txt_horario_inicio.TabIndex = 56;
            // 
            // dgv_mostrar_peliculas
            // 
            this.dgv_mostrar_peliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mostrar_peliculas.Location = new System.Drawing.Point(12, 136);
            this.dgv_mostrar_peliculas.Name = "dgv_mostrar_peliculas";
            this.dgv_mostrar_peliculas.Size = new System.Drawing.Size(690, 180);
            this.dgv_mostrar_peliculas.TabIndex = 55;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.btn_actualizar);
            this.tabPage2.Controls.Add(this.btn_mod_guardar);
            this.tabPage2.Controls.Add(this.lbl_mod_horafin);
            this.tabPage2.Controls.Add(this.txt_mod_hora_inicio);
            this.tabPage2.Controls.Add(this.txt_mod_horafin);
            this.tabPage2.Controls.Add(this.txt_mod_horainicio);
            this.tabPage2.Controls.Add(this.dgv_mod_horario);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(713, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar Horario";
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackgroundImage = global::cinepolis.Properties.Resources.actualizarr;
            this.btn_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_actualizar.Location = new System.Drawing.Point(212, 57);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(84, 73);
            this.btn_actualizar.TabIndex = 85;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            // 
            // btn_mod_guardar
            // 
            this.btn_mod_guardar.BackgroundImage = global::cinepolis.Properties.Resources.guardar;
            this.btn_mod_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_mod_guardar.Location = new System.Drawing.Point(414, 57);
            this.btn_mod_guardar.Name = "btn_mod_guardar";
            this.btn_mod_guardar.Size = new System.Drawing.Size(90, 73);
            this.btn_mod_guardar.TabIndex = 66;
            this.btn_mod_guardar.UseVisualStyleBackColor = true;
            // 
            // lbl_mod_horafin
            // 
            this.lbl_mod_horafin.AutoSize = true;
            this.lbl_mod_horafin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mod_horafin.Location = new System.Drawing.Point(312, 11);
            this.lbl_mod_horafin.Name = "lbl_mod_horafin";
            this.lbl_mod_horafin.Size = new System.Drawing.Size(166, 21);
            this.lbl_mod_horafin.TabIndex = 65;
            this.lbl_mod_horafin.Text = "Hora de finalización:";
            // 
            // txt_mod_hora_inicio
            // 
            this.txt_mod_hora_inicio.AutoSize = true;
            this.txt_mod_hora_inicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mod_hora_inicio.Location = new System.Drawing.Point(20, 11);
            this.txt_mod_hora_inicio.Name = "txt_mod_hora_inicio";
            this.txt_mod_hora_inicio.Size = new System.Drawing.Size(119, 21);
            this.txt_mod_hora_inicio.TabIndex = 64;
            this.txt_mod_hora_inicio.Text = "Hora de inicio:";
            // 
            // txt_mod_horafin
            // 
            this.txt_mod_horafin.Location = new System.Drawing.Point(484, 14);
            this.txt_mod_horafin.MaxLength = 20;
            this.txt_mod_horafin.Name = "txt_mod_horafin";
            this.txt_mod_horafin.Size = new System.Drawing.Size(151, 20);
            this.txt_mod_horafin.TabIndex = 63;
            // 
            // txt_mod_horainicio
            // 
            this.txt_mod_horainicio.Location = new System.Drawing.Point(145, 14);
            this.txt_mod_horainicio.MaxLength = 20;
            this.txt_mod_horainicio.Name = "txt_mod_horainicio";
            this.txt_mod_horainicio.Size = new System.Drawing.Size(151, 20);
            this.txt_mod_horainicio.TabIndex = 62;
            // 
            // dgv_mod_horario
            // 
            this.dgv_mod_horario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mod_horario.Location = new System.Drawing.Point(24, 136);
            this.dgv_mod_horario.Name = "dgv_mod_horario";
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
            this.tabPage3.Text = "Borrar Horario";
            // 
            // btn_borrar
            // 
            this.btn_borrar.BackgroundImage = global::cinepolis.Properties.Resources.borrar;
            this.btn_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_borrar.Location = new System.Drawing.Point(558, 16);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(71, 52);
            this.btn_borrar.TabIndex = 60;
            this.btn_borrar.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = global::cinepolis.Properties.Resources.buscar;
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
            this.dgv_borrar_horario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_borrar_horario.Location = new System.Drawing.Point(6, 77);
            this.dgv_borrar_horario.Name = "dgv_borrar_horario";
            this.dgv_borrar_horario.ReadOnly = true;
            this.dgv_borrar_horario.Size = new System.Drawing.Size(696, 238);
            this.dgv_borrar_horario.TabIndex = 56;
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackgroundImage = global::cinepolis.Properties.Resources.volver;
            this.btn_regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_regresar.Location = new System.Drawing.Point(12, 12);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(57, 40);
            this.btn_regresar.TabIndex = 58;
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // lbl_titulo_mantenimiento_cine
            // 
            this.lbl_titulo_mantenimiento_cine.AutoSize = true;
            this.lbl_titulo_mantenimiento_cine.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_mantenimiento_cine.Location = new System.Drawing.Point(106, 31);
            this.lbl_titulo_mantenimiento_cine.Name = "lbl_titulo_mantenimiento_cine";
            this.lbl_titulo_mantenimiento_cine.Size = new System.Drawing.Size(445, 36);
            this.lbl_titulo_mantenimiento_cine.TabIndex = 57;
            this.lbl_titulo_mantenimiento_cine.Text = "MANTENIMIENTO DE HORARIO";
            // 
            // Horario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(741, 446);
            this.Controls.Add(this.tbc_horario);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.lbl_titulo_mantenimiento_cine);
            this.Name = "Horario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horario";
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
        private System.Windows.Forms.Label lbl_horariofin;
        private System.Windows.Forms.Label lbl_horainicio;
        private System.Windows.Forms.TextBox txt_hora_final;
        private System.Windows.Forms.TextBox txt_horario_inicio;
        private System.Windows.Forms.DataGridView dgv_mostrar_peliculas;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_mod_guardar;
        private System.Windows.Forms.Label lbl_mod_horafin;
        private System.Windows.Forms.Label txt_mod_hora_inicio;
        private System.Windows.Forms.TextBox txt_mod_horafin;
        private System.Windows.Forms.TextBox txt_mod_horainicio;
        private System.Windows.Forms.DataGridView dgv_mod_horario;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label lbl_codigo_buscar;
        private System.Windows.Forms.DataGridView dgv_borrar_horario;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Label lbl_titulo_mantenimiento_cine;
    }
}