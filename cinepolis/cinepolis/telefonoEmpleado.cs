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
    public partial class telefonoEmpleado : Form
    {
        string usu;
        public telefonoEmpleado(string usuario)
        {
            InitializeComponent();
            conect.actualizargrid(dgv_telefono, Squiery, Stabla);
            conect.actualizargrid(dgv_Tel_emp, Squeery, Stabla);
            conect.actualizargrid(dgv_tel_cine, Squeery1, Stabla);
            
            nombre_columna();
            usu = usuario;
        }
        conexionymanipulacion conect = new conexionymanipulacion();
        String Stabla = "telefono";
        String Squiery = "SELECT * FROM `telefono` ORDER BY `telefono`.`pk_idtelefono` ASC"; 
        String Squeery = "select c.pk_idtelemp, a.teltelefono, b.nom1empleado from telefono a, empleado b, telefonoempleado c where b.pk_idempleado=c.pk_idempleado and a.pk_idtelefono=c.pk_idtelefono;";
        String Squeery1 = "select c.pk_idtelcine, a.teltelefono, b.nomcine from telefono a, cine b, telefonocine c where b.pk_idcine=c.pk_idcine and a.pk_idtelefono=c.pk_idtelefono;";
        //String Squeery2 = "select a.teltelefono, b.nom1cliente from telefono a, cliente b, telefonocliente c where b.pk_idcliente=c.pk_idcliente and a.pk_idtelefono=c.pk_idtelefono;";
        Boolean binsert = true;


        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (binsert == true)
            {
                insert();
                MessageBox.Show("insetar");
                cb1();
                cb2();
                cb5();
            }
            else
            {
                update();
                btn_eliminar_proyeccion.Enabled = true;
                btn_buscar_proyeccion.Enabled = true;
                MessageBox.Show("modificar");
                cb1();
                cb2();
                cb5();
                

            }
        }


        private void insert()
        {
            if (txt_nom_proy.Text == "")
            {
                MessageBox.Show("Llene los campos por favor");
            }
            else
            {

                try
                {
                    conect.Conectar();
                    String Squery = "insert into  telefono (teltelefono) values('" + txt_nom_proy.Text + "');";
                    conect.EjecutarQuery(Squery);
                    String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usu + "','" + conect.ip() + "','agrego telefono', NOW());";
                    conect.EjecutarQuery(Query);
                    conect.actualizargrid(dgv_telefono, Squiery, Stabla);
                    nombre_columna();
                    conect.Desconectar();
                    txt_nom_proy.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.TargetSite);
                    MessageBox.Show("Error al Guardar el nombre de la Categoria");
                }
            }
        }


        private void update()
        {
            if (txt_nom_proy.Text == "")
            {
                MessageBox.Show("Llene los campos por favor");
            }
            else
            {

                try
                {
                    String Codigo = this.dgv_telefono.CurrentRow.Cells[0].Value.ToString();
                    conect.Conectar();
                    String Squery = "update telefono set  teltelefono ='" + txt_nom_proy.Text + "'where pk_idtelefono ='" + Codigo + "'";
                    conect.EjecutarQuery(Squery);
                    String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usu + "','" + conect.ip() + "','modifico telefono', NOW());";
                    conect.EjecutarQuery1(Query);
                    conect.actualizargrid(dgv_telefono, Squiery, Stabla);
                    nombre_columna();
                    conect.Desconectar();
                    txt_nom_proy.Clear();
                    binsert = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message + ex.TargetSite);
                    MessageBox.Show("Error en la Actualizacion de Categoria");
                }
            }
        }

        private void btn_buscar_categoria_Click(object sender, EventArgs e)
        {
            try
            {
                conect.Conectar();
                String Squerys = ("Select * from telefono where  teltelefono like'%" + txt_buscarmod.Text + "%';");
                conect.buscarquery(Squerys);
                conect.actualizargrid(dgv_telefono, Squerys, Stabla);
                nombre_columna();
                conect.Desconectar();
                txt_buscarmod.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.TargetSite);
                MessageBox.Show("Error al buscar la categoria");
            }
        }

        private void btn_eliminar_categoria_Click(object sender, EventArgs e)
        {
            try
            {
                String SCelda = this.dgv_telefono.CurrentRow.Cells[0].Value.ToString();
                var Vresultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Vresultado == DialogResult.Yes)
                {
                    conect.Conectar();
                    String Squerys = "delete from  telefono where pk_idtelefono = '" + SCelda + "';";
                    conect.EjecutarQuery(Squerys);
                    String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usu + "','" + conect.ip() + "','borro telefono', NOW());";
                    conect.EjecutarQuery1(Query);
                    conect.actualizargrid(dgv_telefono, Squiery, Stabla);
                    nombre_columna();
                    conect.Desconectar();

                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.TargetSite);
                MessageBox.Show("Error al Borrar la Telefono");

            }

        }


        public void nombre_columna()
        {
            this.dgv_telefono.Columns[0].HeaderText = "No";
            this.dgv_telefono.Columns[1].HeaderText = "Teléfono";

            this.dgv_Tel_emp.Columns[0].HeaderText = "Telefono";
            this.dgv_Tel_emp.Columns[1].HeaderText = "Empleado";

            //this.dgv_tel_cliente.Columns[0].HeaderText = "Telefono";
            //this.dgv_tel_cliente.Columns[1].HeaderText = "Cliente";

            this.dgv_tel_cine.Columns[0].HeaderText = "Telefono";
            this.dgv_tel_cine.Columns[1].HeaderText = "Cine";

        }

        private void bttn_actualizar_categoria_Click(object sender, EventArgs e)
        {
            btn_eliminar_proyeccion.Enabled = false;
            btn_buscar_proyeccion.Enabled = false;
            binsert = false;

            txt_nom_proy.Text = this.dgv_telefono.CurrentRow.Cells[1].Value.ToString();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            mantenimiento r = new mantenimiento(usu);
            r.ShowDialog();
        }

        private void bttn_actualizar_proyeccion_Click(object sender, EventArgs e)
        {
            btn_eliminar_proyeccion.Enabled = false;
            btn_buscar_proyeccion.Enabled = false;
            binsert = false;

            txt_nom_proy.Text = this.dgv_telefono.CurrentRow.Cells[1].Value.ToString();
        }

        private void txt_nom_proy_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_buscarmod_KeyPress(object sender, KeyPressEventArgs e)
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

        //---------------------------------------------Llenado de comboBox---------------------------------------------------------
       

        private void telefonoEmpleado_Load(object sender, EventArgs e)
        {
            cb1();
            cb2();
            cb3();
            cb4();
            cb5();
            cb6();
           
        }

        private void cb1()
        {
            try
            {

                conect.Conectar();
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select pk_idtelefono, teltelefono from telefono;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, conect.rutaconectada());
                //se indica con quu tabla se llena
                dad.Fill(ds, "Telefono");
                cbo_lista_num.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_lista_num.ValueMember = ("pk_idtelefono");
                //se indica el valor a desplegar en el combobox
                cbo_lista_num.DisplayMember = ("teltelefono");
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
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select pk_idtelefono, teltelefono from telefono;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, conect.rutaconectada());
                //se indica con quu tabla se llena
                dad.Fill(ds, "Telefono");
                cbo_lista_num2.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_lista_num2.ValueMember = ("pk_idtelefono");
                //se indica el valor a desplegar en el combobox
                cbo_lista_num2.DisplayMember = ("teltelefono");
                conect.Desconectar();
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

                conect.Conectar();
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select pk_idempleado, nom1empleado from empleado;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, conect.rutaconectada());
                //se indica con quu tabla se llena
                dad.Fill(ds, "Empleado");
                cbo_empleado.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_empleado.ValueMember = ("pk_idempleado");
                //se indica el valor a desplegar en el combobox
                cbo_empleado.DisplayMember = ("nom1empleado");
                conect.Desconectar();
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

                conect.Conectar();
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select pk_idcine, nomcine from cine;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, conect.rutaconectada());
                //se indica con quu tabla se llena
                dad.Fill(ds, "Cine");
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



        private void cb5()
        {
            try
            {

                conect.Conectar();
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select pk_idtelefono, teltelefono from telefono;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, conect.rutaconectada());
                //se indica con quu tabla se llena
                dad.Fill(ds, "Telefono");
                cbo_lista_num3.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_lista_num3.ValueMember = ("pk_idtelefono");
                //se indica el valor a desplegar en el combobox
                cbo_lista_num3.DisplayMember = ("teltelefono");
                conect.Desconectar();
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

                conect.Conectar();
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select pk_idcliente, nom1cliente from cliente;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, conect.rutaconectada());
                //se indica con quu tabla se llena
                dad.Fill(ds, "Cliente");
                cbo_cliente.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_cliente.ValueMember = ("pk_idcliente");
                //se indica el valor a desplegar en el combobox
                cbo_cliente.DisplayMember = ("nom1cliente");
                conect.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //-----------------------------------------------------FIN LLENADO COMBOBOX---------------------------------------------------------------------------





        private void btn_tel_emp_Click(object sender, EventArgs e)
        {
            string slista_numero = cbo_lista_num.SelectedValue.ToString();
            string slista_emp = cbo_empleado.SelectedValue.ToString();

            if (cbo_lista_num.Text == "" || cbo_empleado.Text == "")
            {
                MessageBox.Show("Llene todos los campos por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                try
                {
                    conect.Conectar();
                    String Squery = "insert into  telefonoempleado (pk_idempleado,pk_idtelefono) values('" + slista_emp + "','" + slista_numero + "');";
                    conect.EjecutarQuery(Squery);
                    conect.actualizargrid(dgv_Tel_emp, Squeery, Stabla);
                    nombre_columna();
                    conect.Desconectar();
                    cbo_empleado.ResetText();
                    cbo_lista_num.ResetText();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.TargetSite);
                    MessageBox.Show("Error en la Tabla de telefono_empleado");
                }
            }
        }

        private void btn_tel_cine_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_tel_cine_Click_1(object sender, EventArgs e)
        {
            string slista_numero2 = cbo_lista_num2.SelectedValue.ToString();
            string slista_cine = cbo_cine.SelectedValue.ToString();

            if (cbo_lista_num3.Text == "" || cbo_cliente.Text == "")
            {
                MessageBox.Show("Llene todos los campos por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                try
                {
                    conect.Conectar();
                    String Squery = "insert into  telefonocine (pk_idcine,pk_idtelefono) values('" + slista_cine + "','" + slista_numero2 + "');";
                    conect.EjecutarQuery(Squery);
                    conect.actualizargrid(dgv_tel_cine, Squeery1, Stabla);
                    nombre_columna();
                    conect.Desconectar();
                    cbo_empleado.ResetText();
                    cbo_empleado.ResetText();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.TargetSite);
                    MessageBox.Show("Error en la Tabla de telefono_cliente");
                }
            }
        }

        private void btn_regresar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            seleccion r = new seleccion(usu);
            r.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                String SCelda = this.dgv_Tel_emp.CurrentRow.Cells[0].Value.ToString();
                var Vresultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Vresultado == DialogResult.Yes)
                {
                    conect.Conectar();
                    String Squerys = "delete from  telefonoempleado where pk_idtelemp = '" + SCelda + "';";
                    conect.EjecutarQuery(Squerys);
                    conect.actualizargrid(dgv_Tel_emp, Squeery, Stabla);
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

        private void btn_eliminar_tel_cine_Click(object sender, EventArgs e)
        {
            try
            {
                String SCelda = this.dgv_tel_cine.CurrentRow.Cells[0].Value.ToString();
                var Vresultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Vresultado == DialogResult.Yes)
                {
                    conect.Conectar();
                    String Squerys = "delete from  telefonocine where pk_idtelcine = '" + SCelda + "';";
                    conect.EjecutarQuery(Squerys);
                    conect.actualizargrid(dgv_tel_cine, Squeery1, Stabla);
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
        //-----------------------------------------------------FIN LLENADO COMBOBOX---------------------------------------------------------------------------








    }
}
