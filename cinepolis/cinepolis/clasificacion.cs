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
    public partial class clasificacion : Form
    {
        conexionymanipulacion conect = new conexionymanipulacion();
        String Stabla = "clasificacion";
        String Squeery = "select* from clasificacion";
        Boolean binsert = true;
        string usu;
        public clasificacion(string usuario)
        {
            InitializeComponent();
            conect.actualizargrid(dgv_clasificacion, Squeery, Stabla);
            nombre_columna();
            usu = usuario;
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            mantenimiento r = new mantenimiento(usu);
            r.ShowDialog();
        }

        private void tbc_clasificacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_titulo_mantenimiento_cine_Click(object sender, EventArgs e)
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
                btn_eliminar_pelicula.Enabled = true;
                btn_buscar_pelicula.Enabled = true;
                MessageBox.Show("modificar");

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
                    String Squery = "insert into  clasificacion ( nomclasificacion, descclasificacion ) values('" + txt_clasificacion.Text + "','" + txt_descrip_clasificacion.Text + "');";
                    conect.EjecutarQuery(Squery);
                    String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usu + "','" + conect.ip() + "','agrego clasificacion', NOW());";
                    conect.EjecutarQuery(Query);
                    conect.actualizargrid(dgv_clasificacion, Squeery, Stabla);
                    nombre_columna();
                    conect.Desconectar();
                    txt_clasificacion.Clear();
                    txt_descrip_clasificacion.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.TargetSite);
                    MessageBox.Show("Error en la Insercion sobre Tabla clasificacion");
                }
            }
        }


        private void clasificacion_Load(object sender, EventArgs e)
        {

        }

        private void lbl_modbuscar_Click(object sender, EventArgs e)
        {

        }

        private void dgv_borrar_categoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_mod_guardar_Click(object sender, EventArgs e)
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
                    String Squery = "update clasificacion set  nomclasificacion ='" + txt_clasificacion.Text + "',descclasificacion ='" + txt_descrip_clasificacion.Text + "'where pk_idclasificacion ='" + Codigo + "'";
                    conect.EjecutarQuery(Squery);
                    String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usu + "','" + conect.ip() + "','modifico clasificacion', NOW());";
                    conect.EjecutarQuery(Query);
                    conect.actualizargrid(dgv_clasificacion, Squeery, Stabla);
                    nombre_columna();
                    conect.Desconectar();
                    txt_clasificacion.Clear();
                    txt_descrip_clasificacion.Clear();
                    binsert = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.TargetSite);
                    MessageBox.Show("Error en la Actualizacion sobre Tabla clasificacion");
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
                    String Squerys = "delete from  clasificacion where pk_idclasificacion = '" + SCelda + "';";
                    conect.EjecutarQuery(Squerys);
                    String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usu + "','" + conect.ip() + "','elimino clasificaion', NOW());";
                    conect.EjecutarQuery(Query);
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
                MessageBox.Show("Error en la Actualizacion sobre Tabla clasificacion");
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        public void nombre_columna()
        {
            this.dgv_clasificacion.Columns[0].HeaderText = "No";
            this.dgv_clasificacion.Columns[1].HeaderText = "Clasificacion";
            this.dgv_clasificacion.Columns[2].HeaderText = "Descripcion";

        }

        private void bttn_actualizar_pelicula_Click(object sender, EventArgs e)
        {
            binsert = false;
            btn_eliminar_pelicula.Enabled = false;
            btn_buscar_pelicula.Enabled = false;

            txt_clasificacion.Text = this.dgv_clasificacion.CurrentRow.Cells[1].Value.ToString();
            txt_descrip_clasificacion.Text = this.dgv_clasificacion.CurrentRow.Cells[2].Value.ToString();
        }

        private void btn_buscar_pelicula_Click(object sender, EventArgs e)
        {
            try
            {
                conect.Conectar();
                String Squerys = ("Select * from clasificacion where  nomclasificacion like'%" + txt_modbuscar.Text + "%' or descclasificacion like '%" + txt_modbuscar.Text + "%';");
                conect.buscarquery(Squerys);
                conect.actualizargrid(dgv_clasificacion, Squerys, Stabla);
                nombre_columna();
                conect.Desconectar();
                txt_modbuscar.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.TargetSite);
                MessageBox.Show("Error en la Busqueda sobre Tabla clasificacion");
            }
        }

        private void btn_eliminar_pelicula_Click(object sender, EventArgs e)
        {
            delete();
        }
    }
}
