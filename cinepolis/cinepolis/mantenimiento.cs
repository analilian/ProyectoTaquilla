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


        //----------------------------------------programado por walter y rodrigo-------------------------------------------
        //----------------------------------------fecha inicio:1/08/2016----------------------------------------------------
        //----------------------------------------fecha fin: 17/08/2016-----------------------------------------------------
        public bool Enabled { get; set; }
        string usuario;
        MySqlCommand comand;
        conexionymanipulacion con = new conexionymanipulacion();
        String Stabla = "Pelicula";
        string imgLoc;
        String Squeery = "select* from pelicula";
        
       
        public mantenimiento(string g)
        {
            InitializeComponent();
           
            con.actualizargrid(dgv_modificar_pelicula, Squeery, Stabla);
            nombre_columna();
            this.usuario = g;
            realizar();
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
            seleccion r = new seleccion(usuario);
            r.ShowDialog();
        }


        private void carga_dgv_cinessala() // VISTA DE DATAGRID DE LISTA DE EMPLEADOS
        {
            con.Conectar();

            MySqlCommand peticion_dgv = new MySqlCommand("select a.pk_idcinesal, b.nomsala, c.nomcine from cinessala a, sala b, cine c where a.pk_idcine=c.pk_idcine and a.pk_idsala=b.pk_idsala ORDER BY `c`.`nomcine` ASC", con.rutaconectada());

            MySqlDataAdapter conn = new MySqlDataAdapter(peticion_dgv);
            DataSet ds = new DataSet();
            conn.Fill(ds);


            dgv_relacion_pelicula_hora.DataSource = ds.Tables[0];
            con.Desconectar();

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
            cb16();
            cb6();
            cb7();
            cb8();
            cb9();
        
            carga_dgv_cinessala();
        }



        public void limpiarmod()
        {
            txt_mod_nombre.Clear();
            txt_mod_trailer.Clear();
            
            cbo_mod_idioma.ResetText();
          
       
           cbo_mod_categoria.ResetText();
           
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

   
       

        private void btn_buscarmod_Click(object sender, EventArgs e)
        {
            con.Conectar();
            String Squerys = ("Select * from pelicula where nompelicula like'" + txt_modificarbuscar.Text + "%' or despelicula like '" + txt_modificarbuscar.Text + "%' or vinculopelicula like'" + txt_modificarbuscar.Text +  "%'or pk_ididioma like'" + txt_modificarbuscar.Text +  "%'or pk_idclasificacion like'" + txt_modificarbuscar.Text + "%'or pk_idcategorias like'" + txt_modificarbuscar.Text +  "%';");
            con.buscarquery(Squerys);
            con.actualizargrid(dgv_modificar_pelicula, Squerys, Stabla);
            nombre_columna();
            con.Desconectar();
            txt_modificarbuscar.Clear();
        }

        string codigo;

       

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            int ri = 0;
            try
            {
                codigo = this.dgv_modificar_pelicula.CurrentRow.Cells[0].Value.ToString();
                txt_mod_nombre.Text = this.dgv_modificar_pelicula.CurrentRow.Cells[1].Value.ToString();
                txt_mod_descrip.Text = this.dgv_modificar_pelicula.CurrentRow.Cells[2].Value.ToString();


                txt_mod_trailer.Text = this.dgv_modificar_pelicula.CurrentRow.Cells[4].Value.ToString();

                cbo_mod_idioma.Text = this.dgv_modificar_pelicula.CurrentRow.Cells[5].Value.ToString();
                cbo_mod_clasificacion.Text = this.dgv_modificar_pelicula.CurrentRow.Cells[6].Value.ToString();
                cbo_mod_categoria.Text = this.dgv_modificar_pelicula.CurrentRow.Cells[7].Value.ToString();
                cbo_mod_fecha.Text = this.dgv_modificar_pelicula.CurrentRow.Cells[8].Value.ToString();
                con.Conectar();

                string sql = "Select imagenpelicula from pelicula where pk_idpelicula ='" + codigo + "'";

                MySqlCommand command = new MySqlCommand(sql, con.rutaconectada());
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();

                byte[] img = (byte[])(reader[0]);
                if (img == null)
                {
                    pic_mod_portada.Image = null;
                }
                else
                {
                    MemoryStream ms = new MemoryStream(img);
                    pic_mod_portada.Image = Image.FromStream(ms);

                }
                ñl = ri;
                con.Desconectar();
            }
            catch (Exception ex)
            {
                con.Desconectar();
                MessageBox.Show(ex.Message);
            }
            

        }

     
      

        public void modificar()
        {
            int ri = 1;
            string convidiomamod = cbo_mod_idioma.SelectedValue.ToString();

            string convcategoriamod = cbo_mod_categoria.SelectedValue.ToString();
            string convclacifmod = cbo_mod_clasificacion.SelectedValue.ToString();



            if (txt_mod_nombre.Text == "" || txt_mod_trailer.Text == "" || cbo_mod_idioma.Text == "" || cbo_mod_categoria.Text == "" || cbo_mod_fecha.Text == "" || txt_mod_descrip.Text == "" || pic_mod_portada.ImageLocation == null)
            {
                MessageBox.Show("Llene todos los campos por favor");
            }
            else
            {

                byte[] img = null;
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);

                String sql = "update pelicula set nompelicula ='" + txt_mod_nombre.Text + "',despelicula='" + txt_mod_descrip.Text + "' ,imagenpelicula= @img ,vinculopelicula ='" + txt_mod_trailer.Text + "',pk_ididioma ='" + convidiomamod + "',pk_idclasificacion ='" + convclacifmod + "' ,pk_idcategorias='" + convcategoriamod + "',pk_idfcar = '" + cbo_mod_fecha.Text + "'  where pk_idpelicula='" + codigo + "'";

                if (con.rutaconectada().State != ConnectionState.Open)
                    con.Conectar();
                comand = new MySqlCommand(sql, con.rutaconectada());
                comand.Parameters.Add(new MySqlParameter("@img", img));
                int y = comand.ExecuteNonQuery();
                MessageBox.Show(" Registro guardado");
                String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usuario + "','" + con.ip() + "','modifico pelicula', NOW());";
                con.EjecutarQuery1(Query);
        
                con.actualizargrid(dgv_modificar_pelicula, Squeery, Stabla);
                nombre_columna();
                limpiarmod();
                ñl = ri;
             
                
            }

        }
        public void insertar()
        {
            string convidioma = cbo_mod_idioma.SelectedValue.ToString();
            string convclacif = cbo_mod_clasificacion.SelectedValue.ToString();
            string convcategoria =cbo_mod_categoria.SelectedValue.ToString();



            if (txt_mod_nombre.Text == "" || txt_mod_trailer.Text == "" || cbo_mod_idioma.Text == "" || cbo_mod_clasificacion.Text == "" || cbo_mod_categoria.Text == "" || cbo_mod_fecha.Text == "" || txt_mod_descrip.Text == "" || pic_mod_portada.ImageLocation == null)
            {
                MessageBox.Show("Llene todos los campos por favor");
            }
            else
            {

                byte[] img = null;
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                string sql = "Insert Into pelicula (nompelicula,despelicula,imagenpelicula,vinculopelicula,pk_ididioma,pk_idclasificacion,pk_idcategorias,pk_idfcar)values('" + txt_mod_nombre.Text + "','" + txt_mod_descrip.Text + "',@img,'" + txt_mod_trailer.Text + "','" + convidioma + "','" + convclacif + "','" + convcategoria + "','" + cbo_mod_fecha.Text + "')";
                if (con.rutaconectada().State != ConnectionState.Open)
                    con.Conectar();
                comand = new MySqlCommand(sql, con.rutaconectada());
                comand.Parameters.Add(new MySqlParameter("@img", img));
                int x = comand.ExecuteNonQuery();
                String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usuario + "','" + con.ip() + "','agrego pelicula', NOW());";
                con.EjecutarQuery1(Query);
                con.Desconectar();
                MessageBox.Show(" Registro guardado");
               
                con.actualizargrid(dgv_modificar_pelicula, Squeery, Stabla);
                nombre_columna();
                limpiarmod();
                ñl = 1;
               
            }
         

        }
        int ñl = 1;
        private void btn_extraer_Click(object sender, EventArgs e)
        {
            
            if(ñl==1)
            {
                insertar();
            }
            else
            {
                modificar();
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
             fecha r = new fecha(usuario);
            r.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            sala r = new sala(usuario);
            r.ShowDialog();
        }

        private void btn_agregar_clasificacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            clasificacion r = new clasificacion(usuario);
            r.ShowDialog();
        }

        private void btn_agregar_btn_agregar_categoria_Click(object sender, EventArgs e)
        {
            this.Hide();
            categoria r = new categoria(usuario);
            r.ShowDialog();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            cine r = new cine(usuario);
            r.ShowDialog();
        }

        private void cbo_mod_idioma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbo_mod_proyeccion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
  
        private void realizar()
        {
            int resultado = -1;
            con.Conectar();
            MySqlCommand comando = new MySqlCommand(string.Format("Select nomusuario ,pk_idrole From usuario Where nomusuario = '{0}' and pk_idrole  = 1", usuario), con.rutaconectada());
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                resultado = 50;
            }
            con.Desconectar();

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
          
           

            this.dgv_modificar_pelicula.Columns[0].HeaderText = "No";
            this.dgv_modificar_pelicula.Columns[1].HeaderText = "Nombre";
            this.dgv_modificar_pelicula.Columns[2].HeaderText = "Descripcion";
            this.dgv_modificar_pelicula.Columns[3].HeaderText = "Portada";
            this.dgv_modificar_pelicula.Columns[4].HeaderText = "Vinculo";
            this.dgv_modificar_pelicula.Columns[5].HeaderText = "Idioma";
            this.dgv_modificar_pelicula.Columns[6].HeaderText = "Clasificacion";
            this.dgv_modificar_pelicula.Columns[7].HeaderText = "Categoria";
            this.dgv_modificar_pelicula.Columns[8].HeaderText = "fecha ";
        }
          

        private void cbo_relacion_pelicula_cine_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_agregar_relacion4_Click(object sender, EventArgs e)
        {
            this.Hide();
            proyeccion r = new proyeccion(usuario);
            r.ShowDialog();
        }

        private void cbo_relacion_pelicula_hora1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        private void cb1()
        {
            try
            {

                
                con.Conectar();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select pk_idcategorias, nomcategoria from categoria;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, con.rutaconectada());
                //se indica con quu tabla se llena
                dad.Fill(ds, "Categoria");
                cbo_mod_categoria.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_mod_categoria.ValueMember = ("pk_idcategorias");
                //se indica el valor a desplegar en el combobox
                cbo_mod_categoria.DisplayMember = ("nomcategoria");
                con.Desconectar();

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
                con.Conectar();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select pk_idclasificacion, nomclasificacion from clasificacion;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, con.rutaconectada());
                //se indica con quu tabla se llena
                dad.Fill(ds, "Clasificacion");
                cbo_mod_clasificacion.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_mod_clasificacion.ValueMember = ("pk_idclasificacion");
                //se indica el valor a desplegar en el combobox
                cbo_mod_clasificacion.DisplayMember = ("nomclasificacion");
                con.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        


        
        private void cb16()
        {
            try
            {

                con.Conectar();
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select pk_idfcar, fechainicar,fechafinalcar from fechascartelera;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, con.rutaconectada());
                //se indica con quu tabla se llena
                dad.Fill(ds, "Fecha");
                cbo_mod_fecha.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_mod_fecha.ValueMember = ("pk_idfcar");
                //se indica el valor a desplegar en el combobox
                cbo_mod_fecha.DisplayMember = ("fechainicar"+"-"+ "fechafinalcar");
                con.Desconectar();
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

                con.Conectar();
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select pk_idproyeccion, nomtproyecccion from tipoproyeccion;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, con.rutaconectada());
                //se indica con quu tabla se llena
                dad.Fill(ds, "Proyeccion");
                cbo_relacion_pelicula_proyeccion1.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_relacion_pelicula_proyeccion1.ValueMember = ("pk_idproyeccion");
                //se indica el valor a desplegar en el combobox
                cbo_relacion_pelicula_proyeccion1.DisplayMember = ("nomtproyecccion");
                con.Desconectar();
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

                con.Conectar();
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select pk_ididioma, nomidioma from idioma;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, con.rutaconectada());
                //se indica con quu tabla se llena
                dad.Fill(ds, "Idioma");
                cbo_mod_idioma.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_mod_idioma.ValueMember = ("pk_ididioma");
                //se indica el valor a desplegar en el combobox
                cbo_mod_idioma.DisplayMember = ("nomidioma");
                con.Desconectar();
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

                con.Conectar();
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select pk_idhorario, horainiciohor from horario;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, con.rutaconectada());
                //se indica con quu tabla se llena
                dad.Fill(ds, "Horario");
                cbo_relacion_pelicula_hora1.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_relacion_pelicula_hora1.ValueMember = ("pk_idhorario");
                //se indica el valor a desplegar en el combobox
                cbo_relacion_pelicula_hora1.DisplayMember = ("horainiciohor");
                con.Desconectar();
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

                con.Conectar();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select pk_idpelicula, nompelicula from pelicula;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, con.rutaconectada());
                //se indica con quu tabla se llena
                dad.Fill(ds, "Pelicula");
                cbo_relacion_pelicula.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_relacion_pelicula.ValueMember = ("pk_idpelicula");
                //se indica el valor a desplegar en el combobox
                cbo_relacion_pelicula.DisplayMember = ("nompelicula");
                con.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


       

        private void txt_mod_nombre_TextChanged(object sender, EventArgs e)
        {

        }



      

        private void button3_Click(object sender, EventArgs e)
        {
            string pelicula_ralacion = cbo_relacion_pelicula.SelectedValue.ToString();
            string sala_cine = this.dgv_relacion_pelicula_hora.CurrentRow.Cells[0].Value.ToString();
            string proyeccion_relaci = cbo_relacion_pelicula_proyeccion1.SelectedValue.ToString();
            string horario_relaci = cbo_relacion_pelicula_hora1.SelectedValue.ToString();


            con.Conectar();
            String Squery = "insert into cartelerapelicula (pk_idcinesal, pk_idpelicula, pk_idhorario, pk_idproyeccion) values('" + sala_cine + "', '" + pelicula_ralacion + "', '" + horario_relaci + "','" + proyeccion_relaci + "');";
            con.EjecutarQuery(Squery);
            String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usuario + "','" + con.ip() + "','agrego cartelera de pelicula', NOW());";
            con.EjecutarQuery1(Query);
      
            
            con.actualizargrid(dgv_modificar_pelicula, Squeery, Stabla);
            nombre_columna();
            con.Desconectar();
        }

        private void btn_agregar_relacion1_Click(object sender, EventArgs e)
        {
            this.Hide();
            sala r = new sala(usuario);
            r.ShowDialog();
        }

        private void btn_agregar_relacion3_Click(object sender, EventArgs e)
        {
            this.Hide();
            cine r = new cine(usuario);
            r.ShowDialog();
        }

        private void btn_agregar_relacion2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Horario r = new Horario(usuario);
            r.ShowDialog();
        }

        private void tbc_mantenimiento_cine_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        private void cbo_fecha_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            String SCelda = this.dgv_modificar_pelicula.CurrentRow.Cells[0].Value.ToString();
            var Vresultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Vresultado == DialogResult.Yes)
            {
                con.Conectar();
                String Squerys = "delete from  pelicula  where pk_idpelicula = '" + SCelda + "';";
                con.EjecutarQuery(Squerys);
                String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usuario + "','" + con.ip() + "','elimino pelicula', NOW());";
                con.EjecutarQuery1(Query);

                con.actualizargrid(dgv_modificar_pelicula, Squeery, Stabla);
                nombre_columna();
                con.Desconectar();

            }
            else
            {
                return;
            }
        }

        private void btn_desactivar_Click(object sender, EventArgs e)
        {
            txt_mod_nombre.Enabled = false;
            txt_mod_trailer.Enabled = false;
            cbo_mod_clasificacion.Enabled=false;
            cbo_mod_categoria.Enabled = false;
            cbo_mod_fecha.Enabled = false;
            txt_mod_descrip.Enabled = false;
            btn_desactivar.Enabled = false;
            btn_actualizar.Enabled = false;
            btn_actualizar.Enabled = false;
            btn_buscarmod.Enabled = false;
            btn_eliminar.Enabled = false;
            btn_portada1.Enabled = false;
            btn_activar.Enabled = true;
            txt_modificarbuscar.Enabled = true;
        }

        private void btn_activar_Click(object sender, EventArgs e)
        {
            txt_mod_nombre.Enabled = true;
            txt_mod_trailer.Enabled = true;
            cbo_mod_clasificacion.Enabled = true;
            cbo_mod_categoria.Enabled = true;
            cbo_mod_fecha.Enabled = true;
            txt_mod_descrip.Enabled = true;
            btn_desactivar.Enabled = true;
            btn_actualizar.Enabled = true;
            btn_actualizar.Enabled = true;
            btn_buscarmod.Enabled = true;
            btn_eliminar.Enabled = true;
            btn_portada1.Enabled = true;
            btn_activar.Enabled = false;
            txt_modificarbuscar.Enabled = false;
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            con.actualizargrid(dgv_modificar_pelicula, Squeery, Stabla);
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            this.Hide();
            cliente r = new cliente(usuario);
            r.ShowDialog();
        }




        private const string ayudacinetopiaadministrativa = "Title of this help project.chm";
        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, Application.StartupPath + @"/" + ayudacinetopiaadministrativa);
        }

        private void button1_Click_5(object sender, EventArgs e)
        {
            this.Hide();
            clasificacion r = new clasificacion(usuario);
            r.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            fecha r = new fecha(usuario);
            r.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            categoria r = new categoria(usuario);
            r.ShowDialog();
        }
    }
}
