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
            Boletos boletos = new Boletos();
            this.Hide();
            boletos.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boletos boletos = new Boletos();
            this.Hide();
            boletos.Show();
        }

        private void btnHorario2_Click(object sender, EventArgs e)
        {
            Boletos boletos = new Boletos();
            this.Hide();
            boletos.Show();
        }

        private void btnHorario4_Click(object sender, EventArgs e)
        {
            Boletos boletos = new Boletos();
            this.Hide();
            boletos.Show();
        }

        private void btnHorario5_Click(object sender, EventArgs e)
        {
            Boletos boletos = new Boletos();
            this.Hide();
            boletos.Show();
        }

        private void btnHorario6_Click(object sender, EventArgs e)
        {
            Boletos boletos = new Boletos();
            this.Hide();
            boletos.Show();
        }

        private void btnHorario7_Click(object sender, EventArgs e)
        {
            Boletos boletos = new Boletos();
            this.Hide();
            boletos.Show();
        }

        private void btnHorario8_Click(object sender, EventArgs e)
        {
            Boletos boletos = new Boletos();
            this.Hide();
            boletos.Show();
        }

        private void btnHorario9_Click(object sender, EventArgs e)
        {
            Boletos boletos = new Boletos();
            this.Hide();
            boletos.Show();
        }

        private void btnHorario10_Click(object sender, EventArgs e)
        {
            Boletos boletos = new Boletos();
            this.Hide();
            boletos.Show();
        }

        private void btnHorario11_Click(object sender, EventArgs e)
        {
            Boletos boletos = new Boletos();
            this.Hide();
            boletos.Show();
        }

        private void btnHorario12_Click(object sender, EventArgs e)
        {
            Boletos boletos = new Boletos();
            this.Hide();
            boletos.Show();
        }

        private void btnHorario13_Click(object sender, EventArgs e)
        {
            Boletos boletos = new Boletos();
            this.Hide();
            boletos.Show();
        }

        private void btnHorario14_Click(object sender, EventArgs e)
        {
            butacas butacas = new butacas();
            this.Hide();
            butacas.Show();
        }

        private void btnHorario15_Click(object sender, EventArgs e)
        {
            Boletos boletos = new Boletos();
            this.Hide();
            boletos.Show();
        }

        private void cartelera_Load(object sender, EventArgs e)
        {

        }

        private void llenado(string comple)
        {
            string s = "SELECT * FROM cinessala, cartelerapelicula, cine, pelicula,horario WHERE cinessala.pk_idcinesal = cartelerapelicula.pk_idcinesal AND cine.pk_idcine = cinessala.pk_idcine and cine.nomcine = '" + comple + "' and cartelerapelicula.pk_idpelicula = pelicula.pk_idpelicula and cartelerapelicula.pk_idhorario = horario.pk_idhorario group by(pelicula.nompelicula)";
            conexion.Open();

            MySqlCommand mcd = new MySqlCommand(s, conexion);
            MySqlDataReader mdr = mcd.ExecuteReader();

            while (mdr.Read())
            {
                //btnHor1.Items.Add(mdr.GetString("nombreregion"));

                pbImagen1.Image.Save(mdr.GetString("imagenpelicula"));
                //(mdr.GetString("nomcine"));
            }


            conexion.Close();

        }

    }
}
