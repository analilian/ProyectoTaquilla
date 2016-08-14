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
            this.components = new System.ComponentModel.Container();
            this.tbc_horario = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_hora_final = new System.Windows.Forms.TextBox();
            this.txt_horario_inicio = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_horariofin = new System.Windows.Forms.Label();
            this.lbl_horainicio = new System.Windows.Forms.Label();
            this.dgv_mostrar_horario = new System.Windows.Forms.DataGridView();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.lbl_titulo_mantenimiento_cine = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_eliminar_horario = new System.Windows.Forms.Button();
            this.btn_buscar_horario = new System.Windows.Forms.Button();
            this.bttn_actualizar_horario = new System.Windows.Forms.Button();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.txt_buscarmod = new System.Windows.Forms.TextBox();
            this.tbc_horario.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostrar_horario)).BeginInit();
            this.SuspendLayout();
            // 
            // tbc_horario
            // 
            this.tbc_horario.Controls.Add(this.tabPage1);
            this.tbc_horario.Location = new System.Drawing.Point(12, 70);
            this.tbc_horario.Name = "tbc_horario";
            this.tbc_horario.SelectedIndex = 0;
            this.tbc_horario.Size = new System.Drawing.Size(721, 375);
            this.tbc_horario.TabIndex = 59;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.lbl_buscar);
            this.tabPage1.Controls.Add(this.txt_buscarmod);
            this.tabPage1.Controls.Add(this.btn_eliminar_horario);
            this.tabPage1.Controls.Add(this.btn_buscar_horario);
            this.tabPage1.Controls.Add(this.bttn_actualizar_horario);
            this.tabPage1.Controls.Add(this.txt_hora_final);
            this.tabPage1.Controls.Add(this.txt_horario_inicio);
            this.tabPage1.Controls.Add(this.btn_guardar);
            this.tabPage1.Controls.Add(this.lbl_horariofin);
            this.tabPage1.Controls.Add(this.lbl_horainicio);
            this.tabPage1.Controls.Add(this.dgv_mostrar_horario);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(713, 349);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mantenimiento de Horario";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txt_hora_final
            // 
            this.txt_hora_final.Location = new System.Drawing.Point(170, 54);
            this.txt_hora_final.Name = "txt_hora_final";
            this.txt_hora_final.Size = new System.Drawing.Size(221, 20);
            this.txt_hora_final.TabIndex = 62;
            // 
            // txt_horario_inicio
            // 
            this.txt_horario_inicio.Location = new System.Drawing.Point(168, 16);
            this.txt_horario_inicio.Name = "txt_horario_inicio";
            this.txt_horario_inicio.Size = new System.Drawing.Size(221, 20);
            this.txt_horario_inicio.TabIndex = 61;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImage = global::cinepolis.Properties.Resources.Save_icon;
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.Location = new System.Drawing.Point(553, 73);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(61, 56);
            this.btn_guardar.TabIndex = 60;
            this.toolTip1.SetToolTip(this.btn_guardar, "Guardar");
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_horariofin
            // 
            this.lbl_horariofin.AutoSize = true;
            this.lbl_horariofin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horariofin.Location = new System.Drawing.Point(8, 54);
            this.lbl_horariofin.Name = "lbl_horariofin";
            this.lbl_horariofin.Size = new System.Drawing.Size(166, 21);
            this.lbl_horariofin.TabIndex = 59;
            this.lbl_horariofin.Text = "Hora de finalización:";
            // 
            // lbl_horainicio
            // 
            this.lbl_horainicio.AutoSize = true;
            this.lbl_horainicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horainicio.Location = new System.Drawing.Point(43, 13);
            this.lbl_horainicio.Name = "lbl_horainicio";
            this.lbl_horainicio.Size = new System.Drawing.Size(119, 21);
            this.lbl_horainicio.TabIndex = 58;
            this.lbl_horainicio.Text = "Hora de inicio:";
            // 
            // dgv_mostrar_horario
            // 
            this.dgv_mostrar_horario.AllowUserToAddRows = false;
            this.dgv_mostrar_horario.AllowUserToDeleteRows = false;
            this.dgv_mostrar_horario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_mostrar_horario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mostrar_horario.Location = new System.Drawing.Point(12, 136);
            this.dgv_mostrar_horario.Name = "dgv_mostrar_horario";
            this.dgv_mostrar_horario.ReadOnly = true;
            this.dgv_mostrar_horario.Size = new System.Drawing.Size(690, 206);
            this.dgv_mostrar_horario.TabIndex = 55;
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackgroundImage = global::cinepolis.Properties.Resources.Button_Previous_icon;
            this.btn_regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_regresar.Location = new System.Drawing.Point(12, 12);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(57, 40);
            this.btn_regresar.TabIndex = 58;
            this.toolTip1.SetToolTip(this.btn_regresar, "Regresar");
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
            // btn_eliminar_horario
            // 
            this.btn_eliminar_horario.BackgroundImage = global::cinepolis.Properties.Resources.File_Delete_icon;
            this.btn_eliminar_horario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar_horario.Location = new System.Drawing.Point(617, 72);
            this.btn_eliminar_horario.Name = "btn_eliminar_horario";
            this.btn_eliminar_horario.Size = new System.Drawing.Size(61, 55);
            this.btn_eliminar_horario.TabIndex = 90;
            this.toolTip1.SetToolTip(this.btn_eliminar_horario, "Eliminar");
            this.btn_eliminar_horario.UseVisualStyleBackColor = true;
            this.btn_eliminar_horario.Click += new System.EventHandler(this.btn_eliminar_horario_Click);
            // 
            // btn_buscar_horario
            // 
            this.btn_buscar_horario.BackgroundImage = global::cinepolis.Properties.Resources.Zoom_icon;
            this.btn_buscar_horario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_horario.Location = new System.Drawing.Point(425, 73);
            this.btn_buscar_horario.Name = "btn_buscar_horario";
            this.btn_buscar_horario.Size = new System.Drawing.Size(61, 55);
            this.btn_buscar_horario.TabIndex = 92;
            this.toolTip1.SetToolTip(this.btn_buscar_horario, "Buscar");
            this.btn_buscar_horario.UseVisualStyleBackColor = true;
            this.btn_buscar_horario.Click += new System.EventHandler(this.btn_buscar_horario_Click);
            // 
            // bttn_actualizar_horario
            // 
            this.bttn_actualizar_horario.BackgroundImage = global::cinepolis.Properties.Resources.Button_Refresh_icon;
            this.bttn_actualizar_horario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_actualizar_horario.Location = new System.Drawing.Point(489, 72);
            this.bttn_actualizar_horario.Name = "bttn_actualizar_horario";
            this.bttn_actualizar_horario.Size = new System.Drawing.Size(61, 56);
            this.bttn_actualizar_horario.TabIndex = 91;
            this.toolTip1.SetToolTip(this.bttn_actualizar_horario, "Actualizar");
            this.bttn_actualizar_horario.UseVisualStyleBackColor = true;
            this.bttn_actualizar_horario.Click += new System.EventHandler(this.bttn_actualizar_pelicula_Click);
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.Location = new System.Drawing.Point(20, 100);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(65, 21);
            this.lbl_buscar.TabIndex = 94;
            this.lbl_buscar.Text = "Buscar:";
            // 
            // txt_buscarmod
            // 
            this.txt_buscarmod.Location = new System.Drawing.Point(91, 100);
            this.txt_buscarmod.MaxLength = 100;
            this.txt_buscarmod.Name = "txt_buscarmod";
            this.txt_buscarmod.Size = new System.Drawing.Size(300, 20);
            this.txt_buscarmod.TabIndex = 93;
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
            this.Load += new System.EventHandler(this.Horario_Load);
            this.tbc_horario.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostrar_horario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_horario;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lbl_horariofin;
        private System.Windows.Forms.Label lbl_horainicio;
        private System.Windows.Forms.DataGridView dgv_mostrar_horario;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Label lbl_titulo_mantenimiento_cine;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txt_hora_final;
        private System.Windows.Forms.TextBox txt_horario_inicio;
        private System.Windows.Forms.Button btn_eliminar_horario;
        private System.Windows.Forms.Button btn_buscar_horario;
        private System.Windows.Forms.Button bttn_actualizar_horario;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.TextBox txt_buscarmod;
    }
}