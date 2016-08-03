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
    public partial class clasificacion : Form
    {
        public clasificacion()
        {
            InitializeComponent();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            mantenimiento r = new mantenimiento();
            r.ShowDialog();
        }

        private void tbc_clasificacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_titulo_mantenimiento_cine_Click(object sender, EventArgs e)
        {

        }
    }
}
