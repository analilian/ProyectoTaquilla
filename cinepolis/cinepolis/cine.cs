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
    public partial class cine : Form
    {
        conexionymanipulacion conect = new conexionymanipulacion();
        String Stabla = "cine";
        String Squeery = "select a.pk_idcine, a.nomcine, a.direccin, b.nombreregion from cine a, region b where a.pk_idregion=b.pk_idregion ORDER BY `a`.`nomcine` ASC";
        Boolean binsert = true;
        string usu;
        

        public cine(string usuario)
        {
            InitializeComponent();
            conect.actualizargrid(dgv_clasificacion, Squeery, Stabla);
            nombre_columna();
            usu = usuario;

            txt_nombre_cine.Enabled = false;
            txt_descrip_cine.Enabled = false;
            cbo_cine_region.Enabled = false;
            bttn_actualizar_pelicula.Enabled = false;
            btn_guardar.Enabled = false;
            btn_eliminar_pelicula.Enabled = false;
            btn_telefono_empleado.Enabled = false;
            btn_desactivar.Enabled = false;
            btn_activar.Enabled = true;
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            mantenimiento r = new mantenimiento(usu);
            r.ShowDialog();
        }

        private void cine_Load(object sender, EventArgs e)
        {
            cb1();
            
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
                btn_eliminar_pelicula.Enabled = true;
                btn_buscar_pelicula.Enabled = true;
                MessageBox.Show("modificar");

            }
        }


        private void insert()
        {
            string convregion = cbo_cine_region.SelectedValue.ToString();

            if (txt_nombre_cine.Text == "" || txt_descrip_cine.Text == "")
            {
                MessageBox.Show("Llene los campos por favor");
            }
            else
            {

                try
                {
                    conect.Conectar();
                    String Squery = "insert into  cine (nomcine,direccin,pk_idregion) values('" + txt_nombre_cine.Text + "','" + txt_descrip_cine.Text + "','" + convregion + "');";
                    String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usu + "','" + conect.ip() + "','agrego cine', NOW());";
                    conect.EjecutarQuery(Squery);
                    conect.EjecutarQuery1(Query);
                    conect.actualizargrid(dgv_clasificacion, Squeery, Stabla);
                    nombre_columna();
                    conect.Desconectar();
                    txt_nombre_cine.Clear();
                    txt_descrip_cine.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.TargetSite);
                    MessageBox.Show("Error en la Tabla de cine");
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_mod_guardar_Click(object sender, EventArgs e)
        {
           
        }



        private void update()
        {
            string convregionmod = cbo_cine_region.SelectedValue.ToString();

            if (txt_nombre_cine.Text == "" || txt_descrip_cine.Text == "")
            {
                MessageBox.Show("Llene los campos por favor");
            }
            else
            {

                try
                {
                    String Codigo = this.dgv_clasificacion.CurrentRow.Cells[0].Value.ToString();
                    conect.Conectar();
                    String Squery = "update cine set  nomcine ='" + txt_nombre_cine.Text + "', direccin ='" + txt_descrip_cine.Text + "', pk_idregion ='" + convregionmod + "'where pk_idcine ='" + Codigo + "'";
                    String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usu + "','" + conect.ip() + "','modifico cine', NOW());";
                    conect.EjecutarQuery(Squery);
                    conect.EjecutarQuery1(Query);
                    conect.actualizargrid(dgv_clasificacion, Squeery, Stabla);
                    nombre_columna();
                    conect.Desconectar();
                    txt_nombre_cine.Clear();
                    txt_descrip_cine.Clear();
                    cbo_cine_region.ResetText();
                    binsert = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.TargetSite);
                    MessageBox.Show("Error en la Actualizacion en la Tabla Cine");
                }
            }

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
           
        }

        private void delete()
        {
            try
            {
                String SCelda = this.dgv_clasificacion.CurrentRow.Cells[0].Value.ToString();
                var Vresultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Vresultado == DialogResult.Yes)
                {
                    conect.Conectar();
                    String Squerys = "delete from  cine where pk_idcine = '" + SCelda + "';";
                    String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usu + "','" + conect.ip() + "','Elimino cine', NOW());";
                    conect.EjecutarQuery1(Query);
                     conect.EjecutarQuery(Squerys);
                    conect.actualizargrid(dgv_clasificacion, Squeery, Stabla);
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
                MessageBox.Show("Error al Eliminar un Registro en la Tabla cine");
            }
        }



        public void nombre_columna()
        {
            this.dgv_clasificacion.Columns[0].HeaderText = "No";
            this.dgv_clasificacion.Columns[1].HeaderText = "Cine";
            this.dgv_clasificacion.Columns[2].HeaderText = "Direccion";
            this.dgv_clasificacion.Columns[3].HeaderText = "Region";
          

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_titulo_mantenimiento_cine_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cb1()
        {
            try
            {

                conect.Conectar();
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select pk_idregion, nombreregion from region;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query,conect.rutaconectada());
                //se indica con quu tabla se llena
                dad.Fill(ds, "Region");
                cbo_cine_region.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_cine_region.ValueMember = ("pk_idregion");
                //se indica el valor a desplegar en el combobox
                cbo_cine_region.DisplayMember = ("nombreregion");
                conect.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



       

        private void bttn_actualizar_pelicula_Click(object sender, EventArgs e)
        {
            btn_eliminar_pelicula.Enabled = false;
            btn_buscar_pelicula.Enabled = false;
            binsert = false;

            txt_nombre_cine.Text = this.dgv_clasificacion.CurrentRow.Cells[1].Value.ToString();
            txt_descrip_cine.Text = this.dgv_clasificacion.CurrentRow.Cells[2].Value.ToString();
            cbo_cine_region.Text = this.dgv_clasificacion.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_buscar_pelicula_Click(object sender, EventArgs e)
        {

            try
            {
                conect.Conectar();
                String Squerys = ("Select* from cine where  nomcine like'%" + txt_buscarmod.Text + "%' or direccin like '%" + txt_buscarmod.Text + "%';");
                conect.buscarquery(Squerys);
                conect.actualizargrid(dgv_clasificacion, Squerys, Stabla);
                nombre_columna();
                conect.Desconectar();
                txt_buscarmod.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.TargetSite);
                MessageBox.Show("Error en la Busqueda en la tabla cine");
            }
        }

        private void btn_eliminar_pelicula_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void btn_telefono_empleado_Click(object sender, EventArgs e)
        {
            this.Hide();
            telefonoEmpleado r = new telefonoEmpleado(usu);
            r.ShowDialog();
        }

        private void btn_desactivar_Click(object sender, EventArgs e)
        {
            txt_nombre_cine.Enabled = false;
            txt_descrip_cine.Enabled = false;
            cbo_cine_region.Enabled = false;
            bttn_actualizar_pelicula.Enabled = false;
            btn_guardar.Enabled = false;
            btn_eliminar_pelicula.Enabled = false;
            btn_telefono_empleado.Enabled = false;
            btn_desactivar.Enabled = false;
            btn_activar.Enabled = true;
        }

        private void btn_activar_Click(object sender, EventArgs e)
        {
            txt_nombre_cine.Enabled = true;
            txt_descrip_cine.Enabled = true;
            cbo_cine_region.Enabled = true;
            bttn_actualizar_pelicula.Enabled = true;
            btn_guardar.Enabled = true;
            btn_eliminar_pelicula.Enabled = true;
            btn_telefono_empleado.Enabled = true;
            btn_activar.Enabled = false;
            btn_desactivar.Enabled = true;
        }
    }
}

