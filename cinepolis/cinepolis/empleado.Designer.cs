namespace cinepolis
{
    partial class empleado
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
            this.btn_regresar = new System.Windows.Forms.Button();
            this.btn_cerrarsesion = new System.Windows.Forms.Button();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.lbl_titulo_mantenimiento_cine = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtp_fecha_nac = new System.Windows.Forms.DateTimePicker();
            this.cbo_cine = new System.Windows.Forms.ComboBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_cine = new System.Windows.Forms.Label();
            this.cbo_puesto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_dpi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_apellido2 = new System.Windows.Forms.TextBox();
            this.txt_apellido1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre2 = new System.Windows.Forms.TextBox();
            this.txt_nombre1 = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_agregar = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtp_mod_fecha_nac = new System.Windows.Forms.DateTimePicker();
            this.cbo_mod_cine = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_buscarmod = new System.Windows.Forms.Button();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.txt_modificarbuscar = new System.Windows.Forms.TextBox();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_mod_guardar = new System.Windows.Forms.Button();
            this.dgv_emplados_modificar = new System.Windows.Forms.DataGridView();
            this.cbo_mod_puesto = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_mod_nit = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_mod_dpi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_mod_direccion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_mod_apellido2 = new System.Windows.Forms.TextBox();
            this.txt_mod_apellido1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_mod_nombre2 = new System.Windows.Forms.TextBox();
            this.txt_mod_nombre1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_mod = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.lbl_codigo_buscar = new System.Windows.Forms.Label();
            this.dgv_buscar_empleado = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emplados_modificar)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_buscar_empleado)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackgroundImage = global::cinepolis.Properties.Resources.Button_Previous_icon;
            this.btn_regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_regresar.Location = new System.Drawing.Point(12, 41);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(57, 40);
            this.btn_regresar.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btn_regresar, "Regresar");
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // btn_cerrarsesion
            // 
            this.btn_cerrarsesion.BackgroundImage = global::cinepolis.Properties.Resources.FONDO_ICONO;
            this.btn_cerrarsesion.Location = new System.Drawing.Point(12, 12);
            this.btn_cerrarsesion.Name = "btn_cerrarsesion";
            this.btn_cerrarsesion.Size = new System.Drawing.Size(94, 23);
            this.btn_cerrarsesion.TabIndex = 10;
            this.btn_cerrarsesion.Text = "Cerrar Sesión";
            this.btn_cerrarsesion.UseVisualStyleBackColor = true;
            this.btn_cerrarsesion.Click += new System.EventHandler(this.btn_cerrarsesion_Click);
            // 
            // pic_logo
            // 
            this.pic_logo.BackgroundImage = global::cinepolis.Properties.Resources._13672487_10208834486171149_1624040466_n;
            this.pic_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_logo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_logo.Location = new System.Drawing.Point(794, 9);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(94, 72);
            this.pic_logo.TabIndex = 12;
            this.pic_logo.TabStop = false;
            // 
            // lbl_titulo_mantenimiento_cine
            // 
            this.lbl_titulo_mantenimiento_cine.AutoSize = true;
            this.lbl_titulo_mantenimiento_cine.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_mantenimiento_cine.Location = new System.Drawing.Point(209, 9);
            this.lbl_titulo_mantenimiento_cine.Name = "lbl_titulo_mantenimiento_cine";
            this.lbl_titulo_mantenimiento_cine.Size = new System.Drawing.Size(469, 36);
            this.lbl_titulo_mantenimiento_cine.TabIndex = 13;
            this.lbl_titulo_mantenimiento_cine.Text = "MANTENIMIENTO DE EMPLEADO";
            this.lbl_titulo_mantenimiento_cine.Click += new System.EventHandler(this.lbl_titulo_mantenimiento_cine_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 119);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(876, 384);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.dtp_fecha_nac);
            this.tabPage1.Controls.Add(this.cbo_cine);
            this.tabPage1.Controls.Add(this.btn_guardar);
            this.tabPage1.Controls.Add(this.lbl_cine);
            this.tabPage1.Controls.Add(this.cbo_puesto);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txt_nit);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txt_dpi);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txt_direccion);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_apellido2);
            this.tabPage1.Controls.Add(this.txt_apellido1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txt_nombre2);
            this.tabPage1.Controls.Add(this.txt_nombre1);
            this.tabPage1.Controls.Add(this.lbl_nombre);
            this.tabPage1.Controls.Add(this.lbl_agregar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(868, 358);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingresar empleado";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dtp_fecha_nac
            // 
            this.dtp_fecha_nac.CustomFormat = "yyyy--MM--dd";
            this.dtp_fecha_nac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha_nac.Location = new System.Drawing.Point(619, 176);
            this.dtp_fecha_nac.Name = "dtp_fecha_nac";
            this.dtp_fecha_nac.Size = new System.Drawing.Size(105, 20);
            this.dtp_fecha_nac.TabIndex = 55;
            this.dtp_fecha_nac.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cbo_cine
            // 
            this.cbo_cine.FormattingEnabled = true;
            this.cbo_cine.Location = new System.Drawing.Point(515, 142);
            this.cbo_cine.Name = "cbo_cine";
            this.cbo_cine.Size = new System.Drawing.Size(308, 21);
            this.cbo_cine.TabIndex = 54;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImage = global::cinepolis.Properties.Resources.Save_icon;
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.Location = new System.Drawing.Point(733, 264);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(90, 73);
            this.btn_guardar.TabIndex = 53;
            this.toolTip1.SetToolTip(this.btn_guardar, "Guardar");
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_cine
            // 
            this.lbl_cine.AutoSize = true;
            this.lbl_cine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cine.Location = new System.Drawing.Point(432, 143);
            this.lbl_cine.Name = "lbl_cine";
            this.lbl_cine.Size = new System.Drawing.Size(50, 21);
            this.lbl_cine.TabIndex = 48;
            this.lbl_cine.Text = "Cine:";
            // 
            // cbo_puesto
            // 
            this.cbo_puesto.FormattingEnabled = true;
            this.cbo_puesto.Location = new System.Drawing.Point(515, 111);
            this.cbo_puesto.Name = "cbo_puesto";
            this.cbo_puesto.Size = new System.Drawing.Size(308, 21);
            this.cbo_puesto.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(432, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 46;
            this.label6.Text = "Puesto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(432, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 21);
            this.label5.TabIndex = 45;
            this.label5.Text = "Fecha de nacimiento:";
            // 
            // txt_nit
            // 
            this.txt_nit.Location = new System.Drawing.Point(515, 81);
            this.txt_nit.MaxLength = 10;
            this.txt_nit.Name = "txt_nit";
            this.txt_nit.Size = new System.Drawing.Size(308, 20);
            this.txt_nit.TabIndex = 44;
            this.txt_nit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nit_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(432, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 21);
            this.label4.TabIndex = 43;
            this.label4.Text = "NIT:";
            // 
            // txt_dpi
            // 
            this.txt_dpi.Location = new System.Drawing.Point(515, 49);
            this.txt_dpi.MaxLength = 13;
            this.txt_dpi.Name = "txt_dpi";
            this.txt_dpi.Size = new System.Drawing.Size(308, 20);
            this.txt_dpi.TabIndex = 42;
            this.txt_dpi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dpi_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(432, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 21);
            this.label3.TabIndex = 41;
            this.label3.Text = "DPI:";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(99, 114);
            this.txt_direccion.MaxLength = 20;
            this.txt_direccion.Multiline = true;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(308, 83);
            this.txt_direccion.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 39;
            this.label2.Text = "Dirección:";
            // 
            // txt_apellido2
            // 
            this.txt_apellido2.Location = new System.Drawing.Point(256, 78);
            this.txt_apellido2.Name = "txt_apellido2";
            this.txt_apellido2.Size = new System.Drawing.Size(151, 20);
            this.txt_apellido2.TabIndex = 38;
            this.txt_apellido2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellido2_KeyPress);
            // 
            // txt_apellido1
            // 
            this.txt_apellido1.Location = new System.Drawing.Point(99, 78);
            this.txt_apellido1.MaxLength = 20;
            this.txt_apellido1.Name = "txt_apellido1";
            this.txt_apellido1.Size = new System.Drawing.Size(151, 20);
            this.txt_apellido1.TabIndex = 37;
            this.txt_apellido1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellido1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 36;
            this.label1.Text = "Apellido:";
            // 
            // txt_nombre2
            // 
            this.txt_nombre2.Location = new System.Drawing.Point(256, 52);
            this.txt_nombre2.MaxLength = 20;
            this.txt_nombre2.Name = "txt_nombre2";
            this.txt_nombre2.Size = new System.Drawing.Size(151, 20);
            this.txt_nombre2.TabIndex = 35;
            this.txt_nombre2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre2_KeyPress);
            // 
            // txt_nombre1
            // 
            this.txt_nombre1.Location = new System.Drawing.Point(99, 52);
            this.txt_nombre1.MaxLength = 20;
            this.txt_nombre1.Name = "txt_nombre1";
            this.txt_nombre1.Size = new System.Drawing.Size(151, 20);
            this.txt_nombre1.TabIndex = 34;
            this.txt_nombre1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre1_KeyPress);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(16, 49);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(77, 21);
            this.lbl_nombre.TabIndex = 26;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_agregar
            // 
            this.lbl_agregar.AutoSize = true;
            this.lbl_agregar.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_agregar.Location = new System.Drawing.Point(287, 3);
            this.lbl_agregar.Name = "lbl_agregar";
            this.lbl_agregar.Size = new System.Drawing.Size(326, 36);
            this.lbl_agregar.TabIndex = 15;
            this.lbl_agregar.Text = "AGREGAR EMPLEADO";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.dtp_mod_fecha_nac);
            this.tabPage2.Controls.Add(this.cbo_mod_cine);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btn_buscarmod);
            this.tabPage2.Controls.Add(this.lbl_buscar);
            this.tabPage2.Controls.Add(this.txt_modificarbuscar);
            this.tabPage2.Controls.Add(this.btn_actualizar);
            this.tabPage2.Controls.Add(this.btn_mod_guardar);
            this.tabPage2.Controls.Add(this.dgv_emplados_modificar);
            this.tabPage2.Controls.Add(this.cbo_mod_puesto);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txt_mod_nit);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txt_mod_dpi);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txt_mod_direccion);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.txt_mod_apellido2);
            this.tabPage2.Controls.Add(this.txt_mod_apellido1);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.txt_mod_nombre2);
            this.tabPage2.Controls.Add(this.txt_mod_nombre1);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.lbl_mod);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(868, 358);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar empleado";
            // 
            // dtp_mod_fecha_nac
            // 
            this.dtp_mod_fecha_nac.CustomFormat = "yyyy--MM--dd";
            this.dtp_mod_fecha_nac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_mod_fecha_nac.Location = new System.Drawing.Point(640, 159);
            this.dtp_mod_fecha_nac.Name = "dtp_mod_fecha_nac";
            this.dtp_mod_fecha_nac.Size = new System.Drawing.Size(105, 20);
            this.dtp_mod_fecha_nac.TabIndex = 90;
            // 
            // cbo_mod_cine
            // 
            this.cbo_mod_cine.FormattingEnabled = true;
            this.cbo_mod_cine.Location = new System.Drawing.Point(543, 192);
            this.cbo_mod_cine.Name = "cbo_mod_cine";
            this.cbo_mod_cine.Size = new System.Drawing.Size(257, 21);
            this.cbo_mod_cine.TabIndex = 89;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(460, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 21);
            this.label7.TabIndex = 88;
            this.label7.Text = "Cine:";
            // 
            // btn_buscarmod
            // 
            this.btn_buscarmod.BackgroundImage = global::cinepolis.Properties.Resources.Zoom_icon;
            this.btn_buscarmod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscarmod.Location = new System.Drawing.Point(471, 224);
            this.btn_buscarmod.Name = "btn_buscarmod";
            this.btn_buscarmod.Size = new System.Drawing.Size(42, 48);
            this.btn_buscarmod.TabIndex = 87;
            this.toolTip1.SetToolTip(this.btn_buscarmod, "Buscar");
            this.btn_buscarmod.UseVisualStyleBackColor = true;
            this.btn_buscarmod.Click += new System.EventHandler(this.btn_buscarmod_Click);
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.Location = new System.Drawing.Point(91, 246);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(52, 16);
            this.lbl_buscar.TabIndex = 86;
            this.lbl_buscar.Text = "Buscar:";
            // 
            // txt_modificarbuscar
            // 
            this.txt_modificarbuscar.Location = new System.Drawing.Point(149, 246);
            this.txt_modificarbuscar.MaxLength = 20;
            this.txt_modificarbuscar.Name = "txt_modificarbuscar";
            this.txt_modificarbuscar.Size = new System.Drawing.Size(299, 20);
            this.txt_modificarbuscar.TabIndex = 85;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackgroundImage = global::cinepolis.Properties.Resources.Button_Refresh_icon;
            this.btn_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_actualizar.Location = new System.Drawing.Point(519, 224);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(48, 48);
            this.btn_actualizar.TabIndex = 84;
            this.toolTip1.SetToolTip(this.btn_actualizar, "Actualizar");
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_mod_guardar
            // 
            this.btn_mod_guardar.BackgroundImage = global::cinepolis.Properties.Resources.Save_icon;
            this.btn_mod_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_mod_guardar.Location = new System.Drawing.Point(573, 224);
            this.btn_mod_guardar.Name = "btn_mod_guardar";
            this.btn_mod_guardar.Size = new System.Drawing.Size(45, 50);
            this.btn_mod_guardar.TabIndex = 83;
            this.toolTip1.SetToolTip(this.btn_mod_guardar, "Reguardar");
            this.btn_mod_guardar.UseVisualStyleBackColor = true;
            this.btn_mod_guardar.Click += new System.EventHandler(this.btn_mod_guardar_Click);
            // 
            // dgv_emplados_modificar
            // 
            this.dgv_emplados_modificar.AllowUserToAddRows = false;
            this.dgv_emplados_modificar.AllowUserToDeleteRows = false;
            this.dgv_emplados_modificar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_emplados_modificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_emplados_modificar.Location = new System.Drawing.Point(6, 277);
            this.dgv_emplados_modificar.Name = "dgv_emplados_modificar";
            this.dgv_emplados_modificar.ReadOnly = true;
            this.dgv_emplados_modificar.Size = new System.Drawing.Size(845, 185);
            this.dgv_emplados_modificar.TabIndex = 72;
            // 
            // cbo_mod_puesto
            // 
            this.cbo_mod_puesto.FormattingEnabled = true;
            this.cbo_mod_puesto.Location = new System.Drawing.Point(543, 125);
            this.cbo_mod_puesto.Name = "cbo_mod_puesto";
            this.cbo_mod_puesto.Size = new System.Drawing.Size(264, 21);
            this.cbo_mod_puesto.TabIndex = 68;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(460, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 21);
            this.label9.TabIndex = 67;
            this.label9.Text = "Puesto:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(460, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 21);
            this.label10.TabIndex = 66;
            this.label10.Text = "Fecha de nacimiento:";
            // 
            // txt_mod_nit
            // 
            this.txt_mod_nit.Location = new System.Drawing.Point(543, 95);
            this.txt_mod_nit.MaxLength = 10;
            this.txt_mod_nit.Name = "txt_mod_nit";
            this.txt_mod_nit.Size = new System.Drawing.Size(264, 20);
            this.txt_mod_nit.TabIndex = 65;
            this.txt_mod_nit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mod_nit_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(460, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 21);
            this.label11.TabIndex = 64;
            this.label11.Text = "NIT:";
            // 
            // txt_mod_dpi
            // 
            this.txt_mod_dpi.Location = new System.Drawing.Point(543, 63);
            this.txt_mod_dpi.MaxLength = 13;
            this.txt_mod_dpi.Name = "txt_mod_dpi";
            this.txt_mod_dpi.Size = new System.Drawing.Size(264, 20);
            this.txt_mod_dpi.TabIndex = 63;
            this.txt_mod_dpi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mod_dpi_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(460, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 21);
            this.label12.TabIndex = 62;
            this.label12.Text = "DPI:";
            // 
            // txt_mod_direccion
            // 
            this.txt_mod_direccion.Location = new System.Drawing.Point(119, 128);
            this.txt_mod_direccion.MaxLength = 100;
            this.txt_mod_direccion.Multiline = true;
            this.txt_mod_direccion.Name = "txt_mod_direccion";
            this.txt_mod_direccion.Size = new System.Drawing.Size(308, 86);
            this.txt_mod_direccion.TabIndex = 61;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(27, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 21);
            this.label13.TabIndex = 60;
            this.label13.Text = "Dirección:";
            // 
            // txt_mod_apellido2
            // 
            this.txt_mod_apellido2.Location = new System.Drawing.Point(276, 92);
            this.txt_mod_apellido2.MaxLength = 20;
            this.txt_mod_apellido2.Name = "txt_mod_apellido2";
            this.txt_mod_apellido2.Size = new System.Drawing.Size(151, 20);
            this.txt_mod_apellido2.TabIndex = 59;
            this.txt_mod_apellido2.TextChanged += new System.EventHandler(this.txt_mod_apellido2_TextChanged);
            this.txt_mod_apellido2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mod_apellido2_KeyPress);
            // 
            // txt_mod_apellido1
            // 
            this.txt_mod_apellido1.Location = new System.Drawing.Point(119, 92);
            this.txt_mod_apellido1.MaxLength = 20;
            this.txt_mod_apellido1.Name = "txt_mod_apellido1";
            this.txt_mod_apellido1.Size = new System.Drawing.Size(151, 20);
            this.txt_mod_apellido1.TabIndex = 58;
            this.txt_mod_apellido1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mod_apellido1_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(36, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 21);
            this.label14.TabIndex = 57;
            this.label14.Text = "Apellido:";
            // 
            // txt_mod_nombre2
            // 
            this.txt_mod_nombre2.Location = new System.Drawing.Point(276, 66);
            this.txt_mod_nombre2.MaxLength = 20;
            this.txt_mod_nombre2.Name = "txt_mod_nombre2";
            this.txt_mod_nombre2.Size = new System.Drawing.Size(151, 20);
            this.txt_mod_nombre2.TabIndex = 56;
            this.txt_mod_nombre2.TextChanged += new System.EventHandler(this.textBox16_TextChanged);
            this.txt_mod_nombre2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mod_nombre2_KeyPress);
            // 
            // txt_mod_nombre1
            // 
            this.txt_mod_nombre1.Location = new System.Drawing.Point(119, 66);
            this.txt_mod_nombre1.MaxLength = 20;
            this.txt_mod_nombre1.Name = "txt_mod_nombre1";
            this.txt_mod_nombre1.Size = new System.Drawing.Size(151, 20);
            this.txt_mod_nombre1.TabIndex = 55;
            this.txt_mod_nombre1.TextChanged += new System.EventHandler(this.txt_mod_nombre1_TextChanged);
            this.txt_mod_nombre1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mod_nombre1_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(36, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 21);
            this.label15.TabIndex = 54;
            this.label15.Text = "Nombre:";
            // 
            // lbl_mod
            // 
            this.lbl_mod.AutoSize = true;
            this.lbl_mod.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mod.Location = new System.Drawing.Point(240, 14);
            this.lbl_mod.Name = "lbl_mod";
            this.lbl_mod.Size = new System.Drawing.Size(351, 36);
            this.lbl_mod.TabIndex = 18;
            this.lbl_mod.Text = "MODIFICAR EMPLEADO";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage3.Controls.Add(this.btn_borrar);
            this.tabPage3.Controls.Add(this.btn_buscar);
            this.tabPage3.Controls.Add(this.txt_buscar);
            this.tabPage3.Controls.Add(this.lbl_codigo_buscar);
            this.tabPage3.Controls.Add(this.dgv_buscar_empleado);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(868, 358);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Borrar empleado";
            // 
            // btn_borrar
            // 
            this.btn_borrar.BackgroundImage = global::cinepolis.Properties.Resources.File_Delete_icon;
            this.btn_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_borrar.Location = new System.Drawing.Point(704, 43);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(71, 52);
            this.btn_borrar.TabIndex = 27;
            this.toolTip1.SetToolTip(this.btn_borrar, "Eliminar");
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = global::cinepolis.Properties.Resources.Zoom_icon;
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.Location = new System.Drawing.Point(554, 43);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(78, 52);
            this.btn_buscar.TabIndex = 26;
            this.toolTip1.SetToolTip(this.btn_buscar, "Buscar");
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(233, 44);
            this.txt_buscar.MaxLength = 100;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(276, 20);
            this.txt_buscar.TabIndex = 25;
            // 
            // lbl_codigo_buscar
            // 
            this.lbl_codigo_buscar.AutoSize = true;
            this.lbl_codigo_buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo_buscar.Location = new System.Drawing.Point(63, 43);
            this.lbl_codigo_buscar.Name = "lbl_codigo_buscar";
            this.lbl_codigo_buscar.Size = new System.Drawing.Size(154, 21);
            this.lbl_codigo_buscar.TabIndex = 24;
            this.lbl_codigo_buscar.Text = "Codigo Busqueda:";
            // 
            // dgv_buscar_empleado
            // 
            this.dgv_buscar_empleado.AllowUserToAddRows = false;
            this.dgv_buscar_empleado.AllowUserToDeleteRows = false;
            this.dgv_buscar_empleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_buscar_empleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_buscar_empleado.Location = new System.Drawing.Point(22, 116);
            this.dgv_buscar_empleado.Name = "dgv_buscar_empleado";
            this.dgv_buscar_empleado.ReadOnly = true;
            this.dgv_buscar_empleado.Size = new System.Drawing.Size(825, 228);
            this.dgv_buscar_empleado.TabIndex = 23;
            // 
            // empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(900, 515);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbl_titulo_mantenimiento_cine);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.btn_cerrarsesion);
            this.Name = "empleado";
            this.Text = "empleado";
            this.Load += new System.EventHandler(this.empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emplados_modificar)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_buscar_empleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Button btn_cerrarsesion;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Label lbl_titulo_mantenimiento_cine;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbl_agregar;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_apellido2;
        private System.Windows.Forms.TextBox txt_apellido1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre2;
        private System.Windows.Forms.TextBox txt_nombre1;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_cine;
        private System.Windows.Forms.ComboBox cbo_puesto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_dpi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.DataGridView dgv_emplados_modificar;
        private System.Windows.Forms.ComboBox cbo_mod_puesto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_mod_nit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_mod_dpi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_mod_direccion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_mod_apellido2;
        private System.Windows.Forms.TextBox txt_mod_apellido1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_mod_nombre2;
        private System.Windows.Forms.TextBox txt_mod_nombre1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_mod;
        private System.Windows.Forms.Button btn_buscarmod;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.TextBox txt_modificarbuscar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_mod_guardar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label lbl_codigo_buscar;
        private System.Windows.Forms.DataGridView dgv_buscar_empleado;
        private System.Windows.Forms.ComboBox cbo_cine;
        private System.Windows.Forms.ComboBox cbo_mod_cine;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker dtp_fecha_nac;
        private System.Windows.Forms.DateTimePicker dtp_mod_fecha_nac;
    }
}