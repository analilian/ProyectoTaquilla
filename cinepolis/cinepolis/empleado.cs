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
    public partial class empleado : Form
    {
        conexionymanipulacion conect = new conexionymanipulacion();
 
        String Stabla = "empleado";
        String Squeery = "select a.pk_idempleado, a.nom1empleado, a.nom2empleado, a.ape1empleado, a.ape2empleado, a.dirempleado, a.dpiempleado, a.nitempleado, a.fechanacempleado, b.nomcine, c.nompuesto from empleado a, cine b, puesto c where a.pk_idcine=b.pk_idcine and a.pk_idpuesto=c.pk_idpuesto ORDER BY `b`.`nomcine` ASC";
        Boolean binsert = true;
        string usu;




        public empleado(string usuario)
        {
            InitializeComponent();
            conect.actualizargrid(dgv_emplados_modificar, Squeery, Stabla);
            nombre_columna();
            usu = usuario;


            txt_nombre1.Enabled = false;
            txt_nombre2.Enabled = false;
            txt_apellido1.Enabled = false;
            txt_apellido2.Enabled = false;
            txt_direccion.Enabled = false;
            txt_dpi.Enabled = false;
            txt_nit.Enabled = false;
            cbo_puesto.Enabled = false;
            cbo_cine.Enabled = false;
            dtp_fecha_nac.Enabled = false;
            btn_desactivar.Enabled = false;
            bttn_actualizar_Empleado.Enabled = false;
            btn_guardar.Enabled = false;
            btn_eliminar_Empleado.Enabled = false;
            btn_telefono_empleado.Enabled = false;
            btn_activar.Enabled = true;
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            seleccion r = new seleccion(usu);
            r.ShowDialog();
        }

        private void btn_cerrarsesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 r = new Form1();
            r.ShowDialog();
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
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

        private void txt_nombre2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_apellido1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_apellido2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_dpi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
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
                MessageBox.Show("Este campo solo debe llevar numero", "validacion de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txt_nit_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
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
                MessageBox.Show("Este campo solo debe llevar numero", "validacion de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_mod_nombre1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txt_mod_nombre1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_mod_nombre2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_mod_apellido1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_mod_apellido2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_mod_dpi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
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
                MessageBox.Show("Este campo solo debe llevar numero", "validacion de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_mod_nit_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_mod_apellido2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (binsert == true)
            {
                insert();
                MessageBox.Show("insetar");
            }
            else
            {
                update();
                btn_eliminar_Empleado.Enabled = true;
                btn_buscar_empleado.Enabled = true;
                MessageBox.Show("modificar");

            }
        }


        private void insert()
        {
            string convpuesto = cbo_puesto.SelectedValue.ToString();
            string convcine = cbo_cine.SelectedValue.ToString();
            if (txt_nombre1.Text == "" || txt_nombre2.Text == "" || txt_apellido1.Text == "" || txt_apellido2.Text == "" || txt_direccion.Text == "" || txt_dpi.Text == "" || txt_nit.Text == "" || cbo_puesto.Text == "" || cbo_cine.Text == "")
            {
                MessageBox.Show("Llene todos los campos por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    conect.Conectar();
                    String Squery = "insert into  empleado (nom1empleado,nom2empleado,ape1empleado,ape2empleado,dirempleado,dpiempleado,nitempleado,fechanacempleado,pk_idcine,pk_idpuesto) values('" + txt_nombre1.Text + "','" + txt_nombre2.Text + "','" + txt_apellido1.Text + "','" + txt_apellido2.Text + "','" + txt_direccion.Text + "','" + txt_dpi.Text + "','" + txt_nit.Text + "','" + this.dtp_fecha_nac.Text + "','" + convcine + "','" + convpuesto + "');";
                    conect.EjecutarQuery(Squery);
                    String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usu + "','" + conect.ip() + "','agrego empleado', NOW());";
                    conect.EjecutarQuery1(Query);
                    conect.actualizargrid(dgv_emplados_modificar, Squeery, Stabla);
                    nombre_columna();
                    conect.Desconectar();
                    limpiaringreso();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.TargetSite);
                    MessageBox.Show("Error en la Insercion sobre Tabla empleado");
                }
            }
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            


        }

        

        public void limpiaringreso()
        {
            txt_nombre1.Clear();
            txt_nombre2.Clear();
            txt_apellido1.Clear();
            txt_apellido2.Clear();
            txt_direccion.Clear();
            txt_dpi.Clear();
            txt_nit.Clear();
            cbo_puesto.ResetText();
            cbo_cine.ResetText();
        }

        public void limpiarmod()
        {
           
        }

        private void btn_mod_guardar_Click(object sender, EventArgs e)
        {
            
        }

        private void update()
        {
            string convpuestomod = cbo_puesto.SelectedValue.ToString();
            string convcinemod = cbo_cine.SelectedValue.ToString();

            if (txt_nombre1.Text == "" || txt_nombre2.Text == "" || txt_apellido1.Text == "" || txt_apellido2.Text == "" || txt_direccion.Text == "" || txt_dpi.Text == "" || txt_nit.Text == "" || cbo_puesto.Text == "" || cbo_cine.Text == "")
            {
                MessageBox.Show("Llene todos los campos por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                try
                {
                    String Codigo = this.dgv_emplados_modificar.CurrentRow.Cells[0].Value.ToString();
                    conect.Conectar();
                    String Squery = "update empleado set  nom1empleado ='" + txt_nombre1.Text + "', nom2empleado ='" + txt_nombre2.Text + "',ape1empleado ='" + txt_apellido1.Text + "',ape2empleado ='" + txt_apellido2.Text + "',dirempleado ='" + txt_direccion.Text + "',dpiempleado ='" + txt_dpi.Text + "',nitempleado ='" + txt_nit.Text + "',fechanacempleado ='" + this.dtp_fecha_nac.Text + "',pk_idcine ='" + convcinemod + "',pk_idpuesto ='" + convpuestomod + "' where pk_idempleado ='" + Codigo + "'";
                    conect.EjecutarQuery(Squery);
                    String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usu + "','" + conect.ip() + "','modifico empleado', NOW());";
                    conect.EjecutarQuery1(Query);
                    conect.actualizargrid(dgv_emplados_modificar, Squeery, Stabla);
                    nombre_columna();
                    conect.Desconectar();
                    limpiaringreso();
                    binsert = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.TargetSite);
                    MessageBox.Show("Error en la Actualizacion sobre Tabla empleado");
                }
            }
        }


        private void btn_buscarmod_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            
        }

        private void empleado_Load(object sender, EventArgs e)
        {
            cb12();
            cb13();
  
        }


        public void nombre_columna()
        {
           
            this.dgv_emplados_modificar.Columns[0].HeaderText = "No";
            this.dgv_emplados_modificar.Columns[1].HeaderText = "Primer Nombre";
            this.dgv_emplados_modificar.Columns[2].HeaderText = "Segundo Nombre";
            this.dgv_emplados_modificar.Columns[3].HeaderText = "Primer Apellido";
            this.dgv_emplados_modificar.Columns[4].HeaderText = "Segundo Apellido";
            this.dgv_emplados_modificar.Columns[5].HeaderText = "Direccion";
            this.dgv_emplados_modificar.Columns[6].HeaderText = "Dpi";
            this.dgv_emplados_modificar.Columns[7].HeaderText = "Nit";
            this.dgv_emplados_modificar.Columns[8].HeaderText = "Fecha Nacimiento";
            this.dgv_emplados_modificar.Columns[9].HeaderText = "Cine";
            this.dgv_emplados_modificar.Columns[10].HeaderText = "Puesto";

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //Sfecha1 = dtp_fecha_nac.Value.Date.ToString();
        }


        public void cb12()
        {
            try
            {
                conect.Conectar();
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query = "select pk_idpuesto, nompuesto from puesto;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, conect.rutaconectada());
            //se indica con quu tabla se llena
            dad.Fill(ds, "Puesto");
            cbo_puesto.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_puesto.ValueMember = ("pk_idpuesto");
            //se indica el valor a desplegar en el combobox
            cbo_puesto.DisplayMember = ("nompuesto");
                conect.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void cb13()
        {
            try
            {
                conect.Conectar();
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select pk_idcine, nomcine from cine;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, conect.rutaconectada());
                //se indica con quu tabla se llena
                dad.Fill(ds, "cine");
                cbo_cine.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_cine.ValueMember = ("pk_idcine");
                //se indica el valor a desplegar en el combobox
                cbo_cine.DisplayMember = ("nomcine");
                conect.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


       


       

        private void lbl_titulo_mantenimiento_cine_Click(object sender, EventArgs e)
        {

        }

        private void bttn_actualizar_pelicula_Click(object sender, EventArgs e)
        {
            binsert = false;
            btn_eliminar_Empleado.Enabled = false;
            btn_buscar_empleado.Enabled = false;

            txt_nombre1.Text = this.dgv_emplados_modificar.CurrentRow.Cells[1].Value.ToString();
            txt_nombre2.Text = this.dgv_emplados_modificar.CurrentRow.Cells[2].Value.ToString();
            txt_apellido1.Text = this.dgv_emplados_modificar.CurrentRow.Cells[3].Value.ToString();
            txt_apellido2.Text = this.dgv_emplados_modificar.CurrentRow.Cells[4].Value.ToString();
            txt_direccion.Text = this.dgv_emplados_modificar.CurrentRow.Cells[5].Value.ToString();
            txt_dpi.Text = this.dgv_emplados_modificar.CurrentRow.Cells[6].Value.ToString();
            txt_nit.Text = this.dgv_emplados_modificar.CurrentRow.Cells[7].Value.ToString();
            this.dtp_fecha_nac.Text = this.dgv_emplados_modificar.CurrentRow.Cells[8].Value.ToString();
            cbo_cine.Text = this.dgv_emplados_modificar.CurrentRow.Cells[9].Value.ToString();
            cbo_puesto.Text = this.dgv_emplados_modificar.CurrentRow.Cells[10].Value.ToString();
        }

        private void btn_eliminar_pelicula_Click(object sender, EventArgs e)
        {
            try
            {
                String SCelda = this.dgv_emplados_modificar.CurrentRow.Cells[0].Value.ToString();
                var Vresultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Vresultado == DialogResult.Yes)
                {
                    conect.Conectar();
                    String Squerys = "delete from  empleado where pk_idempleado = '" + SCelda + "';";
                    conect.EjecutarQuery(Squerys);
                    String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usu + "','" + conect.ip() + "','Elimino empelado', NOW());";
                    conect.EjecutarQuery1(Query);
                    conect.actualizargrid(dgv_emplados_modificar, Squeery, Stabla);
                    nombre_columna();
                    conect.Desconectar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.TargetSite);
                MessageBox.Show("Error en la Eliminacion sobre Tabla empleado");
            }
        }

        private void btn_buscar_empleado_Click(object sender, EventArgs e)
        {
            try
            {
                conect.Conectar();
                String Squerys = ("Select* from empleado where  nom1empleado like'" + txt_buscar.Text + "%'or nom2empleado like'" + txt_buscar.Text + "%'or ape1empleado like'" + txt_buscar.Text + "%' or ape2empleado like'" + txt_buscar.Text + "%';");
                conect.buscarquery(Squerys);
                conect.actualizargrid(dgv_emplados_modificar, Squerys, Stabla);
                conect.Desconectar();
                txt_buscar.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.TargetSite);
                MessageBox.Show("Error en la Busqueda sobre Tabla empleado");
            }
        }

        private void btn_telefono_empleado_Click(object sender, EventArgs e)
        {
            this.Hide();
            telefonoEmpleado r = new telefonoEmpleado(usu);
            r.ShowDialog();
        }

        private void btn_desactivar_Click(object sender, EventArgs e)
        {
            txt_nombre1.Enabled = false;
            txt_nombre2.Enabled = false;
            txt_apellido1.Enabled = false;
            txt_apellido2.Enabled = false;
            txt_direccion.Enabled = false;
            txt_dpi.Enabled = false;
            txt_nit.Enabled = false;
            cbo_puesto.Enabled = false;
            cbo_cine.Enabled = false;
            dtp_fecha_nac.Enabled = false;
            btn_desactivar.Enabled = false;
            bttn_actualizar_Empleado.Enabled = false;
            btn_guardar.Enabled = false;
            btn_eliminar_Empleado.Enabled = false;
            btn_telefono_empleado.Enabled = false;
            btn_activar.Enabled = true;
        }

        private void btn_activar_Click(object sender, EventArgs e)
        {
            txt_nombre1.Enabled = true;
            txt_nombre2.Enabled = true;
            txt_apellido1.Enabled = true;
            txt_apellido2.Enabled = true;
            txt_direccion.Enabled = true;
            txt_dpi.Enabled = true;
            txt_nit.Enabled = true;
            cbo_puesto.Enabled = true;
            cbo_cine.Enabled = true;
            dtp_fecha_nac.Enabled = true;
            btn_desactivar.Enabled = true;
            bttn_actualizar_Empleado.Enabled = true;
            btn_guardar.Enabled = true;
            btn_eliminar_Empleado.Enabled = true;
            btn_telefono_empleado.Enabled = true;
            btn_activar.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conect.actualizargrid(dgv_emplados_modificar, Squeery, Stabla);
        }




        private const string ayudacinetopiaadministrativa = "Title of this help project.chm";
        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, Application.StartupPath + @"/" + ayudacinetopiaadministrativa);
        }
    }
}
