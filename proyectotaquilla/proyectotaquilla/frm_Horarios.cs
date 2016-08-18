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
    public partial class frm_Horarios : Form
    {
        conexionn conect = new conexionn();

        MySqlConnection conexion = new MySqlConnection("server=192.168.0.10; database=bdcinetopiaa; Uid=ana; pwd=1234;");
        public string descripcion;
        public string vinculo;
        public string nombre;
        public string complejo;
        public string nombrepelicula;
        public string regi;
        
        //public string tiproyeccion;
        //public string tipocarpeli;
        //public string tipcinesal;
        //public string horariosele;
        //public string horarioselect;
        //public DateTime horarioselectd;
        //public string nombrepelicula;
        //public string compleejo;

//        public string vincu;
  //      public string desc;


        public frm_Horarios()
        {
            InitializeComponent();
        }

        //Nombre_del_programador:Ana Lilian
        //Fecha de inicio: 15/08/2016
        //Fecha finalizacion: 15/08/2016

        public frm_Horarios(string nombrepeli, string comple, string region)
        {
            InitializeComponent();
            llenadohorario(nombrepeli,comple);
            //        nombrepeli = nombrepelicula;
            complejo = comple;
            nombrepelicula = nombrepeli;
            regi = region;
            //      comple = compleejo;
            nombre = nombrepeli;
            //MessageBox.Show(nombrepeli);
            //MessageBox.Show(comple);
            //MessageBox.Show(region);
          //  string sregion = region;

        //    butacas but = new butacas(sregion,tipocarpeli,tiproyeccion,tipcinesal);
            //boletos bole = new boletos(tiproyeccion);



        }


        private void frm_Horarios_Load(object sender, EventArgs e)
        {

        }

        //Nombre_del_programador:Ana Lilian
        //Fecha de inicio: 15/08/2016
        //Fecha finalizacion: 16/08/2016

        private void llenadohorario(string nompelicula, string complejo)
        {
            //string spelicula = "select pk_idpelicula from pelicula where nompelicula='" + nompelicula + "'";
            //int idpelicula = Co(spelicula);
            string s = "select h.horainiciohor from cine c, cinessala cs, cartelerapelicula cp,pelicula p, fechascartelera fc, tipoproyeccion tp, horario h  where p.nompelicula = '"+nompelicula+ "' and c.nomcine = '" + complejo + "' and c.pk_idcine = cs.pk_idcine and cs.pk_idcinesal = cp.pk_idcinesal and cp.pk_idpelicula = p.pk_idpelicula and cp.pk_idproyeccion = tp.pk_idproyeccion and cp.pk_idhorario = h.pk_idhorario and p.pk_idfcar = fc.pk_idfcar";
            
            conexion.Open();
            //DataTable dt = new DataTable();
            MySqlCommand comando = new MySqlCommand(s, conexion);
            MySqlDataReader mdr = comando.ExecuteReader();

            while (mdr.Read())
            {
                cbo_Horario.Items.Add(mdr.GetString("horainiciohor"));
            }

            conexion.Close();

            string sq = "select * from pelicula where nompelicula='"+nompelicula+"'";
            conexion.Open();
            MySqlCommand comando1 = new MySqlCommand(sq, conexion);
            MySqlDataReader mdr1 = comando1.ExecuteReader();

            while (mdr1.Read())
            {
                descripcion = mdr1.GetString("despelicula");
                //MessageBox.Show(descripcion);
            }

            conexion.Close();

            string sq1 = "select * from pelicula where nompelicula='" + nompelicula + "'";
            conexion.Open();
            MySqlCommand comando2 = new MySqlCommand(sq1, conexion);
            MySqlDataReader mdr2 = comando2.ExecuteReader();

            while (mdr2.Read())
            {
                vinculo = mdr2.GetString("vinculopelicula");
                //MessageBox.Show(vinculo);
            }

            conexion.Close();

            
            //string tproyeccion = "select cp.pk_idproyeccion from cine c, cinessala cs, cartelerapelicula cp,pelicula p, fechascartelera fc, tipoproyeccion tp, horario h  where p.nompelicula = '" + nombrepelicula + "' and c.nomcine = '" + compleejo + "' and c.pk_idcine = cs.pk_idcine and cs.pk_idcinesal = cp.pk_idcinesal and cp.pk_idpelicula = p.pk_idpelicula and cp.pk_idproyeccion = tp.pk_idproyeccion and cp.pk_idhorario = h.pk_idhorario and p.pk_idfcar = fc.pk_idfcar";

            //conexion.Open();

            //DataTable dt = new DataTable();
            //MySqlCommand comandoo = new MySqlCommand(tproyeccion, conexion);
            //MySqlDataAdapter adaptador = new MySqlDataAdapter(comandoo);
            //adaptador.Fill(dt);
            //DataRow fila = dt.Rows[0];
            //string sid = Convert.ToString(fila[0]);
            //tiproyeccion = sid;

            //            MessageBox.Show(tiproyeccion);


            //conexion.Close();



            //            conexion.Open();
            //string tcarpeli = "select cp.pk_idcarpelicula from cine c, cinessala cs, cartelerapelicula cp,pelicula p, fechascartelera fc, tipoproyeccion tp, horario h  where p.nompelicula = '" + nompelicula + "' and c.nomcine = '" + complejo + "' and c.pk_idcine = cs.pk_idcine and cs.pk_idcinesal = cp.pk_idcinesal and cp.pk_idpelicula = p.pk_idpelicula and cp.pk_idproyeccion = tp.pk_idproyeccion and cp.pk_idhorario = h.pk_idhorario and p.pk_idfcar = fc.pk_idfcar";

            //            DataTable dt2 = new DataTable();
            //          MySqlCommand comando2 = new MySqlCommand(tcarpeli, conexion);
            //        MySqlDataAdapter adaptador2 = new MySqlDataAdapter(comando2);
            //      adaptador2.Fill(dt2);
            //    DataRow fila2 = dt2.Rows[0];
            //  string sid2 = Convert.ToString(fila2[0]);
            //tipocarpeli = sid2;

            //          MessageBox.Show(sid2);
            //          conexion.Close();

            //        conexion.Open();
            //       string tcinesal = "select cs.pk_idcinesal from cine c, cinessala cs, cartelerapelicula cp,pelicula p, fechascartelera fc, tipoproyeccion tp, horario h  where p.nompelicula = '" + nompelicula + "' and c.nomcine = '" + complejo + "' and c.pk_idcine = cs.pk_idcine and cs.pk_idcinesal = cp.pk_idcinesal and cp.pk_idpelicula = p.pk_idpelicula and cp.pk_idproyeccion = tp.pk_idproyeccion and cp.pk_idhorario = h.pk_idhorario and p.pk_idfcar = fc.pk_idfcar";

            //     DataTable dt3 = new DataTable();
            //   MySqlCommand comando3 = new MySqlCommand(tcinesal, conexion);
            // MySqlDataAdapter adaptador3 = new MySqlDataAdapter(comando3);
            //         adaptador3.Fill(dt3);
            //       DataRow fila3 = dt3.Rows[0];
            //     string sid3 = Convert.ToString(fila3[0]);
            //   tipcinesal = sid3;

            //        MessageBox.Show(sid3);
            // conexion.Close();


        }

        private void btnHor1_Click(object sender, EventArgs e)
        {
            //boletos boletos = new boletos();
            //Hide();
            //boletos.Show();
        }

        private void btnHor3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //Nombre_del_programador:Ana Lilian
        //Fecha de inicio: 17/08/2016
        //Fecha finalizacion: 17/08/2016

        private void btn_seleboleto_Click(object sender, EventArgs e)
        {
            //var horarioseleee = cbo_Horario.SelectedItem.GetType();
            //horarioselectd = Convert.ToTime(horariosele);
            int idproye;
            string tproyeccion = "select cp.pk_idproyeccion from cine c, cinessala cs, cartelerapelicula cp,pelicula p, fechascartelera fc, tipoproyeccion tp, horario h where c.nomcine = '" + complejo + "' and c.pk_idcine = cs.pk_idcine and cs.pk_idcinesal = cp.pk_idcinesal and cp.pk_idpelicula = p.pk_idpelicula and cp.pk_idproyeccion = tp.pk_idproyeccion and cp.pk_idhorario = h.pk_idhorario and p.pk_idfcar = fc.pk_idfcar and p.nompelicula='"+nombrepelicula+"'";

            conexion.Open();
            //DataTable dt = new DataTable();
            MySqlCommand comando = new MySqlCommand(tproyeccion, conexion);
            MySqlDataReader mdr = comando.ExecuteReader();
            mdr.Read();
            //while (mdr.Read())
            //{
                idproye = mdr.GetInt32("pk_idproyeccion");
                MessageBox.Show(Convert.ToString(idproye));
                string selehorario = cbo_Horario.SelectedItem.ToString();

                boletos bol = new boletos(idproye, selehorario);
                Hide();
                bol.Show();

            //}


            conexion.Close();
            int idcarpelicula;
            string tcartepelicula = "select cp.pk_idcarpelicula from cine c, cinessala cs, cartelerapelicula cp,pelicula p, fechascartelera fc, tipoproyeccion tp, horario h where c.nomcine = '"+complejo+"' and c.pk_idcine = cs.pk_idcine and cs.pk_idcinesal = cp.pk_idcinesal and cp.pk_idpelicula = p.pk_idpelicula and cp.pk_idproyeccion = tp.pk_idproyeccion and cp.pk_idhorario = h.pk_idhorario and p.pk_idfcar = fc.pk_idfcar and p.nompelicula='"+nombrepelicula+"' and tp.pk_idproyeccion='"+idproye+"'";
            conexion.Open();
            //DataTable dt = new DataTable();
            MySqlCommand comando1 = new MySqlCommand(tcartepelicula, conexion);
            MySqlDataReader mdr1 = comando1.ExecuteReader();
            mdr1.Read();
            //while (mdr1.Read())
            //{
            idcarpelicula = mdr1.GetInt32("pk_idcarpelicula");
            MessageBox.Show(Convert.ToString(idcarpelicula));

            //Hide();
            //but.Show();

            //}


            conexion.Close();
            int idcinesa;
            string tcinesala = "select cs.pk_idcinesal from cine c, cinessala cs, cartelerapelicula cp,pelicula p, fechascartelera fc, tipoproyeccion tp, horario h where c.nomcine = '" + complejo + "' and c.pk_idcine = cs.pk_idcine and cs.pk_idcinesal = cp.pk_idcinesal and cp.pk_idpelicula = p.pk_idpelicula and cp.pk_idproyeccion = tp.pk_idproyeccion and cp.pk_idhorario = h.pk_idhorario and p.pk_idfcar = fc.pk_idfcar and p.nompelicula='" + nombrepelicula + "' and tp.pk_idproyeccion='" + idproye + "'";
            conexion.Open();
            //DataTable dt = new DataTable();
            MySqlCommand comando2 = new MySqlCommand(tcinesala, conexion);
            MySqlDataReader mdr2 = comando2.ExecuteReader();
            mdr2.Read();
            //while (mdr1.Read())
            //{
            idcinesa = mdr2.GetInt32("pk_idcinesal");
            MessageBox.Show(Convert.ToString(idcinesa));

            //Hide();
            //but.Show();

            //}


            conexion.Close();

            butacas but = new butacas(idcarpelicula, idcinesa,regi);




        }

        private void button4_Click(object sender, EventArgs e)
        {

            sinopsis sinop = new sinopsis(vinculo,descripcion,nombre);
            
            //string descripcion="select * from pelicula where nompelicula = '" + nombrepelicula + "'";
            
          //  conexion.Open();


            //MySqlCommand comando = new MySqlCommand(descripcion, conexion);
           // MySqlDataReader mdr = comando.ExecuteReader();

            //while (mdr.Read())
           // {
             //   desc = mdr.GetString("despelicula");
            //}

            //conexion.Close();
 //           string vinculo = "select * from pelicula where nompelicula = '" + nombrepelicula + "'";
 
 //           conexion.Open();
   //         MySqlCommand comando1 = new MySqlCommand(vinculo, conexion);
     //       MySqlDataReader mdr1 = comando1.ExecuteReader();

       //     while (mdr1.Read())
         //   {
           //     vincu = mdr1.GetString("vinculopelicula");
            //}

            //conexion.Close();

            //sinopsis sino = new sinopsis();
            Hide();
            sinop.Show();

        }
    }
}
