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
using System.Drawing;
using System.Data;
using System.Threading;
using System.IO;
namespace proyectotaquilla
{
    public partial class Boletos : Form
    {
        public Boletos()
        {
            InitializeComponent();
        }

        public int cantidadNiño = 0;
        public int cantidadAdulto = 0;
        public static int cantidadTotal = 0;
        String Stabla = "tarifa";
        MySqlConnection conexion;
        public void Conectar()
        {
            conexion = new MySqlConnection("server=localhost; database= bdcinetopia; Uid=root;pwd=;");
            conexion.Open();
        }
        private void Boletos_Load(object sender, EventArgs e)
        {
           

            conexion.Open();
            String costoAdulto = "select costotarifa from tarifa WHERE pkidedad=1";
            MySqlCommand comando = new MySqlCommand(costoAdulto, conexion);
            comando.ExecuteNonQuery();

            lblCostoAdulto.Text = costoAdulto;

           
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
                cantidadNiño =  cantidadNiño-1;
                lblcantidadNiño.Text = cantidadNiño.ToString();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            butacas butacas = new butacas();
            this.Hide();
            butacas.Show();
            cantidadTotal = cantidadNiño + cantidadAdulto;
            MessageBox.Show("total de boletos:  " + cantidadTotal);
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
                if (cantidadNiño == 0)
                {
                    btnQuitarAdulto.Enabled = false;
                }
        }

        
    }
    
}
