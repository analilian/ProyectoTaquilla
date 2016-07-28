namespace cinepolis
{
    partial class usuario
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
            this.dgv_eliminar = new System.Windows.Forms.TabControl();
            this.tbc_ingresar = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.label_buscar = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.tbc_borrar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.dgv_borrar = new System.Windows.Forms.DataGridView();
            this.label_nombreing = new System.Windows.Forms.Label();
            this.label_contraseña = new System.Windows.Forms.Label();
            this.label_niveluser = new System.Windows.Forms.Label();
            this.label_ingresar = new System.Windows.Forms.Label();
            this.label_mantenimiento = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.cbo_niveluser = new System.Windows.Forms.ComboBox();
            this.dgv_ingresar = new System.Windows.Forms.DataGridView();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.tbp_modificar = new System.Windows.Forms.TabPage();
            this.label_modificar = new System.Windows.Forms.Label();
            this.cbo_nivelusermod = new System.Windows.Forms.ComboBox();
            this.txt_contramod = new System.Windows.Forms.TextBox();
            this.txt_nombmod = new System.Windows.Forms.TextBox();
            this.label_nivelusermod = new System.Windows.Forms.Label();
            this.label_contraseñamod = new System.Windows.Forms.Label();
            this.label_nombremod = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_buscarmod = new System.Windows.Forms.Button();
            this.txt_buscarmod = new System.Windows.Forms.TextBox();
            this.label_buscarmod = new System.Windows.Forms.Label();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_guardarmod = new System.Windows.Forms.Button();
            this.dgv_eliminar.SuspendLayout();
            this.tbc_ingresar.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_borrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ingresar)).BeginInit();
            this.tbp_modificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_eliminar
            // 
            this.dgv_eliminar.Controls.Add(this.tbc_ingresar);
            this.dgv_eliminar.Controls.Add(this.tabPage2);
            this.dgv_eliminar.Controls.Add(this.tbp_modificar);
            this.dgv_eliminar.Location = new System.Drawing.Point(12, 113);
            this.dgv_eliminar.Name = "dgv_eliminar";
            this.dgv_eliminar.SelectedIndex = 0;
            this.dgv_eliminar.Size = new System.Drawing.Size(827, 336);
            this.dgv_eliminar.TabIndex = 13;
            this.dgv_eliminar.SelectedIndexChanged += new System.EventHandler(this.dgv_eliminar_SelectedIndexChanged);
            // 
            // tbc_ingresar
            // 
            this.tbc_ingresar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbc_ingresar.Controls.Add(this.btn_agregar);
            this.tbc_ingresar.Controls.Add(this.dgv_ingresar);
            this.tbc_ingresar.Controls.Add(this.cbo_niveluser);
            this.tbc_ingresar.Controls.Add(this.txt_contraseña);
            this.tbc_ingresar.Controls.Add(this.txt_nombre);
            this.tbc_ingresar.Controls.Add(this.label_ingresar);
            this.tbc_ingresar.Controls.Add(this.label_niveluser);
            this.tbc_ingresar.Controls.Add(this.label_contraseña);
            this.tbc_ingresar.Controls.Add(this.label_nombreing);
            this.tbc_ingresar.Controls.Add(this.label7);
            this.tbc_ingresar.Controls.Add(this.label9);
            this.tbc_ingresar.Controls.Add(this.label2);
            this.tbc_ingresar.Location = new System.Drawing.Point(4, 22);
            this.tbc_ingresar.Name = "tbc_ingresar";
            this.tbc_ingresar.Padding = new System.Windows.Forms.Padding(3);
            this.tbc_ingresar.Size = new System.Drawing.Size(819, 310);
            this.tbc_ingresar.TabIndex = 0;
            this.tbc_ingresar.Text = "Ingresar Usuario";
            this.tbc_ingresar.Click += new System.EventHandler(this.tbc_ingresar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 16);
            this.label9.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 54);
            this.label2.TabIndex = 14;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.dgv_borrar);
            this.tabPage2.Controls.Add(this.btn_buscar);
            this.tabPage2.Controls.Add(this.tbc_borrar);
            this.tabPage2.Controls.Add(this.txt_buscar);
            this.tabPage2.Controls.Add(this.label_buscar);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(819, 310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Borrar Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 44);
            this.label3.TabIndex = 15;
            this.label3.Text = "BORRAR USUARIO ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = global::cinepolis.Properties.Resources.FONDO_ICONO;
            this.btn_back.Location = new System.Drawing.Point(3, 31);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(94, 23);
            this.btn_back.TabIndex = 11;
            this.btn_back.Text = "Regresar";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackgroundImage = global::cinepolis.Properties.Resources.FONDO_ICONO;
            this.btn_cerrar.Location = new System.Drawing.Point(3, 2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(94, 23);
            this.btn_cerrar.TabIndex = 10;
            this.btn_cerrar.Text = "Cerrar Sesión";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_buscar
            // 
            this.label_buscar.AutoSize = true;
            this.label_buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_buscar.Location = new System.Drawing.Point(223, 73);
            this.label_buscar.Name = "label_buscar";
            this.label_buscar.Size = new System.Drawing.Size(65, 21);
            this.label_buscar.TabIndex = 16;
            this.label_buscar.Text = "Buscar:";
            this.label_buscar.Click += new System.EventHandler(this.label_buscar_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(294, 74);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(234, 20);
            this.txt_buscar.TabIndex = 17;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            // 
            // tbc_borrar
            // 
            this.tbc_borrar.Location = new System.Drawing.Point(679, 166);
            this.tbc_borrar.Name = "tbc_borrar";
            this.tbc_borrar.Size = new System.Drawing.Size(75, 67);
            this.tbc_borrar.TabIndex = 18;
            this.tbc_borrar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.tbc_borrar.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(545, 57);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(36, 37);
            this.btn_buscar.TabIndex = 19;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // dgv_borrar
            // 
            this.dgv_borrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_borrar.Location = new System.Drawing.Point(143, 126);
            this.dgv_borrar.Name = "dgv_borrar";
            this.dgv_borrar.Size = new System.Drawing.Size(530, 178);
            this.dgv_borrar.TabIndex = 20;
            // 
            // label_nombreing
            // 
            this.label_nombreing.AutoSize = true;
            this.label_nombreing.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombreing.Location = new System.Drawing.Point(6, 68);
            this.label_nombreing.Name = "label_nombreing";
            this.label_nombreing.Size = new System.Drawing.Size(77, 21);
            this.label_nombreing.TabIndex = 31;
            this.label_nombreing.Text = "Nombre:";
            // 
            // label_contraseña
            // 
            this.label_contraseña.AutoSize = true;
            this.label_contraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_contraseña.Location = new System.Drawing.Point(6, 98);
            this.label_contraseña.Name = "label_contraseña";
            this.label_contraseña.Size = new System.Drawing.Size(107, 21);
            this.label_contraseña.TabIndex = 32;
            this.label_contraseña.Text = "Contraseña:";
            // 
            // label_niveluser
            // 
            this.label_niveluser.AutoSize = true;
            this.label_niveluser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_niveluser.Location = new System.Drawing.Point(6, 129);
            this.label_niveluser.Name = "label_niveluser";
            this.label_niveluser.Size = new System.Drawing.Size(136, 21);
            this.label_niveluser.TabIndex = 33;
            this.label_niveluser.Text = "Nivel de usuario:";
            // 
            // label_ingresar
            // 
            this.label_ingresar.AutoSize = true;
            this.label_ingresar.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ingresar.Location = new System.Drawing.Point(233, 10);
            this.label_ingresar.Name = "label_ingresar";
            this.label_ingresar.Size = new System.Drawing.Size(361, 44);
            this.label_ingresar.TabIndex = 34;
            this.label_ingresar.Text = "INGRESAR USUARIO";
            // 
            // label_mantenimiento
            // 
            this.label_mantenimiento.AutoSize = true;
            this.label_mantenimiento.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mantenimiento.Location = new System.Drawing.Point(184, 11);
            this.label_mantenimiento.Name = "label_mantenimiento";
            this.label_mantenimiento.Size = new System.Drawing.Size(555, 44);
            this.label_mantenimiento.TabIndex = 35;
            this.label_mantenimiento.Text = "MANTENIMIENTO DE USUARIOS";
            this.label_mantenimiento.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(160, 71);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(234, 20);
            this.txt_nombre.TabIndex = 35;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(160, 99);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(234, 20);
            this.txt_contraseña.TabIndex = 36;
            // 
            // cbo_niveluser
            // 
            this.cbo_niveluser.FormattingEnabled = true;
            this.cbo_niveluser.Location = new System.Drawing.Point(160, 129);
            this.cbo_niveluser.Name = "cbo_niveluser";
            this.cbo_niveluser.Size = new System.Drawing.Size(151, 21);
            this.cbo_niveluser.TabIndex = 60;
            // 
            // dgv_ingresar
            // 
            this.dgv_ingresar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ingresar.Location = new System.Drawing.Point(199, 156);
            this.dgv_ingresar.Name = "dgv_ingresar";
            this.dgv_ingresar.Size = new System.Drawing.Size(458, 148);
            this.dgv_ingresar.TabIndex = 61;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(582, 71);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 67);
            this.btn_agregar.TabIndex = 62;
            this.btn_agregar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // tbp_modificar
            // 
            this.tbp_modificar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbp_modificar.Controls.Add(this.btn_guardarmod);
            this.tbp_modificar.Controls.Add(this.btn_modificar);
            this.tbp_modificar.Controls.Add(this.btn_buscarmod);
            this.tbp_modificar.Controls.Add(this.txt_buscarmod);
            this.tbp_modificar.Controls.Add(this.label_buscarmod);
            this.tbp_modificar.Controls.Add(this.dataGridView1);
            this.tbp_modificar.Controls.Add(this.cbo_nivelusermod);
            this.tbp_modificar.Controls.Add(this.txt_contramod);
            this.tbp_modificar.Controls.Add(this.txt_nombmod);
            this.tbp_modificar.Controls.Add(this.label_nivelusermod);
            this.tbp_modificar.Controls.Add(this.label_contraseñamod);
            this.tbp_modificar.Controls.Add(this.label_nombremod);
            this.tbp_modificar.Controls.Add(this.label_modificar);
            this.tbp_modificar.Location = new System.Drawing.Point(4, 22);
            this.tbp_modificar.Name = "tbp_modificar";
            this.tbp_modificar.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_modificar.Size = new System.Drawing.Size(819, 310);
            this.tbp_modificar.TabIndex = 2;
            this.tbp_modificar.Text = "Modificar Usuario";
            // 
            // label_modificar
            // 
            this.label_modificar.AutoEllipsis = true;
            this.label_modificar.AutoSize = true;
            this.label_modificar.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_modificar.Location = new System.Drawing.Point(237, 20);
            this.label_modificar.Name = "label_modificar";
            this.label_modificar.Size = new System.Drawing.Size(391, 44);
            this.label_modificar.TabIndex = 16;
            this.label_modificar.Text = "MODIFICAR USUARIO";
            // 
            // cbo_nivelusermod
            // 
            this.cbo_nivelusermod.FormattingEnabled = true;
            this.cbo_nivelusermod.Location = new System.Drawing.Point(165, 125);
            this.cbo_nivelusermod.Name = "cbo_nivelusermod";
            this.cbo_nivelusermod.Size = new System.Drawing.Size(151, 21);
            this.cbo_nivelusermod.TabIndex = 66;
            // 
            // txt_contramod
            // 
            this.txt_contramod.Location = new System.Drawing.Point(165, 95);
            this.txt_contramod.Name = "txt_contramod";
            this.txt_contramod.Size = new System.Drawing.Size(234, 20);
            this.txt_contramod.TabIndex = 65;
            // 
            // txt_nombmod
            // 
            this.txt_nombmod.Location = new System.Drawing.Point(165, 67);
            this.txt_nombmod.Name = "txt_nombmod";
            this.txt_nombmod.Size = new System.Drawing.Size(234, 20);
            this.txt_nombmod.TabIndex = 64;
            // 
            // label_nivelusermod
            // 
            this.label_nivelusermod.AutoSize = true;
            this.label_nivelusermod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nivelusermod.Location = new System.Drawing.Point(11, 125);
            this.label_nivelusermod.Name = "label_nivelusermod";
            this.label_nivelusermod.Size = new System.Drawing.Size(136, 21);
            this.label_nivelusermod.TabIndex = 63;
            this.label_nivelusermod.Text = "Nivel de usuario:";
            // 
            // label_contraseñamod
            // 
            this.label_contraseñamod.AutoSize = true;
            this.label_contraseñamod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_contraseñamod.Location = new System.Drawing.Point(11, 94);
            this.label_contraseñamod.Name = "label_contraseñamod";
            this.label_contraseñamod.Size = new System.Drawing.Size(107, 21);
            this.label_contraseñamod.TabIndex = 62;
            this.label_contraseñamod.Text = "Contraseña:";
            // 
            // label_nombremod
            // 
            this.label_nombremod.AutoSize = true;
            this.label_nombremod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombremod.Location = new System.Drawing.Point(11, 64);
            this.label_nombremod.Name = "label_nombremod";
            this.label_nombremod.Size = new System.Drawing.Size(77, 21);
            this.label_nombremod.TabIndex = 61;
            this.label_nombremod.Text = "Nombre:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(284, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(425, 138);
            this.dataGridView1.TabIndex = 67;
            // 
            // btn_buscarmod
            // 
            this.btn_buscarmod.Location = new System.Drawing.Point(645, 123);
            this.btn_buscarmod.Name = "btn_buscarmod";
            this.btn_buscarmod.Size = new System.Drawing.Size(36, 37);
            this.btn_buscarmod.TabIndex = 70;
            this.btn_buscarmod.UseVisualStyleBackColor = true;
            // 
            // txt_buscarmod
            // 
            this.txt_buscarmod.Location = new System.Drawing.Point(394, 140);
            this.txt_buscarmod.Name = "txt_buscarmod";
            this.txt_buscarmod.Size = new System.Drawing.Size(234, 20);
            this.txt_buscarmod.TabIndex = 69;
            // 
            // label_buscarmod
            // 
            this.label_buscarmod.AutoSize = true;
            this.label_buscarmod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_buscarmod.Location = new System.Drawing.Point(323, 139);
            this.label_buscarmod.Name = "label_buscarmod";
            this.label_buscarmod.Size = new System.Drawing.Size(65, 21);
            this.label_buscarmod.TabIndex = 68;
            this.label_buscarmod.Text = "Buscar:";
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(491, 64);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 67);
            this.btn_modificar.TabIndex = 71;
            this.btn_modificar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_guardarmod
            // 
            this.btn_guardarmod.Location = new System.Drawing.Point(725, 209);
            this.btn_guardarmod.Name = "btn_guardarmod";
            this.btn_guardarmod.Size = new System.Drawing.Size(75, 67);
            this.btn_guardarmod.TabIndex = 72;
            this.btn_guardarmod.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_guardarmod.UseVisualStyleBackColor = true;
            // 
            // usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(854, 461);
            this.Controls.Add(this.label_mantenimiento);
            this.Controls.Add(this.dgv_eliminar);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_cerrar);
            this.Name = "usuario";
            this.Text = "usuario";
            this.dgv_eliminar.ResumeLayout(false);
            this.tbc_ingresar.ResumeLayout(false);
            this.tbc_ingresar.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_borrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ingresar)).EndInit();
            this.tbp_modificar.ResumeLayout(false);
            this.tbp_modificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.TabControl dgv_eliminar;
        private System.Windows.Forms.TabPage tbc_ingresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_borrar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button tbc_borrar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label label_buscar;
        private System.Windows.Forms.Label label_niveluser;
        private System.Windows.Forms.Label label_contraseña;
        private System.Windows.Forms.Label label_nombreing;
        private System.Windows.Forms.Label label_ingresar;
        private System.Windows.Forms.Label label_mantenimiento;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.DataGridView dgv_ingresar;
        private System.Windows.Forms.ComboBox cbo_niveluser;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TabPage tbp_modificar;
        private System.Windows.Forms.Label label_modificar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbo_nivelusermod;
        private System.Windows.Forms.TextBox txt_contramod;
        private System.Windows.Forms.TextBox txt_nombmod;
        private System.Windows.Forms.Label label_nivelusermod;
        private System.Windows.Forms.Label label_contraseñamod;
        private System.Windows.Forms.Label label_nombremod;
        private System.Windows.Forms.Button btn_guardarmod;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_buscarmod;
        private System.Windows.Forms.TextBox txt_buscarmod;
        private System.Windows.Forms.Label label_buscarmod;
    }
}