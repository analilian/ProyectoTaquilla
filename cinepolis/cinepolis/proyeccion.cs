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
    public partial class proyeccion : Form
    {
        //----------------------------------------programado por walter y rodrigo-------------------------------------------
        //----------------------------------------fecha inicio:1/08/2016----------------------------------------------------
        //----------------------------------------fecha fin: 17/08/2016-----------------------------------------------------
        string usu;
        public proyeccion(string usuario)
        {
            InitializeComponent();
            conect.actualizargrid(dgv_proyeccion, Squeery, Stabla);
            nombre_columna();
            usu = usuario;

            txt_nom_proy.Enabled = false;
            btn_desactivar.Enabled = false;
            bttn_actualizar_proyeccion.Enabled = false;
            btn_guardar_proyeccion.Enabled = false;
            btn_eliminar_proyeccion.Enabled = false;
            btn_activar.Enabled = true;
        }

        conexionymanipulacion conect = new conexionymanipulacion();
        String Stabla = "tipoproyeccion";
        String Squeery = "select* from tipoproyeccion";
        Boolean binsert = true;

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
                btn_eliminar_proyeccion.Enabled = true;
                btn_buscar_proyeccion.Enabled = true;
                MessageBox.Show("modificar");

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
                    String Squery = "insert into  tipoproyeccion (nomtproyecccion) values('" + txt_nom_proy.Text + "');";
                    conect.EjecutarQuery(Squery);
                    String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usu+ "','" + conect.ip() + "','agrego proyeccion', NOW());";
                    conect.EjecutarQuery1(Query);
                    conect.actualizargrid(dgv_proyeccion, Squeery, Stabla);
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
                    String Codigo = this.dgv_proyeccion.CurrentRow.Cells[0].Value.ToString();
                    conect.Conectar();
                    String Squery = "update tipoproyeccion set  nomtproyecccion ='" + txt_nom_proy.Text + "'where pk_idproyeccion ='" + Codigo + "'";
                    conect.EjecutarQuery(Squery);
                    String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usu + "','" + conect.ip() + "','modifico proyeccion', NOW());";
                    conect.EjecutarQuery1(Query);
                    conect.actualizargrid(dgv_proyeccion, Squeery, Stabla);
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
                String Squerys = ("Select * from tipoproyeccion where  nomtproyecccion like'%" + txt_buscarmod.Text + "%';");
                conect.buscarquery(Squerys);
                conect.actualizargrid(dgv_proyeccion, Squerys, Stabla);
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
                String SCelda = this.dgv_proyeccion.CurrentRow.Cells[0].Value.ToString();
                var Vresultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Vresultado == DialogResult.Yes)
                {
                    conect.Conectar();
                    String Squerys = "delete from  tipoproyeccion where pk_idproyeccion = '" + SCelda + "';";
                    conect.EjecutarQuery(Squerys);
                    String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usu + "','" + conect.ip() + "','borro proyeccion', NOW());";
                    conect.EjecutarQuery1(Query);
                    conect.actualizargrid(dgv_proyeccion, Squeery, Stabla);
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
                MessageBox.Show("Error al Borrar la Categoria");

            }

        }


        public void nombre_columna()
        {
            this.dgv_proyeccion.Columns[0].HeaderText = "No";
            this.dgv_proyeccion.Columns[1].HeaderText = "Proyección";

        }

        private void bttn_actualizar_categoria_Click(object sender, EventArgs e)
        {
            btn_eliminar_proyeccion.Enabled = false;
            btn_buscar_proyeccion.Enabled = false;
            binsert = false;

            txt_nom_proy.Text = this.dgv_proyeccion.CurrentRow.Cells[1].Value.ToString();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            mantenimiento r = new mantenimiento(usu);
            r.ShowDialog();
        }

        private void proyeccion_Load(object sender, EventArgs e)
        {

        }

        private void btn_desactivar_Click(object sender, EventArgs e)
        {
            txt_nom_proy.Enabled = false;
            btn_desactivar.Enabled = false;
            bttn_actualizar_proyeccion.Enabled = false;
            btn_guardar_proyeccion.Enabled = false;
            btn_eliminar_proyeccion.Enabled = false;
            btn_activar.Enabled = true;
        }

        private void btn_activar_Click(object sender, EventArgs e)
        {
            txt_nom_proy.Enabled = true;
            btn_desactivar.Enabled = true;
            bttn_actualizar_proyeccion.Enabled = true;
            btn_guardar_proyeccion.Enabled = true;
            btn_eliminar_proyeccion.Enabled = true;
            btn_activar.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conect.actualizargrid(dgv_proyeccion, Squeery, Stabla);
        }



        private const string ayudacinetopiaadministrativa = "Title of this help project.chm";
        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, Application.StartupPath + @"/" + ayudacinetopiaadministrativa);
        }
    }
}
