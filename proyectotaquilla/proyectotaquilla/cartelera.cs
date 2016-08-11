using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Data;
using System.Threading;
using System.IO;
namespace proyectotaquilla
{
    public partial class cartelera : Form
    {
        conexionn conect = new conexionn();

        MySqlConnection conexion = new MySqlConnection("server=localhost; database=bdcinetopia; Uid=root; pwd=;");

        public cartelera(string seleccion)
        {
            InitializeComponent();
            string complejo = seleccion;
            llenado(complejo);
        }


        public cartelera()
        {
            InitializeComponent();

        }
        private void Ejemplo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sinopsis sinop = new sinopsis();
            this.Hide();
            sinop.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            butacas butacas = new butacas();
            this.Hide();
            butacas.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
        
        private void cartelera_Load(object sender, EventArgs e)
        {
            
        }


        
        private void llenado(string comple)
        {
            //string s = "SELECT * FROM cinessala, cartelerapelicula, cine, pelicula,horario WHERE cinessala.pk_idcinesal = cartelerapelicula.pk_idcinesal AND cine.pk_idcine = cinessala.pk_idcine and cine.nomcine = '"+comple+"' and cartelerapelicula.pk_idpelicula = pelicula.pk_idpelicula and cartelerapelicula.pk_idhorario = horario.pk_idhorario group by(pelicula.nompelicula)";
            string s = "SELECT p.nompelicula, p.imagenpelicula, p.pk_idfcar, cp.pk_idcinesal, cp.pk_idhorario, cp.pk_idproyeccion FROM cinessala cs, cartelerapelicula cp, cine c, pelicula p,horario h WHERE cs.pk_idcinesal = cp.pk_idcinesal AND c.pk_idcine = cs.pk_idcine and c.nomcine = '"+comple+"' and cp.pk_idpelicula = p.pk_idpelicula and cp.pk_idhorario = h.pk_idhorario group by(p.nompelicula)";
            conexion.Open();

            //MySqlCommand mcd = new MySqlCommand(s, conexion);
            //MySqlDataReader mdr = mcd.ExecuteReader();

            DataTable dt = new DataTable();
            MySqlCommand comando = new MySqlCommand(s, conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            adaptador.Fill(dt);
            DataRow fila = dt.Rows[0];
            string sid = Convert.ToString(fila[0]);
            MessageBox.Show(sid);

            int idd = Convert.ToInt32(fila[2]);
            string ss = Convert.ToString(idd);
            MessageBox.Show(ss);
            string sql1 = "select imagenpelicula from pelicula where pk_idpelicula='" + idd + "'";
           
            MySqlCommand command = new MySqlCommand(sql1,conexion);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            byte[] img = (byte[])(reader[0]);
            if (img == null)
            {
                pbImagen1.Image = null;
            }

            else
            {
                MemoryStream ms = new MemoryStream(img);
                pbImagen1.Image = Image.FromStream(ms);
            }

            // while (mdr.Read())
            //{

            //btnHor1.Items.Add(mdr.GetString("nombreregion"));

            //pbImagen1.Image.Save(mdr.GetString("imagenpelicula"));
            //(mdr.GetString("nomcine"));
            //}


            conexion.Close();

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }

}

