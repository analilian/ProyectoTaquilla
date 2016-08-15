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
        public String nompeli;
        public String com;

        public cartelera(string seleccion)
        {
            InitializeComponent();
            //public string comp = seleccion;
            string complejo = seleccion;
            com = complejo;
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
            boletos boletos = new boletos();
            this.Hide();
            boletos.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            boletos boletos = new boletos();
            this.Hide();
            boletos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            boletos boletos = new boletos();
            this.Hide();
            boletos.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            boletos boletos = new boletos();
            this.Hide();
            boletos.Show();
        }

        private void cartelera_Load(object sender, EventArgs e)
        {

        }



        private void llenado(string comple)
        {
            //string s = "SELECT * FROM cinessala, cartelerapelicula, cine, pelicula,horario WHERE cinessala.pk_idcinesal = cartelerapelicula.pk_idcinesal AND cine.pk_idcine = cinessala.pk_idcine and cine.nomcine = '"+comple+"' and cartelerapelicula.pk_idpelicula = pelicula.pk_idpelicula and cartelerapelicula.pk_idhorario = horario.pk_idhorario group by(pelicula.nompelicula)";
            string s = "select p.nompelicula, p.despelicula, p.vinculopelicula, fc.fechainicar, fc.fechafinalcar, tp.nomtproyecccion, h.horainiciohor from cine c, cinessala cs, cartelerapelicula cp,pelicula p, fechascartelera fc, tipoproyeccion tp, horario h where c.nomcine = '" + comple + "' and c.pk_idcine = cs.pk_idcine and cs.pk_idcinesal = cp.pk_idcinesal and cp.pk_idpelicula = p.pk_idpelicula and cp.pk_idproyeccion = tp.pk_idproyeccion and cp.pk_idhorario = h.pk_idhorario and p.pk_idfcar = fc.pk_idfcar";
            conexion.Open();

            //MySqlCommand mcd = new MySqlCommand(s, conexion);
            //MySqlDataReader mdr = mcd.ExecuteReader();

            DataTable dt = new DataTable();
            MySqlCommand comando = new MySqlCommand(s, conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            adaptador.Fill(dt);
            DataRow fila = dt.Rows[0];
            string sid = Convert.ToString(fila[0]);
            nompeli=sid;

            MessageBox.Show(sid);
            //MessageBox.Show(nompeli);

            llNombre1.Text = sid;
            if (sid != null)
            {
                llNombre2.Text = sid;
            }
            else
            {
                MessageBox.Show("No hay mas peliculas");
            }

            //llNombre1 = sid;

            //int idd = Convert.ToInt32(fila[2]);
            //string ss = Convert.ToString(idd);
            //MessageBox.Show(ss);


            string sql1 = "select p.imagenpelicula from cine c, cinessala cs, cartelerapelicula cp, pelicula p, fechascartelera fc, tipoproyeccion tp, horario h where c.nomcine = '"+comple+"' and c.pk_idcine = cs.pk_idcine and cs.pk_idcinesal = cp.pk_idcinesal and cp.pk_idpelicula = p.pk_idpelicula and cp.pk_idproyeccion = tp.pk_idproyeccion and cp.pk_idhorario = h.pk_idhorario and p.pk_idfcar = fc.pk_idfcar";

            MySqlCommand command = new MySqlCommand(sql1, conexion);
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

        private void btnHor4_Click(object sender, EventArgs e)
        {
            boletos boletos = new boletos();
            this.Hide();
            boletos.Show();
        }

        private void btnHor5_Click(object sender, EventArgs e)
        {
            boletos boletos = new boletos();
            this.Hide();
            boletos.Show();
        }

        private void btnHor6_Click(object sender, EventArgs e)
        {
            boletos boletos = new boletos();
            this.Hide();
            boletos.Show();
        }

        private void btnHor8_Click(object sender, EventArgs e)
        {
            boletos boletos = new boletos();
            this.Hide();
            boletos.Show();
        }

        private void btnHor9_Click(object sender, EventArgs e)
        {
            boletos boletos = new boletos();
            this.Hide();
            boletos.Show();
        }

        private void btnHor10_Click(object sender, EventArgs e)
        {
            boletos boletos = new boletos();
            this.Hide();
            boletos.Show();
        }

        private void btnHor11_Click(object sender, EventArgs e)
        {
            boletos boletos = new boletos();
            this.Hide();
            boletos.Show();
        }

        private void btnHor12_Click(object sender, EventArgs e)
        {
            boletos boletos = new boletos();
            this.Hide();
            boletos.Show();
        }

        private void btnHor13_Click(object sender, EventArgs e)
        {
            boletos boletos = new boletos();
            this.Hide();
            boletos.Show();
        }

        private void btnHor14_Click(object sender, EventArgs e)
        {
            boletos boletos = new boletos();
            this.Hide();
            boletos.Show();
        }

        private void btnHor15_Click(object sender, EventArgs e)
        {
            boletos boletos = new boletos();
            this.Hide();
            boletos.Show();
        }

        private void llNombre1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Horarios horarios = new frm_Horarios(nompeli,com);
            Hide();
            horarios.Show();

        }
        
        private void llNombre2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }

}

