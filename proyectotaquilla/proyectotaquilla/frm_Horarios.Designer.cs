namespace proyectotaquilla
{
    partial class frm_Horarios
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
            this.lbltitulo1 = new System.Windows.Forms.Label();
            this.btn_sinopsis = new System.Windows.Forms.Button();
            this.cbo_Horario = new System.Windows.Forms.ComboBox();
            this.btn_seleboleto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltitulo1
            // 
            this.lbltitulo1.AutoSize = true;
            this.lbltitulo1.Location = new System.Drawing.Point(356, 38);
            this.lbltitulo1.Name = "lbltitulo1";
            this.lbltitulo1.Size = new System.Drawing.Size(0, 21);
            this.lbltitulo1.TabIndex = 44;
            // 
            // btn_sinopsis
            // 
            this.btn_sinopsis.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_sinopsis.Location = new System.Drawing.Point(135, 160);
            this.btn_sinopsis.Name = "btn_sinopsis";
            this.btn_sinopsis.Size = new System.Drawing.Size(113, 32);
            this.btn_sinopsis.TabIndex = 45;
            this.btn_sinopsis.Text = "Ver Sinopsis";
            this.btn_sinopsis.UseVisualStyleBackColor = false;
            this.btn_sinopsis.Click += new System.EventHandler(this.button4_Click);
            // 
            // cbo_Horario
            // 
            this.cbo_Horario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Horario.FormattingEnabled = true;
            this.cbo_Horario.Location = new System.Drawing.Point(104, 48);
            this.cbo_Horario.Name = "cbo_Horario";
            this.cbo_Horario.Size = new System.Drawing.Size(177, 29);
            this.cbo_Horario.TabIndex = 46;
            this.cbo_Horario.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_seleboleto
            // 
            this.btn_seleboleto.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_seleboleto.Location = new System.Drawing.Point(114, 110);
            this.btn_seleboleto.Name = "btn_seleboleto";
            this.btn_seleboleto.Size = new System.Drawing.Size(157, 32);
            this.btn_seleboleto.TabIndex = 47;
            this.btn_seleboleto.Text = "Reservar boletos";
            this.btn_seleboleto.UseVisualStyleBackColor = false;
            this.btn_seleboleto.Click += new System.EventHandler(this.btn_seleboleto_Click);
            // 
            // frm_Horarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(384, 253);
            this.Controls.Add(this.btn_seleboleto);
            this.Controls.Add(this.cbo_Horario);
            this.Controls.Add(this.btn_sinopsis);
            this.Controls.Add(this.lbltitulo1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_Horarios";
            this.Text = "frm_Horarios";
            this.Load += new System.EventHandler(this.frm_Horarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbltitulo1;
        private System.Windows.Forms.Button btn_sinopsis;
        private System.Windows.Forms.ComboBox cbo_Horario;
        private System.Windows.Forms.Button btn_seleboleto;
    }
}