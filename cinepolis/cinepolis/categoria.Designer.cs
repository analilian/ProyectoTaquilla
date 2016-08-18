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
            this.txt_buscarmod = new System.Windows.Forms.TextBox();
            this.label_busquedamod = new System.Windows.Forms.Label();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.txt_nom_categ = new System.Windows.Forms.TextBox();
            this.dgv_categoria = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_activar = new System.Windows.Forms.Button();
            this.btn_desactivar = new System.Windows.Forms.Button();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.btn_eliminar_categoria = new System.Windows.Forms.Button();
            this.btn_buscar_categoria = new System.Windows.Forms.Button();
            this.bttn_actualizar_categoria = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_ayuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categoria)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo_mantenimiento_cine
            // 
            this.lbl_titulo_mantenimiento_cine.AutoSize = true;
            this.lbl_titulo_mantenimiento_cine.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_mantenimiento_cine.Location = new System.Drawing.Point(136, 16);
            this.lbl_titulo_mantenimiento_cine.Name = "lbl_titulo_mantenimiento_cine";
            this.lbl_titulo_mantenimiento_cine.Size = new System.Drawing.Size(481, 36);
            this.lbl_titulo_mantenimiento_cine.TabIndex = 14;
            this.lbl_titulo_mantenimiento_cine.Text = "MANTENIMIENTO DE CATEGORIA";
            this.lbl_titulo_mantenimiento_cine.Click += new System.EventHandler(this.lbl_titulo_mantenimiento_cine_Click);
            // 
            // txt_buscarmod
            // 
            this.txt_buscarmod.Location = new System.Drawing.Point(199, 195);
            this.txt_buscarmod.MaxLength = 100;
            this.txt_buscarmod.Name = "txt_buscarmod";
            this.txt_buscarmod.Size = new System.Drawing.Size(229, 20);
            this.txt_buscarmod.TabIndex = 94;
            // 
            // label_busquedamod
            // 
            this.label_busquedamod.AutoSize = true;
            this.label_busquedamod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_busquedamod.Location = new System.Drawing.Point(101, 194);
            this.label_busquedamod.Name = "label_busquedamod";
            this.label_busquedamod.Size = new System.Drawing.Size(92, 21);
            this.label_busquedamod.TabIndex = 93;
            this.label_busquedamod.Text = "Busqueda:";
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoria.Location = new System.Drawing.Point(17, 132);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(95, 21);
            this.lbl_categoria.TabIndex = 58;
            this.lbl_categoria.Text = "Categoria:";
            // 
            // txt_nom_categ
            // 
            this.txt_nom_categ.Location = new System.Drawing.Point(142, 135);
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
            this.dgv_categoria.Location = new System.Drawing.Point(21, 228);
            this.dgv_categoria.Name = "dgv_categoria";
            this.dgv_categoria.ReadOnly = true;
            this.dgv_categoria.Size = new System.Drawing.Size(690, 206);
            this.dgv_categoria.TabIndex = 55;
            // 
            // btn_activar
            // 
            this.btn_activar.BackgroundImage = global::cinepolis.Properties.Resources.File_New_icon;
            this.btn_activar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_activar.FlatAppearance.BorderSize = 0;
            this.btn_activar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_activar.Location = new System.Drawing.Point(344, 65);
            this.btn_activar.Name = "btn_activar";
            this.btn_activar.Size = new System.Drawing.Size(65, 65);
            this.btn_activar.TabIndex = 99;
            this.toolTip1.SetToolTip(this.btn_activar, "Activar Iconos y Celdas");
            this.btn_activar.UseVisualStyleBackColor = true;
            this.btn_activar.Click += new System.EventHandler(this.btn_activar_Click);
            // 
            // btn_desactivar
            // 
            this.btn_desactivar.BackgroundImage = global::cinepolis.Properties.Resources.Button_Close_icon;
            this.btn_desactivar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_desactivar.FlatAppearance.BorderSize = 0;
            this.btn_desactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_desactivar.Location = new System.Drawing.Point(409, 65);
            this.btn_desactivar.Name = "btn_desactivar";
            this.btn_desactivar.Size = new System.Drawing.Size(65, 65);
            this.btn_desactivar.TabIndex = 100;
            this.toolTip1.SetToolTip(this.btn_desactivar, "Desactivar Iconos y Celdas");
            this.btn_desactivar.UseVisualStyleBackColor = true;
            this.btn_desactivar.Click += new System.EventHandler(this.btn_desactivar_Click);
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackgroundImage = global::cinepolis.Properties.Resources.Button_Previous_icon;
            this.btn_regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_regresar.FlatAppearance.BorderSize = 0;
            this.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regresar.Location = new System.Drawing.Point(12, 12);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(57, 48);
            this.btn_regresar.TabIndex = 55;
            this.toolTip1.SetToolTip(this.btn_regresar, "Regresar");
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // btn_eliminar_categoria
            // 
            this.btn_eliminar_categoria.BackgroundImage = global::cinepolis.Properties.Resources.File_Delete_icon;
            this.btn_eliminar_categoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar_categoria.FlatAppearance.BorderSize = 0;
            this.btn_eliminar_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar_categoria.Location = new System.Drawing.Point(666, 65);
            this.btn_eliminar_categoria.Name = "btn_eliminar_categoria";
            this.btn_eliminar_categoria.Size = new System.Drawing.Size(65, 65);
            this.btn_eliminar_categoria.TabIndex = 90;
            this.toolTip1.SetToolTip(this.btn_eliminar_categoria, "Eliminar");
            this.btn_eliminar_categoria.UseVisualStyleBackColor = true;
            this.btn_eliminar_categoria.Click += new System.EventHandler(this.btn_eliminar_pelicula_Click);
            // 
            // btn_buscar_categoria
            // 
            this.btn_buscar_categoria.BackgroundImage = global::cinepolis.Properties.Resources.Zoom_icon;
            this.btn_buscar_categoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_categoria.FlatAppearance.BorderSize = 0;
            this.btn_buscar_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar_categoria.Location = new System.Drawing.Point(474, 66);
            this.btn_buscar_categoria.Name = "btn_buscar_categoria";
            this.btn_buscar_categoria.Size = new System.Drawing.Size(65, 65);
            this.btn_buscar_categoria.TabIndex = 92;
            this.toolTip1.SetToolTip(this.btn_buscar_categoria, "Buscar");
            this.btn_buscar_categoria.UseVisualStyleBackColor = true;
            this.btn_buscar_categoria.Click += new System.EventHandler(this.btn_buscar_pelicula_Click);
            // 
            // bttn_actualizar_categoria
            // 
            this.bttn_actualizar_categoria.BackgroundImage = global::cinepolis.Properties.Resources.Edit_Document_icon;
            this.bttn_actualizar_categoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_actualizar_categoria.FlatAppearance.BorderSize = 0;
            this.bttn_actualizar_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_actualizar_categoria.Location = new System.Drawing.Point(538, 65);
            this.bttn_actualizar_categoria.Name = "bttn_actualizar_categoria";
            this.bttn_actualizar_categoria.Size = new System.Drawing.Size(65, 65);
            this.bttn_actualizar_categoria.TabIndex = 91;
            this.toolTip1.SetToolTip(this.bttn_actualizar_categoria, "Modificar");
            this.bttn_actualizar_categoria.UseVisualStyleBackColor = true;
            this.bttn_actualizar_categoria.Click += new System.EventHandler(this.bttn_actualizar_pelicula_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardar.BackgroundImage = global::cinepolis.Properties.Resources.Save_icon;
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Location = new System.Drawing.Point(602, 65);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(65, 65);
            this.btn_guardar.TabIndex = 60;
            this.toolTip1.SetToolTip(this.btn_guardar, "Guardar");
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::cinepolis.Properties.Resources.Button_Refresh_icon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(280, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 65);
            this.button1.TabIndex = 101;
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
            this.btn_ayuda.Location = new System.Drawing.Point(688, 3);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(30, 30);
            this.btn_ayuda.TabIndex = 102;
            this.toolTip1.SetToolTip(this.btn_ayuda, "Menu de Ayuda");
            this.btn_ayuda.UseVisualStyleBackColor = false;
            this.btn_ayuda.Click += new System.EventHandler(this.btn_ayuda_Click);
            // 
            // categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(730, 446);
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_desactivar);
            this.Controls.Add(this.btn_activar);
            this.Controls.Add(this.dgv_categoria);
            this.Controls.Add(this.txt_buscarmod);
            this.Controls.Add(this.label_busquedamod);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.btn_eliminar_categoria);
            this.Controls.Add(this.btn_buscar_categoria);
            this.Controls.Add(this.lbl_titulo_mantenimiento_cine);
            this.Controls.Add(this.bttn_actualizar_categoria);
            this.Controls.Add(this.txt_nom_categ);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.lbl_categoria);
            this.MaximizeBox = false;
            this.Name = "categoria";
            this.Load += new System.EventHandler(this.categoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo_mantenimiento_cine;
        private System.Windows.Forms.Button btn_regresar;
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
        private System.Windows.Forms.Button btn_desactivar;
        private System.Windows.Forms.Button btn_activar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_ayuda;
    }
}