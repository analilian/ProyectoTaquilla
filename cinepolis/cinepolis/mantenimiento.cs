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
using System.Threading;
using System.IO;
namespace cinepolis
{
    public partial class mantenimiento : Form
    {
        public bool Enabled { get; set; }
        string usuario;
        MySqlCommand comand;
        conexionymanipulacion con = new conexionymanipulacion();
        String Stabla = "pelicula";
        MySqlConnection conexion = new MySqlConnection("server=localhost; database=bdcinetopia ; Uid=root;pwd=;");
        string imgLoc;
        String Squeery = "select * from pelicula";
        public mantenimiento(string usu)
        {

            InitializeComponent();
            con.actualizargrid(dgv_insertar, Squeery, Stabla);
            con.actualizargrid(dgv_buscar_pelicula, Squeery, Stabla);
            con.actualizargrid(dgv_modificar_pelicula, Squeery, Stabla);
            this.usuario = usu;
            realizar();

        }
        public mantenimiento()
        {

            InitializeComponent();
            con.actualizargrid(dgv_insertar, Squeery, Stabla);
            con.actualizargrid(dgv_buscar_pelicula, Squeery, Stabla);
            con.actualizargrid(dgv_modificar_pelicula, Squeery, Stabla);


        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 r = new Form1();
            r.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            seleccion r = new seleccion();
            r.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void mantenimiento_Load(object sender, EventArgs e)
        {

        }

        private void txt_nombre1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nombre1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Este campo solo debe llevar letras", "validacion de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_mod_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Este campo solo debe llevar letras", "validacion de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_portada_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files(*.jpg)|*.jpg|GIF Files(*.gif)|*.gif|All Files(*.*)|*.*";
                dlg.Title = "Selecciones su foto de perfil";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    pic_portada.ImageLocation = imgLoc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            byte[] img = null;
            FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);
            string sql = "Insert Into pelicula (nompelicula,despelicula,imagenpelicula,vinculopelicula,pkidsala,pkididioma,pkidproyeccion,pkidclasificacion,pkidcategorias,pkidcine,pkidfcar)values('" + txt_nombre1.Text + "','" + txt_descrip.Text + "',@img'" + txt_trailer.Text + "','" + cbo_sala.Text + "','" + cbo_idioma.Text + "','" + cbo_proyeccion.Text + "','" + cbo_clasificacion.Text + "','" + cbo_categoria.Text + "','" + cbo_cine.Text + "','" + cbo_fecha.Text + "')";
            if (conexion.State != ConnectionState.Open)
                conexion.Open();
            comand = new MySqlCommand(sql, conexion);
            comand.Parameters.Add(new MySqlParameter("@img", img));
            int x = comand.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show(" Registro guardado");
            this.Hide();
            con.actualizargrid(dgv_insertar, Squeery, Stabla);
            con.actualizargrid(dgv_buscar_pelicula, Squeery, Stabla);
            con.actualizargrid(dgv_modificar_pelicula, Squeery, Stabla);
        }

