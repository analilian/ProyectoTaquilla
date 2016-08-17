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
        public string tiproyeccion;
        public string tipocarpeli;
        public string tipcinesal;

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
            //MessageBox.Show(nombrepeli);
            //MessageBox.Show(comple);
            string sregion = region;

            butacas but = new butacas(sregion,tipocarpeli,tiproyeccion,tipcinesal);



        }


        private void frm_Horarios_Load(object sender, EventArgs e)
        {

        }

        //Nombre_del_programador:Ana Lilian
        //Fecha de inicio: 15/08/2016
        //Fecha finalizacion: 15/08/2016

        private void llenadohorario(string nompelicula, string complejo)
        {
            string spelicula = "select pk_idpelicula from pelicula where nompelicula='" + nompelicula + "'";
            //int idpelicula = Co(spelicula);
            string s = "select h.horainiciohor from cine c, cinessala cs, cartelerapelicula cp,pelicula p, fechascartelera fc, tipoproyeccion tp, horario h  where p.nompelicula = '"+nompelicula+ "' and c.nomcine = '" + complejo + "' and c.pk_idcine = cs.pk_idcine and cs.pk_idcinesal = cp.pk_idcinesal and cp.pk_idpelicula = p.pk_idpelicula and cp.pk_idproyeccion = tp.pk_idproyeccion and cp.pk_idhorario = h.pk_idhorario and p.pk_idfcar = fc.pk_idfcar";
            string tproyeccion = "select tp.nomtproyeccion from cine c, cinessala cs, cartelerapelicula cp,pelicula p, fechascartelera fc, tipoproyeccion tp, horario h  where p.nompelicula = '" + nompelicula + "' and c.nomcine = '" + complejo + "' and c.pk_idcine = cs.pk_idcine and cs.pk_idcinesal = cp.pk_idcinesal and cp.pk_idpelicula = p.pk_idpelicula and cp.pk_idproyeccion = tp.pk_idproyeccion and cp.pk_idhorario = h.pk_idhorario and p.pk_idfcar = fc.pk_idfcar";
            string tcarpeli = "select cp.pk_idcarpelicula from cine c, cinessala cs, cartelerapelicula cp,pelicula p, fechascartelera fc, tipoproyeccion tp, horario h  where p.nompelicula = '"+nompelicula+"' and c.nomcine = '"+complejo+"' and c.pk_idcine = cs.pk_idcine and cs.pk_idcinesal = cp.pk_idcinesal and cp.pk_idpelicula = p.pk_idpelicula and cp.pk_idproyeccion = tp.pk_idproyeccion and cp.pk_idhorario = h.pk_idhorario and p.pk_idfcar = fc.pk_idfcar group by (tp.pk_idproyeccion)";
            string tcinesal = "select cs.pk_idcinesal from cine c, cinessala cs, cartelerapelicula cp,pelicula p, fechascartelera fc, tipoproyeccion tp, horario h  where p.nompelicula = '"+nompelicula+"' and c.nomcine = '"+complejo+"' and c.pk_idcine = cs.pk_idcine and cs.pk_idcinesal = cp.pk_idcinesal and cp.pk_idpelicula = p.pk_idpelicula and cp.pk_idproyeccion = tp.pk_idproyeccion and cp.pk_idhorario = h.pk_idhorario and p.pk_idfcar = fc.pk_idfcar group by (tp.pk_idproyeccion)";

            conexion.Open();
            //DataTable dt = new DataTable();
            MySqlCommand comando = new MySqlCommand(s, conexion);
            MySqlDataReader mdr = comando.ExecuteReader();

            tiproyeccion = tproyeccion;
            tipocarpeli = tcarpeli;
            tipcinesal = tcinesal;
            while (mdr.Read())
            {
                cbo_Horario.Items.Add(mdr.GetString("horainiciohor"));
            }


            conexion.Close();


        }

        private void btnHor1_Click(object sender, EventArgs e)
        {
            boletos boletos = new boletos();
            Hide();
            boletos.Show();
        }

        private void btnHor3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_seleboleto_Click(object sender, EventArgs e)
        {

        }
    }
}
