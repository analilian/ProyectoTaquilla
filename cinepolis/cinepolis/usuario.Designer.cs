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
            this.components = new System.ComponentModel.Container();
            this.lbl_mantenimientodeusuario = new System.Windows.Forms.Label();
            this.lbl_modificar = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbo_elegirempleado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_confirmar = new System.Windows.Forms.TextBox();
            this.lbl_uempleado = new System.Windows.Forms.Label();
            this.btn_agregarusuario = new System.Windows.Forms.Button();
            this.dgv_ingresarusuario = new System.Windows.Forms.DataGridView();
            this.cbo_nivelsusario = new System.Windows.Forms.ComboBox();
            this.txt_pasusuario = new System.Windows.Forms.TextBox();
            this.txt_nombreusuario = new System.Windows.Forms.TextBox();
            this.lbl_nivelusuario = new System.Windows.Forms.Label();
            this.lbl_passusuario = new System.Windows.Forms.Label();
            this.lbl_nombreusuario = new System.Windows.Forms.Label();
            this.lbl_ingresarusuario = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_eleminarusuario = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_codigobusqueda = new System.Windows.Forms.Label();
            this.txt_buscarusuario = new System.Windows.Forms.TextBox();
            this.dgv_borrarusuario = new System.Windows.Forms.DataGridView();
            this.lbl_borrarusuario = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbl_confmod = new System.Windows.Forms.Label();
            this.txt_confmod = new System.Windows.Forms.TextBox();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_buscarmod = new System.Windows.Forms.Button();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.txt_modificarbuscar = new System.Windows.Forms.TextBox();
            this.dgv_modificar = new System.Windows.Forms.DataGridView();
            this.lbl_modempl = new System.Windows.Forms.Label();
            this.txt_modempl = new System.Windows.Forms.TextBox();
            this.btn_insertarmod = new System.Windows.Forms.Button();
            this.cbo_modnivel = new System.Windows.Forms.ComboBox();
            this.txt_conmod = new System.Windows.Forms.TextBox();
            this.txt_nommod = new System.Windows.Forms.TextBox();
            this.lbl_modnivel = new System.Windows.Forms.Label();
            this.lbl_modcon = new System.Windows.Forms.Label();
            this.lbl_modnombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.btn_cerrarsesion = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_modificar.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ingresarusuario)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_borrarusuario)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modificar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_mantenimientodeusuario
            // 
            this.lbl_mantenimientodeusuario.AutoSize = true;
            this.lbl_mantenimientodeusuario.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mantenimientodeusuario.Location = new System.Drawing.Point(103, 9);
            this.lbl_mantenimientodeusuario.Name = "lbl_mantenimientodeusuario";
            this.lbl_mantenimientodeusuario.Size = new System.Drawing.Size(736, 54);
            this.lbl_mantenimientodeusuario.TabIndex = 12;
            this.lbl_mantenimientodeusuario.Text = "MANTENIMIENTO DE USUARIO ";
            this.lbl_mantenimientodeusuario.Click += new System.EventHandler(this.lbl_mantenimientodeusuario_Click);
            // 
            // lbl_modificar
            // 
            this.lbl_modificar.Controls.Add(this.tabPage1);
            this.lbl_modificar.Controls.Add(this.tabPage2);
            this.lbl_modificar.Controls.Add(this.tabPage3);
            this.lbl_modificar.Location = new System.Drawing.Point(12, 113);
            this.lbl_modificar.Name = "lbl_modificar";
            this.lbl_modificar.SelectedIndex = 0;
            this.lbl_modificar.Size = new System.Drawing.Size(830, 336);
            this.lbl_modificar.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.cbo_elegirempleado);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_confirmar);
            this.tabPage1.Controls.Add(this.lbl_uempleado);
            this.tabPage1.Controls.Add(this.btn_agregarusuario);
            this.tabPage1.Controls.Add(this.dgv_ingresarusuario);
            this.tabPage1.Controls.Add(this.cbo_nivelsusario);
            this.tabPage1.Controls.Add(this.txt_pasusuario);
            this.tabPage1.Controls.Add(this.txt_nombreusuario);
            this.tabPage1.Controls.Add(this.lbl_nivelusuario);
            this.tabPage1.Controls.Add(this.lbl_passusuario);
            this.tabPage1.Controls.Add(this.lbl_nombreusuario);
            this.tabPage1.Controls.Add(this.lbl_ingresarusuario);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(822, 310);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingresar Usuario";
            // 
            // cbo_elegirempleado
            // 
            this.cbo_elegirempleado.FormattingEnabled = true;
            this.cbo_elegirempleado.Location = new System.Drawing.Point(560, 56);
            this.cbo_elegirempleado.Name = "cbo_elegirempleado";
            this.cbo_elegirempleado.Size = new System.Drawing.Size(113, 21);
            this.cbo_elegirempleado.TabIndex = 40;
            this.cbo_elegirempleado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Confirmar:";
            // 
            // txt_confirmar
            // 
            this.txt_confirmar.Location = new System.Drawing.Point(305, 93);
            this.txt_confirmar.MaxLength = 20;
            this.txt_confirmar.Name = "txt_confirmar";
            this.txt_confirmar.PasswordChar = '*';
            this.txt_confirmar.Size = new System.Drawing.Size(106, 20);
            this.txt_confirmar.TabIndex = 38;
            // 
            // lbl_uempleado
            // 
            this.lbl_uempleado.AutoSize = true;
            this.lbl_uempleado.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uempleado.Location = new System.Drawing.Point(494, 61);
            this.lbl_uempleado.Name = "lbl_uempleado";
            this.lbl_uempleado.Size = new System.Drawing.Size(71, 16);
            this.lbl_uempleado.TabIndex = 37;
            this.lbl_uempleado.Text = "Empleado:";
            // 
            // btn_agregarusuario
            // 
            this.btn_agregarusuario.BackgroundImage = global::cinepolis.Properties.Resources.Save_icon;
            this.btn_agregarusuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregarusuario.Location = new System.Drawing.Point(705, 54);
            this.btn_agregarusuario.Name = "btn_agregarusuario";
            this.btn_agregarusuario.Size = new System.Drawing.Size(96, 89);
            this.btn_agregarusuario.TabIndex = 35;
            this.toolTip1.SetToolTip(this.btn_agregarusuario, "Guardar");
            this.btn_agregarusuario.UseVisualStyleBackColor = true;
            this.btn_agregarusuario.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgv_ingresarusuario
            // 
            this.dgv_ingresarusuario.AllowUserToAddRows = false;
            this.dgv_ingresarusuario.AllowUserToDeleteRows = false;
            this.dgv_ingresarusuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ingresarusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ingresarusuario.Location = new System.Drawing.Point(9, 154);
            this.dgv_ingresarusuario.Name = "dgv_ingresarusuario";
            this.dgv_ingresarusuario.ReadOnly = true;
            this.dgv_ingresarusuario.Size = new System.Drawing.Size(792, 150);
            this.dgv_ingresarusuario.TabIndex = 34;
            this.dgv_ingresarusuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_empleados_CellContentClick);
            // 
            // cbo_nivelsusario
            // 
            this.cbo_nivelsusario.FormattingEnabled = true;
            this.cbo_nivelsusario.Location = new System.Drawing.Point(116, 128);
            this.cbo_nivelsusario.Name = "cbo_nivelsusario";
            this.cbo_nivelsusario.Size = new System.Drawing.Size(113, 21);
            this.cbo_nivelsusario.TabIndex = 33;
            // 
            // txt_pasusuario
            // 
            this.txt_pasusuario.Location = new System.Drawing.Point(115, 92);
            this.txt_pasusuario.MaxLength = 20;
            this.txt_pasusuario.Name = "txt_pasusuario";
            this.txt_pasusuario.PasswordChar = '*';
            this.txt_pasusuario.Size = new System.Drawing.Size(103, 20);
            this.txt_pasusuario.TabIndex = 32;
            this.txt_pasusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pasusuario_KeyPress);
            // 
            // txt_nombreusuario
            // 
            this.txt_nombreusuario.Location = new System.Drawing.Point(116, 60);
            this.txt_nombreusuario.MaxLength = 20;
            this.txt_nombreusuario.Name = "txt_nombreusuario";
            this.txt_nombreusuario.Size = new System.Drawing.Size(299, 20);
            this.txt_nombreusuario.TabIndex = 31;
            this.txt_nombreusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombreusuario_KeyPress);
            // 
            // lbl_nivelusuario
            // 
            this.lbl_nivelusuario.AutoSize = true;
            this.lbl_nivelusuario.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nivelusuario.Location = new System.Drawing.Point(73, 129);
            this.lbl_nivelusuario.Name = "lbl_nivelusuario";
            this.lbl_nivelusuario.Size = new System.Drawing.Size(37, 16);
            this.lbl_nivelusuario.TabIndex = 30;
            this.lbl_nivelusuario.Text = "Role:";
            this.lbl_nivelusuario.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_passusuario
            // 
            this.lbl_passusuario.AutoSize = true;
            this.lbl_passusuario.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passusuario.Location = new System.Drawing.Point(28, 94);
            this.lbl_passusuario.Name = "lbl_passusuario";
            this.lbl_passusuario.Size = new System.Drawing.Size(82, 16);
            this.lbl_passusuario.TabIndex = 29;
            this.lbl_passusuario.Text = "Contraseña :";
            this.lbl_passusuario.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbl_nombreusuario
            // 
            this.lbl_nombreusuario.AutoSize = true;
            this.lbl_nombreusuario.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreusuario.Location = new System.Drawing.Point(51, 64);
            this.lbl_nombreusuario.Name = "lbl_nombreusuario";
            this.lbl_nombreusuario.Size = new System.Drawing.Size(59, 16);
            this.lbl_nombreusuario.TabIndex = 28;
            this.lbl_nombreusuario.Text = "Nombre:";
            // 
            // lbl_ingresarusuario
            // 
            this.lbl_ingresarusuario.AutoSize = true;
            this.lbl_ingresarusuario.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ingresarusuario.Location = new System.Drawing.Point(151, 3);
            this.lbl_ingresarusuario.Name = "lbl_ingresarusuario";
            this.lbl_ingresarusuario.Size = new System.Drawing.Size(487, 54);
            this.lbl_ingresarusuario.TabIndex = 14;
            this.lbl_ingresarusuario.Text = "INGRESAR USUARIO ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.btn_eleminarusuario);
            this.tabPage2.Controls.Add(this.btn_buscar);
            this.tabPage2.Controls.Add(this.lbl_codigobusqueda);
            this.tabPage2.Controls.Add(this.txt_buscarusuario);
            this.tabPage2.Controls.Add(this.dgv_borrarusuario);
            this.tabPage2.Controls.Add(this.lbl_borrarusuario);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(822, 310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Borrar Usuario";
            // 
            // btn_eleminarusuario
            // 
            this.btn_eleminarusuario.BackgroundImage = global::cinepolis.Properties.Resources.File_Delete_icon;
            this.btn_eleminarusuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eleminarusuario.Location = new System.Drawing.Point(654, 68);
            this.btn_eleminarusuario.Name = "btn_eleminarusuario";
            this.btn_eleminarusuario.Size = new System.Drawing.Size(75, 57);
            this.btn_eleminarusuario.TabIndex = 39;
            this.toolTip1.SetToolTip(this.btn_eleminarusuario, "Eliminar");
            this.btn_eleminarusuario.UseVisualStyleBackColor = true;
            this.btn_eleminarusuario.Click += new System.EventHandler(this.btn_eleminarusuario_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = global::cinepolis.Properties.Resources.Zoom_icon;
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.Location = new System.Drawing.Point(491, 68);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(80, 56);
            this.btn_buscar.TabIndex = 38;
            this.toolTip1.SetToolTip(this.btn_buscar, "Buscar");
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // lbl_codigobusqueda
            // 
            this.lbl_codigobusqueda.AutoSize = true;
            this.lbl_codigobusqueda.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigobusqueda.Location = new System.Drawing.Point(78, 87);
            this.lbl_codigobusqueda.Name = "lbl_codigobusqueda";
            this.lbl_codigobusqueda.Size = new System.Drawing.Size(55, 16);
            this.lbl_codigobusqueda.TabIndex = 37;
            this.lbl_codigobusqueda.Text = "Codigo:";
            // 
            // txt_buscarusuario
            // 
            this.txt_buscarusuario.Location = new System.Drawing.Point(143, 83);
            this.txt_buscarusuario.MaxLength = 100;
            this.txt_buscarusuario.Name = "txt_buscarusuario";
            this.txt_buscarusuario.Size = new System.Drawing.Size(299, 20);
            this.txt_buscarusuario.TabIndex = 36;
            // 
            // dgv_borrarusuario
            // 
            this.dgv_borrarusuario.AllowUserToAddRows = false;
            this.dgv_borrarusuario.AllowUserToDeleteRows = false;
            this.dgv_borrarusuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_borrarusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_borrarusuario.Location = new System.Drawing.Point(6, 143);
            this.dgv_borrarusuario.Name = "dgv_borrarusuario";
            this.dgv_borrarusuario.ReadOnly = true;
            this.dgv_borrarusuario.Size = new System.Drawing.Size(792, 150);
            this.dgv_borrarusuario.TabIndex = 35;
            // 
            // lbl_borrarusuario
            // 
            this.lbl_borrarusuario.AutoSize = true;
            this.lbl_borrarusuario.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_borrarusuario.Location = new System.Drawing.Point(202, 3);
            this.lbl_borrarusuario.Name = "lbl_borrarusuario";
            this.lbl_borrarusuario.Size = new System.Drawing.Size(439, 54);
            this.lbl_borrarusuario.TabIndex = 15;
            this.lbl_borrarusuario.Text = "BORRAR USUARIO ";
            this.lbl_borrarusuario.Click += new System.EventHandler(this.label3_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage3.Controls.Add(this.lbl_confmod);
            this.tabPage3.Controls.Add(this.txt_confmod);
            this.tabPage3.Controls.Add(this.btn_modificar);
            this.tabPage3.Controls.Add(this.btn_buscarmod);
            this.tabPage3.Controls.Add(this.lbl_buscar);
            this.tabPage3.Controls.Add(this.txt_modificarbuscar);
            this.tabPage3.Controls.Add(this.dgv_modificar);
            this.tabPage3.Controls.Add(this.lbl_modempl);
            this.tabPage3.Controls.Add(this.txt_modempl);
            this.tabPage3.Controls.Add(this.btn_insertarmod);
            this.tabPage3.Controls.Add(this.cbo_modnivel);
            this.tabPage3.Controls.Add(this.txt_conmod);
            this.tabPage3.Controls.Add(this.txt_nommod);
            this.tabPage3.Controls.Add(this.lbl_modnivel);
            this.tabPage3.Controls.Add(this.lbl_modcon);
            this.tabPage3.Controls.Add(this.lbl_modnombre);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(822, 310);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Modificar Usuario";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // lbl_confmod
            // 
            this.lbl_confmod.AutoSize = true;
            this.lbl_confmod.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confmod.Location = new System.Drawing.Point(280, 96);
            this.lbl_confmod.Name = "lbl_confmod";
            this.lbl_confmod.Size = new System.Drawing.Size(71, 16);
            this.lbl_confmod.TabIndex = 53;
            this.lbl_confmod.Text = "Confirmar:";
            this.lbl_confmod.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // txt_confmod
            // 
            this.txt_confmod.Location = new System.Drawing.Point(357, 95);
            this.txt_confmod.MaxLength = 20;
            this.txt_confmod.Name = "txt_confmod";
            this.txt_confmod.PasswordChar = '*';
            this.txt_confmod.Size = new System.Drawing.Size(106, 20);
            this.txt_confmod.TabIndex = 52;
            this.txt_confmod.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackgroundImage = global::cinepolis.Properties.Resources.Button_Refresh_icon;
            this.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_modificar.Location = new System.Drawing.Point(672, 112);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(42, 42);
            this.btn_modificar.TabIndex = 51;
            this.toolTip1.SetToolTip(this.btn_modificar, "Actualizar");
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_buscarmod
            // 
            this.btn_buscarmod.BackgroundImage = global::cinepolis.Properties.Resources.Zoom_icon;
            this.btn_buscarmod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscarmod.Location = new System.Drawing.Point(624, 112);
            this.btn_buscarmod.Name = "btn_buscarmod";
            this.btn_buscarmod.Size = new System.Drawing.Size(42, 42);
            this.btn_buscarmod.TabIndex = 50;
            this.toolTip1.SetToolTip(this.btn_buscarmod, "Buscar");
            this.btn_buscarmod.UseVisualStyleBackColor = true;
            this.btn_buscarmod.Click += new System.EventHandler(this.btn_buscarmod_Click);
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.Location = new System.Drawing.Point(254, 126);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(52, 16);
            this.lbl_buscar.TabIndex = 49;
            this.lbl_buscar.Text = "Buscar:";
            this.lbl_buscar.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_modificarbuscar
            // 
            this.txt_modificarbuscar.Location = new System.Drawing.Point(315, 126);
            this.txt_modificarbuscar.MaxLength = 20;
            this.txt_modificarbuscar.Name = "txt_modificarbuscar";
            this.txt_modificarbuscar.Size = new System.Drawing.Size(299, 20);
            this.txt_modificarbuscar.TabIndex = 48;
            this.txt_modificarbuscar.TextChanged += new System.EventHandler(this.txt_modificarbuscar_TextChanged);
            // 
            // dgv_modificar
            // 
            this.dgv_modificar.AllowUserToAddRows = false;
            this.dgv_modificar.AllowUserToDeleteRows = false;
            this.dgv_modificar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_modificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_modificar.Location = new System.Drawing.Point(21, 157);
            this.dgv_modificar.Name = "dgv_modificar";
            this.dgv_modificar.ReadOnly = true;
            this.dgv_modificar.Size = new System.Drawing.Size(792, 150);
            this.dgv_modificar.TabIndex = 47;
            this.dgv_modificar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_modificar_CellContentClick);
            // 
            // lbl_modempl
            // 
            this.lbl_modempl.AutoSize = true;
            this.lbl_modempl.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_modempl.Location = new System.Drawing.Point(490, 60);
            this.lbl_modempl.Name = "lbl_modempl";
            this.lbl_modempl.Size = new System.Drawing.Size(71, 16);
            this.lbl_modempl.TabIndex = 46;
            this.lbl_modempl.Text = "Empleado:";
            // 
            // txt_modempl
            // 
            this.txt_modempl.Location = new System.Drawing.Point(567, 59);
            this.txt_modempl.Name = "txt_modempl";
            this.txt_modempl.Size = new System.Drawing.Size(87, 20);
            this.txt_modempl.TabIndex = 45;
            // 
            // btn_insertarmod
            // 
            this.btn_insertarmod.BackgroundImage = global::cinepolis.Properties.Resources.Save_icon;
            this.btn_insertarmod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_insertarmod.Location = new System.Drawing.Point(720, 92);
            this.btn_insertarmod.Name = "btn_insertarmod";
            this.btn_insertarmod.Size = new System.Drawing.Size(79, 59);
            this.btn_insertarmod.TabIndex = 44;
            this.toolTip1.SetToolTip(this.btn_insertarmod, "Reguardar");
            this.btn_insertarmod.UseVisualStyleBackColor = true;
            this.btn_insertarmod.Click += new System.EventHandler(this.btn_insertarmod_Click);
            // 
            // cbo_modnivel
            // 
            this.cbo_modnivel.FormattingEnabled = true;
            this.cbo_modnivel.Location = new System.Drawing.Point(135, 125);
            this.cbo_modnivel.Name = "cbo_modnivel";
            this.cbo_modnivel.Size = new System.Drawing.Size(113, 21);
            this.cbo_modnivel.TabIndex = 43;
            // 
            // txt_conmod
            // 
            this.txt_conmod.Location = new System.Drawing.Point(139, 92);
            this.txt_conmod.MaxLength = 20;
            this.txt_conmod.Name = "txt_conmod";
            this.txt_conmod.PasswordChar = '*';
            this.txt_conmod.Size = new System.Drawing.Size(124, 20);
            this.txt_conmod.TabIndex = 42;
            this.txt_conmod.TextChanged += new System.EventHandler(this.txt_conmod_TextChanged);
            this.txt_conmod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_conmod_KeyPress);
            // 
            // txt_nommod
            // 
            this.txt_nommod.Location = new System.Drawing.Point(139, 63);
            this.txt_nommod.MaxLength = 20;
            this.txt_nommod.Name = "txt_nommod";
            this.txt_nommod.Size = new System.Drawing.Size(299, 20);
            this.txt_nommod.TabIndex = 41;
            this.txt_nommod.TextChanged += new System.EventHandler(this.txt_nommod_TextChanged);
            this.txt_nommod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nommod_KeyPress);
            // 
            // lbl_modnivel
            // 
            this.lbl_modnivel.AutoSize = true;
            this.lbl_modnivel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_modnivel.Location = new System.Drawing.Point(18, 125);
            this.lbl_modnivel.Name = "lbl_modnivel";
            this.lbl_modnivel.Size = new System.Drawing.Size(104, 16);
            this.lbl_modnivel.TabIndex = 40;
            this.lbl_modnivel.Text = "Nivel de usuario:";
            // 
            // lbl_modcon
            // 
            this.lbl_modcon.AutoSize = true;
            this.lbl_modcon.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_modcon.Location = new System.Drawing.Point(22, 96);
            this.lbl_modcon.Name = "lbl_modcon";
            this.lbl_modcon.Size = new System.Drawing.Size(82, 16);
            this.lbl_modcon.TabIndex = 39;
            this.lbl_modcon.Text = "Contraseña :";
            // 
            // lbl_modnombre
            // 
            this.lbl_modnombre.AutoSize = true;
            this.lbl_modnombre.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_modnombre.Location = new System.Drawing.Point(22, 71);
            this.lbl_modnombre.Name = "lbl_modnombre";
            this.lbl_modnombre.Size = new System.Drawing.Size(59, 16);
            this.lbl_modnombre.TabIndex = 38;
            this.lbl_modnombre.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 54);
            this.label1.TabIndex = 16;
            this.label1.Text = "MODIFICAR USUARIO";
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackgroundImage = global::cinepolis.Properties.Resources.Button_Previous_icon;
            this.btn_regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_regresar.Location = new System.Drawing.Point(3, 31);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(66, 48);
            this.btn_regresar.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btn_regresar, "Regresar");
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_cerrarsesion
            // 
            this.btn_cerrarsesion.BackgroundImage = global::cinepolis.Properties.Resources.FONDO_ICONO;
            this.btn_cerrarsesion.Location = new System.Drawing.Point(3, 2);
            this.btn_cerrarsesion.Name = "btn_cerrarsesion";
            this.btn_cerrarsesion.Size = new System.Drawing.Size(94, 23);
            this.btn_cerrarsesion.TabIndex = 10;
            this.btn_cerrarsesion.Text = "Cerrar Sesión";
            this.btn_cerrarsesion.UseVisualStyleBackColor = true;
            this.btn_cerrarsesion.Click += new System.EventHandler(this.button1_Click);
            // 
            // usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(854, 461);
            this.Controls.Add(this.lbl_modificar);
            this.Controls.Add(this.lbl_mantenimientodeusuario);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.btn_cerrarsesion);
            this.Name = "usuario";
            this.Text = "usuario";
            this.Load += new System.EventHandler(this.usuario_Load);
            this.lbl_modificar.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ingresarusuario)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_borrarusuario)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modificar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Button btn_cerrarsesion;
        private System.Windows.Forms.Label lbl_mantenimientodeusuario;
        private System.Windows.Forms.TabControl lbl_modificar;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lbl_ingresarusuario;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbl_passusuario;
        private System.Windows.Forms.Label lbl_nombreusuario;
        private System.Windows.Forms.Label lbl_borrarusuario;
        private System.Windows.Forms.Label lbl_nivelusuario;
        private System.Windows.Forms.Button btn_agregarusuario;
        private System.Windows.Forms.DataGridView dgv_ingresarusuario;
        private System.Windows.Forms.ComboBox cbo_nivelsusario;
        private System.Windows.Forms.TextBox txt_pasusuario;
        private System.Windows.Forms.TextBox txt_nombreusuario;
        private System.Windows.Forms.Button btn_eleminarusuario;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lbl_codigobusqueda;
        private System.Windows.Forms.TextBox txt_buscarusuario;
        private System.Windows.Forms.DataGridView dgv_borrarusuario;
        private System.Windows.Forms.Label lbl_uempleado;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_modempl;
        private System.Windows.Forms.TextBox txt_modempl;
        private System.Windows.Forms.Button btn_insertarmod;
        private System.Windows.Forms.ComboBox cbo_modnivel;
        private System.Windows.Forms.TextBox txt_conmod;
        private System.Windows.Forms.TextBox txt_nommod;
        private System.Windows.Forms.Label lbl_modnivel;
        private System.Windows.Forms.Label lbl_modcon;
        private System.Windows.Forms.Label lbl_modnombre;
        private System.Windows.Forms.DataGridView dgv_modificar;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.TextBox txt_modificarbuscar;
        private System.Windows.Forms.Button btn_buscarmod;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_confirmar;
        private System.Windows.Forms.Label lbl_confmod;
        private System.Windows.Forms.TextBox txt_confmod;
        private System.Windows.Forms.ComboBox cbo_elegirempleado;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}