namespace proyectotaquilla
{
    partial class FPrincipal
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
            this.ltitulo = new System.Windows.Forms.Label();
            this.letiqueta1 = new System.Windows.Forms.Label();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbComplejo = new System.Windows.Forms.ComboBox();
            this.btnvercartelera = new System.Windows.Forms.Button();
            this.pBfoto2 = new System.Windows.Forms.PictureBox();
            this.pBfoto1 = new System.Windows.Forms.PictureBox();
            this.pBfoto3 = new System.Windows.Forms.PictureBox();
            this.pBfoto4 = new System.Windows.Forms.PictureBox();
            this.pBfoto5 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pBfoto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBfoto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBfoto3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBfoto4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBfoto5)).BeginInit();
            this.SuspendLayout();
            // 
            // ltitulo
            // 
            this.ltitulo.AutoSize = true;
            this.ltitulo.Font = new System.Drawing.Font("Century Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltitulo.Location = new System.Drawing.Point(330, 47);
            this.ltitulo.Name = "ltitulo";
            this.ltitulo.Padding = new System.Windows.Forms.Padding(5);
            this.ltitulo.Size = new System.Drawing.Size(164, 46);
            this.ltitulo.TabIndex = 0;
            this.ltitulo.Text = "Cinetopia";
            // 
            // letiqueta1
            // 
            this.letiqueta1.AutoSize = true;
            this.letiqueta1.Location = new System.Drawing.Point(248, 139);
            this.letiqueta1.Name = "letiqueta1";
            this.letiqueta1.Size = new System.Drawing.Size(333, 21);
            this.letiqueta1.TabIndex = 2;
            this.letiqueta1.Text = "Compra tus entradas facil y rapidamente";
            // 
            // cbRegion
            // 
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Items.AddRange(new object[] {
            "Zacapa, Guatemala",
            "Santa Rosa, Guatemala",
            "Guatemala, Guatemala"});
            this.cbRegion.Location = new System.Drawing.Point(197, 403);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(210, 29);
            this.cbRegion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecciona tu region";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Selecciona tu complejo";
            // 
            // cbComplejo
            // 
            this.cbComplejo.FormattingEnabled = true;
            this.cbComplejo.Items.AddRange(new object[] {
            "Miraflores",
            "Oakland Mall",
            "Cayala ",
            "Santa Clara"});
            this.cbComplejo.Location = new System.Drawing.Point(611, 403);
            this.cbComplejo.Name = "cbComplejo";
            this.cbComplejo.Size = new System.Drawing.Size(214, 29);
            this.cbComplejo.TabIndex = 6;
            // 
            // btnvercartelera
            // 
            this.btnvercartelera.BackColor = System.Drawing.Color.DarkCyan;
            this.btnvercartelera.ForeColor = System.Drawing.Color.White;
            this.btnvercartelera.Location = new System.Drawing.Point(336, 450);
            this.btnvercartelera.Name = "btnvercartelera";
            this.btnvercartelera.Size = new System.Drawing.Size(185, 34);
            this.btnvercartelera.TabIndex = 7;
            this.btnvercartelera.Text = "Ver Cartelera";
            this.btnvercartelera.UseVisualStyleBackColor = false;
            this.btnvercartelera.Click += new System.EventHandler(this.bvercartelera_Click);
            // 
            // pBfoto2
            // 
            this.pBfoto2.Image = global::proyectotaquilla.Properties.Resources.foto4;
            this.pBfoto2.Location = new System.Drawing.Point(95, 188);
            this.pBfoto2.Name = "pBfoto2";
            this.pBfoto2.Size = new System.Drawing.Size(684, 173);
            this.pBfoto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBfoto2.TabIndex = 8;
            this.pBfoto2.TabStop = false;
            // 
            // pBfoto1
            // 
            this.pBfoto1.Image = global::proyectotaquilla.Properties.Resources.logo2;
            this.pBfoto1.Location = new System.Drawing.Point(658, -4);
            this.pBfoto1.Name = "pBfoto1";
            this.pBfoto1.Size = new System.Drawing.Size(202, 164);
            this.pBfoto1.TabIndex = 1;
            this.pBfoto1.TabStop = false;
            // 
            // pBfoto3
            // 
            this.pBfoto3.Image = global::proyectotaquilla.Properties.Resources.foto3;
            this.pBfoto3.Location = new System.Drawing.Point(95, 188);
            this.pBfoto3.Name = "pBfoto3";
            this.pBfoto3.Size = new System.Drawing.Size(684, 173);
            this.pBfoto3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBfoto3.TabIndex = 9;
            this.pBfoto3.TabStop = false;
            // 
            // pBfoto4
            // 
            this.pBfoto4.Image = global::proyectotaquilla.Properties.Resources.foto2;
            this.pBfoto4.Location = new System.Drawing.Point(95, 188);
            this.pBfoto4.Name = "pBfoto4";
            this.pBfoto4.Size = new System.Drawing.Size(684, 173);
            this.pBfoto4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBfoto4.TabIndex = 10;
            this.pBfoto4.TabStop = false;
            // 
            // pBfoto5
            // 
            this.pBfoto5.Image = global::proyectotaquilla.Properties.Resources.foto1;
            this.pBfoto5.Location = new System.Drawing.Point(95, 188);
            this.pBfoto5.Name = "pBfoto5";
            this.pBfoto5.Size = new System.Drawing.Size(684, 173);
            this.pBfoto5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBfoto5.TabIndex = 11;
            this.pBfoto5.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(857, 496);
            this.Controls.Add(this.pBfoto5);
            this.Controls.Add(this.pBfoto4);
            this.Controls.Add(this.pBfoto3);
            this.Controls.Add(this.pBfoto2);
            this.Controls.Add(this.btnvercartelera);
            this.Controls.Add(this.cbComplejo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbRegion);
            this.Controls.Add(this.letiqueta1);
            this.Controls.Add(this.pBfoto1);
            this.Controls.Add(this.ltitulo);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FPrincipal";
            this.Load += new System.EventHandler(this.FPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBfoto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBfoto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBfoto3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBfoto4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBfoto5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ltitulo;
        private System.Windows.Forms.PictureBox pBfoto1;
        private System.Windows.Forms.Label letiqueta1;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbComplejo;
        private System.Windows.Forms.Button btnvercartelera;
        private System.Windows.Forms.PictureBox pBfoto2;
        private System.Windows.Forms.PictureBox pBfoto3;
        private System.Windows.Forms.PictureBox pBfoto4;
        private System.Windows.Forms.PictureBox pBfoto5;
        private System.Windows.Forms.Timer timer1;
    }
}

