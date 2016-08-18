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
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.txt_buscarmod = new System.Windows.Forms.TextBox();
            this.btn_eliminar_horario = new System.Windows.Forms.Button();
            this.btn_buscar_horario = new System.Windows.Forms.Button();
            this.bttn_actualizar_horario = new System.Windows.Forms.Button();
            this.txt_hora_final = new System.Windows.Forms.TextBox();
            this.txt_horario_inicio = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_horariofin = new System.Windows.Forms.Label();
            this.lbl_horainicio = new System.Windows.Forms.Label();
            this.dgv_mostrar_horario = new System.Windows.Forms.DataGridView();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.lbl_titulo_mantenimiento_cine = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_desactivar = new System.Windows.Forms.Button();
            this.btn_activar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_ayuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostrar_horario)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.Location = new System.Drawing.Point(73, 211);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(65, 21);
            this.lbl_buscar.TabIndex = 94;
            this.lbl_buscar.Text = "Buscar:";
            // 
            // txt_buscarmod
            // 
            this.txt_buscarmod.Location = new System.Drawing.Point(144, 211);
            this.txt_buscarmod.MaxLength = 100;
            this.txt_buscarmod.Name = "txt_buscarmod";
            this.txt_buscarmod.Size = new System.Drawing.Size(300, 20);
            this.txt_buscarmod.TabIndex = 93;
            // 
            // btn_eliminar_horario
            // 
            this.btn_eliminar_horario.BackgroundImage = global::cinepolis.Properties.Resources.File_Delete_icon;
            this.btn_eliminar_horario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar_horario.FlatAppearance.BorderSize = 0;
            this.btn_eliminar_horario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar_horario.Location = new System.Drawing.Point(672, 46);
            this.btn_eliminar_horario.Name = "btn_eliminar_horario";
            this.btn_eliminar_horario.Size = new System.Drawing.Size(65, 65);
            this.btn_eliminar_horario.TabIndex = 90;
            this.toolTip1.SetToolTip(this.btn_eliminar_horario, "Eliminar");
            this.btn_eliminar_horario.UseVisualStyleBackColor = true;
            this.btn_eliminar_horario.Click += new System.EventHandler(this.btn_eliminar_horario_Click);
            // 
            // btn_buscar_horario
            // 
            this.btn_buscar_horario.BackgroundImage = global::cinepolis.Properties.Resources.Zoom_icon;
            this.btn_buscar_horario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_horario.FlatAppearance.BorderSize = 0;
            this.btn_buscar_horario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar_horario.Location = new System.Drawing.Point(480, 47);
            this.btn_buscar_horario.Name = "btn_buscar_horario";
            this.btn_buscar_horario.Size = new System.Drawing.Size(65, 65);
            this.btn_buscar_horario.TabIndex = 92;
            this.toolTip1.SetToolTip(this.btn_buscar_horario, "Buscar");
            this.btn_buscar_horario.UseVisualStyleBackColor = true;
            this.btn_buscar_horario.Click += new System.EventHandler(this.btn_buscar_horario_Click);
            // 
            // bttn_actualizar_horario
            // 
            this.bttn_actualizar_horario.BackgroundImage = global::cinepolis.Properties.Resources.Edit_Document_icon;
            this.bttn_actualizar_horario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_actualizar_horario.FlatAppearance.BorderSize = 0;
            this.bttn_actualizar_horario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_actualizar_horario.Location = new System.Drawing.Point(544, 46);
            this.bttn_actualizar_horario.Name = "bttn_actualizar_horario";
            this.bttn_actualizar_horario.Size = new System.Drawing.Size(65, 65);
            this.bttn_actualizar_horario.TabIndex = 91;
            this.toolTip1.SetToolTip(this.bttn_actualizar_horario, "Modificar");
            this.bttn_actualizar_horario.UseVisualStyleBackColor = true;
            this.bttn_actualizar_horario.Click += new System.EventHandler(this.bttn_actualizar_pelicula_Click);
            // 
            // txt_hora_final
            // 
            this.txt_hora_final.Location = new System.Drawing.Point(521, 142);
            this.txt_hora_final.Name = "txt_hora_final";
            this.txt_hora_final.Size = new System.Drawing.Size(221, 20);
            this.txt_hora_final.TabIndex = 62;
            // 
            // txt_horario_inicio
            // 
            this.txt_horario_inicio.Location = new System.Drawing.Point(133, 142);
            this.txt_horario_inicio.Name = "txt_horario_inicio";
            this.txt_horario_inicio.Size = new System.Drawing.Size(221, 20);
            this.txt_horario_inicio.TabIndex = 61;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImage = global::cinepolis.Properties.Resources.Save_icon;
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Location = new System.Drawing.Point(608, 47);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(65, 65);
            this.btn_guardar.TabIndex = 60;
            this.toolTip1.SetToolTip(this.btn_guardar, "Guardar");
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_horariofin
            // 
            this.lbl_horariofin.AutoSize = true;
            this.lbl_horariofin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horariofin.Location = new System.Drawing.Point(359, 142);
            this.lbl_horariofin.Name = "lbl_horariofin";
            this.lbl_horariofin.Size = new System.Drawing.Size(166, 21);
            this.lbl_horariofin.TabIndex = 59;
            this.lbl_horariofin.Text = "Hora de finalización:";
            // 
            // lbl_horainicio
            // 
            this.lbl_horainicio.AutoSize = true;
            this.lbl_horainicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horainicio.Location = new System.Drawing.Point(8, 139);
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
            this.dgv_mostrar_horario.Location = new System.Drawing.Point(12, 235);
            this.dgv_mostrar_horario.Name = "dgv_mostrar_horario";
            this.dgv_mostrar_horario.ReadOnly = true;
            this.dgv_mostrar_horario.Size = new System.Drawing.Size(717, 206);
            this.dgv_mostrar_horario.TabIndex = 55;
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackgroundImage = global::cinepolis.Properties.Resources.Button_Previous_icon;
            this.btn_regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_regresar.FlatAppearance.BorderSize = 0;
            this.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regresar.Location = new System.Drawing.Point(12, 12);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(58, 50);
            this.btn_regresar.TabIndex = 58;
            this.toolTip1.SetToolTip(this.btn_regresar, "Regresar");
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // lbl_titulo_mantenimiento_cine
            // 
            this.lbl_titulo_mantenimiento_cine.AutoSize = true;
            this.lbl_titulo_mantenimiento_cine.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_mantenimiento_cine.Location = new System.Drawing.Point(149, 7);
            this.lbl_titulo_mantenimiento_cine.Name = "lbl_titulo_mantenimiento_cine";
            this.lbl_titulo_mantenimiento_cine.Size = new System.Drawing.Size(445, 36);
            this.lbl_titulo_mantenimiento_cine.TabIndex = 57;
            this.lbl_titulo_mantenimiento_cine.Text = "MANTENIMIENTO DE HORARIO";
            // 
            // btn_desactivar
            // 
            this.btn_desactivar.BackgroundImage = global::cinepolis.Properties.Resources.Button_Close_icon;
            this.btn_desactivar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_desactivar.FlatAppearance.BorderSize = 0;
            this.btn_desactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_desactivar.Location = new System.Drawing.Point(419, 48);
            this.btn_desactivar.Name = "btn_desactivar";
            this.btn_desactivar.Size = new System.Drawing.Size(65, 65);
            this.btn_desactivar.TabIndex = 102;
            this.toolTip1.SetToolTip(this.btn_desactivar, "Desactivar Iconos y Celdas");
            this.btn_desactivar.UseVisualStyleBackColor = true;
            this.btn_desactivar.Click += new System.EventHandler(this.btn_desactivar_Click);
            // 
            // btn_activar
            // 
            this.btn_activar.BackgroundImage = global::cinepolis.Properties.Resources.File_New_icon;
            this.btn_activar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_activar.FlatAppearance.BorderSize = 0;
            this.btn_activar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_activar.Location = new System.Drawing.Point(356, 48);
            this.btn_activar.Name = "btn_activar";
            this.btn_activar.Size = new System.Drawing.Size(65, 65);
            this.btn_activar.TabIndex = 101;
            this.toolTip1.SetToolTip(this.btn_activar, "Activar Iconos y Celdas");
            this.btn_activar.UseVisualStyleBackColor = true;
            this.btn_activar.Click += new System.EventHandler(this.btn_activar_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::cinepolis.Properties.Resources.Button_Refresh_icon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(292, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 65);
            this.button1.TabIndex = 103;
            this.toolTip1.SetToolTip(this.button1, "Actualizar");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.BackColor = System.Drawing.Color.Transparent;
            this.btn_ayuda.BackgroundImage = global::cinepolis.Properties.Resources.ayuda3;
            this.btn_ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ayuda.FlatAppearance.BorderSize = 0;
            this.btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ayuda.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ayuda.Location = new System.Drawing.Point(710, 0);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(30, 30);
            this.btn_ayuda.TabIndex = 104;
            this.toolTip1.SetToolTip(this.btn_ayuda, "Menu de Ayuda");
            this.btn_ayuda.UseVisualStyleBackColor = false;
            this.btn_ayuda.Click += new System.EventHandler(this.btn_ayuda_Click);
            // 
            // Horario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(741, 446);
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_desactivar);
            this.Controls.Add(this.btn_activar);
            this.Controls.Add(this.dgv_mostrar_horario);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.txt_buscarmod);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.btn_eliminar_horario);
            this.Controls.Add(this.lbl_titulo_mantenimiento_cine);
            this.Controls.Add(this.btn_buscar_horario);
            this.Controls.Add(this.lbl_horainicio);
            this.Controls.Add(this.bttn_actualizar_horario);
            this.Controls.Add(this.lbl_horariofin);
            this.Controls.Add(this.txt_hora_final);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_horario_inicio);
            this.MaximizeBox = false;
            this.Name = "Horario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horario";
            this.Load += new System.EventHandler(this.Horario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostrar_horario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button btn_desactivar;
        private System.Windows.Forms.Button btn_activar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_ayuda;
    }
}