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
    public partial class Region : Form
    {
        conexionymanipulacion conect = new conexionymanipulacion();
        String Stabla = "region";
        String Squeery = "select* from region";
        Boolean binsert = true;
        string usu;

        public Region(string usuario)
        {
            InitializeComponent();
            conect.actualizargrid(dgv_categoria, Squeery, Stabla);
            nombre_columna();
            usu = usuario;

            txt_nom_categ.Enabled = false;
            bttn_actualizar_categoria.Enabled = false;
            btn_guardar.Enabled = false;
            btn_eliminar_categoria.Enabled = false;
            btn_activar.Enabled = true;
            btn_desactivar.Enabled = false;

        }

        private void lbl_titulo_mantenimiento_cine_Click(object sender, EventArgs e)
        {

        }
        public void nombre_columna()
        {
            this.dgv_categoria.Columns[0].HeaderText = "No";
            this.dgv_categoria.Columns[1].HeaderText = "Region";
        }

        private void Region_Load(object sender, EventArgs e)
        {

        }
        private void update()
        {
            if (txt_nom_categ.Text == "")
            {
                MessageBox.Show("Llene los campos por favor");
            }
            else
            {

                try
                {
                    String Codigo = this.dgv_categoria.CurrentRow.Cells[0].Value.ToString();
                    conect.Conectar();
                    String Squery = "update Region set  nombreregion ='" + txt_nom_categ.Text + "'where pk_idregion ='" + Codigo + "'";
                    conect.EjecutarQuery(Squery);
                    String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usu + "','" + conect.ip() + "','modifico region', NOW());";
                    conect.EjecutarQuery1(Query);
                    conect.actualizargrid(dgv_categoria, Squeery, Stabla);
                    nombre_columna();
                    conect.Desconectar();
                    txt_nom_categ.Clear();
                    binsert = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message + ex.TargetSite);
                    MessageBox.Show("Error en la Actualizacion de region");
                }
            }
        }
        private void insert()
        {
            if (txt_nom_categ.Text == "")
            {
                MessageBox.Show("Llene los campos por favor");
            }
            else
            {

                try
                {
                    conect.Conectar();
                    String Squery = "insert into  region (nombreregion) values('" + txt_nom_categ.Text + "');";

                    conect.EjecutarQuery(Squery);
                    String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usu + "','" + conect.ip() + "','agrego Region', NOW());";
                    conect.EjecutarQuery1(Query);
                    conect.actualizargrid(dgv_categoria, Squeery, Stabla);
                    nombre_columna();
                    conect.Desconectar();
                    txt_nom_categ.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.TargetSite);
                    MessageBox.Show("Error al Guardar el nombre de la Region");
                }
            }
        }
        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
           cine r= new cine(usu);
            r.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            conect.actualizargrid(dgv_categoria, Squeery, Stabla);
        }

        private void btn_activar_Click(object sender, EventArgs e)
        {
            txt_nom_categ.Enabled = true;
            bttn_actualizar_categoria.Enabled = true;
            btn_guardar.Enabled = true;
            btn_eliminar_categoria.Enabled = true;
            btn_desactivar.Enabled = true;
            btn_activar.Enabled = false;
        }

        private void btn_desactivar_Click(object sender, EventArgs e)
        {
            txt_nom_categ.Enabled = false;
            bttn_actualizar_categoria.Enabled = false;
            btn_guardar.Enabled = false;
            btn_eliminar_categoria.Enabled = false;
            btn_activar.Enabled = true;
            btn_desactivar.Enabled = false;
        }

        private void btn_buscar_categoria_Click(object sender, EventArgs e)
        {
            try
            {
                conect.Conectar();
                String Squerys = ("Select * from Region where  nombreregion like'" + txt_buscarmod.Text + "%';");
                conect.buscarquery(Squerys);
                conect.actualizargrid(dgv_categoria, Squerys, Stabla);
                nombre_columna();
                conect.Desconectar();
                txt_buscarmod.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.TargetSite);
                MessageBox.Show("Error al buscar la region");
            }
        }

        private void bttn_actualizar_categoria_Click(object sender, EventArgs e)
        {
            btn_eliminar_categoria.Enabled = false;
            btn_buscar_categoria.Enabled = false;
            binsert = false;

            txt_nom_categ.Text = this.dgv_categoria.CurrentRow.Cells[1].Value.ToString();
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
                btn_eliminar_categoria.Enabled = true;
                btn_buscar_categoria.Enabled = true;
                MessageBox.Show("modificar");

            }
        }

        private void btn_eliminar_categoria_Click(object sender, EventArgs e)
        {
            try
            {
                String SCelda = this.dgv_categoria.CurrentRow.Cells[0].Value.ToString();
                var Vresultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Vresultado == DialogResult.Yes)
                {
                    conect.Conectar();
                    String Squerys = "delete from  region where pk_idregion = '" + SCelda + "';";
                    conect.EjecutarQuery(Squerys);
                    String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usu + "','" + conect.ip() + "','Elimino Region', NOW());";
                    conect.EjecutarQuery1(Query);
                    conect.actualizargrid(dgv_categoria, Squeery, Stabla);
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
                MessageBox.Show("Error al Borrar la Region");

            }
        }
    }
}
            

