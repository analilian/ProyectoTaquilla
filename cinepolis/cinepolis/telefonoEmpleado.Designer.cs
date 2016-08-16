namespace cinepolis
{
    partial class telefonoEmpleado
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_desactivar = new System.Windows.Forms.Button();
            this.txt_buscarmod = new System.Windows.Forms.TextBox();
            this.btn_activar = new System.Windows.Forms.Button();
            this.lbl_codigo_buscar = new System.Windows.Forms.Label();
            this.btn_eliminar_proyeccion = new System.Windows.Forms.Button();
            this.btn_buscar_proyeccion = new System.Windows.Forms.Button();
            this.bttn_actualizar_proyeccion = new System.Windows.Forms.Button();
            this.btn_guardar_proyeccion = new System.Windows.Forms.Button();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.dgv_telefono = new System.Windows.Forms.DataGridView();
            this.txt_nom_proy = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_eliminar_tel_emp = new System.Windows.Forms.Button();
            this.dgv_Tel_emp = new System.Windows.Forms.DataGridView();
            this.btn_tel_emp = new System.Windows.Forms.Button();
            this.lbl_empleado = new System.Windows.Forms.Label();
            this.cbo_empleado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_lista_num = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgv_tel_cliente = new System.Windows.Forms.DataGridView();
            this.btn_tel_cliente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_cliente = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_lista_num3 = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_eliminar_tel_cine = new System.Windows.Forms.Button();
            this.dgv_tel_cine = new System.Windows.Forms.DataGridView();
            this.btn_tel_cine = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_cine = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_lista_num2 = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_regresar = new System.Windows.Forms.Button();
            this.lbl_titulo_mantenimiento_cine = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_telefono)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tel_emp)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tel_cliente)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tel_cine)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(651, 362);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btn_desactivar);
            this.tabPage1.Controls.Add(this.txt_buscarmod);
            this.tabPage1.Controls.Add(this.btn_activar);
            this.tabPage1.Controls.Add(this.lbl_codigo_buscar);
            this.tabPage1.Controls.Add(this.btn_eliminar_proyeccion);
            this.tabPage1.Controls.Add(this.btn_buscar_proyeccion);
            this.tabPage1.Controls.Add(this.bttn_actualizar_proyeccion);
            this.tabPage1.Controls.Add(this.btn_guardar_proyeccion);
            this.tabPage1.Controls.Add(this.lbl_Telefono);
            this.tabPage1.Controls.Add(this.dgv_telefono);
            this.tabPage1.Controls.Add(this.txt_nom_proy);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(643, 336);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mantenimiento de Telefono";
            // 
            // btn_desactivar
            // 
            this.btn_desactivar.BackgroundImage = global::cinepolis.Properties.Resources.Button_Close_icon;
            this.btn_desactivar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_desactivar.Location = new System.Drawing.Point(322, 6);
            this.btn_desactivar.Name = "btn_desactivar";
            this.btn_desactivar.Size = new System.Drawing.Size(65, 65);
            this.btn_desactivar.TabIndex = 102;
            this.toolTip1.SetToolTip(this.btn_desactivar, "Desactivar Iconos y Celdas");
            this.btn_desactivar.UseVisualStyleBackColor = true;
            this.btn_desactivar.Click += new System.EventHandler(this.btn_desactivar_Click);
            // 
            // txt_buscarmod
            // 
            this.txt_buscarmod.Location = new System.Drawing.Point(77, 139);
            this.txt_buscarmod.MaxLength = 100;
            this.txt_buscarmod.Name = "txt_buscarmod";
            this.txt_buscarmod.Size = new System.Drawing.Size(220, 20);
            this.txt_buscarmod.TabIndex = 100;
            this.txt_buscarmod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buscarmod_KeyPress);
            // 
            // btn_activar
            // 
            this.btn_activar.BackgroundImage = global::cinepolis.Properties.Resources.File_New_icon;
            this.btn_activar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_activar.Location = new System.Drawing.Point(258, 6);
            this.btn_activar.Name = "btn_activar";
            this.btn_activar.Size = new System.Drawing.Size(65, 65);
            this.btn_activar.TabIndex = 101;
            this.toolTip1.SetToolTip(this.btn_activar, "Activar Iconos y Celdas");
            this.btn_activar.UseVisualStyleBackColor = true;
            this.btn_activar.Click += new System.EventHandler(this.btn_activar_Click);
            // 
            // lbl_codigo_buscar
            // 
            this.lbl_codigo_buscar.AutoSize = true;
            this.lbl_codigo_buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo_buscar.Location = new System.Drawing.Point(6, 139);
            this.lbl_codigo_buscar.Name = "lbl_codigo_buscar";
            this.lbl_codigo_buscar.Size = new System.Drawing.Size(65, 21);
            this.lbl_codigo_buscar.TabIndex = 99;
            this.lbl_codigo_buscar.Text = "Buscar:";
            // 
            // btn_eliminar_proyeccion
            // 
            this.btn_eliminar_proyeccion.BackgroundImage = global::cinepolis.Properties.Resources.File_Delete_icon;
            this.btn_eliminar_proyeccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar_proyeccion.Location = new System.Drawing.Point(576, 5);
            this.btn_eliminar_proyeccion.Name = "btn_eliminar_proyeccion";
            this.btn_eliminar_proyeccion.Size = new System.Drawing.Size(65, 65);
            this.btn_eliminar_proyeccion.TabIndex = 96;
            this.toolTip1.SetToolTip(this.btn_eliminar_proyeccion, "Eliminar");
            this.btn_eliminar_proyeccion.UseVisualStyleBackColor = true;
            // 
            // btn_buscar_proyeccion
            // 
            this.btn_buscar_proyeccion.BackgroundImage = global::cinepolis.Properties.Resources.Zoom_icon;
            this.btn_buscar_proyeccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_proyeccion.Location = new System.Drawing.Point(385, 6);
            this.btn_buscar_proyeccion.Name = "btn_buscar_proyeccion";
            this.btn_buscar_proyeccion.Size = new System.Drawing.Size(65, 65);
            this.btn_buscar_proyeccion.TabIndex = 98;
            this.toolTip1.SetToolTip(this.btn_buscar_proyeccion, "Buscar");
            this.btn_buscar_proyeccion.UseVisualStyleBackColor = true;
            // 
            // bttn_actualizar_proyeccion
            // 
            this.bttn_actualizar_proyeccion.BackgroundImage = global::cinepolis.Properties.Resources.Button_Refresh_icon;
            this.bttn_actualizar_proyeccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_actualizar_proyeccion.Location = new System.Drawing.Point(449, 5);
            this.bttn_actualizar_proyeccion.Name = "bttn_actualizar_proyeccion";
            this.bttn_actualizar_proyeccion.Size = new System.Drawing.Size(65, 65);
            this.bttn_actualizar_proyeccion.TabIndex = 97;
            this.toolTip1.SetToolTip(this.bttn_actualizar_proyeccion, "Modificar");
            this.bttn_actualizar_proyeccion.UseVisualStyleBackColor = true;
            this.bttn_actualizar_proyeccion.Click += new System.EventHandler(this.bttn_actualizar_proyeccion_Click);
            // 
            // btn_guardar_proyeccion
            // 
            this.btn_guardar_proyeccion.BackgroundImage = global::cinepolis.Properties.Resources.Save_icon;
            this.btn_guardar_proyeccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar_proyeccion.Location = new System.Drawing.Point(513, 6);
            this.btn_guardar_proyeccion.Name = "btn_guardar_proyeccion";
            this.btn_guardar_proyeccion.Size = new System.Drawing.Size(65, 65);
            this.btn_guardar_proyeccion.TabIndex = 95;
            this.toolTip1.SetToolTip(this.btn_guardar_proyeccion, "Guardar");
            this.btn_guardar_proyeccion.UseVisualStyleBackColor = true;
            this.btn_guardar_proyeccion.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Telefono.Location = new System.Drawing.Point(6, 97);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(80, 21);
            this.lbl_Telefono.TabIndex = 75;
            this.lbl_Telefono.Text = "Teléfono:";
            // 
            // dgv_telefono
            // 
            this.dgv_telefono.AllowUserToAddRows = false;
            this.dgv_telefono.AllowUserToDeleteRows = false;
            this.dgv_telefono.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_telefono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_telefono.Location = new System.Drawing.Point(3, 163);
            this.dgv_telefono.Name = "dgv_telefono";
            this.dgv_telefono.ReadOnly = true;
            this.dgv_telefono.Size = new System.Drawing.Size(626, 167);
            this.dgv_telefono.TabIndex = 74;
            // 
            // txt_nom_proy
            // 
            this.txt_nom_proy.Location = new System.Drawing.Point(89, 97);
            this.txt_nom_proy.MaxLength = 8;
            this.txt_nom_proy.Name = "txt_nom_proy";
            this.txt_nom_proy.Size = new System.Drawing.Size(197, 20);
            this.txt_nom_proy.TabIndex = 0;
            this.txt_nom_proy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nom_proy_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.btn_eliminar_tel_emp);
            this.tabPage2.Controls.Add(this.dgv_Tel_emp);
            this.tabPage2.Controls.Add(this.btn_tel_emp);
            this.tabPage2.Controls.Add(this.lbl_empleado);
            this.tabPage2.Controls.Add(this.cbo_empleado);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cbo_lista_num);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(643, 336);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Asignar telefono-Empleado";
            // 
            // btn_eliminar_tel_emp
            // 
            this.btn_eliminar_tel_emp.BackgroundImage = global::cinepolis.Properties.Resources.File_Delete_icon;
            this.btn_eliminar_tel_emp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar_tel_emp.Location = new System.Drawing.Point(439, 27);
            this.btn_eliminar_tel_emp.Name = "btn_eliminar_tel_emp";
            this.btn_eliminar_tel_emp.Size = new System.Drawing.Size(61, 55);
            this.btn_eliminar_tel_emp.TabIndex = 106;
            this.toolTip1.SetToolTip(this.btn_eliminar_tel_emp, "Eliminar");
            this.btn_eliminar_tel_emp.UseVisualStyleBackColor = true;
            this.btn_eliminar_tel_emp.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dgv_Tel_emp
            // 
            this.dgv_Tel_emp.AllowUserToAddRows = false;
            this.dgv_Tel_emp.AllowUserToDeleteRows = false;
            this.dgv_Tel_emp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Tel_emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Tel_emp.Location = new System.Drawing.Point(26, 116);
            this.dgv_Tel_emp.Name = "dgv_Tel_emp";
            this.dgv_Tel_emp.ReadOnly = true;
            this.dgv_Tel_emp.Size = new System.Drawing.Size(594, 177);
            this.dgv_Tel_emp.TabIndex = 105;
            // 
            // btn_tel_emp
            // 
            this.btn_tel_emp.BackgroundImage = global::cinepolis.Properties.Resources.Button_Add_icon;
            this.btn_tel_emp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_tel_emp.Location = new System.Drawing.Point(506, 27);
            this.btn_tel_emp.Name = "btn_tel_emp";
            this.btn_tel_emp.Size = new System.Drawing.Size(61, 55);
            this.btn_tel_emp.TabIndex = 99;
            this.toolTip1.SetToolTip(this.btn_tel_emp, "Agregar Telefono a un Empleado");
            this.btn_tel_emp.UseVisualStyleBackColor = true;
            this.btn_tel_emp.Click += new System.EventHandler(this.btn_tel_emp_Click);
            // 
            // lbl_empleado
            // 
            this.lbl_empleado.AutoSize = true;
            this.lbl_empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empleado.Location = new System.Drawing.Point(222, 27);
            this.lbl_empleado.Name = "lbl_empleado";
            this.lbl_empleado.Size = new System.Drawing.Size(94, 21);
            this.lbl_empleado.TabIndex = 78;
            this.lbl_empleado.Text = "Empleado:";
            // 
            // cbo_empleado
            // 
            this.cbo_empleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_empleado.FormattingEnabled = true;
            this.cbo_empleado.Location = new System.Drawing.Point(226, 51);
            this.cbo_empleado.Name = "cbo_empleado";
            this.cbo_empleado.Size = new System.Drawing.Size(132, 21);
            this.cbo_empleado.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 76;
            this.label1.Text = "Teléfono:";
            // 
            // cbo_lista_num
            // 
            this.cbo_lista_num.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_lista_num.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_lista_num.FormattingEnabled = true;
            this.cbo_lista_num.Location = new System.Drawing.Point(56, 51);
            this.cbo_lista_num.Name = "cbo_lista_num";
            this.cbo_lista_num.Size = new System.Drawing.Size(132, 21);
            this.cbo_lista_num.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage3.Controls.Add(this.dgv_tel_cliente);
            this.tabPage3.Controls.Add(this.btn_tel_cliente);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.cbo_cliente);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.cbo_lista_num3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(643, 336);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Asignar telefono-Cliente";
            // 
            // dgv_tel_cliente
            // 
            this.dgv_tel_cliente.AllowUserToAddRows = false;
            this.dgv_tel_cliente.AllowUserToDeleteRows = false;
            this.dgv_tel_cliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tel_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tel_cliente.Location = new System.Drawing.Point(24, 101);
            this.dgv_tel_cliente.Name = "dgv_tel_cliente";
            this.dgv_tel_cliente.ReadOnly = true;
            this.dgv_tel_cliente.Size = new System.Drawing.Size(594, 191);
            this.dgv_tel_cliente.TabIndex = 116;
            // 
            // btn_tel_cliente
            // 
            this.btn_tel_cliente.BackgroundImage = global::cinepolis.Properties.Resources.Button_Add_icon;
            this.btn_tel_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_tel_cliente.Location = new System.Drawing.Point(504, 27);
            this.btn_tel_cliente.Name = "btn_tel_cliente";
            this.btn_tel_cliente.Size = new System.Drawing.Size(61, 55);
            this.btn_tel_cliente.TabIndex = 115;
            this.toolTip1.SetToolTip(this.btn_tel_cliente, "Agregar Telefono a un Empleado");
            this.btn_tel_cliente.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(218, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 114;
            this.label4.Text = "Cliente:";
            // 
            // cbo_cliente
            // 
            this.cbo_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_cliente.FormattingEnabled = true;
            this.cbo_cliente.Location = new System.Drawing.Point(222, 51);
            this.cbo_cliente.Name = "cbo_cliente";
            this.cbo_cliente.Size = new System.Drawing.Size(132, 21);
            this.cbo_cliente.TabIndex = 113;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 112;
            this.label5.Text = "Teléfono:";
            // 
            // cbo_lista_num3
            // 
            this.cbo_lista_num3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_lista_num3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_lista_num3.FormattingEnabled = true;
            this.cbo_lista_num3.Location = new System.Drawing.Point(52, 51);
            this.cbo_lista_num3.Name = "cbo_lista_num3";
            this.cbo_lista_num3.Size = new System.Drawing.Size(132, 21);
            this.cbo_lista_num3.TabIndex = 111;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage4.Controls.Add(this.btn_eliminar_tel_cine);
            this.tabPage4.Controls.Add(this.dgv_tel_cine);
            this.tabPage4.Controls.Add(this.btn_tel_cine);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.cbo_cine);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.cbo_lista_num2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(643, 336);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Asignar telefono-Cine";
            // 
            // btn_eliminar_tel_cine
            // 
            this.btn_eliminar_tel_cine.BackgroundImage = global::cinepolis.Properties.Resources.File_Delete_icon;
            this.btn_eliminar_tel_cine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar_tel_cine.Location = new System.Drawing.Point(429, 22);
            this.btn_eliminar_tel_cine.Name = "btn_eliminar_tel_cine";
            this.btn_eliminar_tel_cine.Size = new System.Drawing.Size(61, 55);
            this.btn_eliminar_tel_cine.TabIndex = 111;
            this.toolTip1.SetToolTip(this.btn_eliminar_tel_cine, "Eliminar");
            this.btn_eliminar_tel_cine.UseVisualStyleBackColor = true;
            this.btn_eliminar_tel_cine.Click += new System.EventHandler(this.btn_eliminar_tel_cine_Click);
            // 
            // dgv_tel_cine
            // 
            this.dgv_tel_cine.AllowUserToAddRows = false;
            this.dgv_tel_cine.AllowUserToDeleteRows = false;
            this.dgv_tel_cine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tel_cine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tel_cine.Location = new System.Drawing.Point(20, 111);
            this.dgv_tel_cine.Name = "dgv_tel_cine";
            this.dgv_tel_cine.ReadOnly = true;
            this.dgv_tel_cine.Size = new System.Drawing.Size(594, 177);
            this.dgv_tel_cine.TabIndex = 110;
            // 
            // btn_tel_cine
            // 
            this.btn_tel_cine.BackgroundImage = global::cinepolis.Properties.Resources.Button_Add_icon;
            this.btn_tel_cine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_tel_cine.Location = new System.Drawing.Point(496, 22);
            this.btn_tel_cine.Name = "btn_tel_cine";
            this.btn_tel_cine.Size = new System.Drawing.Size(61, 55);
            this.btn_tel_cine.TabIndex = 109;
            this.toolTip1.SetToolTip(this.btn_tel_cine, "Agregar Telefono a un Empleado");
            this.btn_tel_cine.UseVisualStyleBackColor = true;
            this.btn_tel_cine.Click += new System.EventHandler(this.btn_tel_cine_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 108;
            this.label2.Text = "Cine:";
            // 
            // cbo_cine
            // 
            this.cbo_cine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_cine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_cine.FormattingEnabled = true;
            this.cbo_cine.Location = new System.Drawing.Point(214, 46);
            this.cbo_cine.Name = "cbo_cine";
            this.cbo_cine.Size = new System.Drawing.Size(132, 21);
            this.cbo_cine.TabIndex = 107;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 106;
            this.label3.Text = "Teléfono:";
            // 
            // cbo_lista_num2
            // 
            this.cbo_lista_num2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_lista_num2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_lista_num2.FormattingEnabled = true;
            this.cbo_lista_num2.Location = new System.Drawing.Point(44, 46);
            this.cbo_lista_num2.Name = "cbo_lista_num2";
            this.cbo_lista_num2.Size = new System.Drawing.Size(132, 21);
            this.cbo_lista_num2.TabIndex = 105;
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
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click_1);
            // 
            // lbl_titulo_mantenimiento_cine
            // 
            this.lbl_titulo_mantenimiento_cine.AutoSize = true;
            this.lbl_titulo_mantenimiento_cine.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_mantenimiento_cine.Location = new System.Drawing.Point(120, 16);
            this.lbl_titulo_mantenimiento_cine.Name = "lbl_titulo_mantenimiento_cine";
            this.lbl_titulo_mantenimiento_cine.Size = new System.Drawing.Size(453, 36);
            this.lbl_titulo_mantenimiento_cine.TabIndex = 56;
            this.lbl_titulo_mantenimiento_cine.Text = "MANTENIMIENTO DE TELÉFONO";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::cinepolis.Properties.Resources.Button_Refresh_icon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(195, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 65);
            this.button1.TabIndex = 103;
            this.toolTip1.SetToolTip(this.button1, "Actualizar");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // telefonoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(671, 432);
            this.Controls.Add(this.lbl_titulo_mantenimiento_cine);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "telefonoEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "telefonoEmpleado";
            this.Load += new System.EventHandler(this.telefonoEmpleado_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_telefono)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tel_emp)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tel_cliente)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tel_cine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_nom_proy;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.DataGridView dgv_telefono;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.Label lbl_titulo_mantenimiento_cine;
        private System.Windows.Forms.Button btn_eliminar_proyeccion;
        private System.Windows.Forms.Button btn_buscar_proyeccion;
        private System.Windows.Forms.Button bttn_actualizar_proyeccion;
        private System.Windows.Forms.Button btn_guardar_proyeccion;
        private System.Windows.Forms.TextBox txt_buscarmod;
        private System.Windows.Forms.Label lbl_codigo_buscar;
        private System.Windows.Forms.DataGridView dgv_Tel_emp;
        private System.Windows.Forms.Button btn_tel_emp;
        private System.Windows.Forms.Label lbl_empleado;
        private System.Windows.Forms.ComboBox cbo_empleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_lista_num;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgv_tel_cliente;
        private System.Windows.Forms.Button btn_tel_cliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_cliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_lista_num3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_tel_cine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_cine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_lista_num2;
        private System.Windows.Forms.DataGridView dgv_tel_cine;
        private System.Windows.Forms.Button btn_eliminar_tel_emp;
        private System.Windows.Forms.Button btn_eliminar_tel_cine;
        private System.Windows.Forms.Button btn_desactivar;
        private System.Windows.Forms.Button btn_activar;
        private System.Windows.Forms.Button button1;
    }
}