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

namespace cinepolis
{
    public partial class Form1 : Form
    {
        
        encriptado encrip = new encriptado();

        public Form1()
        {
            InitializeComponent();
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        public static MySqlConnection ObtenerConexion()
        {
            string sdireccion = "localhost";
            string susuario = "root";
            string spass = "";

            MySqlConnection Conn = new MySqlConnection("server='" + sdireccion + "'; database= bdcinetopia; Uid= '" + susuario + "' ;pwd=  '" + spass + "';");
            Conn.Open();
                return Conn;
       
        }
        private static int revisar(string f, string g)
        {
            int resultado = -1;
            MySqlConnection conexion = ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("Select nomusuario ,contusuario From usuario Where nomusuario = '{0}' and contusuario ='{1}'", f, g), conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                resultado = 50;
            }
            conexion.Close();
            return resultado;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int resultado = -1;
            MySqlConnection conexion = ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("Select nomusuario ,pk_idrole From usuario Where nomusuario = '{0}' and pk_idrole  = 1", txt_usuario.Text), conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                resultado = 50;
            }
            conexion.Close();
            if (revisar(txt_usuario.Text, encrip.EncryptKey(txt_pass.Text)) > 0)
            {
                if (resultado > 0)
                {
                    this.Hide();
                    seleccion a = new seleccion(txt_usuario.Text);
                    a.ShowDialog();


                }
                else
                {
                    this.Hide();
                    mantenimiento a = new mantenimiento(txt_usuario.Text);
                    a.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show(" USUARIO O CONTRASEÑA INCORRECTA");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

