using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinepolis
{
    public partial class CR_ganancia : Form
    {
        string usu;
        public CR_ganancia(string usuario)
        {
            InitializeComponent();
            usu = usuario;
        }

        private void txt_regreso_reporte_pago_Click(object sender, EventArgs e)
        {
            this.Hide();
            reportes r = new reportes(usu);
            r.ShowDialog();
        }
    }
}
