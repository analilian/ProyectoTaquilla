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
using System.Net;
using System.Net.NetworkInformation;
//programador:Rodrigo Sifontes
//inicio 31/07/2016  fin: 14/08/2016


namespace cinepolis
{
    // reutlizacion de codigo
    class conexionymanipulacion
    {

        string connect = "server=localhost; database= bdcinetopia; Uid=root  ;pwd= ;";
        MySqlConnection conexion;

        //conexion
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
        // ejecutar querys
        public void EjecutarQuery(String Query)
        {
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            int Ifilasafectadas = comando.ExecuteNonQuery();
            if (Ifilasafectadas > 0)
                MessageBox.Show("Operacion realizada con exitosamente");
        }

        public void EjecutarQuery1(String Query)
        {
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            int Ifilasafectadas = comando.ExecuteNonQuery();
   
        }
        //actualizar y llenar los datagrid
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
        //se obtine ip del ordenador
        public string ip()
        {
            IPHostEntry host;
            string localIP="";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            }
           
            return localIP;

        }
        // la opcion buscar dentro de un datagrid
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
