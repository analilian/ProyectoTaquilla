namespace cinepolis
{
    partial class CR_tarjeta_puntos
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.puntos_cliente1 = new cinepolis.puntos_cliente();
            this.txt_regreso_reporte_puntos = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.puntos_cliente1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1006, 508);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // txt_regreso_reporte_puntos
            // 
            this.txt_regreso_reporte_puntos.BackgroundImage = global::cinepolis.Properties.Resources.Button_Previous_icon;
            this.txt_regreso_reporte_puntos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_regreso_reporte_puntos.FlatAppearance.BorderSize = 0;
            this.txt_regreso_reporte_puntos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_regreso_reporte_puntos.Location = new System.Drawing.Point(500, 5);
            this.txt_regreso_reporte_puntos.Name = "txt_regreso_reporte_puntos";
            this.txt_regreso_reporte_puntos.Size = new System.Drawing.Size(28, 23);
            this.txt_regreso_reporte_puntos.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txt_regreso_reporte_puntos, "Regresar");
            this.txt_regreso_reporte_puntos.UseVisualStyleBackColor = true;
            this.txt_regreso_reporte_puntos.Click += new System.EventHandler(this.txt_regreso_reporte_puntos_Click);
            // 
            // CR_tarjeta_puntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 508);
            this.Controls.Add(this.txt_regreso_reporte_puntos);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "CR_tarjeta_puntos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CR_tarjeta_puntos";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private puntos_cliente puntos_cliente1;
        private System.Windows.Forms.Button txt_regreso_reporte_puntos;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}