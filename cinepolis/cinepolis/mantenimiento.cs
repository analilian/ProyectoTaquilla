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
        String Stabla = "Pelicula";
        MySqlConnection conexion = new MySqlConnection("server=localhost; database=bdcinetopia; Uid=root;pwd=;");
        string imgLoc;
        String Squeery = "select* from pelicula";
        const string MySqlConnecionString = "server=localhost; database=bdcinetopia; Uid=root;pwd=;";
        public mantenimiento(string g)
        {
            InitializeComponent();
            con.actualizargrid(dgv_insertar, Squeery, Stabla);
            con.actualizargrid(dgv_buscar_pelicula, Squeery, Stabla);
            con.actualizargrid(dgv_modificar_pelicula, Squeery, Stabla);
            nombre_columna();
            this.usuario = g;
            realizar();
        }
        public mantenimiento()
        {
            InitializeComponent();
            con.actualizargrid(dgv_insertar, Squeery, Stabla);
            con.actualizargrid(dgv_buscar_pelicula, Squeery, Stabla);
            con.actualizargrid(dgv_modificar_pelicula, Squeery, Stabla);
            nombre_columna();
          

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
            cb1();
            cb2();
            cb3();
            cb4();
            cb5();
            cb6();
            cb7();
            cb8();
            cb9();
            cb10();
            cb11();
            cb12();
        }

        public void limpiaringreso()
        {
            txt_nombre1.Clear();
            txt_trailer.Clear();
            cbo_sala.ResetText();
            cbo_idioma.ResetText();
            cbo_proyeccion.ResetText();
            cbo_clasificacion.ResetText();
            cbo_categoria.ResetText();
            cbo_cine.ResetText();
            cbo_fecha.ResetText();
            txt_descrip.Clear();
            pic_portada.Image = null;
        }

        public void limpiarmod()
        {
            txt_mod_nombre.Clear();
            txt_mod_trailer.Clear();
            cbo_mod_sala.ResetText();
            cbo_mod_idioma.ResetText();
            cbo_mod_proyeccion.ResetText();
            cbo_mod_clasificacion.ResetText();
            cbo_mod_categoria.ResetText();
            cbo_mod_cine.ResetText();
            cbo_mod_fecha.ResetText();
            txt_mod_descrip.Clear();
            pic_mod_portada.Image = null;
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
            string convsala = cbo_sala.SelectedValue.ToString();
            string convidioma = cbo_idioma.SelectedValue.ToString();
            string convproy = cbo_proyeccion.SelectedValue.ToString();
            string convcategoria = cbo_categoria.SelectedValue.ToString();
             string convclacif = cbo_clasificacion.SelectedValue.ToString();
            string convcine = cbo_cine.SelectedValue.ToString();

            if (txt_nombre1.Text == "" || txt_trailer.Text == "" || cbo_sala.Text == "" || cbo_idioma.Text == "" || cbo_proyeccion.Text == "" || cbo_clasificacion.Text == "" || cbo_categoria.Text == "" || cbo_cine.Text == "" || cbo_fecha.Text == "" || txt_descrip.Text == "" || pic_portada.ImageLocation == null)
            {
                MessageBox.Show("Llene todos los campos por favor");
            }
            else
            {

                byte[] img = null;
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                string sql = "Insert Into pelicula (nompelicula,despelicula,imagenpelicula,vinculopelicula,pkidsala,pkididioma,pkidproyeccion,pkidclasificacion,pkidcategorias,pkidcine,pkidfcar)values('" + txt_nombre1.Text + "','" + txt_descrip.Text + "',@img,'" + txt_trailer.Text + "','" + convsala + "','" + convidioma + "','" + convproy + "','" + convclacif + "','" + convcategoria + "','" + convcine + "','" + cbo_fecha.Text + "')";
                if (conexion.State != ConnectionState.Open)
                    conexion.Open();
                comand = new MySqlCommand(sql, conexion);
                comand.Parameters.Add(new MySqlParameter("@img", img));
                int x = comand.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show(" Registro guardado");
                con.actualizargrid(dgv_insertar, Squeery, Stabla);
                con.actualizargrid(dgv_buscar_pelicula, Squeery, Stabla);
                con.actualizargrid(dgv_modificar_pelicula, Squeery, Stabla);
                nombre_columna();
                limpiaringreso();
            }
        }

        private void btn_buscarmod_Click(object sender, EventArgs e)
        {
            con.Conectar();
            String Squerys = ("Select * from pelicula where nompelicula like'" + txt_modificarbuscar.Text + "%' or despelicula like '" + txt_modificarbuscar.Text + "%' or vinculopelicula like'" + txt_modificarbuscar.Text + "%'or pkidsala like'" + txt_modificarbuscar.Text + "%'or pkididioma like'" + txt_modificarbuscar.Text + "%'or pkidproyeccion like'" + txt_modificarbuscar.Text + "%'or pkidclasificacion like'" + txt_modificarbuscar.Text + "%'or pkidcategorias like'" + txt_modificarbuscar.Text + "%'or pkidcine like'" + txt_modificarbuscar.Text + "%'or pkidfcar like'" + txt_modificarbuscar.Text + "%';");
            con.buscarquery(Squerys);
            con.actualizargrid(dgv_modificar_pelicula, Squerys, Stabla);
            nombre_columna();
            con.Desconectar();
            txt_modificarbuscar.Clear();
        }

        string codigo;

       

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            codigo = this.dgv_modificar_pelicula.CurrentRow.Cells[0].Value.ToString();
            txt_mod_nombre.Text = this.dgv_modificar_pelicula.CurrentRow.Cells[1].Value.ToString();
            txt_mod_descrip.Text=this.dgv_modificar_pelicula.CurrentRow.Cells[2].Value.ToString();
            //pic_mod_portada.ImageLocation = this.dgv_modificar_pelicula.CurrentRow.Cells[3].Value.ToString();
          
            txt_mod_trailer.Text= this.dgv_modificar_pelicula.CurrentRow.Cells[4].Value.ToString();
            cbo_mod_sala.Text= this.dgv_modificar_pelicula.CurrentRow.Cells[5].Value.ToString();
            cbo_mod_idioma.Text= this.dgv_modificar_pelicula.CurrentRow.Cells[6].Value.ToString();
            cbo_mod_proyeccion.Text= this.dgv_modificar_pelicula.CurrentRow.Cells[7].Value.ToString();
            cbo_mod_clasificacion.Text= this.dgv_modificar_pelicula.CurrentRow.Cells[8].Value.ToString();
            cbo_mod_categoria.Text= this.dgv_modificar_pelicula.CurrentRow.Cells[9].Value.ToString();
            cbo_mod_cine.Text= this.dgv_modificar_pelicula.CurrentRow.Cells[10].Value.ToString();
            cbo_mod_fecha.Text= this.dgv_modificar_pelicula.CurrentRow.Cells[11].Value.ToString();
            
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            con.Conectar();
            String Squerys = ("Select* from Pelicula where nompelicula like'" + txt_buscar.Text + "%' or despelicula like '" + txt_buscar.Text + "%' or vinculopelicula like'" + txt_buscar.Text + "%'or pkidsala like'" + txt_buscar.Text + "%'or pkididioma like'" + txt_buscar.Text + "%'or pkidproyeccion like'" + txt_buscar.Text + "%'or pkidclasificacion like'" + txt_buscar.Text + "%'or pkidcategorias like'" + txt_buscar.Text + "%'or pkidcine like'" + txt_buscar.Text + "%'or pkidfcar like'" + txt_buscar.Text + "%';");
            con.buscarquery(Squerys);
            con.actualizargrid(dgv_buscar_pelicula, Squerys, Stabla);
            nombre_columna();
            con.Desconectar();
            txt_buscar.Clear();
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
                nombre_columna();
                con.Desconectar();

            }
            else
            {
                return;
            }
        }

        private void btn_extraer_Click(object sender, EventArgs e)
        {
            string convsalamod = cbo_mod_sala.SelectedValue.ToString();
            string convidiomamod = cbo_mod_idioma.SelectedValue.ToString();
            string convproymod = cbo_mod_proyeccion.SelectedValue.ToString();
            string convcategoriamod = cbo_mod_categoria.SelectedValue.ToString();
            string convclacifmod = cbo_mod_clasificacion.SelectedValue.ToString();
            string convcinemod = cbo_mod_cine.SelectedValue.ToString();


            if (txt_mod_nombre.Text == "" || txt_mod_trailer.Text == "" || cbo_mod_sala.Text == "" || cbo_mod_idioma.Text == "" || cbo_mod_proyeccion.Text == "" || cbo_mod_clasificacion.Text == "" || cbo_mod_categoria.Text == "" || cbo_mod_cine.Text == "" || cbo_mod_fecha.Text == "" || txt_mod_descrip.Text == "" || pic_mod_portada.ImageLocation == null)
            {
                MessageBox.Show("Llene todos los campos por favor");
            }
            else
            {

                byte[] img = null;
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                String sql = "update pelicula set nompelicula ='" + txt_mod_nombre.Text + "',despelicula='" + txt_mod_descrip.Text + "' ,imagenpelicula= @img ,vinculopelicula ='" + txt_mod_trailer.Text + "' ,pkidsala='" + convsalamod + "',pkididioma ='" + convidiomamod + "',pkidproyeccion='" + convproymod + "',pkidclasificacion ='" + convclacifmod + "' ,pkidcategorias='" + convcategoriamod + "',pkidcine ='" + convcinemod + "',pkidfcar ='" + cbo_mod_fecha.Text + "'  where pkidpelicula='" + codigo + "'";
                if (conexion.State != ConnectionState.Open)
                    conexion.Open();
                comand = new MySqlCommand(sql, conexion);
                comand.Parameters.Add(new MySqlParameter("@img", img));
                int x = comand.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show(" Registro guardado");
                con.actualizargrid(dgv_insertar, Squeery, Stabla);
                con.actualizargrid(dgv_buscar_pelicula, Squeery, Stabla);
                con.actualizargrid(dgv_modificar_pelicula, Squeery, Stabla);
                nombre_columna();
                limpiarmod();
            }
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

        private void cbo_mod_idioma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbo_mod_proyeccion_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
        public void nombre_columna()
        {
            this.dgv_insertar.Columns[0].HeaderText = "No";
            this.dgv_insertar.Columns[1].HeaderText = "Nombre";
            this.dgv_insertar.Columns[2].HeaderText = "Descripcion";
            this.dgv_insertar.Columns[3].HeaderText = "Portada";
            this.dgv_insertar.Columns[4].HeaderText = "Vinculo";
            this.dgv_insertar.Columns[5].HeaderText = "Sala";
            this.dgv_insertar.Columns[6].HeaderText = "Idioma";
            this.dgv_insertar.Columns[7].HeaderText = "Proyeccion";
            this.dgv_insertar.Columns[8].HeaderText = "Clasificacion";
            this.dgv_insertar.Columns[9].HeaderText = "Categorias";
            this.dgv_insertar.Columns[10].HeaderText = "Cine";
            this.dgv_insertar.Columns[11].HeaderText = "Fecha en Cartelera";
            this.dgv_buscar_pelicula.Columns[0].HeaderText = "No";
            this.dgv_buscar_pelicula.Columns[1].HeaderText = "Nombre";
            this.dgv_buscar_pelicula.Columns[2].HeaderText = "Descripcion";
            this.dgv_buscar_pelicula.Columns[3].HeaderText = "Portada";
            this.dgv_buscar_pelicula.Columns[4].HeaderText = "Vinculo";
            this.dgv_buscar_pelicula.Columns[5].HeaderText = "Sala";
            this.dgv_buscar_pelicula.Columns[6].HeaderText = "Idioma";
            this.dgv_buscar_pelicula.Columns[7].HeaderText = "Proyeccion";
            this.dgv_buscar_pelicula.Columns[8].HeaderText = "Clasificacion";
            this.dgv_buscar_pelicula.Columns[9].HeaderText = "Categorias";
            this.dgv_buscar_pelicula.Columns[10].HeaderText = "Cine";
            this.dgv_buscar_pelicula.Columns[11].HeaderText = "Fecha en Cartelera";
            this.dgv_modificar_pelicula.Columns[0].HeaderText = "No";
            this.dgv_modificar_pelicula.Columns[1].HeaderText = "Nombre";
            this.dgv_modificar_pelicula.Columns[2].HeaderText = "Descripcion";
            this.dgv_modificar_pelicula.Columns[3].HeaderText = "Portada";
            this.dgv_modificar_pelicula.Columns[4].HeaderText = "Vinculo";
            this.dgv_modificar_pelicula.Columns[5].HeaderText = "Sala";
            this.dgv_modificar_pelicula.Columns[6].HeaderText = "Idioma";
            this.dgv_modificar_pelicula.Columns[7].HeaderText = "Proyeccion";
            this.dgv_modificar_pelicula.Columns[8].HeaderText = "Clasificacion";
            this.dgv_modificar_pelicula.Columns[9].HeaderText = "Categorias";
            this.dgv_modificar_pelicula.Columns[10].HeaderText = "Cine";
            this.dgv_modificar_pelicula.Columns[11].HeaderText = "Fecha en Cartelera";
        }

        private void cbo_relacion_pelicula_cine_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_agregar_relacion4_Click(object sender, EventArgs e)
        {

        }

        private void cbo_relacion_pelicula_hora1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void cb1()
        {
            try
            {
                MySqlConnection micon = new MySqlConnection("server=localhost; database=bdcinetopia; Uid=root; pwd=;");
                //se realiza la conexión a la base de datos
                micon.Open();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select pkidcategorias, nomcategoria from categoria;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, micon);
                //se indica con quu tabla se llena
                dad.Fill(ds, "Categoria");
                cbo_mod_categoria.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_mod_categoria.ValueMember = ("pkidcategorias");
                //se indica el valor a desplegar en el combobox
                cbo_mod_categoria.DisplayMember = ("nomcategoria");
                micon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void cb2()
        {
            try
            {

                MySqlConnection micon = new MySqlConnection("server=localhost; database=bdcinetopia; Uid=root; pwd=;");
                //se realiza la conexión a la base de datos
                micon.Open();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select pkidclasificacion, nomclasificacion from clasificacion;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, micon);
                //se indica con quu tabla se llena
                dad.Fill(ds, "Clasificacion");
                cbo_mod_clasificacion.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_mod_clasificacion.ValueMember = ("pkidclasificacion");
                //se indica el valor a desplegar en el combobox
                cbo_mod_clasificacion.DisplayMember = ("nomclasificacion");
                micon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cb3()
        {
            try
            {

                MySqlConnection micon = new MySqlConnection("server=localhost; database=bdcinetopia; Uid=root; pwd=;");
                //se realiza la conexión a la base de datos
                micon.Open();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select pkidproyeccion, nomtproyecccion from tipoproyeccion;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, micon);
                //se indica con quu tabla se llena
                dad.Fill(ds, "Proyeccion");
                cbo_mod_proyeccion.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_mod_proyeccion.ValueMember = ("pkidproyeccion");
                //se indica el valor a desplegar en el combobox
                cbo_mod_proyeccion.DisplayMember = ("nomtproyecccion");
                micon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cb4()
        {
            try
            {

                MySqlConnection micon = new MySqlConnection("server=localhost; database=bdcinetopia; Uid=root; pwd=;");
                //se realiza la conexión a la base de datos
                micon.Open();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select pkidsala, nomsala from sala;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, micon);
                //se indica con quu tabla se llena
                dad.Fill(ds, "Sala");
                cbo_sala.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_sala.ValueMember = ("pkidsala");
                //se indica el valor a desplegar en el combobox
                cbo_sala.DisplayMember = ("nomsala");
                micon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cb5()
        {
            try
            {

                MySqlConnection micon = new MySqlConnection("server=localhost; database=bdcinetopia; Uid=root; pwd=;");
                //se realiza la conexión a la base de datos
                micon.Open();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select pkididioma, nomidioma from idioma;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, micon);
                //se indica con quu tabla se llena
                dad.Fill(ds, "Idioma");
                cbo_idioma.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_idioma.ValueMember = ("pkididioma");
                //se indica el valor a desplegar en el combobox
                cbo_idioma.DisplayMember = ("nomidioma");
                micon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cb6()
        {
            try
            {

                MySqlConnection micon = new MySqlConnection("server=localhost; database=bdcinetopia; Uid=root; pwd=;");
                //se realiza la conexión a la base de datos
                micon.Open();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select pkidproyeccion, nomtproyecccion from tipoproyeccion;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, micon);
                //se indica con quu tabla se llena
                dad.Fill(ds, "Proyeccion");
                cbo_proyeccion.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_proyeccion.ValueMember = ("pkidproyeccion");
                //se indica el valor a desplegar en el combobox
                cbo_proyeccion.DisplayMember = ("nomtproyecccion");
                micon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cb7()
        {
            try
            {

                MySqlConnection micon = new MySqlConnection("server=localhost; database=bdcinetopia; Uid=root; pwd=;");
                //se realiza la conexión a la base de datos
                micon.Open();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select pkididioma, nomidioma from idioma;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, micon);
                //se indica con quu tabla se llena
                dad.Fill(ds, "Idioma");
                cbo_mod_idioma.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_mod_idioma.ValueMember = ("pkididioma");
                //se indica el valor a desplegar en el combobox
                cbo_mod_idioma.DisplayMember = ("nomidioma");
                micon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cb8()
        {
            try
            {

                MySqlConnection micon = new MySqlConnection("server=localhost; database=bdcinetopia; Uid=root; pwd=;");
                //se realiza la conexión a la base de datos
                micon.Open();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select pkidsala, nomsala from sala;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, micon);
                //se indica con quu tabla se llena
                dad.Fill(ds, "Sala");
                cbo_mod_sala.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_mod_sala.ValueMember = ("pkidsala");
                //se indica el valor a desplegar en el combobox
                cbo_mod_sala.DisplayMember = ("nomsala");
                micon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cb9()
        {
            try
            {

                MySqlConnection micon = new MySqlConnection("server=localhost; database=bdcinetopia; Uid=root; pwd=;");
                //se realiza la conexión a la base de datos
                micon.Open();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select pkidcine, nomcine from cine;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, micon);
                //se indica con quu tabla se llena
                dad.Fill(ds, "cine");
                cbo_cine.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_cine.ValueMember = ("pkidcine");
                //se indica el valor a desplegar en el combobox
                cbo_cine.DisplayMember = ("nomcine");
                micon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cb10()
        {
            try
            {

                MySqlConnection micon = new MySqlConnection("server=localhost; database=bdcinetopia; Uid=root; pwd=;");
                //se realiza la conexión a la base de datos
                micon.Open();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select pkidclasificacion, nomclasificacion from clasificacion;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, micon);
                //se indica con quu tabla se llena
                dad.Fill(ds, "Clasificacion");
                cbo_clasificacion.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_clasificacion.ValueMember = ("pkidclasificacion");
                //se indica el valor a desplegar en el combobox
                cbo_clasificacion.DisplayMember = ("nomclasificacion");
                micon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void cb11()
        {
            try
            {
                MySqlConnection micon = new MySqlConnection("server=localhost; database=bdcinetopia; Uid=root; pwd=;");
                //se realiza la conexión a la base de datos
                micon.Open();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select pkidcategorias, nomcategoria from categoria;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, micon);
                //se indica con quu tabla se llena
                dad.Fill(ds, "Categoria");
                cbo_categoria.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_categoria.ValueMember = ("pkidcategorias");
                //se indica el valor a desplegar en el combobox
                cbo_categoria.DisplayMember = ("nomcategoria");
                micon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void cb12()
        {
            try
            {

                MySqlConnection micon = new MySqlConnection("server=localhost; database=bdcinetopia; Uid=root; pwd=;");
                //se realiza la conexión a la base de datos
                micon.Open();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select pkidcine, nomcine from cine;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, micon);
                //se indica con quu tabla se llena
                dad.Fill(ds, "cine");
                cbo_mod_cine.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_mod_cine.ValueMember = ("pkidcine");
                //se indica el valor a desplegar en el combobox
                cbo_mod_cine.DisplayMember = ("nomcine");
                micon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
