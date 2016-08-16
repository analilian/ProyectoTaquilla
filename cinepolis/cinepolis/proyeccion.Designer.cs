namespace cinepolis
{
    partial class proyeccion
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
            this.txt_buscarmod = new System.Windows.Forms.TextBox();
            this.label_busquedamod = new System.Windows.Forms.Label();
            this.btn_eliminar_proyeccion = new System.Windows.Forms.Button();
            this.btn_buscar_proyeccion = new System.Windows.Forms.Button();
            this.bttn_actualizar_proyeccion = new System.Windows.Forms.Button();
            this.btn_guardar_proyeccion = new System.Windows.Forms.Button();
            this.lbl_proyeccion = new System.Windows.Forms.Label();
            this.txt_nom_proy = new System.Windows.Forms.TextBox();
            this.dgv_proyeccion = new System.Windows.Forms.DataGridView();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.lbl_titulo_mantenimiento_proyeccion = new System.Windows.Forms.Label();
            this.btn_desactivar = new System.Windows.Forms.Button();
            this.btn_activar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proyeccion)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_buscarmod
            // 
            this.txt_buscarmod.Location = new System.Drawing.Point(203, 205);
            this.txt_buscarmod.MaxLength = 100;
            this.txt_buscarmod.Name = "txt_buscarmod";
            this.txt_buscarmod.Size = new System.Drawing.Size(229, 20);
            this.txt_buscarmod.TabIndex = 94;
            // 
            // label_busquedamod
            // 
            this.label_busquedamod.AutoSize = true;
            this.label_busquedamod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_busquedamod.Location = new System.Drawing.Point(105, 204);
            this.label_busquedamod.Name = "label_busquedamod";
            this.label_busquedamod.Size = new System.Drawing.Size(92, 21);
            this.label_busquedamod.TabIndex = 93;
            this.label_busquedamod.Text = "Busqueda:";
            // 
            // btn_eliminar_proyeccion
            // 
            this.btn_eliminar_proyeccion.BackgroundImage = global::cinepolis.Properties.Resources.File_Delete_icon;
            this.btn_eliminar_proyeccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar_proyeccion.Location = new System.Drawing.Point(661, 59);
            this.btn_eliminar_proyeccion.Name = "btn_eliminar_proyeccion";
            this.btn_eliminar_proyeccion.Size = new System.Drawing.Size(65, 65);
            this.btn_eliminar_proyeccion.TabIndex = 90;
            this.toolTip1.SetToolTip(this.btn_eliminar_proyeccion, "Eliminar");
            this.btn_eliminar_proyeccion.UseVisualStyleBackColor = true;
            this.btn_eliminar_proyeccion.Click += new System.EventHandler(this.btn_eliminar_categoria_Click);
            // 
            // btn_buscar_proyeccion
            // 
            this.btn_buscar_proyeccion.BackgroundImage = global::cinepolis.Properties.Resources.Zoom_icon;
            this.btn_buscar_proyeccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_proyeccion.Location = new System.Drawing.Point(469, 60);
            this.btn_buscar_proyeccion.Name = "btn_buscar_proyeccion";
            this.btn_buscar_proyeccion.Size = new System.Drawing.Size(65, 65);
            this.btn_buscar_proyeccion.TabIndex = 92;
            this.toolTip1.SetToolTip(this.btn_buscar_proyeccion, "Buscar");
            this.btn_buscar_proyeccion.UseVisualStyleBackColor = true;
            this.btn_buscar_proyeccion.Click += new System.EventHandler(this.btn_buscar_categoria_Click);
            // 
            // bttn_actualizar_proyeccion
            // 
            this.bttn_actualizar_proyeccion.BackgroundImage = global::cinepolis.Properties.Resources.moddificar;
            this.bttn_actualizar_proyeccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_actualizar_proyeccion.Location = new System.Drawing.Point(533, 59);
            this.bttn_actualizar_proyeccion.Name = "bttn_actualizar_proyeccion";
            this.bttn_actualizar_proyeccion.Size = new System.Drawing.Size(65, 65);
            this.bttn_actualizar_proyeccion.TabIndex = 91;
            this.toolTip1.SetToolTip(this.bttn_actualizar_proyeccion, "Modificar");
            this.bttn_actualizar_proyeccion.UseVisualStyleBackColor = true;
            this.bttn_actualizar_proyeccion.Click += new System.EventHandler(this.bttn_actualizar_categoria_Click);
            // 
            // btn_guardar_proyeccion
            // 
            this.btn_guardar_proyeccion.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardar_proyeccion.BackgroundImage = global::cinepolis.Properties.Resources.Save_icon;
            this.btn_guardar_proyeccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar_proyeccion.Location = new System.Drawing.Point(597, 59);
            this.btn_guardar_proyeccion.Name = "btn_guardar_proyeccion";
            this.btn_guardar_proyeccion.Size = new System.Drawing.Size(65, 65);
            this.btn_guardar_proyeccion.TabIndex = 60;
            this.toolTip1.SetToolTip(this.btn_guardar_proyeccion, "Guardar");
            this.btn_guardar_proyeccion.UseVisualStyleBackColor = false;
            this.btn_guardar_proyeccion.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_proyeccion
            // 
            this.lbl_proyeccion.AutoSize = true;
            this.lbl_proyeccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_proyeccion.Location = new System.Drawing.Point(27, 157);
            this.lbl_proyeccion.Name = "lbl_proyeccion";
            this.lbl_proyeccion.Size = new System.Drawing.Size(99, 21);
            this.lbl_proyeccion.TabIndex = 58;
            this.lbl_proyeccion.Text = "Proyección:";
            // 
            // txt_nom_proy
            // 
            this.txt_nom_proy.Location = new System.Drawing.Point(152, 160);
            this.txt_nom_proy.MaxLength = 20;
            this.txt_nom_proy.Name = "txt_nom_proy";
            this.txt_nom_proy.Size = new System.Drawing.Size(196, 20);
            this.txt_nom_proy.TabIndex = 56;
            // 
            // dgv_proyeccion
            // 
            this.dgv_proyeccion.AllowUserToAddRows = false;
            this.dgv_proyeccion.AllowUserToDeleteRows = false;
            this.dgv_proyeccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_proyeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_proyeccion.Location = new System.Drawing.Point(12, 228);
            this.dgv_proyeccion.Name = "dgv_proyeccion";
            this.dgv_proyeccion.ReadOnly = true;
            this.dgv_proyeccion.Size = new System.Drawing.Size(690, 206);
            this.dgv_proyeccion.TabIndex = 55;
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackgroundImage = global::cinepolis.Properties.Resources.Button_Previous_icon;
            this.btn_regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_regresar.Location = new System.Drawing.Point(12, 7);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(57, 40);
            this.btn_regresar.TabIndex = 58;
            this.toolTip1.SetToolTip(this.btn_regresar, "Regresar");
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // lbl_titulo_mantenimiento_proyeccion
            // 
            this.lbl_titulo_mantenimiento_proyeccion.AutoSize = true;
            this.lbl_titulo_mantenimiento_proyeccion.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_mantenimiento_proyeccion.Location = new System.Drawing.Point(126, 11);
            this.lbl_titulo_mantenimiento_proyeccion.Name = "lbl_titulo_mantenimiento_proyeccion";
            this.lbl_titulo_mantenimiento_proyeccion.Size = new System.Drawing.Size(506, 36);
            this.lbl_titulo_mantenimiento_proyeccion.TabIndex = 57;
            this.lbl_titulo_mantenimiento_proyeccion.Text = "MANTENIMIENTO DE PROYECCIÓN";
            // 
            // btn_desactivar
            // 
            this.btn_desactivar.BackgroundImage = global::cinepolis.Properties.Resources.Button_Close_icon;
            this.btn_desactivar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_desactivar.Location = new System.Drawing.Point(405, 60);
            this.btn_desactivar.Name = "btn_desactivar";
            this.btn_desactivar.Size = new System.Drawing.Size(65, 65);
            this.btn_desactivar.TabIndex = 102;
            this.toolTip1.SetToolTip(this.btn_desactivar, "Desactivar Iconos y Campos");
            this.btn_desactivar.UseVisualStyleBackColor = true;
            this.btn_desactivar.Click += new System.EventHandler(this.btn_desactivar_Click);
            // 
            // btn_activar
            // 
            this.btn_activar.BackgroundImage = global::cinepolis.Properties.Resources.File_New_icon;
            this.btn_activar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_activar.Location = new System.Drawing.Point(342, 60);
            this.btn_activar.Name = "btn_activar";
            this.btn_activar.Size = new System.Drawing.Size(65, 65);
            this.btn_activar.TabIndex = 101;
            this.toolTip1.SetToolTip(this.btn_activar, "Activar Iconos y Campos");
            this.btn_activar.UseVisualStyleBackColor = true;
            this.btn_activar.Click += new System.EventHandler(this.btn_activar_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::cinepolis.Properties.Resources.Button_Refresh_icon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(279, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 65);
            this.button1.TabIndex = 103;
            this.toolTip1.SetToolTip(this.button1, "Actualizar");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // proyeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(730, 446);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_desactivar);
            this.Controls.Add(this.btn_activar);
            this.Controls.Add(this.dgv_proyeccion);
            this.Controls.Add(this.txt_buscarmod);
            this.Controls.Add(this.label_busquedamod);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.btn_eliminar_proyeccion);
            this.Controls.Add(this.lbl_titulo_mantenimiento_proyeccion);
            this.Controls.Add(this.btn_buscar_proyeccion);
            this.Controls.Add(this.lbl_proyeccion);
            this.Controls.Add(this.bttn_actualizar_proyeccion);
            this.Controls.Add(this.txt_nom_proy);
            this.Controls.Add(this.btn_guardar_proyeccion);
            this.MaximizeBox = false;
            this.Name = "proyeccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "proyeccion";
            this.Load += new System.EventHandler(this.proyeccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proyeccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_buscarmod;
        private System.Windows.Forms.Label label_busquedamod;
        private System.Windows.Forms.Button btn_eliminar_proyeccion;
        private System.Windows.Forms.Button btn_buscar_proyeccion;
        private System.Windows.Forms.Button bttn_actualizar_proyeccion;
        private System.Windows.Forms.Button btn_guardar_proyeccion;
        private System.Windows.Forms.Label lbl_proyeccion;
        private System.Windows.Forms.TextBox txt_nom_proy;
        private System.Windows.Forms.DataGridView dgv_proyeccion;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Label lbl_titulo_mantenimiento_proyeccion;
        private System.Windows.Forms.Button btn_desactivar;
        private System.Windows.Forms.Button btn_activar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
    }
}