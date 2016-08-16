using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using MySql.Data.MySqlClient;
//----------------------------------Precio y Cantidad de Boletos por Roberto Portillo 0901-13-20332-------------------------
namespace proyectotaquilla
{
    public partial class boletos : Form
    {
        public boletos()
        {
            InitializeComponent();
        }
        public int cantidadNiño = 0;
        public int cantidadAdulto = 0;
        public int cantidadTotal = 0;
        int PrecioTotal = 0;
        int TotalNiño = 0;
        int TotalAdulto = 0;

        MySqlConnection conection = new MySqlConnection("server=localhost; database= bdcinetopia; Uid=root; pwd=;");
   
        private void button1_Click(object sender, EventArgs e)
        {
            PrecioTotal = TotalNiño + TotalAdulto;
            cantidadTotal = cantidadNiño + cantidadAdulto;
            butacas butacas = new butacas(cantidadTotal, PrecioTotal);
        
            butacas.Show();
            this.Hide();

           
            MessageBox.Show("total de boletos:  " + cantidadTotal);
            MessageBox.Show("total a Pagar:  " + PrecioTotal);
        }

        private void btnAgregarNiño_Click(object sender, EventArgs e)
        {

            if (cantidadNiño >= 0)
            {
                cantidadNiño = 1 + cantidadNiño;

                lblcantidadNiño.Text = cantidadNiño.ToString();
                btnQuitarNiño.Enabled = true;
            }
            else
                if (cantidadNiño == 0)
                {
                    btnQuitarNiño.Enabled = false;
                }

            //--------------------------------------------------------------
            conection.Open();

            String costoNiño2D = "SELECT `costotarifa` FROM `tarifa` WHERE `pk_idtarifas`= '2' AND pk_idedad = '2'";
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conection;

            comando.CommandText = costoNiño2D;

            MySqlDataReader leer = comando.ExecuteReader();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    leer.Read();
                    lblCostoNiños.Text = leer["costotarifa"].ToString();

                    int CostoNiño = int.Parse(lblCostoNiños.Text);

                    TotalNiño = cantidadNiño * CostoNiño;
                    lblSubNiños.Text = TotalNiño.ToString();

                }
                conection.Close();
            }
        }

        private void btnQuitarNiño_Click(object sender, EventArgs e)
        {
            if (cantidadNiño <= 0)
            {
                btnQuitarNiño.Enabled = false;
            }
            else
            {
                btnQuitarNiño.Enabled = true;
                cantidadNiño = cantidadNiño - 1;
                lblcantidadNiño.Text = cantidadNiño.ToString();
            }
            //----------------------------------------------
            conection.Open();

            String costoNiño2D = "SELECT `costotarifa` FROM `tarifa` WHERE `pk_idtarifas`= '2' AND pk_idedad = '2'";
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conection;

            comando.CommandText = costoNiño2D;

            MySqlDataReader leer = comando.ExecuteReader();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    leer.Read();
                    lblCostoNiños.Text = leer["costotarifa"].ToString();

                    int CostoNiño = int.Parse(lblCostoNiños.Text);

                    TotalNiño = cantidadNiño * CostoNiño;
                    lblSubNiños.Text = TotalNiño.ToString();

                }
                conection.Close();
            }
        }

        private void btnAgregarAdulto_Click(object sender, EventArgs e)
        {


            if (cantidadAdulto >= 0)
            {
                cantidadAdulto = 1 + cantidadAdulto;

                lblCantidadAdulto.Text = cantidadAdulto.ToString();
                btnQuitarAdulto.Enabled = true;
            }
            else
                if (cantidadAdulto == 0)
                {
                    btnQuitarAdulto.Enabled = false;
                }
            //-------------------------------------------------------------------------------------------------------------  

            conection.Open();

            String costoAdulto2D = "SELECT `costotarifa` FROM `tarifa` WHERE `pk_idtarifas`= '1' AND pk_idedad = '1'";
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conection;

            comando.CommandText = costoAdulto2D;

            MySqlDataReader leer = comando.ExecuteReader();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    leer.Read();
                    lblCostoAdulto.Text = leer["costotarifa"].ToString();
                    int CostoAdulto = int.Parse(lblCostoAdulto.Text);

                    TotalAdulto = cantidadAdulto * CostoAdulto;
                    lblSubAdulto.Text = TotalAdulto.ToString();
                }

                conection.Close();
            }
            
        }

        private void btnQuitarAdulto_Click(object sender, EventArgs e)
        {
            if (cantidadAdulto <= 0)
            {
                btnQuitarAdulto.Enabled = false;
            }
            else
            {
                btnQuitarAdulto.Enabled = true;
                cantidadAdulto = cantidadAdulto - 1;
                lblCantidadAdulto.Text = cantidadAdulto.ToString();
            }

            //-------------------------------------------------------------------------------------------------------------  

            conection.Open();

            String costoAdulto2D = "SELECT `costotarifa` FROM `tarifa` WHERE `pk_idtarifas`= '1' AND pk_idedad = '1'";
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conection;

            comando.CommandText = costoAdulto2D;

            MySqlDataReader leer = comando.ExecuteReader();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    leer.Read();
                    lblCostoAdulto.Text = leer["costotarifa"].ToString();
                    int CostoAdulto = int.Parse(lblCostoAdulto.Text);

                    TotalAdulto = cantidadAdulto * CostoAdulto;
                    lblSubAdulto.Text = TotalAdulto.ToString();
                }

                conection.Close();
            }
        }
    }
}
