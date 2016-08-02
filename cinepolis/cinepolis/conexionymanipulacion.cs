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



namespace cinepolis
{
    class conexionymanipulacion
    {
        MySqlConnection conexion;
        public void Conectar()
        {
            conexion = new MySqlConnection("server=localhost; database=; Uid=root;pwd=;");
            conexion.Open();
        }
        public void Desconectar()
        {
            conexion.Close();
        }

        public void EjecutarQuery(String Query)
        {
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            int filasafectadas = comando.ExecuteNonQuery();
            if (filasafectadas > 0)
                MessageBox.Show("Operacion realizada con exitosamente");
        }
     public void actualizargrid(DataGridView dg, String Query, String tabla)
        {
            this.Conectar();
            DataSet midataset = new DataSet();
            MySqlDataAdapter miadapter = new MySqlDataAdapter(Query, conexion);
            miadapter.Fill(midataset,tabla);
            dg.DataSource = midataset;
            dg.DataMember = tabla;
            this.Desconectar();

        }
    }
}
