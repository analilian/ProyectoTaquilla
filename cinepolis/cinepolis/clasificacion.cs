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
        public clasificacion()
        {
            InitializeComponent();
               conect.actualizargrid(dgv_clasificacion, Squeery, Stabla);
            conect.actualizargrid(dgv_mod_clasificacion, Squeery, Stabla);
            conect.actualizargrid(dgv_borrarclasificacion, Squeery, Stabla);
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            mantenimiento r = new mantenimiento();
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
            conect.Conectar();
            String Squery = "insert into  clasificacion ( nomclasificacion, descclasificacion ) values('" + txt_clasificacion.Text + "','"+txt_descrip_clasificacion.Text+"');";
            conect.EjecutarQuery(Squery);
            conect.actualizargrid(dgv_clasificacion, Squeery, Stabla);
            conect.actualizargrid(dgv_mod_clasificacion, Squeery, Stabla);
            conect.actualizargrid(dgv_borrarclasificacion, Squeery, Stabla);
            conect.Desconectar();
            txt_clasificacion.Clear();
            txt_descrip_clasificacion.Clear();
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
            conect.Conectar();
            String Squerys = ("Select * from clasificacion where  nomclasificacion like'" + txt_modbuscar.Text + "%' or descclasificacion like '" + txt_modbuscar.Text + "%';");
            conect.buscarquery(Squerys);
            conect.actualizargrid(dgv_mod_clasificacion, Squerys, Stabla);
            conect.Desconectar();
            txt_modbuscar.Clear();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            txt_mod_clasificacion.Text = this.dgv_mod_clasificacion.CurrentRow.Cells[1].Value.ToString();
           txt_mod_descrip_clasificacion.Text = this.dgv_mod_clasificacion.CurrentRow.Cells[2].Value.ToString();
        }

        private void btn_mod_guardar_Click(object sender, EventArgs e)
        {
            String Codigo = this.dgv_mod_clasificacion.CurrentRow.Cells[0].Value.ToString();
          conect.Conectar();
            String Squery = "update clasificacion set  nomclasificacion ='" + txt_mod_clasificacion.Text + "',descclasificacion ='" +txt_mod_descrip_clasificacion.Text + "'where pkidclasificacion ='" + Codigo + "'";
            conect.EjecutarQuery(Squery);
            conect.actualizargrid(dgv_clasificacion, Squeery, Stabla);
            conect.actualizargrid(dgv_mod_clasificacion, Squeery, Stabla);
            conect.actualizargrid(dgv_borrarclasificacion, Squeery, Stabla);
            conect.Desconectar();
            txt_mod_clasificacion.Clear();
            txt_mod_descrip_clasificacion.Clear();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            conect.Conectar();
            String Squerys = ("Select * from clasificacion where  nomclasificacion like'" + txt_buscar.Text + "%' or descclasificacion like '" + txt_buscar.Text + "%';");
            conect.buscarquery(Squerys);
            conect.actualizargrid(dgv_borrarclasificacion, Squerys, Stabla);
            conect.Desconectar();
            txt_buscar.Clear();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            String SCelda = this.dgv_borrarclasificacion.CurrentRow.Cells[0].Value.ToString();
            var Vresultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Vresultado == DialogResult.Yes)
            {
                conect.Conectar();
                String Squerys = "delete from  clasificacion where pkidclasificacion = '" + SCelda + "';";
                conect.EjecutarQuery(Squerys);
                conect.actualizargrid(dgv_clasificacion, Squeery, Stabla);
                conect.actualizargrid(dgv_mod_clasificacion, Squeery, Stabla);
                conect.actualizargrid(dgv_borrarclasificacion, Squeery, Stabla);
                conect.Desconectar();

            }
            else
            {
                return;
            }
        }
    }
}
