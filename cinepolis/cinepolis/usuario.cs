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
// programadores:walter recinos y rodrigo sifontes
// inicio: 31/07/16 fin:13/08/2016


namespace cinepolis
{
    public partial class usuario : Form
    {
        encriptado encrip = new encriptado();
        conexionymanipulacion conect = new conexionymanipulacion();
        String Stabla ="usuario";
        String Squeery = "select a.pk_idusuario, a.nomusuario, a.contusuario, b.nom1empleado, c.role from usuario a, empleado b, role c where a.pk_idempleado=b.pk_idempleado and a.pk_idrole=c.pk_idrole";
        Boolean binsert = true;
        string usu;


        public usuario(string usuario)
        {
            InitializeComponent();
            conect.actualizargrid(dgv_ingresarusuario,Squeery, Stabla);
            nombre_columna();
            usu = usuario;

            txt_nombreusuario.Enabled = false;
            txt_pasusuario.Enabled = false;
            txt_confirmar.Enabled = false;
            cbo_nivelsusario.Enabled = false;
            cbo_elegirempleado.Enabled = false;
            btn_desactivar.Enabled = false;
            bttn_actualizar_usuario.Enabled = false;
            btn_agregarusuario.Enabled = false;
            btn_eliminar_usuario.Enabled = false;
            btn_activar.Enabled = true;
        }
        

        private void label3_Click(object sender, EventArgs e)
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
            seleccion r = new seleccion(usu);
            r.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void limpiaringresar()
        {
            txt_nombreusuario.Clear();
            txt_pasusuario.Clear();
            txt_confirmar.Clear();
            cbo_nivelsusario.ResetText();
            cbo_elegirempleado.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (binsert == true)
            {
                insert();
                MessageBox.Show("insetar");
            }
            else
            {
                update();
                
                btn_buscar_usuario.Enabled = true;
                btn_eliminar_usuario.Enabled = true;
                MessageBox.Show("modificar");

            }
            
            
        }


