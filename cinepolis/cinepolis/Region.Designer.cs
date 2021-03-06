﻿namespace cinepolis
{
    partial class Region
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_desactivar = new System.Windows.Forms.Button();
            this.btn_activar = new System.Windows.Forms.Button();
            this.dgv_categoria = new System.Windows.Forms.DataGridView();
            this.txt_buscarmod = new System.Windows.Forms.TextBox();
            this.label_busquedamod = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.btn_eliminar_categoria = new System.Windows.Forms.Button();
            this.btn_buscar_categoria = new System.Windows.Forms.Button();
            this.lbl_titulo_mantenimiento_cine = new System.Windows.Forms.Label();
            this.bttn_actualizar_categoria = new System.Windows.Forms.Button();
            this.txt_nom_categ = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_categoria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categoria)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::cinepolis.Properties.Resources.Button_Refresh_icon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(308, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 65);
            this.button1.TabIndex = 115;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_desactivar
            // 
            this.btn_desactivar.BackgroundImage = global::cinepolis.Properties.Resources.Button_Close_icon;
            this.btn_desactivar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_desactivar.FlatAppearance.BorderSize = 0;
            this.btn_desactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_desactivar.Location = new System.Drawing.Point(437, 61);
            this.btn_desactivar.Name = "btn_desactivar";
            this.btn_desactivar.Size = new System.Drawing.Size(65, 65);
            this.btn_desactivar.TabIndex = 114;
            this.btn_desactivar.UseVisualStyleBackColor = true;
            this.btn_desactivar.Click += new System.EventHandler(this.btn_desactivar_Click);
            // 
            // btn_activar
            // 
            this.btn_activar.BackgroundImage = global::cinepolis.Properties.Resources.File_New_icon;
            this.btn_activar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_activar.FlatAppearance.BorderSize = 0;
            this.btn_activar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_activar.Location = new System.Drawing.Point(372, 61);
            this.btn_activar.Name = "btn_activar";
            this.btn_activar.Size = new System.Drawing.Size(65, 65);
            this.btn_activar.TabIndex = 113;
            this.btn_activar.UseVisualStyleBackColor = true;
            this.btn_activar.Click += new System.EventHandler(this.btn_activar_Click);
            // 
            // dgv_categoria
            // 
            this.dgv_categoria.AllowUserToAddRows = false;
            this.dgv_categoria.AllowUserToDeleteRows = false;
            this.dgv_categoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_categoria.Location = new System.Drawing.Point(49, 224);
            this.dgv_categoria.Name = "dgv_categoria";
            this.dgv_categoria.ReadOnly = true;
            this.dgv_categoria.Size = new System.Drawing.Size(690, 206);
            this.dgv_categoria.TabIndex = 103;
            // 
            // txt_buscarmod
            // 
            this.txt_buscarmod.Location = new System.Drawing.Point(227, 191);
            this.txt_buscarmod.MaxLength = 100;
            this.txt_buscarmod.Name = "txt_buscarmod";
            this.txt_buscarmod.Size = new System.Drawing.Size(229, 20);
            this.txt_buscarmod.TabIndex = 112;
            // 
            // label_busquedamod
            // 
            this.label_busquedamod.AutoSize = true;
            this.label_busquedamod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_busquedamod.Location = new System.Drawing.Point(129, 190);
            this.label_busquedamod.Name = "label_busquedamod";
            this.label_busquedamod.Size = new System.Drawing.Size(92, 21);
            this.label_busquedamod.TabIndex = 111;
            this.label_busquedamod.Text = "Busqueda:";
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackgroundImage = global::cinepolis.Properties.Resources.Button_Previous_icon;
            this.btn_regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_regresar.FlatAppearance.BorderSize = 0;
            this.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regresar.Location = new System.Drawing.Point(22, 13);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(57, 48);
            this.btn_regresar.TabIndex = 104;
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // btn_eliminar_categoria
            // 
            this.btn_eliminar_categoria.BackgroundImage = global::cinepolis.Properties.Resources.File_Delete_icon;
            this.btn_eliminar_categoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar_categoria.FlatAppearance.BorderSize = 0;
            this.btn_eliminar_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar_categoria.Location = new System.Drawing.Point(694, 61);
            this.btn_eliminar_categoria.Name = "btn_eliminar_categoria";
            this.btn_eliminar_categoria.Size = new System.Drawing.Size(65, 65);
            this.btn_eliminar_categoria.TabIndex = 108;
            this.btn_eliminar_categoria.UseVisualStyleBackColor = true;
            this.btn_eliminar_categoria.Click += new System.EventHandler(this.btn_eliminar_categoria_Click);
            // 
            // btn_buscar_categoria
            // 
            this.btn_buscar_categoria.BackgroundImage = global::cinepolis.Properties.Resources.Zoom_icon;
            this.btn_buscar_categoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_categoria.FlatAppearance.BorderSize = 0;
            this.btn_buscar_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar_categoria.Location = new System.Drawing.Point(502, 62);
            this.btn_buscar_categoria.Name = "btn_buscar_categoria";
            this.btn_buscar_categoria.Size = new System.Drawing.Size(65, 65);
            this.btn_buscar_categoria.TabIndex = 110;
            this.btn_buscar_categoria.UseVisualStyleBackColor = true;
            this.btn_buscar_categoria.Click += new System.EventHandler(this.btn_buscar_categoria_Click);
            // 
            // lbl_titulo_mantenimiento_cine
            // 
            this.lbl_titulo_mantenimiento_cine.AutoSize = true;
            this.lbl_titulo_mantenimiento_cine.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_mantenimiento_cine.Location = new System.Drawing.Point(164, 12);
            this.lbl_titulo_mantenimiento_cine.Name = "lbl_titulo_mantenimiento_cine";
            this.lbl_titulo_mantenimiento_cine.Size = new System.Drawing.Size(431, 36);
            this.lbl_titulo_mantenimiento_cine.TabIndex = 102;
            this.lbl_titulo_mantenimiento_cine.Text = "MANTENIMIENTO DE  REGION\r\n";
            this.lbl_titulo_mantenimiento_cine.Click += new System.EventHandler(this.lbl_titulo_mantenimiento_cine_Click);
            // 
            // bttn_actualizar_categoria
            // 
            this.bttn_actualizar_categoria.BackgroundImage = global::cinepolis.Properties.Resources.Edit_Document_icon;
            this.bttn_actualizar_categoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_actualizar_categoria.FlatAppearance.BorderSize = 0;
            this.bttn_actualizar_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_actualizar_categoria.Location = new System.Drawing.Point(566, 61);
            this.bttn_actualizar_categoria.Name = "bttn_actualizar_categoria";
            this.bttn_actualizar_categoria.Size = new System.Drawing.Size(65, 65);
            this.bttn_actualizar_categoria.TabIndex = 109;
            this.bttn_actualizar_categoria.UseVisualStyleBackColor = true;
            this.bttn_actualizar_categoria.Click += new System.EventHandler(this.bttn_actualizar_categoria_Click);
            // 
            // txt_nom_categ
            // 
            this.txt_nom_categ.Location = new System.Drawing.Point(170, 131);
            this.txt_nom_categ.MaxLength = 20;
            this.txt_nom_categ.Name = "txt_nom_categ";
            this.txt_nom_categ.Size = new System.Drawing.Size(196, 20);
            this.txt_nom_categ.TabIndex = 105;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardar.BackgroundImage = global::cinepolis.Properties.Resources.Save_icon;
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Location = new System.Drawing.Point(630, 61);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(65, 65);
            this.btn_guardar.TabIndex = 107;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoria.Location = new System.Drawing.Point(86, 128);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(78, 21);
            this.lbl_categoria.TabIndex = 106;
            this.lbl_categoria.Text = "REGION:";
            // 
            // Region
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(799, 438);
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
            this.Name = "Region";
            this.Text = "Region";
            this.Load += new System.EventHandler(this.Region_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_desactivar;
        private System.Windows.Forms.Button btn_activar;
        private System.Windows.Forms.DataGridView dgv_categoria;
        private System.Windows.Forms.TextBox txt_buscarmod;
        private System.Windows.Forms.Label label_busquedamod;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Button btn_eliminar_categoria;
        private System.Windows.Forms.Button btn_buscar_categoria;
        private System.Windows.Forms.Label lbl_titulo_mantenimiento_cine;
        private System.Windows.Forms.Button bttn_actualizar_categoria;
        private System.Windows.Forms.TextBox txt_nom_categ;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label lbl_categoria;
    }
}