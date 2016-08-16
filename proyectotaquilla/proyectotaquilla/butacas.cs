using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//----------------------------------Manejo de Seleccion de Butacas por Roberto Portillo 0901-13-20332 ( funcionalidad de A1 hasta B5)-------------------------
namespace proyectotaquilla
{
    public partial class butacas : Form
    {
        int ParametroCantidad = 0;

        public butacas(int cantidadTotal, int totalpago)
        {
            InitializeComponent();
            this.comparar = cantidadTotal;

        }


        int comparar = 0;
        

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
           
           
            
        }
        private void chkA1_CheckedChanged(object sender, EventArgs e)
        {

            if (chkA1.Checked)
            {
                ParametroCantidad++;
                chkA1.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

          
            if (comparar == ParametroCantidad)
            {
       
              var respuesta =  MessageBox.Show("Esta Satisfecho con su Eleccion?", " Eleccion de Asientos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
              if (respuesta == DialogResult.Yes)
                {
                    chkA1.Enabled = false; chkA2.Enabled = false; chkA3.Enabled = false;  chkA4.Enabled = false; chkA5.Enabled = false; chkA6.Enabled = false; chkA7.Enabled = false; chkA8.Enabled = false; chkA9.Enabled = false; chkB1.Enabled = false; chkB2.Enabled = false; chkB3.Enabled = false; chkB4.Enabled = false; chkB5.Enabled = false; chkB6.Enabled = false; chkB7.Enabled = false; chkB8.Enabled = false; chkB9.Enabled = false; chkC1.Enabled = false; chkA2.Enabled = false; chkC3.Enabled = false; chkC4.Enabled = false; chkC5.Enabled = false; chkC6.Enabled = false; chkC7.Enabled = false; chkC8.Enabled = false; chkC9.Enabled = false;
                    chkD1.Enabled = false; chkD2.Enabled = false; chkD3.Enabled = false;  chkD4.Enabled = false; chkD5.Enabled = false; chkD6.Enabled = false; chkD7.Enabled = false; chkD8.Enabled = false; chkD9.Enabled = false; chkE1.Enabled = false; chkE2.Enabled = false; chkE3.Enabled = false; chkE4.Enabled = false; chkE5.Enabled = false; chkE6.Enabled = false; chkE7.Enabled = false; chkE8.Enabled = false; chkE9.Enabled = false;     
                   

                }
              else
                  if (respuesta == DialogResult.No)
                  {

                      chkA1.Checked = false;

                      chkA1.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                    

                      chkA1.Enabled = true; chkA2.Enabled = true; chkA3.Enabled = true; chkA4.Enabled = true; chkA5.Enabled = true; chkA6.Enabled = true; chkA7.Enabled = true; chkA8.Enabled = true; chkA9.Enabled = true; chkB1.Enabled = true; chkB2.Enabled = true; chkB3.Enabled = true; chkB4.Enabled = true; chkB5.Enabled = true; chkB6.Enabled = true; chkB7.Enabled = true; chkB8.Enabled = true; chkB9.Enabled = true; chkC1.Enabled = true; chkA2.Enabled = true; chkC3.Enabled = true; chkC4.Enabled = true; chkC5.Enabled = true; chkC6.Enabled = true; chkC7.Enabled = true; chkC8.Enabled = true; chkC9.Enabled = true;
                      chkD1.Enabled = true; chkD2.Enabled = true; chkD3.Enabled = true; chkD4.Enabled = true; chkD5.Enabled = true; chkD6.Enabled = true; chkD7.Enabled = true; chkD8.Enabled = true; chkD9.Enabled = true; chkE1.Enabled = true; chkE2.Enabled = true; chkE3.Enabled = true; chkE4.Enabled = true; chkE5.Enabled = true; chkE6.Enabled = true; chkE7.Enabled = true; chkE8.Enabled = true; chkE9.Enabled = true;
                  } 
            }
                     
              }
            
            else
                if (chkA1.Checked == false)
            {
                ParametroCantidad = ParametroCantidad - 1;
                chkA1.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                MessageBox.Show("la cantidad actual es de: " + ParametroCantidad);
            
            }
            //---------------------------------------------------------------------------

         
        }

        private void chkA2_CheckedChanged(object sender, EventArgs e)
        {


            if (chkA2.Checked == true)
            {
                ParametroCantidad++;
                chkA2.BackgroundImage = proyectotaquilla.Properties.Resources.verde;


                if (comparar == ParametroCantidad)
                {

                    var respuesta = MessageBox.Show("Esta Satisfecho con su Eleccion?", " Eleccion de Asientos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        chkA1.Enabled = false; chkA2.Enabled = false; chkA3.Enabled = false; chkA4.Enabled = false; chkA5.Enabled = false; chkA6.Enabled = false; chkA7.Enabled = false; chkA8.Enabled = false; chkA9.Enabled = false; chkB1.Enabled = false; chkB2.Enabled = false; chkB3.Enabled = false; chkB4.Enabled = false; chkB5.Enabled = false; chkB6.Enabled = false; chkB7.Enabled = false; chkB8.Enabled = false; chkB9.Enabled = false; chkC1.Enabled = false; chkA2.Enabled = false; chkC3.Enabled = false; chkC4.Enabled = false; chkC5.Enabled = false; chkC6.Enabled = false; chkC7.Enabled = false; chkC8.Enabled = false; chkC9.Enabled = false;
                        chkD1.Enabled = false; chkD2.Enabled = false; chkD3.Enabled = false; chkD4.Enabled = false; chkD5.Enabled = false; chkD6.Enabled = false; chkD7.Enabled = false; chkD8.Enabled = false; chkD9.Enabled = false; chkE1.Enabled = false; chkE2.Enabled = false; chkE3.Enabled = false; chkE4.Enabled = false; chkE5.Enabled = false; chkE6.Enabled = false; chkE7.Enabled = false; chkE8.Enabled = false; chkE9.Enabled = false;


                    }
                    else
                        if (respuesta == DialogResult.No)
                        {

                            chkA2.Checked = false;

                            chkA2.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                           

                            chkA1.Enabled = true; chkA2.Enabled = true; chkA3.Enabled = true; chkA4.Enabled = true; chkA5.Enabled = true; chkA6.Enabled = true; chkA7.Enabled = true; chkA8.Enabled = true; chkA9.Enabled = true; chkB1.Enabled = true; chkB2.Enabled = true; chkB3.Enabled = true; chkB4.Enabled = true; chkB5.Enabled = true; chkB6.Enabled = true; chkB7.Enabled = true; chkB8.Enabled = true; chkB9.Enabled = true; chkC1.Enabled = true; chkA2.Enabled = true; chkC3.Enabled = true; chkC4.Enabled = true; chkC5.Enabled = true; chkC6.Enabled = true; chkC7.Enabled = true; chkC8.Enabled = true; chkC9.Enabled = true;
                            chkD1.Enabled = true; chkD2.Enabled = true; chkD3.Enabled = true; chkD4.Enabled = true; chkD5.Enabled = true; chkD6.Enabled = true; chkD7.Enabled = true; chkD8.Enabled = true; chkD9.Enabled = true; chkE1.Enabled = true; chkE2.Enabled = true; chkE3.Enabled = true; chkE4.Enabled = true; chkE5.Enabled = true; chkE6.Enabled = true; chkE7.Enabled = true; chkE8.Enabled = true; chkE9.Enabled = true;
                        }
                }

            }

            else
                if (chkA2.Checked == false)
                {
                    ParametroCantidad = ParametroCantidad - 1;
                    chkA2.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                    MessageBox.Show("la cantidad actual es de: " + ParametroCantidad);

                }
        }

        private void chkA3_CheckedChanged(object sender, EventArgs e)
        {

            if (chkA3.Checked == true)
            {
                ParametroCantidad++;
                chkA3.BackgroundImage = proyectotaquilla.Properties.Resources.verde;


                if (comparar == ParametroCantidad)
                {

                    var respuesta = MessageBox.Show("Esta Satisfecho con su Eleccion?", " Eleccion de Asientos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        chkA1.Enabled = false; chkA2.Enabled = false; chkA3.Enabled = false; chkA4.Enabled = false; chkA5.Enabled = false; chkA6.Enabled = false; chkA7.Enabled = false; chkA8.Enabled = false; chkA9.Enabled = false; chkB1.Enabled = false; chkB2.Enabled = false; chkB3.Enabled = false; chkB4.Enabled = false; chkB5.Enabled = false; chkB6.Enabled = false; chkB7.Enabled = false; chkB8.Enabled = false; chkB9.Enabled = false; chkC1.Enabled = false; chkA2.Enabled = false; chkC3.Enabled = false; chkC4.Enabled = false; chkC5.Enabled = false; chkC6.Enabled = false; chkC7.Enabled = false; chkC8.Enabled = false; chkC9.Enabled = false;
                        chkD1.Enabled = false; chkD2.Enabled = false; chkD3.Enabled = false; chkD4.Enabled = false; chkD5.Enabled = false; chkD6.Enabled = false; chkD7.Enabled = false; chkD8.Enabled = false; chkD9.Enabled = false; chkE1.Enabled = false; chkE2.Enabled = false; chkE3.Enabled = false; chkE4.Enabled = false; chkE5.Enabled = false; chkE6.Enabled = false; chkE7.Enabled = false; chkE8.Enabled = false; chkE9.Enabled = false;


                    }
                    else
                        if (respuesta == DialogResult.No)
                        {

                            chkA3.Checked = false;

                            chkA3.BackgroundImage = proyectotaquilla.Properties.Resources.gris;


                            chkA1.Enabled = true; chkA2.Enabled = true; chkA3.Enabled = true; chkA4.Enabled = true; chkA5.Enabled = true; chkA6.Enabled = true; chkA7.Enabled = true; chkA8.Enabled = true; chkA9.Enabled = true; chkB1.Enabled = true; chkB2.Enabled = true; chkB3.Enabled = true; chkB4.Enabled = true; chkB5.Enabled = true; chkB6.Enabled = true; chkB7.Enabled = true; chkB8.Enabled = true; chkB9.Enabled = true; chkC1.Enabled = true; chkA2.Enabled = true; chkC3.Enabled = true; chkC4.Enabled = true; chkC5.Enabled = true; chkC6.Enabled = true; chkC7.Enabled = true; chkC8.Enabled = true; chkC9.Enabled = true;
                            chkD1.Enabled = true; chkD2.Enabled = true; chkD3.Enabled = true; chkD4.Enabled = true; chkD5.Enabled = true; chkD6.Enabled = true; chkD7.Enabled = true; chkD8.Enabled = true; chkD9.Enabled = true; chkE1.Enabled = true; chkE2.Enabled = true; chkE3.Enabled = true; chkE4.Enabled = true; chkE5.Enabled = true; chkE6.Enabled = true; chkE7.Enabled = true; chkE8.Enabled = true; chkE9.Enabled = true;
                        }
                }

            }

            else
                if (chkA3.Checked == false)
                {
                    ParametroCantidad = ParametroCantidad - 1;
                    chkA3.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                    MessageBox.Show("la cantidad actual es de: " + ParametroCantidad);

                }
        }

        private void chkA4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkA4.Checked == true)
            {
                ParametroCantidad++;
                chkA4.BackgroundImage = proyectotaquilla.Properties.Resources.verde;


                if (comparar == ParametroCantidad)
                {

                    var respuesta = MessageBox.Show("Esta Satisfecho con su Eleccion?", " Eleccion de Asientos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        chkA1.Enabled = false; chkA2.Enabled = false; chkA3.Enabled = false; chkA4.Enabled = false; chkA5.Enabled = false; chkA6.Enabled = false; chkA7.Enabled = false; chkA8.Enabled = false; chkA9.Enabled = false; chkB1.Enabled = false; chkB2.Enabled = false; chkB3.Enabled = false; chkB4.Enabled = false; chkB5.Enabled = false; chkB6.Enabled = false; chkB7.Enabled = false; chkB8.Enabled = false; chkB9.Enabled = false; chkC1.Enabled = false; chkA2.Enabled = false; chkC3.Enabled = false; chkC4.Enabled = false; chkC5.Enabled = false; chkC6.Enabled = false; chkC7.Enabled = false; chkC8.Enabled = false; chkC9.Enabled = false;
                        chkD1.Enabled = false; chkD2.Enabled = false; chkD3.Enabled = false; chkD4.Enabled = false; chkD5.Enabled = false; chkD6.Enabled = false; chkD7.Enabled = false; chkD8.Enabled = false; chkD9.Enabled = false; chkE1.Enabled = false; chkE2.Enabled = false; chkE3.Enabled = false; chkE4.Enabled = false; chkE5.Enabled = false; chkE6.Enabled = false; chkE7.Enabled = false; chkE8.Enabled = false; chkE9.Enabled = false;


                    }
                    else
                        if (respuesta == DialogResult.No)
                        {

                            chkA4.Checked = false;

                            chkA4.BackgroundImage = proyectotaquilla.Properties.Resources.gris;


                            chkA1.Enabled = true; chkA2.Enabled = true; chkA3.Enabled = true; chkA4.Enabled = true; chkA5.Enabled = true; chkA6.Enabled = true; chkA7.Enabled = true; chkA8.Enabled = true; chkA9.Enabled = true; chkB1.Enabled = true; chkB2.Enabled = true; chkB3.Enabled = true; chkB4.Enabled = true; chkB5.Enabled = true; chkB6.Enabled = true; chkB7.Enabled = true; chkB8.Enabled = true; chkB9.Enabled = true; chkC1.Enabled = true; chkA2.Enabled = true; chkC3.Enabled = true; chkC4.Enabled = true; chkC5.Enabled = true; chkC6.Enabled = true; chkC7.Enabled = true; chkC8.Enabled = true; chkC9.Enabled = true;
                            chkD1.Enabled = true; chkD2.Enabled = true; chkD3.Enabled = true; chkD4.Enabled = true; chkD5.Enabled = true; chkD6.Enabled = true; chkD7.Enabled = true; chkD8.Enabled = true; chkD9.Enabled = true; chkE1.Enabled = true; chkE2.Enabled = true; chkE3.Enabled = true; chkE4.Enabled = true; chkE5.Enabled = true; chkE6.Enabled = true; chkE7.Enabled = true; chkE8.Enabled = true; chkE9.Enabled = true;
                        }
                }

            }

