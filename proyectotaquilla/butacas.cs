using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectotaquilla
{
    public partial class butacas : Form
    {
        public butacas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pago pago = new pago();
            this.Hide();
            pago.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkA2.CheckState == CheckState.Checked)
            {

                chkA2.BackgroundImage = proyectotaquilla.Properties.Resources.verde;
            }
            else
            {

                chkA2.BackgroundImage = proyectotaquilla.Properties.Resources.gris;

            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void butacas_Load(object sender, EventArgs e)
        {

        }
    }
}
