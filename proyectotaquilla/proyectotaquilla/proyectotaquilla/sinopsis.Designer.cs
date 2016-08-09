namespace proyectotaquilla
{
    partial class sinopsis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sinopsis));
            this.pBpelicula = new System.Windows.Forms.PictureBox();
            this.lDescripcion = new System.Windows.Forms.Label();
            this.sfLink = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBpelicula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfLink)).BeginInit();
            this.SuspendLayout();
            // 
            // pBpelicula
            // 
            this.pBpelicula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBpelicula.Image = global::proyectotaquilla.Properties.Resources.peli1;
            this.pBpelicula.Location = new System.Drawing.Point(40, 129);
            this.pBpelicula.Name = "pBpelicula";
            this.pBpelicula.Size = new System.Drawing.Size(180, 257);
            this.pBpelicula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBpelicula.TabIndex = 0;
            this.pBpelicula.TabStop = false;
            this.pBpelicula.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lDescripcion
            // 
            this.lDescripcion.AutoSize = true;
            this.lDescripcion.ForeColor = System.Drawing.Color.White;
            this.lDescripcion.Location = new System.Drawing.Point(250, 40);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(514, 210);
            this.lDescripcion.TabIndex = 1;
            this.lDescripcion.Text = resources.GetString("lDescripcion.Text");
            // 
            // sfLink
            // 
            this.sfLink.Enabled = true;
            this.sfLink.Location = new System.Drawing.Point(298, 291);
            this.sfLink.Name = "sfLink";
            this.sfLink.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("sfLink.OcxState")));
            this.sfLink.Size = new System.Drawing.Size(434, 216);
            this.sfLink.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(80, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Regresar ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sinopsis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(841, 552);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sfLink);
            this.Controls.Add(this.lDescripcion);
            this.Controls.Add(this.pBpelicula);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "sinopsis";
            this.Text = "sinopsis";
            ((System.ComponentModel.ISupportInitialize)(this.pBpelicula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfLink)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBpelicula;
        private System.Windows.Forms.Label lDescripcion;
        private AxShockwaveFlashObjects.AxShockwaveFlash sfLink;
        private System.Windows.Forms.Button button1;
    }
}