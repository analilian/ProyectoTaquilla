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

        MySqlConnection conexion = new MySqlConnection("server=localhost; database=bdcinetopia; Uid=root; pwd=;");

        public frm_Horarios()
        {
            InitializeComponent();
        }

        //Nombre_del_programador:Ana Lilian
        //Fecha de inicio: 15/08/2016
        //Fecha finalizacion: 15/08/2016

        public frm_Horarios(string nombrepeli, string comple)
        {
            InitializeComponent();
            llenadohorario(nombrepeli,comple);
            MessageBox.Show(nombrepeli);
            MessageBox.Show(comple);
        }


        private void frm_Horarios_Load(object sender, EventArgs e)
        {

        }

        //Nombre_del_programador:Ana Lilian
        //Fecha de inicio: 15/08/2016
        //Fecha finalizacion: 15/08/2016

        private void llenadohorario(string nompelicula, string complejo)
        {
            string s = "select h.horainiciohor from cine c, cinessala cs, cartelerapelicula cp,pelicula p, fechascartelera fc, tipoproyeccion tp, horario h  where p.nompelicula = '"+nompelicula+ "' and c.nomcine = '" + complejo + "' and c.pk_idcine = cs.pk_idcine and cs.pk_idcinesal = cp.pk_idcinesal and cp.pk_idpelicula = p.pk_idpelicula and cp.pk_idproyeccion = tp.pk_idproyeccion and cp.pk_idhorario = h.pk_idhorario and p.pk_idfcar = fc.pk_idfcar";
            conexion.Open();
            DataTable dt = new DataTable();
            MySqlCommand comando = new MySqlCommand(s, conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            adaptador.Fill(dt);
            DataRow fila = dt.Rows[0];
            string sid = Convert.ToString(fila[0]);

            btnHor1.Text = sid;
            if(sid!= null)
            {
                btnHor2.Text = sid;
            }

        }

        private void btnHor1_Click(object sender, EventArgs e)
        {
            boletos boletos = new boletos();
            Hide();
            boletos.Show();
        }
    }
}
