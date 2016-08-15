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
        conexionymanipulacion conect = new conexionymanipulacion();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
       
        private static int revisar(string f, string g)
        {
            int resultado = -1;
            conexionymanipulacion conect = new conexionymanipulacion();
            conect.Conectar();
            MySqlCommand comando = new MySqlCommand(string.Format("Select nomusuario ,contusuario From usuario Where nomusuario = '{0}' and contusuario ='{1}'", f, g), conect.rutaconectada());
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                resultado = 50;
            }
            conect.Desconectar();
            return resultado;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int resultado = -1;
            conexionymanipulacion conect = new conexionymanipulacion();
            conect.Conectar();
            MySqlCommand comando = new MySqlCommand(string.Format("Select nomusuario ,pk_idrole From usuario Where nomusuario = '{0}' and pk_idrole  = 1", txt_usuario.Text), conect.rutaconectada());
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                resultado = 50;
            }
            conect.Desconectar();
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