            else
                if (chkA4.Checked == false)
                {
                    ParametroCantidad = ParametroCantidad - 1;
                    chkA4.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                    MessageBox.Show("la cantidad actual es de: " + ParametroCantidad);

                }
        
        }

        private void chkA5_CheckedChanged(object sender, EventArgs e)
        {
            if (chkA5.Checked == true)
            {
                ParametroCantidad++;
                chkA5.BackgroundImage = proyectotaquilla.Properties.Resources.verde;


                if (comparar == ParametroCantidad)
                {

                    var respuesta = MessageBox.Show("Esta Satisfecho con su Eleccion?", " Eleccion de Asientos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        chkA1.Enabled = false; chkA2.Enabled = false; chkA3.Enabled = false; chkA4.Enabled = false; chkA5.Enabled = false; chkA6.Enabled = false; chkA7.Enabled = false; chkA8.Enabled = false; chkA9.Enabled = false; chkB1.Enabled = false; chkB2.Enabled = false; chkB3.Enabled = false; chkB4.Enabled = false; chkB5.Enabled = false; chkB6.Enabled = false; chkB7.Enabled = false; chkB8.Enabled = false; chkB9.Enabled = false; chkC1.Enabled = false; chkA2.Enabled = false; chkC3.Enabled = false; chkC4.Enabled = false; chkC5.Enabled = false; chkC6.Enabled = false; chkC7.Enabled = false; chkC8.Enabled = false; chkC9.Enabled = false;
                        chkD1.Enabled = false; chkD2.Enabled = false; chkD3.Enabled = false; chkD4.Enabled = false; chkD5.Enabled = false; chkD6.Enabled = false; chkD7.Enabled = false; chkD8.Enabled = false; chkD9.Enabled = false; chkE1.Enabled = false; chkE2.Enabled = false; chkE3.Enabled = false; chkE4.Enabled = false; chkE5.Enabled = false; chkE6.Enabled = false; chkE7.Enabled = false; chkE8.Enabled = false; chkE9.Enabled = false;


                    }
                    else
                        if (respuesta == DialogResult.No)
                        {

                            chkA5.Checked = false;

                            chkA5.BackgroundImage = proyectotaquilla.Properties.Resources.gris;


                            chkA1.Enabled = true; chkA2.Enabled = true; chkA3.Enabled = true; chkA4.Enabled = true; chkA5.Enabled = true; chkA6.Enabled = true; chkA7.Enabled = true; chkA8.Enabled = true; chkA9.Enabled = true; chkB1.Enabled = true; chkB2.Enabled = true; chkB3.Enabled = true; chkB4.Enabled = true; chkB5.Enabled = true; chkB6.Enabled = true; chkB7.Enabled = true; chkB8.Enabled = true; chkB9.Enabled = true; chkC1.Enabled = true; chkA2.Enabled = true; chkC3.Enabled = true; chkC4.Enabled = true; chkC5.Enabled = true; chkC6.Enabled = true; chkC7.Enabled = true; chkC8.Enabled = true; chkC9.Enabled = true;
                            chkD1.Enabled = true; chkD2.Enabled = true; chkD3.Enabled = true; chkD4.Enabled = true; chkD5.Enabled = true; chkD6.Enabled = true; chkD7.Enabled = true; chkD8.Enabled = true; chkD9.Enabled = true; chkE1.Enabled = true; chkE2.Enabled = true; chkE3.Enabled = true; chkE4.Enabled = true; chkE5.Enabled = true; chkE6.Enabled = true; chkE7.Enabled = true; chkE8.Enabled = true; chkE9.Enabled = true;
                        }
                }

            }

            else
                if (chkA5.Checked == false)
                {
                    ParametroCantidad = ParametroCantidad - 1;
                    chkA5.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                    MessageBox.Show("la cantidad actual es de: " + ParametroCantidad);

                }
        
        }

        private void chkA6_CheckedChanged(object sender, EventArgs e)
        {
            if (chkA6.Checked == true)
            {
                ParametroCantidad++;
                chkA6.BackgroundImage = proyectotaquilla.Properties.Resources.verde;


                if (comparar == ParametroCantidad)
                {

                    var respuesta = MessageBox.Show("Esta Satisfecho con su Eleccion?", " Eleccion de Asientos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        chkA1.Enabled = false; chkA2.Enabled = false; chkA3.Enabled = false; chkA4.Enabled = false; chkA5.Enabled = false; chkA6.Enabled = false; chkA7.Enabled = false; chkA8.Enabled = false; chkA9.Enabled = false; chkB1.Enabled = false; chkB2.Enabled = false; chkB3.Enabled = false; chkB4.Enabled = false; chkB5.Enabled = false; chkB6.Enabled = false; chkB7.Enabled = false; chkB8.Enabled = false; chkB9.Enabled = false; chkC1.Enabled = false; chkA2.Enabled = false; chkC3.Enabled = false; chkC4.Enabled = false; chkC5.Enabled = false; chkC6.Enabled = false; chkC7.Enabled = false; chkC8.Enabled = false; chkC9.Enabled = false;
                        chkD1.Enabled = false; chkD2.Enabled = false; chkD3.Enabled = false; chkD4.Enabled = false; chkD5.Enabled = false; chkD6.Enabled = false; chkD7.Enabled = false; chkD8.Enabled = false; chkD9.Enabled = false; chkE1.Enabled = false; chkE2.Enabled = false; chkE3.Enabled = false; chkE4.Enabled = false; chkE5.Enabled = false; chkE6.Enabled = false; chkE7.Enabled = false; chkE8.Enabled = false; chkE9.Enabled = false;


                    }
                    else
                        if (respuesta == DialogResult.No)
                        {

                            chkA6.Checked = false;

                            chkA6.BackgroundImage = proyectotaquilla.Properties.Resources.gris;


                            chkA1.Enabled = true; chkA2.Enabled = true; chkA3.Enabled = true; chkA4.Enabled = true; chkA5.Enabled = true; chkA6.Enabled = true; chkA7.Enabled = true; chkA8.Enabled = true; chkA9.Enabled = true; chkB1.Enabled = true; chkB2.Enabled = true; chkB3.Enabled = true; chkB4.Enabled = true; chkB5.Enabled = true; chkB6.Enabled = true; chkB7.Enabled = true; chkB8.Enabled = true; chkB9.Enabled = true; chkC1.Enabled = true; chkA2.Enabled = true; chkC3.Enabled = true; chkC4.Enabled = true; chkC5.Enabled = true; chkC6.Enabled = true; chkC7.Enabled = true; chkC8.Enabled = true; chkC9.Enabled = true;
                            chkD1.Enabled = true; chkD2.Enabled = true; chkD3.Enabled = true; chkD4.Enabled = true; chkD5.Enabled = true; chkD6.Enabled = true; chkD7.Enabled = true; chkD8.Enabled = true; chkD9.Enabled = true; chkE1.Enabled = true; chkE2.Enabled = true; chkE3.Enabled = true; chkE4.Enabled = true; chkE5.Enabled = true; chkE6.Enabled = true; chkE7.Enabled = true; chkE8.Enabled = true; chkE9.Enabled = true;
                        }
                }

            }

            else
                if (chkA6.Checked == false)
                {
                    ParametroCantidad = ParametroCantidad - 1;
                    chkA6.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                    MessageBox.Show("la cantidad actual es de: " + ParametroCantidad);

                }
        
        }

        private void chkA7_CheckedChanged(object sender, EventArgs e)
        {
            if (chkA7.Checked == true)
            {
                ParametroCantidad++;
                chkA7.BackgroundImage = proyectotaquilla.Properties.Resources.verde;


                if (comparar == ParametroCantidad)
                {

                    var respuesta = MessageBox.Show("Esta Satisfecho con su Eleccion?", " Eleccion de Asientos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        chkA1.Enabled = false; chkA2.Enabled = false; chkA3.Enabled = false; chkA4.Enabled = false; chkA5.Enabled = false; chkA6.Enabled = false; chkA7.Enabled = false; chkA8.Enabled = false; chkA9.Enabled = false; chkB1.Enabled = false; chkB2.Enabled = false; chkB3.Enabled = false; chkB4.Enabled = false; chkB5.Enabled = false; chkB6.Enabled = false; chkB7.Enabled = false; chkB8.Enabled = false; chkB9.Enabled = false; chkC1.Enabled = false; chkA2.Enabled = false; chkC3.Enabled = false; chkC4.Enabled = false; chkC5.Enabled = false; chkC6.Enabled = false; chkC7.Enabled = false; chkC8.Enabled = false; chkC9.Enabled = false;
                        chkD1.Enabled = false; chkD2.Enabled = false; chkD3.Enabled = false; chkD4.Enabled = false; chkD5.Enabled = false; chkD6.Enabled = false; chkD7.Enabled = false; chkD8.Enabled = false; chkD9.Enabled = false; chkE1.Enabled = false; chkE2.Enabled = false; chkE3.Enabled = false; chkE4.Enabled = false; chkE5.Enabled = false; chkE6.Enabled = false; chkE7.Enabled = false; chkE8.Enabled = false; chkE9.Enabled = false;


                    }
                    else
                        if (respuesta == DialogResult.No)
                        {

                            chkA7.Checked = false;

                            chkA7.BackgroundImage = proyectotaquilla.Properties.Resources.gris;


                            chkA1.Enabled = true; chkA2.Enabled = true; chkA3.Enabled = true; chkA4.Enabled = true; chkA5.Enabled = true; chkA6.Enabled = true; chkA7.Enabled = true; chkA8.Enabled = true; chkA9.Enabled = true; chkB1.Enabled = true; chkB2.Enabled = true; chkB3.Enabled = true; chkB4.Enabled = true; chkB5.Enabled = true; chkB6.Enabled = true; chkB7.Enabled = true; chkB8.Enabled = true; chkB9.Enabled = true; chkC1.Enabled = true; chkA2.Enabled = true; chkC3.Enabled = true; chkC4.Enabled = true; chkC5.Enabled = true; chkC6.Enabled = true; chkC7.Enabled = true; chkC8.Enabled = true; chkC9.Enabled = true;
                            chkD1.Enabled = true; chkD2.Enabled = true; chkD3.Enabled = true; chkD4.Enabled = true; chkD5.Enabled = true; chkD6.Enabled = true; chkD7.Enabled = true; chkD8.Enabled = true; chkD9.Enabled = true; chkE1.Enabled = true; chkE2.Enabled = true; chkE3.Enabled = true; chkE4.Enabled = true; chkE5.Enabled = true; chkE6.Enabled = true; chkE7.Enabled = true; chkE8.Enabled = true; chkE9.Enabled = true;
                        }
                }

            }

            else
                if (chkA7.Checked == false)
                {
                    ParametroCantidad = ParametroCantidad - 1;
                    chkA7.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                    MessageBox.Show("la cantidad actual es de: " + ParametroCantidad);

                }
        
        }

        private void chkA8_CheckedChanged(object sender, EventArgs e)
        {
            if (chkA8.Checked == true)
            {
                ParametroCantidad++;
                chkA8.BackgroundImage = proyectotaquilla.Properties.Resources.verde;


                if (comparar == ParametroCantidad)
                {

                    var respuesta = MessageBox.Show("Esta Satisfecho con su Eleccion?", " Eleccion de Asientos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        chkA1.Enabled = false; chkA2.Enabled = false; chkA3.Enabled = false; chkA4.Enabled = false; chkA5.Enabled = false; chkA6.Enabled = false; chkA7.Enabled = false; chkA8.Enabled = false; chkA9.Enabled = false; chkB1.Enabled = false; chkB2.Enabled = false; chkB3.Enabled = false; chkB4.Enabled = false; chkB5.Enabled = false; chkB6.Enabled = false; chkB7.Enabled = false; chkB8.Enabled = false; chkB9.Enabled = false; chkC1.Enabled = false; chkA2.Enabled = false; chkC3.Enabled = false; chkC4.Enabled = false; chkC5.Enabled = false; chkC6.Enabled = false; chkC7.Enabled = false; chkC8.Enabled = false; chkC9.Enabled = false;
                        chkD1.Enabled = false; chkD2.Enabled = false; chkD3.Enabled = false; chkD4.Enabled = false; chkD5.Enabled = false; chkD6.Enabled = false; chkD7.Enabled = false; chkD8.Enabled = false; chkD9.Enabled = false; chkE1.Enabled = false; chkE2.Enabled = false; chkE3.Enabled = false; chkE4.Enabled = false; chkE5.Enabled = false; chkE6.Enabled = false; chkE7.Enabled = false; chkE8.Enabled = false; chkE9.Enabled = false;


                    }
                    else
                        if (respuesta == DialogResult.No)
                        {

                            chkA8.Checked = false;

                            chkA8.BackgroundImage = proyectotaquilla.Properties.Resources.gris;


                            chkA1.Enabled = true; chkA2.Enabled = true; chkA3.Enabled = true; chkA4.Enabled = true; chkA5.Enabled = true; chkA6.Enabled = true; chkA7.Enabled = true; chkA8.Enabled = true; chkA9.Enabled = true; chkB1.Enabled = true; chkB2.Enabled = true; chkB3.Enabled = true; chkB4.Enabled = true; chkB5.Enabled = true; chkB6.Enabled = true; chkB7.Enabled = true; chkB8.Enabled = true; chkB9.Enabled = true; chkC1.Enabled = true; chkA2.Enabled = true; chkC3.Enabled = true; chkC4.Enabled = true; chkC5.Enabled = true; chkC6.Enabled = true; chkC7.Enabled = true; chkC8.Enabled = true; chkC9.Enabled = true;
                            chkD1.Enabled = true; chkD2.Enabled = true; chkD3.Enabled = true; chkD4.Enabled = true; chkD5.Enabled = true; chkD6.Enabled = true; chkD7.Enabled = true; chkD8.Enabled = true; chkD9.Enabled = true; chkE1.Enabled = true; chkE2.Enabled = true; chkE3.Enabled = true; chkE4.Enabled = true; chkE5.Enabled = true; chkE6.Enabled = true; chkE7.Enabled = true; chkE8.Enabled = true; chkE9.Enabled = true;
                        }
                }

            }

            else
                if (chkA8.Checked == false)
                {
                    ParametroCantidad = ParametroCantidad - 1;
                    chkA8.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                    MessageBox.Show("la cantidad actual es de: " + ParametroCantidad);

                }
        
        }

        private void chkA9_CheckedChanged(object sender, EventArgs e)
        {
            if (chkA9.Checked == true)
            {
                ParametroCantidad++;
                chkA9.BackgroundImage = proyectotaquilla.Properties.Resources.verde;


                if (comparar == ParametroCantidad)
                {

                    var respuesta = MessageBox.Show("Esta Satisfecho con su Eleccion?", " Eleccion de Asientos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        chkA1.Enabled = false; chkA2.Enabled = false; chkA3.Enabled = false; chkA4.Enabled = false; chkA5.Enabled = false; chkA6.Enabled = false; chkA7.Enabled = false; chkA8.Enabled = false; chkA9.Enabled = false; chkB1.Enabled = false; chkB2.Enabled = false; chkB3.Enabled = false; chkB4.Enabled = false; chkB5.Enabled = false; chkB6.Enabled = false; chkB7.Enabled = false; chkB8.Enabled = false; chkB9.Enabled = false; chkC1.Enabled = false; chkA2.Enabled = false; chkC3.Enabled = false; chkC4.Enabled = false; chkC5.Enabled = false; chkC6.Enabled = false; chkC7.Enabled = false; chkC8.Enabled = false; chkC9.Enabled = false;
                        chkD1.Enabled = false; chkD2.Enabled = false; chkD3.Enabled = false; chkD4.Enabled = false; chkD5.Enabled = false; chkD6.Enabled = false; chkD7.Enabled = false; chkD8.Enabled = false; chkD9.Enabled = false; chkE1.Enabled = false; chkE2.Enabled = false; chkE3.Enabled = false; chkE4.Enabled = false; chkE5.Enabled = false; chkE6.Enabled = false; chkE7.Enabled = false; chkE8.Enabled = false; chkE9.Enabled = false;


                    }
                    else
                        if (respuesta == DialogResult.No)
                        {

                            chkA9.Checked = false;

                            chkA9.BackgroundImage = proyectotaquilla.Properties.Resources.gris;


                            chkA1.Enabled = true; chkA2.Enabled = true; chkA3.Enabled = true; chkA4.Enabled = true; chkA5.Enabled = true; chkA6.Enabled = true; chkA7.Enabled = true; chkA8.Enabled = true; chkA9.Enabled = true; chkB1.Enabled = true; chkB2.Enabled = true; chkB3.Enabled = true; chkB4.Enabled = true; chkB5.Enabled = true; chkB6.Enabled = true; chkB7.Enabled = true; chkB8.Enabled = true; chkB9.Enabled = true; chkC1.Enabled = true; chkA2.Enabled = true; chkC3.Enabled = true; chkC4.Enabled = true; chkC5.Enabled = true; chkC6.Enabled = true; chkC7.Enabled = true; chkC8.Enabled = true; chkC9.Enabled = true;
                            chkD1.Enabled = true; chkD2.Enabled = true; chkD3.Enabled = true; chkD4.Enabled = true; chkD5.Enabled = true; chkD6.Enabled = true; chkD7.Enabled = true; chkD8.Enabled = true; chkD9.Enabled = true; chkE1.Enabled = true; chkE2.Enabled = true; chkE3.Enabled = true; chkE4.Enabled = true; chkE5.Enabled = true; chkE6.Enabled = true; chkE7.Enabled = true; chkE8.Enabled = true; chkE9.Enabled = true;
                        }
                }

            }

            else
                if (chkA9.Checked == false)
                {
                    ParametroCantidad = ParametroCantidad - 1;
                    chkA9.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                    MessageBox.Show("la cantidad actual es de: " + ParametroCantidad);

                }
        
        }

        private void chkB1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB1.Checked == true)
            {
                ParametroCantidad++;
                chkB1.BackgroundImage = proyectotaquilla.Properties.Resources.verde;


                if (comparar == ParametroCantidad)
                {

                    var respuesta = MessageBox.Show("Esta Satisfecho con su Eleccion?", " Eleccion de Asientos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        chkA1.Enabled = false; chkA2.Enabled = false; chkA3.Enabled = false; chkA4.Enabled = false; chkA5.Enabled = false; chkA6.Enabled = false; chkA7.Enabled = false; chkA8.Enabled = false; chkA9.Enabled = false; chkB1.Enabled = false; chkB2.Enabled = false; chkB3.Enabled = false; chkB4.Enabled = false; chkB5.Enabled = false; chkB6.Enabled = false; chkB7.Enabled = false; chkB8.Enabled = false; chkB9.Enabled = false; chkC1.Enabled = false; chkA2.Enabled = false; chkC3.Enabled = false; chkC4.Enabled = false; chkC5.Enabled = false; chkC6.Enabled = false; chkC7.Enabled = false; chkC8.Enabled = false; chkC9.Enabled = false;
                        chkD1.Enabled = false; chkD2.Enabled = false; chkD3.Enabled = false; chkD4.Enabled = false; chkD5.Enabled = false; chkD6.Enabled = false; chkD7.Enabled = false; chkD8.Enabled = false; chkD9.Enabled = false; chkE1.Enabled = false; chkE2.Enabled = false; chkE3.Enabled = false; chkE4.Enabled = false; chkE5.Enabled = false; chkE6.Enabled = false; chkE7.Enabled = false; chkE8.Enabled = false; chkE9.Enabled = false;


                    }
                    else
                        if (respuesta == DialogResult.No)
                        {

                            chkB1.Checked = false;

                            chkB1.BackgroundImage = proyectotaquilla.Properties.Resources.gris;


                            chkA1.Enabled = true; chkA2.Enabled = true; chkA3.Enabled = true; chkA4.Enabled = true; chkA5.Enabled = true; chkA6.Enabled = true; chkA7.Enabled = true; chkA8.Enabled = true; chkA9.Enabled = true; chkB1.Enabled = true; chkB2.Enabled = true; chkB3.Enabled = true; chkB4.Enabled = true; chkB5.Enabled = true; chkB6.Enabled = true; chkB7.Enabled = true; chkB8.Enabled = true; chkB9.Enabled = true; chkC1.Enabled = true; chkA2.Enabled = true; chkC3.Enabled = true; chkC4.Enabled = true; chkC5.Enabled = true; chkC6.Enabled = true; chkC7.Enabled = true; chkC8.Enabled = true; chkC9.Enabled = true;
                            chkD1.Enabled = true; chkD2.Enabled = true; chkD3.Enabled = true; chkD4.Enabled = true; chkD5.Enabled = true; chkD6.Enabled = true; chkD7.Enabled = true; chkD8.Enabled = true; chkD9.Enabled = true; chkE1.Enabled = true; chkE2.Enabled = true; chkE3.Enabled = true; chkE4.Enabled = true; chkE5.Enabled = true; chkE6.Enabled = true; chkE7.Enabled = true; chkE8.Enabled = true; chkE9.Enabled = true;
                        }
                }

            }

            else
                if (chkB1.Checked == false)
                {
                    ParametroCantidad = ParametroCantidad - 1;
                    chkB1.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                    MessageBox.Show("la cantidad actual es de: " + ParametroCantidad);

                }
        
        }

        private void chkB2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB2.Checked == true)
            {
                ParametroCantidad++;
                chkB2.BackgroundImage = proyectotaquilla.Properties.Resources.verde;


                if (comparar == ParametroCantidad)
                {

                    var respuesta = MessageBox.Show("Esta Satisfecho con su Eleccion?", " Eleccion de Asientos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        chkA1.Enabled = false; chkA2.Enabled = false; chkA3.Enabled = false; chkA4.Enabled = false; chkA5.Enabled = false; chkA6.Enabled = false; chkA7.Enabled = false; chkA8.Enabled = false; chkA9.Enabled = false; chkB1.Enabled = false; chkB2.Enabled = false; chkB3.Enabled = false; chkB4.Enabled = false; chkB5.Enabled = false; chkB6.Enabled = false; chkB7.Enabled = false; chkB8.Enabled = false; chkB9.Enabled = false; chkC1.Enabled = false; chkA2.Enabled = false; chkC3.Enabled = false; chkC4.Enabled = false; chkC5.Enabled = false; chkC6.Enabled = false; chkC7.Enabled = false; chkC8.Enabled = false; chkC9.Enabled = false;
                        chkD1.Enabled = false; chkD2.Enabled = false; chkD3.Enabled = false; chkD4.Enabled = false; chkD5.Enabled = false; chkD6.Enabled = false; chkD7.Enabled = false; chkD8.Enabled = false; chkD9.Enabled = false; chkE1.Enabled = false; chkE2.Enabled = false; chkE3.Enabled = false; chkE4.Enabled = false; chkE5.Enabled = false; chkE6.Enabled = false; chkE7.Enabled = false; chkE8.Enabled = false; chkE9.Enabled = false;


                    }
                    else
                        if (respuesta == DialogResult.No)
                        {

                            chkB2.Checked = false;

                            chkB2.BackgroundImage = proyectotaquilla.Properties.Resources.gris;


                            chkA1.Enabled = true; chkA2.Enabled = true; chkA3.Enabled = true; chkA4.Enabled = true; chkA5.Enabled = true; chkA6.Enabled = true; chkA7.Enabled = true; chkA8.Enabled = true; chkA9.Enabled = true; chkB1.Enabled = true; chkB2.Enabled = true; chkB3.Enabled = true; chkB4.Enabled = true; chkB5.Enabled = true; chkB6.Enabled = true; chkB7.Enabled = true; chkB8.Enabled = true; chkB9.Enabled = true; chkC1.Enabled = true; chkA2.Enabled = true; chkC3.Enabled = true; chkC4.Enabled = true; chkC5.Enabled = true; chkC6.Enabled = true; chkC7.Enabled = true; chkC8.Enabled = true; chkC9.Enabled = true;
                            chkD1.Enabled = true; chkD2.Enabled = true; chkD3.Enabled = true; chkD4.Enabled = true; chkD5.Enabled = true; chkD6.Enabled = true; chkD7.Enabled = true; chkD8.Enabled = true; chkD9.Enabled = true; chkE1.Enabled = true; chkE2.Enabled = true; chkE3.Enabled = true; chkE4.Enabled = true; chkE5.Enabled = true; chkE6.Enabled = true; chkE7.Enabled = true; chkE8.Enabled = true; chkE9.Enabled = true;
                        }
                }

            }

            else
                if (chkB2.Checked == false)
                {
                    ParametroCantidad = ParametroCantidad - 1;
                    chkB2.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                    MessageBox.Show("la cantidad actual es de: " + ParametroCantidad);

                }
        }

        private void chkB3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB3.Checked == true)
            {
                ParametroCantidad++;
                chkB3.BackgroundImage = proyectotaquilla.Properties.Resources.verde;


                if (comparar == ParametroCantidad)
                {

                    var respuesta = MessageBox.Show("Esta Satisfecho con su Eleccion?", " Eleccion de Asientos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        chkA1.Enabled = false; chkA2.Enabled = false; chkA3.Enabled = false; chkA4.Enabled = false; chkA5.Enabled = false; chkA6.Enabled = false; chkA7.Enabled = false; chkA8.Enabled = false; chkA9.Enabled = false; chkB1.Enabled = false; chkB2.Enabled = false; chkB3.Enabled = false; chkB4.Enabled = false; chkB5.Enabled = false; chkB6.Enabled = false; chkB7.Enabled = false; chkB8.Enabled = false; chkB9.Enabled = false; chkC1.Enabled = false; chkA2.Enabled = false; chkC3.Enabled = false; chkC4.Enabled = false; chkC5.Enabled = false; chkC6.Enabled = false; chkC7.Enabled = false; chkC8.Enabled = false; chkC9.Enabled = false;
                        chkD1.Enabled = false; chkD2.Enabled = false; chkD3.Enabled = false; chkD4.Enabled = false; chkD5.Enabled = false; chkD6.Enabled = false; chkD7.Enabled = false; chkD8.Enabled = false; chkD9.Enabled = false; chkE1.Enabled = false; chkE2.Enabled = false; chkE3.Enabled = false; chkE4.Enabled = false; chkE5.Enabled = false; chkE6.Enabled = false; chkE7.Enabled = false; chkE8.Enabled = false; chkE9.Enabled = false;


                    }
                    else
                        if (respuesta == DialogResult.No)
                        {

                            chkB3.Checked = false;

                            chkB3.BackgroundImage = proyectotaquilla.Properties.Resources.gris;


                            chkA1.Enabled = true; chkA2.Enabled = true; chkA3.Enabled = true; chkA4.Enabled = true; chkA5.Enabled = true; chkA6.Enabled = true; chkA7.Enabled = true; chkA8.Enabled = true; chkA9.Enabled = true; chkB1.Enabled = true; chkB2.Enabled = true; chkB3.Enabled = true; chkB4.Enabled = true; chkB5.Enabled = true; chkB6.Enabled = true; chkB7.Enabled = true; chkB8.Enabled = true; chkB9.Enabled = true; chkC1.Enabled = true; chkA2.Enabled = true; chkC3.Enabled = true; chkC4.Enabled = true; chkC5.Enabled = true; chkC6.Enabled = true; chkC7.Enabled = true; chkC8.Enabled = true; chkC9.Enabled = true;
                            chkD1.Enabled = true; chkD2.Enabled = true; chkD3.Enabled = true; chkD4.Enabled = true; chkD5.Enabled = true; chkD6.Enabled = true; chkD7.Enabled = true; chkD8.Enabled = true; chkD9.Enabled = true; chkE1.Enabled = true; chkE2.Enabled = true; chkE3.Enabled = true; chkE4.Enabled = true; chkE5.Enabled = true; chkE6.Enabled = true; chkE7.Enabled = true; chkE8.Enabled = true; chkE9.Enabled = true;
                        }
                }

            }

            else
                if (chkB3.Checked == false)
                {
                    ParametroCantidad = ParametroCantidad - 1;
                    chkB3.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                    MessageBox.Show("la cantidad actual es de: " + ParametroCantidad);

                }
        }

        private void chkB4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB4.Checked == true)
            {
                ParametroCantidad++;
                chkB4.BackgroundImage = proyectotaquilla.Properties.Resources.verde;


                if (comparar == ParametroCantidad)
                {

                    var respuesta = MessageBox.Show("Esta Satisfecho con su Eleccion?", " Eleccion de Asientos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        chkA1.Enabled = false; chkA2.Enabled = false; chkA3.Enabled = false; chkA4.Enabled = false; chkA5.Enabled = false; chkA6.Enabled = false; chkA7.Enabled = false; chkA8.Enabled = false; chkA9.Enabled = false; chkB1.Enabled = false; chkB2.Enabled = false; chkB3.Enabled = false; chkB4.Enabled = false; chkB5.Enabled = false; chkB6.Enabled = false; chkB7.Enabled = false; chkB8.Enabled = false; chkB9.Enabled = false; chkC1.Enabled = false; chkA2.Enabled = false; chkC3.Enabled = false; chkC4.Enabled = false; chkC5.Enabled = false; chkC6.Enabled = false; chkC7.Enabled = false; chkC8.Enabled = false; chkC9.Enabled = false;
                        chkD1.Enabled = false; chkD2.Enabled = false; chkD3.Enabled = false; chkD4.Enabled = false; chkD5.Enabled = false; chkD6.Enabled = false; chkD7.Enabled = false; chkD8.Enabled = false; chkD9.Enabled = false; chkE1.Enabled = false; chkE2.Enabled = false; chkE3.Enabled = false; chkE4.Enabled = false; chkE5.Enabled = false; chkE6.Enabled = false; chkE7.Enabled = false; chkE8.Enabled = false; chkE9.Enabled = false;


                    }
                    else
                        if (respuesta == DialogResult.No)
                        {

                            chkB4.Checked = false;

                            chkB4.BackgroundImage = proyectotaquilla.Properties.Resources.gris;


                            chkA1.Enabled = true; chkA2.Enabled = true; chkA3.Enabled = true; chkA4.Enabled = true; chkA5.Enabled = true; chkA6.Enabled = true; chkA7.Enabled = true; chkA8.Enabled = true; chkA9.Enabled = true; chkB1.Enabled = true; chkB2.Enabled = true; chkB3.Enabled = true; chkB4.Enabled = true; chkB5.Enabled = true; chkB6.Enabled = true; chkB7.Enabled = true; chkB8.Enabled = true; chkB9.Enabled = true; chkC1.Enabled = true; chkA2.Enabled = true; chkC3.Enabled = true; chkC4.Enabled = true; chkC5.Enabled = true; chkC6.Enabled = true; chkC7.Enabled = true; chkC8.Enabled = true; chkC9.Enabled = true;
                            chkD1.Enabled = true; chkD2.Enabled = true; chkD3.Enabled = true; chkD4.Enabled = true; chkD5.Enabled = true; chkD6.Enabled = true; chkD7.Enabled = true; chkD8.Enabled = true; chkD9.Enabled = true; chkE1.Enabled = true; chkE2.Enabled = true; chkE3.Enabled = true; chkE4.Enabled = true; chkE5.Enabled = true; chkE6.Enabled = true; chkE7.Enabled = true; chkE8.Enabled = true; chkE9.Enabled = true;
                        }
                }

            }

            else
                if (chkB4.Checked == false)
                {
                    ParametroCantidad = ParametroCantidad - 1;
                    chkB4.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                    MessageBox.Show("la cantidad actual es de: " + ParametroCantidad);

                }
        }

        private void chkB5_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB5.Checked == true)
            {
                ParametroCantidad++;
                chkB5.BackgroundImage = proyectotaquilla.Properties.Resources.verde;


                if (comparar == ParametroCantidad)
                {

                    var respuesta = MessageBox.Show("Esta Satisfecho con su Eleccion?", " Eleccion de Asientos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        chkA1.Enabled = false; chkA2.Enabled = false; chkA3.Enabled = false; chkA4.Enabled = false; chkA5.Enabled = false; chkA6.Enabled = false; chkA7.Enabled = false; chkA8.Enabled = false; chkA9.Enabled = false; chkB1.Enabled = false; chkB2.Enabled = false; chkB3.Enabled = false; chkB4.Enabled = false; chkB5.Enabled = false; chkB6.Enabled = false; chkB7.Enabled = false; chkB8.Enabled = false; chkB9.Enabled = false; chkC1.Enabled = false; chkA2.Enabled = false; chkC3.Enabled = false; chkC4.Enabled = false; chkC5.Enabled = false; chkC6.Enabled = false; chkC7.Enabled = false; chkC8.Enabled = false; chkC9.Enabled = false;
                        chkD1.Enabled = false; chkD2.Enabled = false; chkD3.Enabled = false; chkD4.Enabled = false; chkD5.Enabled = false; chkD6.Enabled = false; chkD7.Enabled = false; chkD8.Enabled = false; chkD9.Enabled = false; chkE1.Enabled = false; chkE2.Enabled = false; chkE3.Enabled = false; chkE4.Enabled = false; chkE5.Enabled = false; chkE6.Enabled = false; chkE7.Enabled = false; chkE8.Enabled = false; chkE9.Enabled = false;


                    }
                    else
                        if (respuesta == DialogResult.No)
                        {

                            chkB5.Checked = false;

                            chkB5.BackgroundImage = proyectotaquilla.Properties.Resources.gris;


                            chkA1.Enabled = true; chkA2.Enabled = true; chkA3.Enabled = true; chkA4.Enabled = true; chkA5.Enabled = true; chkA6.Enabled = true; chkA7.Enabled = true; chkA8.Enabled = true; chkA9.Enabled = true; chkB1.Enabled = true; chkB2.Enabled = true; chkB3.Enabled = true; chkB4.Enabled = true; chkB5.Enabled = true; chkB6.Enabled = true; chkB7.Enabled = true; chkB8.Enabled = true; chkB9.Enabled = true; chkC1.Enabled = true; chkA2.Enabled = true; chkC3.Enabled = true; chkC4.Enabled = true; chkC5.Enabled = true; chkC6.Enabled = true; chkC7.Enabled = true; chkC8.Enabled = true; chkC9.Enabled = true;
                            chkD1.Enabled = true; chkD2.Enabled = true; chkD3.Enabled = true; chkD4.Enabled = true; chkD5.Enabled = true; chkD6.Enabled = true; chkD7.Enabled = true; chkD8.Enabled = true; chkD9.Enabled = true; chkE1.Enabled = true; chkE2.Enabled = true; chkE3.Enabled = true; chkE4.Enabled = true; chkE5.Enabled = true; chkE6.Enabled = true; chkE7.Enabled = true; chkE8.Enabled = true; chkE9.Enabled = true;
                        }
                }

            }

            else
                if (chkB5.Checked == false)
                {
                    ParametroCantidad = ParametroCantidad - 1;
                    chkB5.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                    MessageBox.Show("la cantidad actual es de: " + ParametroCantidad);

                }
        }

        private void chkB6_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB6.Checked == true)
            {
                ParametroCantidad++;
                chkB6.BackgroundImage = proyectotaquilla.Properties.Resources.verde;


                if (comparar == ParametroCantidad)
                {

                    var respuesta = MessageBox.Show("Esta Satisfecho con su Eleccion?", " Eleccion de Asientos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        chkA1.Enabled = false; chkA2.Enabled = false; chkA3.Enabled = false; chkA4.Enabled = false; chkA5.Enabled = false; chkA6.Enabled = false; chkA7.Enabled = false; chkA8.Enabled = false; chkA9.Enabled = false; chkB1.Enabled = false; chkB2.Enabled = false; chkB3.Enabled = false; chkB4.Enabled = false; chkB5.Enabled = false; chkB6.Enabled = false; chkB7.Enabled = false; chkB8.Enabled = false; chkB9.Enabled = false; chkC1.Enabled = false; chkA2.Enabled = false; chkC3.Enabled = false; chkC4.Enabled = false; chkC5.Enabled = false; chkC6.Enabled = false; chkC7.Enabled = false; chkC8.Enabled = false; chkC9.Enabled = false;
                        chkD1.Enabled = false; chkD2.Enabled = false; chkD3.Enabled = false; chkD4.Enabled = false; chkD5.Enabled = false; chkD6.Enabled = false; chkD7.Enabled = false; chkD8.Enabled = false; chkD9.Enabled = false; chkE1.Enabled = false; chkE2.Enabled = false; chkE3.Enabled = false; chkE4.Enabled = false; chkE5.Enabled = false; chkE6.Enabled = false; chkE7.Enabled = false; chkE8.Enabled = false; chkE9.Enabled = false;


                    }
                    else
                        if (respuesta == DialogResult.No)
                        {

                            chkB6.Checked = false;

                            chkB6.BackgroundImage = proyectotaquilla.Properties.Resources.gris;


                            chkA1.Enabled = true; chkA2.Enabled = true; chkA3.Enabled = true; chkA4.Enabled = true; chkA5.Enabled = true; chkA6.Enabled = true; chkA7.Enabled = true; chkA8.Enabled = true; chkA9.Enabled = true; chkB1.Enabled = true; chkB2.Enabled = true; chkB3.Enabled = true; chkB4.Enabled = true; chkB5.Enabled = true; chkB6.Enabled = true; chkB7.Enabled = true; chkB8.Enabled = true; chkB9.Enabled = true; chkC1.Enabled = true; chkA2.Enabled = true; chkC3.Enabled = true; chkC4.Enabled = true; chkC5.Enabled = true; chkC6.Enabled = true; chkC7.Enabled = true; chkC8.Enabled = true; chkC9.Enabled = true;
                            chkD1.Enabled = true; chkD2.Enabled = true; chkD3.Enabled = true; chkD4.Enabled = true; chkD5.Enabled = true; chkD6.Enabled = true; chkD7.Enabled = true; chkD8.Enabled = true; chkD9.Enabled = true; chkE1.Enabled = true; chkE2.Enabled = true; chkE3.Enabled = true; chkE4.Enabled = true; chkE5.Enabled = true; chkE6.Enabled = true; chkE7.Enabled = true; chkE8.Enabled = true; chkE9.Enabled = true;
                        }
                }

            }

            else
                if (chkB6.Checked == false)
                {
                    ParametroCantidad = ParametroCantidad - 1;
                    chkB6.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                    MessageBox.Show("la cantidad actual es de: " + ParametroCantidad);

                }
        }

        private void chkB7_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB7.Checked == true)
            {
                ParametroCantidad++;
                chkB7.BackgroundImage = proyectotaquilla.Properties.Resources.verde;


                if (comparar == ParametroCantidad)
                {

                    var respuesta = MessageBox.Show("Esta Satisfecho con su Eleccion?", " Eleccion de Asientos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        chkA1.Enabled = false; chkA2.Enabled = false; chkA3.Enabled = false; chkA4.Enabled = false; chkA5.Enabled = false; chkA6.Enabled = false; chkA7.Enabled = false; chkA8.Enabled = false; chkA9.Enabled = false; chkB1.Enabled = false; chkB2.Enabled = false; chkB3.Enabled = false; chkB4.Enabled = false; chkB5.Enabled = false; chkB6.Enabled = false; chkB7.Enabled = false; chkB8.Enabled = false; chkB9.Enabled = false; chkC1.Enabled = false; chkA2.Enabled = false; chkC3.Enabled = false; chkC4.Enabled = false; chkC5.Enabled = false; chkC6.Enabled = false; chkC7.Enabled = false; chkC8.Enabled = false; chkC9.Enabled = false;
                        chkD1.Enabled = false; chkD2.Enabled = false; chkD3.Enabled = false; chkD4.Enabled = false; chkD5.Enabled = false; chkD6.Enabled = false; chkD7.Enabled = false; chkD8.Enabled = false; chkD9.Enabled = false; chkE1.Enabled = false; chkE2.Enabled = false; chkE3.Enabled = false; chkE4.Enabled = false; chkE5.Enabled = false; chkE6.Enabled = false; chkE7.Enabled = false; chkE8.Enabled = false; chkE9.Enabled = false;


                    }
                    else
                        if (respuesta == DialogResult.No)
                        {

                            chkB7.Checked = false;

                            chkB7.BackgroundImage = proyectotaquilla.Properties.Resources.gris;


                            chkA1.Enabled = true; chkA2.Enabled = true; chkA3.Enabled = true; chkA4.Enabled = true; chkA5.Enabled = true; chkA6.Enabled = true; chkA7.Enabled = true; chkA8.Enabled = true; chkA9.Enabled = true; chkB1.Enabled = true; chkB2.Enabled = true; chkB3.Enabled = true; chkB4.Enabled = true; chkB5.Enabled = true; chkB6.Enabled = true; chkB7.Enabled = true; chkB8.Enabled = true; chkB9.Enabled = true; chkC1.Enabled = true; chkA2.Enabled = true; chkC3.Enabled = true; chkC4.Enabled = true; chkC5.Enabled = true; chkC6.Enabled = true; chkC7.Enabled = true; chkC8.Enabled = true; chkC9.Enabled = true;
                            chkD1.Enabled = true; chkD2.Enabled = true; chkD3.Enabled = true; chkD4.Enabled = true; chkD5.Enabled = true; chkD6.Enabled = true; chkD7.Enabled = true; chkD8.Enabled = true; chkD9.Enabled = true; chkE1.Enabled = true; chkE2.Enabled = true; chkE3.Enabled = true; chkE4.Enabled = true; chkE5.Enabled = true; chkE6.Enabled = true; chkE7.Enabled = true; chkE8.Enabled = true; chkE9.Enabled = true;
                        }
                }

            }

            else
                if (chkB7.Checked == false)
                {
                    ParametroCantidad = ParametroCantidad - 1;
                    chkB7.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                    MessageBox.Show("la cantidad actual es de: " + ParametroCantidad);

                }
        }

        private void chkB8_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB8.Checked == true)
            {
                ParametroCantidad++;
                chkB8.BackgroundImage = proyectotaquilla.Properties.Resources.verde;


                if (comparar == ParametroCantidad)
                {

                    var respuesta = MessageBox.Show("Esta Satisfecho con su Eleccion?", " Eleccion de Asientos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        chkA1.Enabled = false; chkA2.Enabled = false; chkA3.Enabled = false; chkA4.Enabled = false; chkA5.Enabled = false; chkA6.Enabled = false; chkA7.Enabled = false; chkA8.Enabled = false; chkA9.Enabled = false; chkB1.Enabled = false; chkB2.Enabled = false; chkB3.Enabled = false; chkB4.Enabled = false; chkB5.Enabled = false; chkB6.Enabled = false; chkB7.Enabled = false; chkB8.Enabled = false; chkB9.Enabled = false; chkC1.Enabled = false; chkA2.Enabled = false; chkC3.Enabled = false; chkC4.Enabled = false; chkC5.Enabled = false; chkC6.Enabled = false; chkC7.Enabled = false; chkC8.Enabled = false; chkC9.Enabled = false;
                        chkD1.Enabled = false; chkD2.Enabled = false; chkD3.Enabled = false; chkD4.Enabled = false; chkD5.Enabled = false; chkD6.Enabled = false; chkD7.Enabled = false; chkD8.Enabled = false; chkD9.Enabled = false; chkE1.Enabled = false; chkE2.Enabled = false; chkE3.Enabled = false; chkE4.Enabled = false; chkE5.Enabled = false; chkE6.Enabled = false; chkE7.Enabled = false; chkE8.Enabled = false; chkE9.Enabled = false;


                    }
                    else
                        if (respuesta == DialogResult.No)
                        {

                            chkB8.Checked = false;

                            chkB8.BackgroundImage = proyectotaquilla.Properties.Resources.gris;


                            chkA1.Enabled = true; chkA2.Enabled = true; chkA3.Enabled = true; chkA4.Enabled = true; chkA5.Enabled = true; chkA6.Enabled = true; chkA7.Enabled = true; chkA8.Enabled = true; chkA9.Enabled = true; chkB1.Enabled = true; chkB2.Enabled = true; chkB3.Enabled = true; chkB4.Enabled = true; chkB5.Enabled = true; chkB6.Enabled = true; chkB7.Enabled = true; chkB8.Enabled = true; chkB9.Enabled = true; chkC1.Enabled = true; chkA2.Enabled = true; chkC3.Enabled = true; chkC4.Enabled = true; chkC5.Enabled = true; chkC6.Enabled = true; chkC7.Enabled = true; chkC8.Enabled = true; chkC9.Enabled = true;
                            chkD1.Enabled = true; chkD2.Enabled = true; chkD3.Enabled = true; chkD4.Enabled = true; chkD5.Enabled = true; chkD6.Enabled = true; chkD7.Enabled = true; chkD8.Enabled = true; chkD9.Enabled = true; chkE1.Enabled = true; chkE2.Enabled = true; chkE3.Enabled = true; chkE4.Enabled = true; chkE5.Enabled = true; chkE6.Enabled = true; chkE7.Enabled = true; chkE8.Enabled = true; chkE9.Enabled = true;
                        }
                }

            }

            else
                if (chkB8.Checked == false)
                {
                    ParametroCantidad = ParametroCantidad - 1;
                    chkB8.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                    MessageBox.Show("la cantidad actual es de: " + ParametroCantidad);

                }
        }

        private void chkB9_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB9.Checked == true)
            {
                ParametroCantidad++;
                chkB9.BackgroundImage = proyectotaquilla.Properties.Resources.verde;


                if (comparar == ParametroCantidad)
                {

                    var respuesta = MessageBox.Show("Esta Satisfecho con su Eleccion?", " Eleccion de Asientos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        chkA1.Enabled = false; chkA2.Enabled = false; chkA3.Enabled = false; chkA4.Enabled = false; chkA5.Enabled = false; chkA6.Enabled = false; chkA7.Enabled = false; chkA8.Enabled = false; chkA9.Enabled = false; chkB1.Enabled = false; chkB2.Enabled = false; chkB3.Enabled = false; chkB4.Enabled = false; chkB5.Enabled = false; chkB6.Enabled = false; chkB7.Enabled = false; chkB8.Enabled = false; chkB9.Enabled = false; chkC1.Enabled = false; chkA2.Enabled = false; chkC3.Enabled = false; chkC4.Enabled = false; chkC5.Enabled = false; chkC6.Enabled = false; chkC7.Enabled = false; chkC8.Enabled = false; chkC9.Enabled = false;
                        chkD1.Enabled = false; chkD2.Enabled = false; chkD3.Enabled = false; chkD4.Enabled = false; chkD5.Enabled = false; chkD6.Enabled = false; chkD7.Enabled = false; chkD8.Enabled = false; chkD9.Enabled = false; chkE1.Enabled = false; chkE2.Enabled = false; chkE3.Enabled = false; chkE4.Enabled = false; chkE5.Enabled = false; chkE6.Enabled = false; chkE7.Enabled = false; chkE8.Enabled = false; chkE9.Enabled = false;


                    }
                    else
                        if (respuesta == DialogResult.No)
                        {

                            chkB9.Checked = false;

                            chkB9.BackgroundImage = proyectotaquilla.Properties.Resources.gris;


                            chkA1.Enabled = true; chkA2.Enabled = true; chkA3.Enabled = true; chkA4.Enabled = true; chkA5.Enabled = true; chkA6.Enabled = true; chkA7.Enabled = true; chkA8.Enabled = true; chkA9.Enabled = true; chkB1.Enabled = true; chkB2.Enabled = true; chkB3.Enabled = true; chkB4.Enabled = true; chkB5.Enabled = true; chkB6.Enabled = true; chkB7.Enabled = true; chkB8.Enabled = true; chkB9.Enabled = true; chkC1.Enabled = true; chkA2.Enabled = true; chkC3.Enabled = true; chkC4.Enabled = true; chkC5.Enabled = true; chkC6.Enabled = true; chkC7.Enabled = true; chkC8.Enabled = true; chkC9.Enabled = true;
                            chkD1.Enabled = true; chkD2.Enabled = true; chkD3.Enabled = true; chkD4.Enabled = true; chkD5.Enabled = true; chkD6.Enabled = true; chkD7.Enabled = true; chkD8.Enabled = true; chkD9.Enabled = true; chkE1.Enabled = true; chkE2.Enabled = true; chkE3.Enabled = true; chkE4.Enabled = true; chkE5.Enabled = true; chkE6.Enabled = true; chkE7.Enabled = true; chkE8.Enabled = true; chkE9.Enabled = true;
                        }
                }

            }

            else
                if (chkB9.Checked == false)
                {
                    ParametroCantidad = ParametroCantidad - 1;
                    chkB9.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                    MessageBox.Show("la cantidad actual es de: " + ParametroCantidad);

                }
        }

        private void chkC1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkC1.Checked == true)
            {
                ParametroCantidad++;
                chkC1.BackgroundImage = proyectotaquilla.Properties.Resources.verde;


                if (comparar == ParametroCantidad)
                {

                    var respuesta = MessageBox.Show("Esta Satisfecho con su Eleccion?", " Eleccion de Asientos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        chkA1.Enabled = false; chkA2.Enabled = false; chkA3.Enabled = false; chkA4.Enabled = false; chkA5.Enabled = false; chkA6.Enabled = false; chkA7.Enabled = false; chkA8.Enabled = false; chkA9.Enabled = false; chkB1.Enabled = false; chkB2.Enabled = false; chkB3.Enabled = false; chkB4.Enabled = false; chkB5.Enabled = false; chkB6.Enabled = false; chkB7.Enabled = false; chkB8.Enabled = false; chkB9.Enabled = false; chkC1.Enabled = false; chkA2.Enabled = false; chkC3.Enabled = false; chkC4.Enabled = false; chkC5.Enabled = false; chkC6.Enabled = false; chkC7.Enabled = false; chkC8.Enabled = false; chkC9.Enabled = false;
                        chkD1.Enabled = false; chkD2.Enabled = false; chkD3.Enabled = false; chkD4.Enabled = false; chkD5.Enabled = false; chkD6.Enabled = false; chkD7.Enabled = false; chkD8.Enabled = false; chkD9.Enabled = false; chkE1.Enabled = false; chkE2.Enabled = false; chkE3.Enabled = false; chkE4.Enabled = false; chkE5.Enabled = false; chkE6.Enabled = false; chkE7.Enabled = false; chkE8.Enabled = false; chkE9.Enabled = false;


                    }
                    else
                        if (respuesta == DialogResult.No)
                        {

                            chkC1.Checked = false;

                            chkC1.BackgroundImage = proyectotaquilla.Properties.Resources.gris;


                            chkA1.Enabled = true; chkA2.Enabled = true; chkA3.Enabled = true; chkA4.Enabled = true; chkA5.Enabled = true; chkA6.Enabled = true; chkA7.Enabled = true; chkA8.Enabled = true; chkA9.Enabled = true; chkB1.Enabled = true; chkB2.Enabled = true; chkB3.Enabled = true; chkB4.Enabled = true; chkB5.Enabled = true; chkB6.Enabled = true; chkB7.Enabled = true; chkB8.Enabled = true; chkB9.Enabled = true; chkC1.Enabled = true; chkA2.Enabled = true; chkC3.Enabled = true; chkC4.Enabled = true; chkC5.Enabled = true; chkC6.Enabled = true; chkC7.Enabled = true; chkC8.Enabled = true; chkC9.Enabled = true;
                            chkD1.Enabled = true; chkD2.Enabled = true; chkD3.Enabled = true; chkD4.Enabled = true; chkD5.Enabled = true; chkD6.Enabled = true; chkD7.Enabled = true; chkD8.Enabled = true; chkD9.Enabled = true; chkE1.Enabled = true; chkE2.Enabled = true; chkE3.Enabled = true; chkE4.Enabled = true; chkE5.Enabled = true; chkE6.Enabled = true; chkE7.Enabled = true; chkE8.Enabled = true; chkE9.Enabled = true;
                        }
                }

            }

            else
                if (chkC1.Checked == false)
                {
                    ParametroCantidad = ParametroCantidad - 1;
                    chkC1.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                    MessageBox.Show("la cantidad actual es de: " + ParametroCantidad);

                }
        }

        private void chkC2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkC2.Checked)
            {
                ParametroCantidad++;
                chkC2.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                ParametroCantidad--;
                chkC2.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkC3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkC3.Checked)
            {
                ParametroCantidad++;
                chkC3.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkC3.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                ParametroCantidad--;
            }
        }

        private void chkC4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkC4.Checked)
            {
                ParametroCantidad++;
                chkC4.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkC4.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                ParametroCantidad--;
            }

        }

        private void chkC5_CheckedChanged(object sender, EventArgs e)
        {
            if (chkC5.Checked)
            {

                chkC5.BackgroundImage = proyectotaquilla.Properties.Resources.verde;
                ParametroCantidad++;
            }
            else
            {
                chkC5.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                ParametroCantidad--;
            }

        }

        private void chkC6_CheckedChanged(object sender, EventArgs e)
        {
            if (chkC6.Checked)
            {

                ParametroCantidad++;
                chkC6.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkC6.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                ParametroCantidad--;
            }
        }

        private void chkC7_CheckedChanged(object sender, EventArgs e)
        {
            if (chkC7.Checked)
            {

                chkC7.BackgroundImage = proyectotaquilla.Properties.Resources.verde;
                ParametroCantidad++;
            }
            else
            {
                ParametroCantidad--;
                chkC7.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkC8_CheckedChanged(object sender, EventArgs e)
        {
            if (chkC8.Checked)
            {
                ParametroCantidad++;
                chkC8.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkC8.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                ParametroCantidad--;
            }

        }

        private void chkC9_CheckedChanged(object sender, EventArgs e)
        {
            if (chkC9.Checked)
            {

                chkC9.BackgroundImage = proyectotaquilla.Properties.Resources.verde;
                ParametroCantidad++;
            }
            else
            {
                chkC9.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                ParametroCantidad--;
            }
        }

        private void chkD1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkD1.Checked)
            {
                ParametroCantidad++;
                chkD1.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                ParametroCantidad--;
                chkD1.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
            }
        }

        private void chkD2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkD2.Checked)
            {

                chkD2.BackgroundImage = proyectotaquilla.Properties.Resources.verde;
                ParametroCantidad++;
            }
            else
            {
                chkD2.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                ParametroCantidad--;
            }
        }

        private void chkD3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkD3.Checked)
            {
                ParametroCantidad++;
                chkD3.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkD3.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                ParametroCantidad--;
            }
        }

        private void chkD4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkD4.Checked)
            {
                ParametroCantidad++;
                chkD4.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkD4.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                ParametroCantidad--;
            }
        }

        private void chkD5_CheckedChanged(object sender, EventArgs e)
        {
            if (chkD5.Checked)
            {
                ParametroCantidad++;
                chkD5.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkD5.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                ParametroCantidad--;
            }
        }

        private void chkD6_CheckedChanged(object sender, EventArgs e)
        {
            if (chkD6.Checked)
            {
                ParametroCantidad++;
                chkD6.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkD6.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                ParametroCantidad--;
            }
        }

        private void chkD7_CheckedChanged(object sender, EventArgs e)
        {
            if (chkD7.Checked)
            {
                ParametroCantidad++;
                chkD7.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkD7.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                ParametroCantidad--;
            }
        }

        private void chkD8_CheckedChanged(object sender, EventArgs e)
        {
            if (chkD8.Checked)
            {
                ParametroCantidad++;
                chkD8.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkD8.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                ParametroCantidad--;
            }
        }

        private void chkD9_CheckedChanged(object sender, EventArgs e)
        {
            if (chkD9.Checked)
            {
                ParametroCantidad++;
                chkD9.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkD9.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                ParametroCantidad--;
            }
        }

        private void chkE1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkE1.Checked)
            {

                chkE1.BackgroundImage = proyectotaquilla.Properties.Resources.verde;
                ParametroCantidad++;
            }
            else
            {
                chkE1.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                ParametroCantidad--;
            }
        }

        private void chkE2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkE2.Checked)
            {
                ParametroCantidad++;
                chkE2.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkE2.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                ParametroCantidad--;
            }
        }

        private void chkE3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkE3.Checked)
            {

                chkE3.BackgroundImage = proyectotaquilla.Properties.Resources.verde;
                ParametroCantidad++;
            }
            else
            {
                chkE3.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                ParametroCantidad--;
            }
        }

        private void chkE4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkE4.Checked)
            {
                ParametroCantidad++;
                chkE4.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkE4.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                ParametroCantidad--;
            }
        }

        private void chkE5_CheckedChanged(object sender, EventArgs e)
        {
            if (chkE5.Checked)
            {

                chkE5.BackgroundImage = proyectotaquilla.Properties.Resources.verde;
                ParametroCantidad++;
            }
            else
            {
                chkE5.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                ParametroCantidad--;
            }
        }

        private void chkE6_CheckedChanged(object sender, EventArgs e)
        {
            if (chkE6.Checked)
            {
                ParametroCantidad++;
                chkE6.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkE6.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                ParametroCantidad--;
            }
        }

        private void chkE7_CheckedChanged(object sender, EventArgs e)
        {
            if (chkE7.Checked)
            {

                chkE7.BackgroundImage = proyectotaquilla.Properties.Resources.verde;
                ParametroCantidad++;
            }
            else
            {
                chkE7.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                ParametroCantidad--;
            }
        }

        private void chkE8_CheckedChanged(object sender, EventArgs e)
        {
            if (chkE8.Checked)
            {

                chkE8.BackgroundImage = proyectotaquilla.Properties.Resources.verde;
                ParametroCantidad++;
            }
            else
            {
                chkE8.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                ParametroCantidad--;
            }

        }

        private void chkE9_CheckedChanged(object sender, EventArgs e)
        {
            if (chkE9.Checked)
            {
                ParametroCantidad++;
                chkE9.BackgroundImage = proyectotaquilla.Properties.Resources.verde;

            }
            else
            {
                chkE9.BackgroundImage = proyectotaquilla.Properties.Resources.gris;
                ParametroCantidad--;
            }
        }

        private void lblValorTotal_Click(object sender, EventArgs e)
        {



            lblValorTotal.Text = precio.ToString(); 
        }

        private void txtprecio_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void butacas_Load(object sender, EventArgs e)
        {
            lblasientos.Text = comparar.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void lblasientos_Click(object sender, EventArgs e)
        {
            lblasientos.Text = comparar.ToString();
        }
    }
}
