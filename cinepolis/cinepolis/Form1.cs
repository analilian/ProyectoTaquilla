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


        private static int validarusuario(string r)
        {
            conexionymanipulacion con = new conexionymanipulacion();
            string cad1 = r;
            int resp=0;
            int resultado = 0;

            DataTable dt = new DataTable();
            String sQuery = "SELECT nomusuario FROM usuario WHERE nomusuario= '" + r + "'";
            MySqlCommand comando = new MySqlCommand(sQuery, con.rutaconectada());
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            adaptador.Fill(dt);
            DataRow fila = dt.Rows[0];
            string cad2 = Convert.ToString(fila[0]);
            resultado = cad2.CompareTo(cad1);

            if(resultado == 0)
            {
                resp = 1;
            }

            return resp;

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
                    if (validarusuario(txt_usuario.Text) == 1)
                    {
                        conect.Conectar();
                        String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + txt_usuario.Text + "','" + conect.ip() + "','inicio sesion', NOW());";
                        conect.EjecutarQuery1(Query);
                        conect.Desconectar();
                        this.Hide();
                        seleccion a = new seleccion(txt_usuario.Text);
                        a.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTA", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }




                }
                else
                {
                    if (validarusuario(txt_usuario.Text) == 1)
                    {
                        conect.Conectar();
                        String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + txt_usuario.Text + "','" + conect.ip() + "','inicio sesion', NOW());";
                        conect.EjecutarQuery1(Query);
                        conect.Desconectar();
                        this.Hide();
                        mantenimiento a = new mantenimiento(txt_usuario.Text);
                        a.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTA", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                    }




                }
            }
            else
            {
                MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTA", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private const string ayudacinetopiaadministrativa = "Title of this help project.chm";
        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, Application.StartupPath + @"/" + ayudacinetopiaadministrativa);
        }
    }
}

