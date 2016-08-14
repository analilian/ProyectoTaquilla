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
            this.tbc_categoria = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.tbc_categoria.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proyeccion)).BeginInit();
            this.SuspendLayout();
            // 
            // tbc_categoria
            // 
            this.tbc_categoria.Controls.Add(this.tabPage1);
            this.tbc_categoria.Location = new System.Drawing.Point(5, 65);
            this.tbc_categoria.Name = "tbc_categoria";
            this.tbc_categoria.SelectedIndex = 0;
            this.tbc_categoria.Size = new System.Drawing.Size(721, 375);
            this.tbc_categoria.TabIndex = 59;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.txt_buscarmod);
            this.tabPage1.Controls.Add(this.label_busquedamod);
            this.tabPage1.Controls.Add(this.btn_eliminar_proyeccion);
            this.tabPage1.Controls.Add(this.btn_buscar_proyeccion);
            this.tabPage1.Controls.Add(this.bttn_actualizar_proyeccion);
            this.tabPage1.Controls.Add(this.btn_guardar_proyeccion);
            this.tabPage1.Controls.Add(this.lbl_proyeccion);
            this.tabPage1.Controls.Add(this.txt_nom_proy);
            this.tabPage1.Controls.Add(this.dgv_proyeccion);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(713, 349);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mantenimiento de Proyección";
            // 
            // txt_buscarmod
            // 
            this.txt_buscarmod.Location = new System.Drawing.Point(190, 91);
            this.txt_buscarmod.MaxLength = 100;
            this.txt_buscarmod.Name = "txt_buscarmod";
            this.txt_buscarmod.Size = new System.Drawing.Size(229, 20);
            this.txt_buscarmod.TabIndex = 94;
            // 
            // label_busquedamod
            // 
            this.label_busquedamod.AutoSize = true;
            this.label_busquedamod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_busquedamod.Location = new System.Drawing.Point(92, 90);
            this.label_busquedamod.Name = "label_busquedamod";
            this.label_busquedamod.Size = new System.Drawing.Size(92, 21);
            this.label_busquedamod.TabIndex = 93;
            this.label_busquedamod.Text = "Busqueda:";
            // 
            // btn_eliminar_proyeccion
            // 
            this.btn_eliminar_proyeccion.BackgroundImage = global::cinepolis.Properties.Resources.File_Delete_icon;
            this.btn_eliminar_proyeccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar_proyeccion.Location = new System.Drawing.Point(638, 74);
            this.btn_eliminar_proyeccion.Name = "btn_eliminar_proyeccion";
            this.btn_eliminar_proyeccion.Size = new System.Drawing.Size(61, 55);
            this.btn_eliminar_proyeccion.TabIndex = 90;
            this.btn_eliminar_proyeccion.UseVisualStyleBackColor = true;
            this.btn_eliminar_proyeccion.Click += new System.EventHandler(this.btn_eliminar_categoria_Click);
            // 
            // btn_buscar_proyeccion
            // 
            this.btn_buscar_proyeccion.BackgroundImage = global::cinepolis.Properties.Resources.Zoom_icon;
            this.btn_buscar_proyeccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_proyeccion.Location = new System.Drawing.Point(446, 75);
            this.btn_buscar_proyeccion.Name = "btn_buscar_proyeccion";
            this.btn_buscar_proyeccion.Size = new System.Drawing.Size(61, 55);
            this.btn_buscar_proyeccion.TabIndex = 92;
            this.btn_buscar_proyeccion.UseVisualStyleBackColor = true;
            this.btn_buscar_proyeccion.Click += new System.EventHandler(this.btn_buscar_categoria_Click);
            // 
            // bttn_actualizar_proyeccion
            // 
            this.bttn_actualizar_proyeccion.BackgroundImage = global::cinepolis.Properties.Resources.Button_Refresh_icon;
            this.bttn_actualizar_proyeccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_actualizar_proyeccion.Location = new System.Drawing.Point(510, 74);
            this.bttn_actualizar_proyeccion.Name = "bttn_actualizar_proyeccion";
            this.bttn_actualizar_proyeccion.Size = new System.Drawing.Size(61, 56);
            this.bttn_actualizar_proyeccion.TabIndex = 91;
            this.bttn_actualizar_proyeccion.UseVisualStyleBackColor = true;
            this.bttn_actualizar_proyeccion.Click += new System.EventHandler(this.bttn_actualizar_categoria_Click);
            // 
            // btn_guardar_proyeccion
            // 
            this.btn_guardar_proyeccion.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardar_proyeccion.BackgroundImage = global::cinepolis.Properties.Resources.Save_icon;
            this.btn_guardar_proyeccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar_proyeccion.Location = new System.Drawing.Point(574, 74);
            this.btn_guardar_proyeccion.Name = "btn_guardar_proyeccion";
            this.btn_guardar_proyeccion.Size = new System.Drawing.Size(61, 55);
            this.btn_guardar_proyeccion.TabIndex = 60;
            this.btn_guardar_proyeccion.UseVisualStyleBackColor = false;
            this.btn_guardar_proyeccion.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_proyeccion
            // 
            this.lbl_proyeccion.AutoSize = true;
            this.lbl_proyeccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_proyeccion.Location = new System.Drawing.Point(8, 28);
            this.lbl_proyeccion.Name = "lbl_proyeccion";
            this.lbl_proyeccion.Size = new System.Drawing.Size(99, 21);
            this.lbl_proyeccion.TabIndex = 58;
            this.lbl_proyeccion.Text = "Proyección:";
            // 
            // txt_nom_proy
            // 
            this.txt_nom_proy.Location = new System.Drawing.Point(133, 31);
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
            this.dgv_proyeccion.Location = new System.Drawing.Point(12, 136);
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
            // proyeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(730, 446);
            this.Controls.Add(this.tbc_categoria);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.lbl_titulo_mantenimiento_proyeccion);
            this.Name = "proyeccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "proyeccion";
            this.Load += new System.EventHandler(this.proyeccion_Load);
            this.tbc_categoria.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proyeccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_categoria;
        private System.Windows.Forms.TabPage tabPage1;
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
    }
}