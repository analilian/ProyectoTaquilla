using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

//programador:Rodrigo Sifontes


namespace cinepolis
{
    
    class conexionymanipulacion
    {

        string connect = "server=localhost; database= bdcinetopia; Uid= root  ;pwd= ;";
        MySqlConnection conexion;
        
        public void Conectar()
        {
            conexion = new MySqlConnection(connect);
            conexion.Open();
           
        }
        public MySqlConnection rutaconectada()
        {
            conexion = new MySqlConnection(connect);
            conexion.Open();
            return conexion;
        }
        public string Ruta ()
        {
            return connect;
           
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
