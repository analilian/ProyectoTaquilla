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
    public partial class sinopsis : Form
    {
        conexionn conect = new conexionn();

        MySqlConnection conexion = new MySqlConnection("server=192.168.0.10; database=bdcinetopiaa; Uid=ana; pwd=1234;");

        public string vinculop;
        public string descp;
        public string nombrep;
        public string descripcion;
        public sinopsis()
        {
            InitializeComponent();
        }


        //Nombre_del_programador:Ana Lilian
        //Fecha de inicio: 13/08/2016
        //Fecha finalizacion: 13/08/2016

        public sinopsis(string vinc, string des, string nomb)
        {
            InitializeComponent();
            descp = des;
            //MessageBox.Show(descp);
            
            vinculop = vinc;
            //MessageBox.Show(vinc);


            nombrep=nomb;
            llama(nombrep);
            //MessageBox.Show(nombrep);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cartelera carte = new cartelera();
            this.Hide();
            carte.Show();
        }

        private void sinopsis_Load(object sender, EventArgs e)
        {

            
            //llama();
        }


        //Nombre_del_programador:Ana Lilian
        //Fecha de inicio: 17/08/2016
        //Fecha finalizacion: 17/08/2016

        private void llama(string nombre)
        {

            string descripci;

            string sq1 = "select * from pelicula where nompelicula='" + nombre + "'";
            conexion.Open();
            MySqlCommand comando2 = new MySqlCommand(sq1, conexion);
            MySqlDataReader mdr2 = comando2.ExecuteReader();
//            MessageBox.Show(sq1);
            
            while (mdr2.Read())
            {
                descripci = mdr2.GetString("despelicula");
                label1.Text = descripci;
            //    MessageBox.Show(descripci);
            }

            conexion.Close();

            axShockwaveFlash1.Movie=vinculop;
            //axShockwaveFlash1.MovieData ="https://www.youtube.com/watch?v=zjOw2ynQ3QQ";

        }

        private void axShockwaveFlash1_Enter(object sender, EventArgs e)
        {

        }
    }
}
