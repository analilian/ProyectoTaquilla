using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace proyectotaquilla
{
    class conexionn
    {
        MySqlConnection conexion;
        public void Conectar()
        {
            conexion = new MySqlConnection("server=localhost; database= bdcinetopiaa; Uid=root;pwd=;");
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

    }

}