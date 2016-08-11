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
        
        }

        private void btnIraPago_Click(object sender, EventArgs e)
        {
            pago pago = new pago();
            this.Hide();
            pago.ShowDialog();
        }

        public double precio = 0;
        public double total = 0;

        public void tipo_de_boleto()
        {
           
            if (rbdAdulto.Checked)
            {
                precio = 37;
                lblValorTotal.Text = precio.ToString();
            }
            else
                if (rbdNiño.Checked)
                {

                    precio = 27;
                    lblValorTotal.Text = precio.ToString();
                }
                else
                    if (rdbTerceraEdad.Checked) { 
                        precio = 25;
                        lblValorTotal.Text = precio.ToString();
                    }
                    else {
                        precio = 0; 
                    }

            
        }
        private void chkA1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkA1.Checked)
            {

                chkA1.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkA1. BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkA2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkA2.Checked)
            {

                chkA2.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkA2.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkA3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkA3.Checked)
            {

                chkA3.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkA3.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkA4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkA4.Checked)
            {

                chkA4.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkA4.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkA5_CheckedChanged(object sender, EventArgs e)
        {
            if (chkA5.Checked)
            {

                chkA5.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkA5.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkA6_CheckedChanged(object sender, EventArgs e)
        {
            if (chkA6.Checked)
            {

                chkA6.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkA6.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkA7_CheckedChanged(object sender, EventArgs e)
        {
            if (chkA7.Checked)
            {

                chkA7.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkA7.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkA8_CheckedChanged(object sender, EventArgs e)
        {
            if (chkA8.Checked)
            {

                chkA8.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkA8.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkA9_CheckedChanged(object sender, EventArgs e)
        {
            if (chkA9.Checked)
            {

                chkA9.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkA9.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkB1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB1.Checked)
            {

                chkB1.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkB1.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkB2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB2.Checked)
            {

                chkB2.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkB2.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkB3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB3.Checked)
            {

                chkB3.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkB3.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkB4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB4.Checked)
            {

                chkB4.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkB4.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkB5_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB5.Checked)
            {

                chkB5.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkB5.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkB6_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB6.Checked)
            {

                chkB6.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkB6.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkB7_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB7.Checked)
            {

                chkB7.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkB7.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkB8_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB8.Checked)
            {

                chkB8.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkB8.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkB9_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB9.Checked)
            {

                chkB9.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkB9.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkC1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkC1.Checked)
            {

                chkC1.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkC1.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkC2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkC2.Checked)
            {

                chkC2.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkC2.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkC3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkC3.Checked)
            {

                chkC3.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkC3.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkC4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkC4.Checked)
            {

                chkC4.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkC4.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkC5_CheckedChanged(object sender, EventArgs e)
        {
            if (chkC5.Checked)
            {

                chkC5.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkC5.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkC6_CheckedChanged(object sender, EventArgs e)
        {
            if (chkC6.Checked)
            {

                chkC6.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkC6.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkC7_CheckedChanged(object sender, EventArgs e)
        {
            if (chkC7.Checked)
            {

                chkC7.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkC7.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkC8_CheckedChanged(object sender, EventArgs e)
        {
            if (chkC8.Checked)
            {

                chkC8.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkC8.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkC9_CheckedChanged(object sender, EventArgs e)
        {
            if (chkC9.Checked)
            {

                chkC9.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkC9.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkD1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkD1.Checked)
            {

                chkD1.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkD1.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkD2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkD2.Checked)
            {

                chkD2.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkD2.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkD3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkD3.Checked)
            {

                chkD3.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkD3.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkD4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkD4.Checked)
            {

                chkD4.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkD4.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkD5_CheckedChanged(object sender, EventArgs e)
        {
            if (chkD5.Checked)
            {

                chkD5.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkD5.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkD6_CheckedChanged(object sender, EventArgs e)
        {
            if (chkD6.Checked)
            {

                chkD6.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkD6.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkD7_CheckedChanged(object sender, EventArgs e)
        {
            if (chkD7.Checked)
            {

                chkD7.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkD7.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkD8_CheckedChanged(object sender, EventArgs e)
        {
            if (chkD8.Checked)
            {

                chkD8.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkD8.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkD9_CheckedChanged(object sender, EventArgs e)
        {
            if (chkD9.Checked)
            {

                chkD9.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkD9.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkE1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkE1.Checked)
            {

                chkE1.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkE1.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkE2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkE2.Checked)
            {

                chkE2.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkE2.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkE3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkE3.Checked)
            {

                chkE3.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkE3.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkE4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkE4.Checked)
            {

                chkE4.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkE4.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkE5_CheckedChanged(object sender, EventArgs e)
        {
            if (chkE5.Checked)
            {

                chkE5.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkE5.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkE6_CheckedChanged(object sender, EventArgs e)
        {
            if (chkE6.Checked)
            {

                chkE6.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkE6.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkE7_CheckedChanged(object sender, EventArgs e)
        {
            if (chkE7.Checked)
            {

                chkE7.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkE7.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkE8_CheckedChanged(object sender, EventArgs e)
        {
            if (chkE8.Checked)
            {

                chkE8.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkE8.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkE9_CheckedChanged(object sender, EventArgs e)
        {
            if (chkE9.Checked)
            {

                chkE9.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkE9.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void lblValorTotal_Click(object sender, EventArgs e)
        {



            lblValorTotal.Text = precio.ToString(); 
        }

        private void txtprecio_TextChanged(object sender, EventArgs e)
        {
            double precio = 200;
            precio = Convert.ToInt32(txtprecio.Text);
            precio = double.Parse(txtprecio.Text);
        }
    }
}
