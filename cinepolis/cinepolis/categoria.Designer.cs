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
            this.lbl_titulo_mantenimiento_cine = new System.Windows.Forms.Label();
            this.tbc_categoria = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.txt_categoria = new System.Windows.Forms.TextBox();
            this.dgv_categoria = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_mod_guardar = new System.Windows.Forms.Button();
            this.txt_mod_categoria = new System.Windows.Forms.Label();
            this.txt_mod_categoriaa = new System.Windows.Forms.TextBox();
            this.dgv_mod_categoria = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.lbl_codigo_buscar = new System.Windows.Forms.Label();
            this.dgv_borrar_categoria = new System.Windows.Forms.DataGridView();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.tbc_categoria.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categoria)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mod_categoria)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_borrar_categoria)).BeginInit();
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
            this.tbc_categoria.Controls.Add(this.tabPage2);
            this.tbc_categoria.Controls.Add(this.tabPage3);
            this.tbc_categoria.Location = new System.Drawing.Point(12, 97);
            this.tbc_categoria.Name = "tbc_categoria";
            this.tbc_categoria.SelectedIndex = 0;
            this.tbc_categoria.Size = new System.Drawing.Size(721, 348);
            this.tbc_categoria.TabIndex = 56;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.btn_guardar);
            this.tabPage1.Controls.Add(this.lbl_categoria);
            this.tabPage1.Controls.Add(this.txt_categoria);
            this.tabPage1.Controls.Add(this.dgv_categoria);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(713, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar Categoria";
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImage = global::cinepolis.Properties.Resources.guardar;
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.Location = new System.Drawing.Point(513, 23);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(90, 73);
            this.btn_guardar.TabIndex = 60;
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoria.Location = new System.Drawing.Point(64, 62);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(95, 21);
            this.lbl_categoria.TabIndex = 58;
            this.lbl_categoria.Text = "Categoria:";
            // 
            // txt_categoria
            // 
            this.txt_categoria.Location = new System.Drawing.Point(189, 65);
            this.txt_categoria.MaxLength = 20;
            this.txt_categoria.Name = "txt_categoria";
            this.txt_categoria.Size = new System.Drawing.Size(151, 20);
            this.txt_categoria.TabIndex = 56;
            // 
            // dgv_categoria
            // 
            this.dgv_categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_categoria.Location = new System.Drawing.Point(12, 136);
            this.dgv_categoria.Name = "dgv_categoria";
            this.dgv_categoria.Size = new System.Drawing.Size(690, 180);
            this.dgv_categoria.TabIndex = 55;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.btn_actualizar);
            this.tabPage2.Controls.Add(this.btn_mod_guardar);
            this.tabPage2.Controls.Add(this.txt_mod_categoria);
            this.tabPage2.Controls.Add(this.txt_mod_categoriaa);
            this.tabPage2.Controls.Add(this.dgv_mod_categoria);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(713, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar Categoria";
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackgroundImage = global::cinepolis.Properties.Resources.actualizarr;
            this.btn_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_actualizar.Location = new System.Drawing.Point(451, 21);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(84, 73);
            this.btn_actualizar.TabIndex = 85;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            // 
            // btn_mod_guardar
            // 
            this.btn_mod_guardar.BackgroundImage = global::cinepolis.Properties.Resources.guardar;
            this.btn_mod_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_mod_guardar.Location = new System.Drawing.Point(592, 21);
            this.btn_mod_guardar.Name = "btn_mod_guardar";
            this.btn_mod_guardar.Size = new System.Drawing.Size(90, 73);
            this.btn_mod_guardar.TabIndex = 66;
            this.btn_mod_guardar.UseVisualStyleBackColor = true;
            // 
            // txt_mod_categoria
            // 
            this.txt_mod_categoria.AutoSize = true;
            this.txt_mod_categoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mod_categoria.Location = new System.Drawing.Point(40, 45);
            this.txt_mod_categoria.Name = "txt_mod_categoria";
            this.txt_mod_categoria.Size = new System.Drawing.Size(95, 21);
            this.txt_mod_categoria.TabIndex = 64;
            this.txt_mod_categoria.Text = "Categoria:";
            // 
            // txt_mod_categoriaa
            // 
            this.txt_mod_categoriaa.Location = new System.Drawing.Point(165, 48);
            this.txt_mod_categoriaa.MaxLength = 20;
            this.txt_mod_categoriaa.Name = "txt_mod_categoriaa";
            this.txt_mod_categoriaa.Size = new System.Drawing.Size(151, 20);
            this.txt_mod_categoriaa.TabIndex = 62;
            // 
            // dgv_mod_categoria
            // 
            this.dgv_mod_categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mod_categoria.Location = new System.Drawing.Point(24, 136);
            this.dgv_mod_categoria.Name = "dgv_mod_categoria";
            this.dgv_mod_categoria.Size = new System.Drawing.Size(635, 180);
            this.dgv_mod_categoria.TabIndex = 61;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage3.Controls.Add(this.btn_borrar);
            this.tabPage3.Controls.Add(this.btn_buscar);
            this.tabPage3.Controls.Add(this.txt_buscar);
            this.tabPage3.Controls.Add(this.lbl_codigo_buscar);
            this.tabPage3.Controls.Add(this.dgv_borrar_categoria);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(713, 322);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Borrar Categoria";
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
            // dgv_borrar_categoria
            // 
            this.dgv_borrar_categoria.AllowUserToAddRows = false;
            this.dgv_borrar_categoria.AllowUserToDeleteRows = false;
            this.dgv_borrar_categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_borrar_categoria.Location = new System.Drawing.Point(6, 77);
            this.dgv_borrar_categoria.Name = "dgv_borrar_categoria";
            this.dgv_borrar_categoria.ReadOnly = true;
            this.dgv_borrar_categoria.Size = new System.Drawing.Size(696, 238);
            this.dgv_borrar_categoria.TabIndex = 56;
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackgroundImage = global::cinepolis.Properties.Resources.volver;
            this.btn_regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_regresar.Location = new System.Drawing.Point(12, 12);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(57, 40);
            this.btn_regresar.TabIndex = 55;
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
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
            this.tbc_categoria.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categoria)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mod_categoria)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_borrar_categoria)).EndInit();
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
        private System.Windows.Forms.TextBox txt_categoria;
        private System.Windows.Forms.DataGridView dgv_categoria;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_mod_guardar;
        private System.Windows.Forms.Label txt_mod_categoria;
        private System.Windows.Forms.TextBox txt_mod_categoriaa;
        private System.Windows.Forms.DataGridView dgv_mod_categoria;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgv_borrar_categoria;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label lbl_codigo_buscar;
    }
}