        private void insert()
        {
            string convrole = cbo_nivelsusario.SelectedValue.ToString();
            string convemp = cbo_elegirempleado.SelectedValue.ToString();

            if (txt_nombreusuario.Text == "" || txt_pasusuario.Text == "" || txt_confirmar.Text == "" || cbo_nivelsusario.Text == "")
            {
                MessageBox.Show("Llene todos los campos por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
            else
            {

                if (txt_pasusuario.Text == txt_confirmar.Text)
                {



                    conect.Conectar();
                    if (cbo_nivelsusario.Text == "administrativo")
                    {

                        String Squery = "insert into  usuario (nomusuario,contusuario,pk_idrole,pk_idempleado) values('" + txt_nombreusuario.Text + "','" + encrip.EncryptKey(txt_pasusuario.Text) + "','" + convrole + "','" + convemp + "');";

                        conect.EjecutarQuery(Squery);
                        String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usu + "','" + conect.ip() + "','agrego usuario', NOW());";
                        conect.EjecutarQuery(Query);
                        limpiaringresar();
                    }
                    else
                    {


                        String Squery = "insert into  usuario (nomusuario,contusuario,pk_idrole,pk_idempleado) values('" + txt_nombreusuario.Text + "','" + encrip.EncryptKey(txt_pasusuario.Text) + "','" + convrole + "','" + convemp + "');";
                        conect.EjecutarQuery(Squery);
                        String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usu + "','" + conect.ip() + "','agrego usuario', NOW());";
                        conect.EjecutarQuery(Query);
                        limpiaringresar();
                    }

                    conect.actualizargrid(dgv_ingresarusuario, Squeery, Stabla);
                    nombre_columna();
                    conect.Desconectar();
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinsiden", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void usuario_Load(object sender, EventArgs e)
        {
            cb1();
            cb2();
            
        }

        private void dgv_empleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_eleminarusuario_Click(object sender, EventArgs e)
        {
            delete();             
        }

        private void delete()
        {
            String SCelda = this.dgv_ingresarusuario.CurrentRow.Cells[0].Value.ToString();
            var Vresultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Vresultado == DialogResult.Yes)
            {
                conect.Conectar();
                String Squerys = "delete from  usuario where pk_idusuario = '" + SCelda + "';";
                conect.EjecutarQuery(Squerys);
                String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usu + "','" + conect.ip() + "','borro usuario', NOW());";
                conect.EjecutarQuery(Query);
                conect.actualizargrid(dgv_ingresarusuario, Squeery, Stabla);
                nombre_columna();
                conect.Desconectar();

            }
            else
            {
                return;
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_buscarmod_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void buscar()
        {
            conect.Conectar();
            String Squerys = ("Select* from usuario where nomusuario like'" + txt_buscar_usuario.Text + "%' or pk_idempleado like '" + txt_buscar_usuario.Text + "%' or pk_idrole like '" + txt_buscar_usuario.Text + "%';");
            conect.buscarquery(Squerys);
            conect.actualizargrid(dgv_ingresarusuario, Squerys, Stabla);
            nombre_columna();
            conect.Desconectar();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cargardato_a_textbox();
        }

        private void cargardato_a_textbox()
        {
            binsert = false;
            btn_buscar_usuario.Enabled = false;
            btn_eliminar_usuario.Enabled = false;
            txt_nombreusuario.Text = this.dgv_ingresarusuario.CurrentRow.Cells[1].Value.ToString();
            txt_pasusuario.Text = encrip.DecryptKey(this.dgv_ingresarusuario.CurrentRow.Cells[2].Value.ToString()); ;
            cbo_nivelsusario.Text = this.dgv_ingresarusuario.CurrentRow.Cells[4].Value.ToString();
            cbo_elegirempleado.Text = this.dgv_ingresarusuario.CurrentRow.Cells[3].Value.ToString();
        }

       

        private void btn_insertarmod_Click(object sender, EventArgs e)
        {
            update();
        }



        private void update()
        {
            string convrolemod = cbo_nivelsusario.SelectedValue.ToString();
            string convempmod = cbo_elegirempleado.SelectedValue.ToString();


            if (txt_nombreusuario.Text == "" || txt_pasusuario.Text == "" || txt_confirmar.Text == "" || cbo_nivelsusario.Text == "" || cbo_elegirempleado.Text=="")
            {
                MessageBox.Show("Llene todos los campos por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                String Codigo = this.dgv_ingresarusuario.CurrentRow.Cells[0].Value.ToString();
                conect.Conectar();
                if (txt_pasusuario.Text == txt_confirmar.Text)
                {
                    String Squery = "update usuario set nomusuario ='" + txt_nombreusuario.Text + "',contusuario='" + encrip.EncryptKey(txt_pasusuario.Text) + "' ,pk_idrole='" + convrolemod + "',pk_idempleado ='" + convempmod + "'where pk_idusuario='" + Codigo + "'";
                    conect.EjecutarQuery(Squery);
                    String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usu + "','" + conect.ip() + "','modifico usuario', NOW());";
                    conect.EjecutarQuery(Query);
                    conect.actualizargrid(dgv_ingresarusuario, Squeery, Stabla);
                    nombre_columna();
                    conect.Desconectar();
                    limpiaringresar();
                    binsert = true;
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }




        private void txt_nombreusuario_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_pasusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar))
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
                MessageBox.Show("Este campo no puede llevar simbolos", "validacion de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_nommod_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nommod_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_conmod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar))
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
                MessageBox.Show("Este campo no puede llevar simbolos", "validacion de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_modificarbuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_modificar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }


        private void cb1()
        {
            try
            {

                conect.Conectar();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select pk_idrole, role from role;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, conect.Ruta());
                //se indica con quu tabla se llena
                dad.Fill(ds, "Role");
                cbo_nivelsusario.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_nivelsusario.ValueMember = ("pk_idrole");
                //se indica el valor a desplegar en el combobox
                cbo_nivelsusario.DisplayMember = ("role");
                conect.Desconectar();
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

                conect.Conectar();
                //se realiza la conexión a la base de datos
                
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select pk_idempleado, nom1empleado from empleado;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, conect.Ruta());
                //se indica con quu tabla se llena
                dad.Fill(ds, "Empleado");
                cbo_elegirempleado.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_elegirempleado.ValueMember = ("pk_idempleado");
                //se indica el valor a desplegar en el combobox
                cbo_elegirempleado.DisplayMember = ("nom1empleado");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_conmod_TextChanged(object sender, EventArgs e)
        {

        }
        public void nombre_columna()
        {
           this.dgv_ingresarusuario.Columns[0].HeaderText = "No";
            this.dgv_ingresarusuario.Columns[1].HeaderText = "Usuario";
            this.dgv_ingresarusuario.Columns[3].HeaderText = "Empleado";
            this.dgv_ingresarusuario.Columns[4].HeaderText = "Role";
            this.dgv_ingresarusuario.Columns[2].Visible = false;
        
        }

        private void lbl_mantenimientodeusuario_Click(object sender, EventArgs e)
        {

        }

        private void bttn_actualizar_usuario_Click(object sender, EventArgs e)
        {
            cargardato_a_textbox();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            delete();
        }

        private void btn_buscar_usuario_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void cbo_nivelsusario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_desactivar_Click(object sender, EventArgs e)
        {
            txt_nombreusuario.Enabled = false;
            txt_pasusuario.Enabled = false;
            txt_confirmar.Enabled = false;
            cbo_nivelsusario.Enabled = false;
            cbo_elegirempleado.Enabled = false;
            btn_desactivar.Enabled = false;
            bttn_actualizar_usuario.Enabled = false;
            btn_agregarusuario.Enabled = false;
            btn_eliminar_usuario.Enabled = false;
            btn_activar.Enabled = true;
        }

        private void btn_activar_Click(object sender, EventArgs e)
        {
            txt_nombreusuario.Enabled = true;
            txt_pasusuario.Enabled = true;
            txt_confirmar.Enabled = true;
            cbo_nivelsusario.Enabled = true;
            cbo_elegirempleado.Enabled = true;
            btn_desactivar.Enabled = true;
            bttn_actualizar_usuario.Enabled = true;
            btn_agregarusuario.Enabled = true;
            btn_eliminar_usuario.Enabled = true;
            btn_activar.Enabled = false;
        }

        private void lbl_nombreusuario_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_uempleado_Click(object sender, EventArgs e)
        {

        }

        private void lbl_buscar_usuario_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            conect.actualizargrid(dgv_ingresarusuario, Squeery, Stabla);
        }
    }
}
