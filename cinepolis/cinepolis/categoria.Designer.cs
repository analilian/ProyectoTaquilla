namespace cinepolis
{
    partial class categoria
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
            this.lbl_titulo_mantenimiento_cine = new System.Windows.Forms.Label();
            this.tbc_categoria = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.txt_nom_categ = new System.Windows.Forms.TextBox();
            this.dgv_categoria = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_regresar = new System.Windows.Forms.Button();
            this.btn_eliminar_categoria = new System.Windows.Forms.Button();
            this.btn_buscar_categoria = new System.Windows.Forms.Button();
            this.bttn_actualizar_categoria = new System.Windows.Forms.Button();
            this.txt_buscarmod = new System.Windows.Forms.TextBox();
            this.label_busquedamod = new System.Windows.Forms.Label();
            this.tbc_categoria.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categoria)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo_mantenimiento_cine
            // 
            this.lbl_titulo_mantenimiento_cine.AutoSize = true;
            this.lbl_titulo_mantenimiento_cine.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_mantenimiento_cine.Location = new System.Drawing.Point(106, 31);
            this.lbl_titulo_mantenimiento_cine.Name = "lbl_titulo_mantenimiento_cine";
            this.lbl_titulo_mantenimiento_cine.Size = new System.Drawing.Size(481, 36);
            this.lbl_titulo_mantenimiento_cine.TabIndex = 14;
            this.lbl_titulo_mantenimiento_cine.Text = "MANTENIMIENTO DE CATEGORIA";
            // 
            // tbc_categoria
            // 
            this.tbc_categoria.Controls.Add(this.tabPage1);
            this.tbc_categoria.Location = new System.Drawing.Point(5, 70);
            this.tbc_categoria.Name = "tbc_categoria";
            this.tbc_categoria.SelectedIndex = 0;
            this.tbc_categoria.Size = new System.Drawing.Size(721, 375);
            this.tbc_categoria.TabIndex = 56;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.txt_buscarmod);
            this.tabPage1.Controls.Add(this.label_busquedamod);
            this.tabPage1.Controls.Add(this.btn_eliminar_categoria);
            this.tabPage1.Controls.Add(this.btn_buscar_categoria);
            this.tabPage1.Controls.Add(this.bttn_actualizar_categoria);
            this.tabPage1.Controls.Add(this.btn_guardar);
            this.tabPage1.Controls.Add(this.lbl_categoria);
            this.tabPage1.Controls.Add(this.txt_nom_categ);
            this.tabPage1.Controls.Add(this.dgv_categoria);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(713, 349);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mantenimiento de Categoria";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardar.BackgroundImage = global::cinepolis.Properties.Resources.Save_icon;
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.Location = new System.Drawing.Point(574, 74);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(61, 55);
            this.btn_guardar.TabIndex = 60;
            this.toolTip1.SetToolTip(this.btn_guardar, "Guardar");
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoria.Location = new System.Drawing.Point(8, 28);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(95, 21);
            this.lbl_categoria.TabIndex = 58;
            this.lbl_categoria.Text = "Categoria:";
            // 
            // txt_nom_categ
            // 
            this.txt_nom_categ.Location = new System.Drawing.Point(133, 31);
            this.txt_nom_categ.MaxLength = 20;
            this.txt_nom_categ.Name = "txt_nom_categ";
            this.txt_nom_categ.Size = new System.Drawing.Size(196, 20);
            this.txt_nom_categ.TabIndex = 56;
            // 
            // dgv_categoria
            // 
            this.dgv_categoria.AllowUserToAddRows = false;
            this.dgv_categoria.AllowUserToDeleteRows = false;
            this.dgv_categoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_categoria.Location = new System.Drawing.Point(12, 136);
            this.dgv_categoria.Name = "dgv_categoria";
            this.dgv_categoria.ReadOnly = true;
            this.dgv_categoria.Size = new System.Drawing.Size(690, 206);
            this.dgv_categoria.TabIndex = 55;
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackgroundImage = global::cinepolis.Properties.Resources.Button_Previous_icon;
            this.btn_regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_regresar.Location = new System.Drawing.Point(12, 12);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(57, 40);
            this.btn_regresar.TabIndex = 55;
            this.toolTip1.SetToolTip(this.btn_regresar, "Regresar");
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // btn_eliminar_categoria
            // 
            this.btn_eliminar_categoria.BackgroundImage = global::cinepolis.Properties.Resources.File_Delete_icon;
            this.btn_eliminar_categoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar_categoria.Location = new System.Drawing.Point(638, 74);
            this.btn_eliminar_categoria.Name = "btn_eliminar_categoria";
            this.btn_eliminar_categoria.Size = new System.Drawing.Size(61, 55);
            this.btn_eliminar_categoria.TabIndex = 90;
            this.toolTip1.SetToolTip(this.btn_eliminar_categoria, "Eliminar");
            this.btn_eliminar_categoria.UseVisualStyleBackColor = true;
            this.btn_eliminar_categoria.Click += new System.EventHandler(this.btn_eliminar_pelicula_Click);
            // 
            // btn_buscar_categoria
            // 
            this.btn_buscar_categoria.BackgroundImage = global::cinepolis.Properties.Resources.Zoom_icon;
            this.btn_buscar_categoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_categoria.Location = new System.Drawing.Point(446, 75);
            this.btn_buscar_categoria.Name = "btn_buscar_categoria";
            this.btn_buscar_categoria.Size = new System.Drawing.Size(61, 55);
            this.btn_buscar_categoria.TabIndex = 92;
            this.toolTip1.SetToolTip(this.btn_buscar_categoria, "Buscar");
            this.btn_buscar_categoria.UseVisualStyleBackColor = true;
            this.btn_buscar_categoria.Click += new System.EventHandler(this.btn_buscar_pelicula_Click);
            // 
            // bttn_actualizar_categoria
            // 
            this.bttn_actualizar_categoria.BackgroundImage = global::cinepolis.Properties.Resources.Button_Refresh_icon;
            this.bttn_actualizar_categoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_actualizar_categoria.Location = new System.Drawing.Point(510, 74);
            this.bttn_actualizar_categoria.Name = "bttn_actualizar_categoria";
            this.bttn_actualizar_categoria.Size = new System.Drawing.Size(61, 56);
            this.bttn_actualizar_categoria.TabIndex = 91;
            this.toolTip1.SetToolTip(this.bttn_actualizar_categoria, "Actualizar");
            this.bttn_actualizar_categoria.UseVisualStyleBackColor = true;
            this.bttn_actualizar_categoria.Click += new System.EventHandler(this.bttn_actualizar_pelicula_Click);
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
            // categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(730, 446);
            this.Controls.Add(this.tbc_categoria);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.lbl_titulo_mantenimiento_cine);
            this.Name = "categoria";
            this.Load += new System.EventHandler(this.categoria_Load);
            this.tbc_categoria.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo_mantenimiento_cine;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.TabControl tbc_categoria;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.TextBox txt_nom_categ;
        private System.Windows.Forms.DataGridView dgv_categoria;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_eliminar_categoria;
        private System.Windows.Forms.Button btn_buscar_categoria;
        private System.Windows.Forms.Button bttn_actualizar_categoria;
        private System.Windows.Forms.TextBox txt_buscarmod;
        private System.Windows.Forms.Label label_busquedamod;
    }
}