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
            conexion = new MySqlConnection("server=localhost; database= bdcinetopia; Uid=root;pwd=;");
            conexion.Open();
        }
        public void Desconectar()
        {
            conexion.Close();
        }

        public void EjecutarQuery(String Query)
        {
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            int Ifilasafectadas = comando.ExecuteNonQuery();
            if (Ifilasafectadas > 0)
                MessageBox.Show("Operacion realizada con exitosamente");
        }
     public void actualizargrid(DataGridView dg, String SQuery, String Stabla)
        {
            this.Conectar();
            DataSet midataset = new DataSet();
            MySqlDataAdapter miadapter = new MySqlDataAdapter(SQuery, conexion);
            miadapter.Fill(midataset,Stabla);
            dg.DataSource = midataset;
            dg.DataMember = Stabla;
            this.Desconectar();

        }
        public void buscarquery(String Squery)
        {
            MySqlCommand Micomando = new MySqlCommand(Squery, conexion);
            int FilasAfectadas = Micomando.ExecuteNonQuery();
            if (FilasAfectadas > 0)
                MessageBox.Show("No se encontro el Registro", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Busqueda Realizada", "Musqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      
    }
}
