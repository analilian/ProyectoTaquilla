namespace cinepolis
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_iniciosesion = new System.Windows.Forms.Label();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.pic_usuario = new System.Windows.Forms.PictureBox();
            this.btn_iniciosesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_usuario.Location = new System.Drawing.Point(128, 232);
            this.txt_usuario.MaxLength = 100;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(321, 20);
            this.txt_usuario.TabIndex = 0;
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_pass.Location = new System.Drawing.Point(128, 258);
            this.txt_pass.MaxLength = 20;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(321, 20);
            this.txt_pass.TabIndex = 1;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(38, 235);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(59, 13);
            this.lbl_usuario.TabIndex = 3;
            this.lbl_usuario.Text = "USUARIO:";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(38, 265);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(84, 13);
            this.lbl_pass.TabIndex = 4;
            this.lbl_pass.Text = "CONTRASEÑA:";
            // 
            // lbl_iniciosesion
            // 
            this.lbl_iniciosesion.AutoSize = true;
            this.lbl_iniciosesion.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_iniciosesion.Location = new System.Drawing.Point(52, 9);
            this.lbl_iniciosesion.Name = "lbl_iniciosesion";
            this.lbl_iniciosesion.Size = new System.Drawing.Size(434, 54);
            this.lbl_iniciosesion.TabIndex = 6;
            this.lbl_iniciosesion.Text = "INICIO DE SESIÓN";
            // 
            // pic_logo
            // 
            this.pic_logo.BackgroundImage = global::cinepolis.Properties.Resources._13672487_10208834486171149_1624040466_n;
            this.pic_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_logo.Location = new System.Drawing.Point(492, 9);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(55, 48);
            this.pic_logo.TabIndex = 7;
            this.pic_logo.TabStop = false;
            // 
            // pic_usuario
            // 
            this.pic_usuario.BackgroundImage = global::cinepolis.Properties.Resources.usuario_1;
            this.pic_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_usuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_usuario.Location = new System.Drawing.Point(201, 66);
            this.pic_usuario.Name = "pic_usuario";
            this.pic_usuario.Size = new System.Drawing.Size(171, 134);
            this.pic_usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_usuario.TabIndex = 5;
            this.pic_usuario.TabStop = false;
            // 
            // btn_iniciosesion
            // 
            this.btn_iniciosesion.BackgroundImage = global::cinepolis.Properties.Resources.inicio_de_sesion;
            this.btn_iniciosesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_iniciosesion.Location = new System.Drawing.Point(173, 322);
            this.btn_iniciosesion.Name = "btn_iniciosesion";
            this.btn_iniciosesion.Size = new System.Drawing.Size(199, 48);
            this.btn_iniciosesion.TabIndex = 2;
            this.btn_iniciosesion.UseVisualStyleBackColor = true;
            this.btn_iniciosesion.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(556, 406);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.lbl_iniciosesion);
            this.Controls.Add(this.pic_usuario);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.btn_iniciosesion);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_usuario);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_usuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button btn_iniciosesion;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_iniciosesion;
        private System.Windows.Forms.PictureBox pic_usuario;
        private System.Windows.Forms.PictureBox pic_logo;
    }
}