        private void btn_buscarmod_Click(object sender, EventArgs e)
        {
            con.Conectar();
            String Squerys = ("Select* from pelicula where nompelicula='" + txt_modificarbuscar.Text + "%' or despelicula= '" + txt_modificarbuscar.Text + "%' or vinculopelicula ='" + txt_modificarbuscar.Text + "%'or pkidsala ='" + txt_modificarbuscar.Text + "%'or pkididioma ='" + txt_modificarbuscar.Text + "%'or pkidproyeccion ='" + txt_modificarbuscar.Text + "%'or pkidclasificacion ='" + txt_modificarbuscar.Text + "%'or pkidcategoria ='" + txt_modificarbuscar.Text + "%'or pkidcine ='" + txt_modificarbuscar.Text + "%'or pkidfcar ='" + txt_modificarbuscar.Text + "%';");
            con.buscarquery(Squerys);
            con.actualizargrid(dgv_modificar_pelicula, Squerys, Stabla);
            con.Desconectar();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            txt_mod_nombre.Text = this.dgv_modificar_pelicula.CurrentRow.Cells[1].Value.ToString();
            txt_mod_descrip.Text = this.dgv_modificar_pelicula.CurrentRow.Cells[2].Value.ToString();
            pic_mod_portada.ImageLocation = this.dgv_modificar_pelicula.CurrentRow.Cells[3].Value.ToString();
            txt_mod_trailer.Text = this.dgv_modificar_pelicula.CurrentRow.Cells[4].Value.ToString();
            cbo_mod_sala.Text = this.dgv_modificar_pelicula.CurrentRow.Cells[5].Value.ToString();
            cbo_mod_idioma.Text = this.dgv_modificar_pelicula.CurrentRow.Cells[6].Value.ToString();
            cbo_mod_proyeccion.Text = this.dgv_modificar_pelicula.CurrentRow.Cells[7].Value.ToString();
            cbo_mod_clasificacion.Text = this.dgv_modificar_pelicula.CurrentRow.Cells[8].Value.ToString();
            cbo_mod_categoria.Text = this.dgv_modificar_pelicula.CurrentRow.Cells[9].Value.ToString();
            cbo_mod_cine.Text = this.dgv_modificar_pelicula.CurrentRow.Cells[10].Value.ToString();
            cbo_mod_cine.Text = this.dgv_modificar_pelicula.CurrentRow.Cells[11].Value.ToString();
            cbo_mod_fecha.Text = this.dgv_modificar_pelicula.CurrentRow.Cells[12].Value.ToString();

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            con.Conectar();
            String Squerys = ("Select* from pelicula where nompelicula='" + txt_buscar.Text + "%' or despelicula= '" + txt_buscar.Text + "%' or vinculopelicula ='" + txt_buscar.Text + "%'or pkidsala ='" + txt_buscar.Text + "%'or pkididioma ='" + txt_buscar.Text + "%'or pkidproyeccion ='" + txt_buscar.Text + "%'or pkidclasificacion ='" + txt_buscar.Text + "%'or pkidcategoria ='" + txt_buscar.Text + "%'or pkidcine ='" + txt_buscar.Text + "%'or pkidfcar ='" + txt_buscar.Text + "%';");
            con.buscarquery(Squerys);
            con.actualizargrid(dgv_modificar_pelicula, Squerys, Stabla);
            con.Desconectar();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            String SCelda = this.dgv_buscar_pelicula.CurrentRow.Cells[0].Value.ToString();
            var Vresultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Vresultado == DialogResult.Yes)
            {
                con.Conectar();
                String Squerys = "delete from  pelicula  where pkidpelicula = '" + SCelda + "';";
                con.EjecutarQuery(Squerys);
                con.actualizargrid(dgv_insertar, Squeery, Stabla);
                con.actualizargrid(dgv_buscar_pelicula, Squeery, Stabla);
                con.actualizargrid(dgv_modificar_pelicula, Squeery, Stabla);
                con.Desconectar();

            }
            else
            {
                return;
            }
        }

        private void btn_extraer_Click(object sender, EventArgs e)
        {
            byte[] img = null;
            FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);
            string sql = "Insert Into pelicula (nompelicula,despelicula,imagenpelicula,vinculopelicula,pkidsala,pkididioma,pkidproyeccion,pkidclasificacion,pkidcategorias,pkidcine,pkidfcar)values('" + txt_mod_nombre.Text + "','" + txt_mod_descrip.Text + "',@img'" + txt_mod_trailer.Text + "','" + cbo_mod_sala.Text + "','" + cbo_mod_idioma.Text + "','" + cbo_mod_proyeccion.Text + "','" + cbo_mod_clasificacion.Text + "','" + cbo_mod_categoria.Text + "','" + cbo_mod_cine.Text + "','" + cbo_mod_fecha.Text + "')";
            if (conexion.State != ConnectionState.Open)
                conexion.Open();
            comand = new MySqlCommand(sql, conexion);
            comand.Parameters.Add(new MySqlParameter("@img", img));
            int x = comand.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show(" Registro guardado");
            this.Hide();
            con.actualizargrid(dgv_insertar, Squeery, Stabla);
            con.actualizargrid(dgv_buscar_pelicula, Squeery, Stabla);
            con.actualizargrid(dgv_modificar_pelicula, Squeery, Stabla);
        }

        private void btn_portada1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files(*.jpg)|*.jpg|GIF Files(*.gif)|*.gif|All Files(*.*)|*.*";
                dlg.Title = "Selecciones su foto de perfil";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    pic_mod_portada.ImageLocation = imgLoc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbl_portadapeli_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_agregar_horario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Horario r = new Horario();
            r.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            sala r = new sala();
            r.ShowDialog();
        }

        private void btn_agregar_clasificacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            clasificacion r = new clasificacion();
            r.ShowDialog();
        }

        private void btn_agregar_btn_agregar_categoria_Click(object sender, EventArgs e)
        {
            this.Hide();
            categoria r = new categoria();
            r.ShowDialog();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            cine r = new cine();
            r.ShowDialog();
        }
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection Conn = new MySqlConnection("server=localhost; database=bdcinetopia; Uid=root; pwd=;");
            Conn.Open();
            return Conn;

        }
        private void realizar()
        {
            int resultado = -1;
            MySqlConnection conexion = ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("Select nomusuario ,pkidrole From usuario Where nomusuario = '{0}' and pkidrole  = 1", usuario), conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                resultado = 50;
            }
            conexion.Close();

            if (resultado < 0)
            {
                btn_regresar.Enabled = false;

            }
        }
    }
}
