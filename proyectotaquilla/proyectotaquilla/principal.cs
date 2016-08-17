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

namespace proyectotaquilla
{

    public partial class FPrincipal : Form
    {

        conexionn conect = new conexionn();

        MySqlConnection conexion = new MySqlConnection("server=localhost; database=bdcinetopiaa; Uid=root; pwd=;");

        public FPrincipal()
        {
            InitializeComponent();
        }

        private void bvercartelera_Click(object sender, EventArgs e)
        {

            string selecine = cbComplejo.SelectedItem.ToString();
            string seleregion = cbo_region.SelectedItem.ToString();
            cartelera carte = new cartelera(seleregion, selecine);
            this.Hide();
            carte.Show();


        }

        private void FPrincipal_Load(object sender, EventArgs e)
        {
            timer1.Start();
            cbr();
           // cbr2();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pBfoto2.Visible == true)
            {
                pBfoto2.Visible = false;
                pBfoto3.Visible = true;

            }
            else if (pBfoto3.Visible == true)
            {
                pBfoto3.Visible = false;
                pBfoto4.Visible = true;

            }
            else if (pBfoto4.Visible == true)
            {
                pBfoto4.Visible = false;
                pBfoto5.Visible = true;

            }
            else if (pBfoto5.Visible == true)
            {
                pBfoto5.Visible = false;
                pBfoto2.Visible = true;

            }
        }
        //Nombre_del_programador:Ana Lilian
        //Fecha de inicio: 11/08/2016
        //Fecha finalizacion: 11/08/2016

        private void cbr()
        {

            string s = "select * from bdcinetopiaa.region";

            conexion.Open();

            MySqlCommand mcd = new MySqlCommand(s, conexion);
            MySqlDataReader mdr = mcd.ExecuteReader();

            while (mdr.Read())
            {
                cbo_region.Items.Add(mdr.GetString("nombreregion"));
            }

            
            conexion.Close();

        }

        private void cbo_region_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cbo_region.SelectedItem.ToString();
            cbComplejo.Items.Clear();

            cbr2(selected);


        }

        //Nombre_del_programador:Ana Lilian
        //Fecha de inicio: 11/08/2016
        //Fecha finalizacion: 11/08/2016

        private void cbr2(string sel)
        {

            // Object selectedItem = cbo_region.SelectedItem;

            string d = "select * from cine ci,region reg where nombreregion='" + sel + "' && ci.pk_idregion=reg.pk_idregion";

            conexion.Open();

            MySqlCommand mcd = new MySqlCommand(d, conexion);
            MySqlDataReader mdr = mcd.ExecuteReader();

            while (mdr.Read())
            {
                cbComplejo.Items.Add(mdr.GetString("nomcine"));
             
            }
            cbComplejo.ResetText();
            conexion.Close();
            
        }

       
    }
}




