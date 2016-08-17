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

        MySqlConnection conexion = new MySqlConnection("server=localhost; database=bdcinetopiaa; Uid=root; pwd=;");
        public String nompeli;
        public String com;
        public String proyeccion;
        public string sregion;
        public cartelera(string seleccionregion,string seleccion)
        {
            InitializeComponent();
            //public string comp = seleccion;
            sregion = seleccionregion;
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

        //Nombre_del_programador:Ana Lilian
        //Fecha de inicio: 13/08/2016
        //Fecha finalizacion: 13/08/2016


        private void llenado(string comple)
        {
            //string s = "SELECT * FROM cinessala, cartelerapelicula, cine, pelicula,horario WHERE cinessala.pk_idcinesal = cartelerapelicula.pk_idcinesal AND cine.pk_idcine = cinessala.pk_idcine and cine.nomcine = '"+comple+"' and cartelerapelicula.pk_idpelicula = pelicula.pk_idpelicula and cartelerapelicula.pk_idhorario = horario.pk_idhorario group by(pelicula.nompelicula)";
            //string s = "select p.nompelicula, p.despelicula, p.vinculopelicula, fc.fechainicar, fc.fechafinalcar, tp.nomtproyecccion, h.horainiciohor from cine c, cinessala cs, cartelerapelicula cp,pelicula p, fechascartelera fc, tipoproyeccion tp, horario h where c.nomcine = '" + comple + "' and c.pk_idcine = cs.pk_idcine and cs.pk_idcinesal = cp.pk_idcinesal and cp.pk_idpelicula = p.pk_idpelicula and cp.pk_idproyeccion = tp.pk_idproyeccion and cp.pk_idhorario = h.pk_idhorario and p.pk_idfcar = fc.pk_idfcar";
            string s = "select p.nompelicula from cine c, cinessala cs, cartelerapelicula cp,pelicula p, fechascartelera fc, tipoproyeccion tp, horario h where c.nomcine = '" + comple + "' and c.pk_idcine = cs.pk_idcine and cs.pk_idcinesal = cp.pk_idcinesal and cp.pk_idpelicula = p.pk_idpelicula and cp.pk_idproyeccion = tp.pk_idproyeccion and cp.pk_idhorario = h.pk_idhorario and p.pk_idfcar = fc.pk_idfcar";


            string sproyeccion = "select tp.pk_idproyeccion from cine c, cinessala cs, cartelerapelicula cp, pelicula p, fechascartelera fc, tipoproyeccion tp, horario h where c.nomcine = '" + comple + "'  and c.pk_idcine = cs.pk_idcine and cs.pk_idcinesal = cp.pk_idcinesal and cp.pk_idpelicula = p.pk_idpelicula and cp.pk_idproyeccion = tp.pk_idproyeccion and cp.pk_idhorario = h.pk_idhorario and p.pk_idfcar = fc.pk_idfcar and cp.pk_idpelicula=5";

            conexion.Open();

            //MySqlCommand mcd = new MySqlCommand(s, conexion);
            //MySqlDataReader mdr = mcd.ExecuteReader();
            proyeccion = sproyeccion;

            DataTable dt = new DataTable();
            MySqlCommand comando = new MySqlCommand(s, conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            adaptador.Fill(dt);
            DataRow fila = dt.Rows[0];
  //          DataColumn dc= dt.Columns[0];

            //for (int i = 0; i <= 9; i++) { 
            //foreach(DataRow dt in comando) { 
            
            //MessageBox.Show(sid);
            /////            llNombre1.Text = sid;
            ////            llNombre2.Text = sid;

            //            }
            string numerofilas = Convert.ToString(dt.Rows.Count);
            int numfilas = dt.Rows.Count;
            MessageBox.Show(numerofilas);
            //programador:rodrigo Sifontes 17/08/2016 fin 17/08/2016
            //ayuda con problema de llenado de peliculas
            object[] rowArray = new object[10];

            int r = numfilas;
           
            object[] rowArray1 = new object[10];
            int j = 0;
            foreach (DataColumn dc in dt.Columns) 
            {
                foreach (DataRow dtRow in dt.Rows)
                {
                 

                        ////int x = 0;
                        var nombpeli = dtRow[dc].ToString();
                    int x = 0;
                    rowArray[x] = dtRow[dc];
                    rowArray1[j] = rowArray[x];
                    j++;
                    


                }

            }
           
            for (int c = 0; c < numfilas; c++)
            {
                panel1.Controls.Add(new LinkLabel()

                {

                    Name = "llNombre" + c,
                    Text = rowArray1[c].ToString(),
                    Left = c * 100,
                    Width = 100
                });
                
            }
            //fin de solucion

            /* for (int y = 0; y <= numfilas; y++)
             {
             //      int r = y;
             //rowArray[r] = dtRow[dc];
             MessageBox.Show(rowArray[x].ToString()+"asdf");
             panel1.Controls.Add(new LinkLabel()

             {

               Name = "llNombre" + y,
               Text = rowArray[x].ToString(),
               Left = y*100,
               Width =100
             });

         }*/

            ////}

            ////                if (numerofilas != null)
            ////                {
            ///                panel1.Controls.Clear();
            ////             for (int i = 0; i <= numfilas; i++)

            ///          {
            ///      string[] nomarreglo = dtRow[dc];
            ///    var nombrepeli = dtRow[dc].ToString();
            ///              panel1.Controls.Add(new LinkLabel()

            ////         {

            ////              Name = "llNombre" + i,
            ////          Text = nombpeli,
            ////      Left = i*100,
            ////  Width =100
            ////});

            ////}
            ////}

            ////if (numerofilas != null)
            ////{
            ////panel1.Controls.Clear();
            ////int i=0;
            ////for(int i = 0; i <= numfilas;i++)

            ////{
            //string[] nomarreglo = dtRow[dc];
            ////var nombrepeli = dtRow[dc].ToString();
            ////panel1.Controls.Add(new LinkLabel()

            ////{
            ////Name = "llNombre" + i,
            ////Text = rowArray[x].ToString(),
            ////Left = 100,
            ////Width = i*100
            ////});


            //// }
            ////}

            //     }
            //llNombre1.Text = nombpeli;
            //   }

            //var nombrepeli = dtRow[dc].ToString();
            //string nombpeli = dtRow[dc].ToString();
            //MessageBox.Show(nombrepeli);
            //*LinkLabel llNombre1 = new System.Windows.Forms.LinkLabel();
            //llNombre1.Location = new System.Drawing.Point(300, 130);
            //llNombre1.Name = "Hola";
            //llNombre1.Size = new System.Drawing.Size(120, 21);
            //llNombre1.TabIndex = 0;
            //llNombre1.Text = nombrepeli;
            //Controls.Add(llNombre1);

            ////if (numerofilas != null)
            ////{
            //// panel1.Controls.Clear();
            ////  for (int i = 0; i <= numfilas; i++)

            ////  {
            //string[] nomarreglo = dtRow[dc];
            ////var nombpeli = dtRow[dc].ToString();
            //// panel1.Controls.Add(new LinkLabel()

            //// {

            //// Name = "llNombre" + i,
            //// Text = nombpeli,
            //// Left = i * 100,
            ////  Width = 100
            //// });

            ////}
            ////}

            string sql1 = "select p.imagenpelicula from cine c, cinessala cs, cartelerapelicula cp, pelicula p, fechascartelera fc, tipoproyeccion tp, horario h where c.nomcine = '" + comple + "' and c.pk_idcine = cs.pk_idcine and cs.pk_idcinesal = cp.pk_idcinesal and cp.pk_idpelicula = p.pk_idpelicula and cp.pk_idproyeccion = tp.pk_idproyeccion and cp.pk_idhorario = h.pk_idhorario and p.pk_idfcar = fc.pk_idfcar";

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
    }

}

