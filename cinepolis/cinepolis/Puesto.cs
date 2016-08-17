using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinepolis
{
    public partial class Puesto : Form
    {
        conexionymanipulacion conect = new conexionymanipulacion();
        String Stabla = "Puesto";
        String Squeery = "select* from puesto";
        Boolean binsert = true;
        string usu;

        public Puesto(string usuario)
        {

            InitializeComponent();
            conect.actualizargrid(dgv_clasificacion, Squeery, Stabla);
            nombre_columna();
            usu = usuario;
   
            txt_descrip_clasificacion.Enabled = false;
            txt_clasificacion.Enabled = false;
            bttn_actualizar_pelicula.Enabled = false;
            btn_guardar.Enabled = false;
            btn_eliminar_pelicula.Enabled = false;
            btn_desactivar.Enabled = false;
            btn_activar.Enabled = true;
        
    }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            empleado r = new empleado(usu);
            r.ShowDialog();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conect.actualizargrid(dgv_clasificacion, Squeery, Stabla);
        }

        private void btn_activar_Click(object sender, EventArgs e)
        {
            txt_descrip_clasificacion.Enabled = true;
            txt_clasificacion.Enabled = true;
            txt_sueldo.Enabled = true;
            bttn_actualizar_pelicula.Enabled = true;
            btn_guardar.Enabled = true;
            btn_eliminar_pelicula.Enabled = true;
            btn_desactivar.Enabled = true;
            btn_activar.Enabled = false;
        }

        private void btn_desactivar_Click(object sender, EventArgs e)
        {
            txt_sueldo.Enabled = false;
            txt_descrip_clasificacion.Enabled = false;
            txt_clasificacion.Enabled = false;
            bttn_actualizar_pelicula.Enabled = false;
            btn_guardar.Enabled = false;
            btn_eliminar_pelicula.Enabled = false;
            btn_desactivar.Enabled = false;
            btn_activar.Enabled = true;
        }

        private void btn_buscar_pelicula_Click(object sender, EventArgs e)
        {
            try
            {
                conect.Conectar();
                String Squerys = ("Select * from puesto where  nompuesto like'%" + txt_modbuscar.Text + "%' or sueldopuesto like '%" + txt_modbuscar.Text + "%' or descpuesto like '%" + txt_modbuscar.Text + "%';");
                conect.buscarquery(Squerys);
                conect.actualizargrid(dgv_clasificacion, Squerys, Stabla);
                nombre_columna();
                conect.Desconectar();
                txt_modbuscar.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.TargetSite);
                MessageBox.Show("Error en la Busqueda sobre Tabla puesto");
            }
        }

        private void bttn_actualizar_pelicula_Click(object sender, EventArgs e)
        {
            binsert = false;
            btn_eliminar_pelicula.Enabled = false;
            btn_buscar_pelicula.Enabled = false;

            txt_clasificacion.Text = this.dgv_clasificacion.CurrentRow.Cells[1].Value.ToString();
            txt_descrip_clasificacion.Text = this.dgv_clasificacion.CurrentRow.Cells[3].Value.ToString();
            txt_sueldo.Text = this.dgv_clasificacion.CurrentRow.Cells[2].Value.ToString();
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

        private void btn_eliminar_pelicula_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void Puesto_Load(object sender, EventArgs e)
        {

        }
        private void update()
        {
            if (txt_clasificacion.Text == "" || txt_descrip_clasificacion.Text == "")
            {
                MessageBox.Show("Llene todos los campos por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                try
                {
                    String Codigo = this.dgv_clasificacion.CurrentRow.Cells[0].Value.ToString();
                    conect.Conectar();
                    String Squery = "update puesto set  nompuesto ='" + txt_clasificacion.Text + "',sueldopuesto ='" + txt_sueldo.Text+ "',descpuesto ='" + txt_descrip_clasificacion.Text + "'where pk_idpuesto='" + Codigo + "'";
                    conect.EjecutarQuery(Squery);
                    String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usu + "','" + conect.ip() + "','modifico sueldo', NOW());";
                    conect.EjecutarQuery1(Query);
                    conect.actualizargrid(dgv_clasificacion, Squeery, Stabla);
                    nombre_columna();
                    conect.Desconectar();
                    txt_clasificacion.Clear();
                    txt_descrip_clasificacion.Clear();
                    txt_sueldo.Clear();
                    binsert = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.TargetSite);
                    MessageBox.Show("Error en la Actualizacion sobre Tabla puesto");
                }
            }
        }
        public void nombre_columna()
        {
            this.dgv_clasificacion.Columns[0].HeaderText = "No";
            this.dgv_clasificacion.Columns[1].HeaderText = "Puesto";
            this.dgv_clasificacion.Columns[2].HeaderText = "Sueldo";
            this.dgv_clasificacion.Columns[3].HeaderText = "Descripcion Puesto";


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
                    String Squerys = "delete from  puesto where pk_idpuesto = '" + SCelda + "';";
                    conect.EjecutarQuery(Squerys);
                    String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usu + "','" + conect.ip() + "','elimino puesto', NOW());";
                    conect.EjecutarQuery1(Query);
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
                MessageBox.Show("Error en la Actualizacion sobre Tabla puesto");
            }
        }
        private void insert()
        {
            if (txt_clasificacion.Text == "" || txt_descrip_clasificacion.Text == "")
            {
                MessageBox.Show("Llene todos los campos por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {


                try
                {
                    conect.Conectar();
                    String Squery = "insert into  puesto ( nompuesto,sueldopuesto, descpuesto ) values('" + txt_clasificacion.Text + "','" + txt_sueldo.Text + "','" + txt_descrip_clasificacion.Text + "');";
                    conect.EjecutarQuery(Squery);
                    String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usu + "','" + conect.ip() + "','agrego puesto', NOW());";
                    conect.EjecutarQuery1(Query);
                    conect.actualizargrid(dgv_clasificacion, Squeery, Stabla);
                    nombre_columna();
                    conect.Desconectar();
                    txt_clasificacion.Clear();
                    txt_descrip_clasificacion.Clear();
                    txt_sueldo.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.TargetSite);
                    MessageBox.Show("Error en la Insercion sobre Tabla clasificacion");
                }
            }
        }
    }
}
