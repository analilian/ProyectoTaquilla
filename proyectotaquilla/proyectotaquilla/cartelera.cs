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

        MySqlConnection conexion = new MySqlConnection("server=192.168.0.10; database=bdcinetopiaa; Uid=ana; pwd=1234;");
        public String nompeli;
        public String nompeli2;
        public String nompeli3;
        public String nompeli4;
        public String nompeli5;
        public String nompeli6;
        public String nompeli7;
        public String nompeli8;
        public String nompeli9;
        public String nompeli10;
        public String com;
        //public String proyeccion;
        public string sregion;


        //Nombre_del_programador:Ana Lilian
        //Fecha de inicio: 15/08/2016
        //Fecha finalizacion: 15/08/2016

        public cartelera(string seleccionregion,string seleccioncine)
        {
            InitializeComponent();
            //public string comp = seleccion;
            sregion = seleccionregion;
             
            com = seleccioncine;
            MessageBox.Show(sregion);
            MessageBox.Show(com);
            llenado(com);

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

        //Nombre_del_programador:Ana Lilian
        //Fecha de inicio: 13/08/2016
        //Fecha finalizacion: 17/08/2016


        private void llenado(string comple)
        {
            //string s = "SELECT * FROM cinessala, cartelerapelicula, cine, pelicula,horario WHERE cinessala.pk_idcinesal = cartelerapelicula.pk_idcinesal AND cine.pk_idcine = cinessala.pk_idcine and cine.nomcine = '"+comple+"' and cartelerapelicula.pk_idpelicula = pelicula.pk_idpelicula and cartelerapelicula.pk_idhorario = horario.pk_idhorario group by(pelicula.nompelicula)";
            //string s = "select p.nompelicula, p.despelicula, p.vinculopelicula, fc.fechainicar, fc.fechafinalcar, tp.nomtproyecccion, h.horainiciohor from cine c, cinessala cs, cartelerapelicula cp,pelicula p, fechascartelera fc, tipoproyeccion tp, horario h where c.nomcine = '" + comple + "' and c.pk_idcine = cs.pk_idcine and cs.pk_idcinesal = cp.pk_idcinesal and cp.pk_idpelicula = p.pk_idpelicula and cp.pk_idproyeccion = tp.pk_idproyeccion and cp.pk_idhorario = h.pk_idhorario and p.pk_idfcar = fc.pk_idfcar";
            string s = "select p.nompelicula from cine c, cinessala cs, cartelerapelicula cp,pelicula p, fechascartelera fc, tipoproyeccion tp, horario h where c.nomcine = '" + comple + "' and c.pk_idcine = cs.pk_idcine and cs.pk_idcinesal = cp.pk_idcinesal and cp.pk_idpelicula = p.pk_idpelicula and cp.pk_idproyeccion = tp.pk_idproyeccion and cp.pk_idhorario = h.pk_idhorario and p.pk_idfcar = fc.pk_idfcar";
            //string s1 = "select p.nompelicula, cp.pk_idproyeccion from cine c, cinessala cs, cartelerapelicula cp,pelicula p, fechascartelera fc, tipoproyeccion tp, horario h where c.nomcine = '" + comple + "' and c.pk_idcine = cs.pk_idcine and cs.pk_idcinesal = cp.pk_idcinesal and cp.pk_idpelicula = p.pk_idpelicula and cp.pk_idproyeccion = tp.pk_idproyeccion and cp.pk_idhorario = h.pk_idhorario and p.pk_idfcar = fc.pk_idfcar";


            //string sproyeccion = "select tp.pk_idproyeccion from cine c, cinessala cs, cartelerapelicula cp, pelicula p, fechascartelera fc, tipoproyeccion tp, horario h where c.nomcine = '" + comple + "'  and c.pk_idcine = cs.pk_idcine and cs.pk_idcinesal = cp.pk_idcinesal and cp.pk_idpelicula = p.pk_idpelicula and cp.pk_idproyeccion = tp.pk_idproyeccion and cp.pk_idhorario = h.pk_idhorario and p.pk_idfcar = fc.pk_idfcar and cp.pk_idpelicula=5";

            conexion.Open();

            //MySqlCommand mcd = new MySqlCommand(s, conexion);
            //MySqlDataReader mdr = mcd.ExecuteReader();
            //proyeccion = sproyeccion;
            //MessageBox.Show(proyeccion);
            DataTable dt = new DataTable();
            MySqlCommand comando = new MySqlCommand(s, conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            adaptador.Fill(dt);
            DataRow fila = dt.Rows[0];

            string numerofilas = Convert.ToString(dt.Rows.Count);
            int numfilas = dt.Rows.Count;
            //MessageBox.Show(numerofilas);

            object[] rowArray = new object[10];

            int r = numfilas;
           
            object[] rowArray1 = new object[10];
            int j = 0;
            foreach (DataColumn dc in dt.Columns) 
            {
                foreach (DataRow dtRow in dt.Rows)
                {
                 

                    var nombpeli = dtRow[dc].ToString();
                    int x = 0;
                    rowArray[x] = dtRow[dc];
                    rowArray1[j] = rowArray[x];
                    j++;

                }

            }
           
            //for (int c = 0; c < numfilas; c++)
            //{
                LilNombre1.Text = rowArray1[0].ToString();
                LilNombre1.Visible = true;
                nompeli = LilNombre1.Text;
                LilNombre2.Text = rowArray1[1].ToString();
                LilNombre2.Visible = true;
                nompeli2 = LilNombre2.Text;
                LilNombre3.Text = rowArray1[2].ToString();
                LilNombre3.Visible = true;
            nompeli3 = LilNombre3.Text;
            LilNombre4.Text = rowArray1[3].ToString();
                LilNombre4.Visible = true;
            nompeli4 = LilNombre4.Text;
            LilNombre5.Text = rowArray1[4].ToString();
                LilNombre5.Visible = true;
            nompeli5 = LilNombre5.Text;
            LilNombre6.Text = rowArray1[5].ToString();
                LilNombre6.Visible = true;
            nompeli6 = LilNombre6.Text;
            LilNombre7.Text = rowArray1[6].ToString();
                LilNombre7.Visible = true;
            nompeli7 = LilNombre7.Text;
            LilNombre8.Text = rowArray1[7].ToString();
                LilNombre8.Visible = true;
            nompeli8 = LilNombre8.Text;
            LilNombre9.Text = rowArray1[8].ToString();
                LilNombre9.Visible = true;
            nompeli9 = LilNombre9.Text;
            LilNombre10.Text = rowArray1[9].ToString();
                LilNombre10.Visible = true;
            nompeli10 = LilNombre10.Text;


            //MessageBox.Show(nompeli);
            //MessageBox.Show(nompeli2);
            //MessageBox.Show(nompeli3);
            //MessageBox.Show(nompeli4);
            //MessageBox.Show(nompeli5);
            //MessageBox.Show(nompeli6);
            //MessageBox.Show(nompeli7);
            //MessageBox.Show(nompeli8);
            //MessageBox.Show(nompeli9);
            //MessageBox.Show(nompeli10);

            conexion.Close();
            //LilNombre11.Text = rowArray1[10].ToString();
            //LilNombre11.Visible = true;
            //panel1.Controls.Add(new LinkLabel()

            //                {

            //                Name = "LilNombre" + c,
            //            Text = rowArray1[c].ToString(),
            //        Left = c * 100,
            //    Width = 100,

            //                    });

            //}


            //string sql1 = "select p.imagenpelicula from cine c, cinessala cs, cartelerapelicula cp, pelicula p, fechascartelera fc, tipoproyeccion tp, horario h where c.nomcine = '" + comple + "' and c.pk_idcine = cs.pk_idcine and cs.pk_idcinesal = cp.pk_idcinesal and cp.pk_idpelicula = p.pk_idpelicula and cp.pk_idproyeccion = tp.pk_idproyeccion and cp.pk_idhorario = h.pk_idhorario and p.pk_idfcar = fc.pk_idfcar";

            string sql = "select p.imagenpelicula from pelicula p where p.nompelicula='" + nompeli + "'";
            conexion.Open();

            MySqlCommand command = new MySqlCommand(sql, conexion);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            byte[] img = (byte[])(reader[0]);
            if (img == null)
            {
                pb_Imagen1.Image = null;
            }
            
            else
            {
                MemoryStream ms = new MemoryStream(img);
                pb_Imagen1.Image = Image.FromStream(ms);
                pb_Imagen1.Visible = true;
            }
            conexion.Close();
            string sql2 = "select p.imagenpelicula from pelicula p where p.nompelicula='" + nompeli2 + "'";
            conexion.Open();

            MySqlCommand command2 = new MySqlCommand(sql2, conexion);
            MySqlDataReader reader2 = command2.ExecuteReader();
            reader2.Read();
            byte[] img2 = (byte[])(reader2[0]);
            if (img2 == null)
            {
                pb_Imagen2.Image = null;
            }

            else
            {
                MemoryStream ms = new MemoryStream(img2);
                pb_Imagen2.Image = Image.FromStream(ms);
                pb_Imagen2.Visible = true;
            }


            // while (mdr.Read())
            //{

            //btnHor1.Items.Add(mdr.GetString("nombreregion"));

            //pbImagen1.Image.Save(mdr.GetString("imagenpelicula"));
            //(mdr.GetString("nomcine"));
            //}


            conexion.Close();
            string sql3 = "select p.imagenpelicula from pelicula p where p.nompelicula='" + nompeli3 + "'";
            conexion.Open();

            MySqlCommand command3 = new MySqlCommand(sql3, conexion);
            MySqlDataReader reader3 = command3.ExecuteReader();
            reader3.Read();
            byte[] img3 = (byte[])(reader3[0]);
            if (img3 == null)
            {
                pb_Imagen3.Image = null;
            }

            else
            {
                MemoryStream ms = new MemoryStream(img3);
                pb_Imagen3.Image = Image.FromStream(ms);
                pb_Imagen3.Visible = true;
            }



            conexion.Close();

            string sql4 = "select p.imagenpelicula from pelicula p where p.nompelicula='" + nompeli4 + "'";
            conexion.Open();

            MySqlCommand command4 = new MySqlCommand(sql4, conexion);
            MySqlDataReader reader4 = command4.ExecuteReader();
            reader4.Read();
            byte[] img4 = (byte[])(reader4[0]);
            if (img4 == null)
            {
                pb_Imagen4.Image = null;
            }

            else
            {
                MemoryStream ms = new MemoryStream(img4);
                pb_Imagen4.Image = Image.FromStream(ms);
                pb_Imagen4.Visible = true;
                
            }



            conexion.Close();

            string sql5 = "select p.imagenpelicula from pelicula p where p.nompelicula='" + nompeli5 + "'";
            conexion.Open();

            MySqlCommand command5 = new MySqlCommand(sql5, conexion);
            MySqlDataReader reader5 = command5.ExecuteReader();
            reader5.Read();
            byte[] img5 = (byte[])(reader5[0]);
            if (img5 == null)
            {
                pb_Imagen5.Image = null;
            }

            else
            {
                MemoryStream ms = new MemoryStream(img5);
                pb_Imagen5.Image = Image.FromStream(ms);
                pb_Imagen5.Visible = true;
            }



            conexion.Close();

            string sql6 = "select p.imagenpelicula from pelicula p where p.nompelicula='" + nompeli6 + "'";
            conexion.Open();

            MySqlCommand command6 = new MySqlCommand(sql6, conexion);
            MySqlDataReader reader6 = command6.ExecuteReader();
            reader6.Read();
            byte[] img6 = (byte[])(reader6[0]);
            if (img6 == null)
            {
                pb_Imagen6.Image = null;
            }

            else
            {
                MemoryStream ms = new MemoryStream(img6);
                pb_Imagen6.Image = Image.FromStream(ms);
                pb_Imagen6.Visible = true;
            }



            conexion.Close();

            string sql7 = "select p.imagenpelicula from pelicula p where p.nompelicula='" + nompeli7 + "'";
            conexion.Open();

            MySqlCommand command7 = new MySqlCommand(sql7, conexion);
            MySqlDataReader reader7 = command7.ExecuteReader();
            reader7.Read();
            byte[] img7 = (byte[])(reader7[0]);
            if (img7 == null)
            {
                pb_Imagen7.Image = null;
            }

            else
            {
                MemoryStream ms = new MemoryStream(img7);
                pb_Imagen7.Image = Image.FromStream(ms);
                pb_Imagen7.Visible = true;
            }



            conexion.Close();

            string sql8 = "select p.imagenpelicula from pelicula p where p.nompelicula='" + nompeli8 + "'";
            conexion.Open();

            MySqlCommand command8 = new MySqlCommand(sql8, conexion);
            MySqlDataReader reader8 = command8.ExecuteReader();
            reader8.Read();
            byte[] img8 = (byte[])(reader8[0]);
            if (img8 == null)
            {
                pb_Imagen8.Image = null;
            }

            else
            {
                MemoryStream ms = new MemoryStream(img8);
                pb_Imagen8.Image = Image.FromStream(ms);
                pb_Imagen8.Visible = true;
            }



            conexion.Close();

            string sql9 = "select p.imagenpelicula from pelicula p where p.nompelicula='" + nompeli9 + "'";
            conexion.Open();

            MySqlCommand command9 = new MySqlCommand(sql9, conexion);
            MySqlDataReader reader9 = command9.ExecuteReader();
            reader9.Read();
            byte[] img9 = (byte[])(reader9[0]);
            if (img9 == null)
            {
                pb_Imagen9.Image = null;
            }

            else
            {
                MemoryStream ms = new MemoryStream(img9);
                pb_Imagen9.Image = Image.FromStream(ms);
                pb_Imagen9.Visible = true;
            }



            conexion.Close();

            string sql10 = "select p.imagenpelicula from pelicula p where p.nompelicula='" + nompeli10 + "'";
                    conexion.Open();

            MySqlCommand command10 = new MySqlCommand(sql10, conexion);
            MySqlDataReader reader10 = command10.ExecuteReader();
            reader10.Read();
            byte[] img10 = (byte[])(reader10[0]);
            if (img10 == null)
            {
                pb_Imagen10.Image = null;
            }

            else
            {
                MemoryStream ms = new MemoryStream(img10);
                pb_Imagen10.Image = Image.FromStream(ms);
                pb_Imagen10.Visible = true;
            }



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
            frm_Horarios horarios = new frm_Horarios(nompeli,com,sregion);
            Hide();
            horarios.Show();

        }
        
        private void llNombre2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void llNombre1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Horarios horarios = new frm_Horarios(nompeli, com, sregion);
            Hide();
            horarios.Show();

            
           //boletos bolet = new boletos(proyeccion);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void LilNombre1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Horarios horarios = new frm_Horarios(nompeli, com, sregion);
            Hide();
            horarios.Show();

        }

        private void LilNombre2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Horarios horarios = new frm_Horarios(nompeli2, com, sregion);
            Hide();
            horarios.Show();

        }

        private void LilNombre3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Horarios horarios = new frm_Horarios(nompeli3, com, sregion);
            Hide();
            horarios.Show();

        }

        private void LilNombre4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Horarios horarios = new frm_Horarios(nompeli4, com, sregion);
            Hide();
            horarios.Show();

        }

        private void LilNombre5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Horarios horarios = new frm_Horarios(nompeli5, com, sregion);
            Hide();
            horarios.Show();

        }

        private void LilNombre6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Horarios horarios = new frm_Horarios(nompeli6, com, sregion);
            Hide();
            horarios.Show();

        }

        private void LilNombre7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Horarios horarios = new frm_Horarios(nompeli7, com, sregion);
            Hide();
            horarios.Show();

        }

        private void LilNombre8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Horarios horarios = new frm_Horarios(nompeli8, com, sregion);
            Hide();
            horarios.Show();

        }

        private void LilNombre9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Horarios horarios = new frm_Horarios(nompeli9, com, sregion);
            Hide();
            horarios.Show();

        }

        private void LilNombre10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Horarios horarios = new frm_Horarios(nompeli10, com, sregion);
            Hide();
            horarios.Show();

        }

        private void LilNombre11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Horarios horarios = new frm_Horarios(nompeli, com, sregion);
            Hide();
            horarios.Show();

        }

        private void LilNombre12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Horarios horarios = new frm_Horarios(nompeli, com, sregion);
            Hide();
            horarios.Show();

        }
    }

}

