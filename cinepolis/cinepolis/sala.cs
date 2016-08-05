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
    public partial class sala : Form
    {
        conexionymanipulacion conect = new conexionymanipulacion();
        String Stabla = "sala";
        String Stabla1 = "cine";
        String Squeery = "select * from sala";
        String Squeery1 = "select * from cine";
        public sala()
        {
            InitializeComponent();
            conect.actualizargrid(dgv_sala, Squeery1, Stabla1);
            conect.actualizargrid(dgv_modsala, Squeery, Stabla);
            conect.actualizargrid(dgv_borrarsala, Squeery, Stabla);
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            mantenimiento r = new mantenimiento();
            r.ShowDialog();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            string scodigo = this.dgv_sala.CurrentRow.Cells[0].Value.ToString();
            conect.Conectar();
            String Squery = "insert into  sala (nomsala, pkidcine) values('" + txt_sala.Text + "','"+ scodigo +"' );";
            conect.EjecutarQuery(Squery);
            conect.actualizargrid(dgv_modsala, Squeery, Stabla);
            conect.actualizargrid(dgv_borrarsala, Squeery, Stabla);
            conect.Desconectar();
            txt_sala.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void sala_Load(object sender, EventArgs e)
        {

        }

        private void tbc_clasificacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_codigo_buscar_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            conect.Conectar();
            String Squerys = ("Select * from sala where  nomsala like'" + txt_buscar.Text + "%';");
            conect.buscarquery(Squerys);
            conect.actualizargrid(dgv_borrarsala, Squerys, Stabla);
            conect.Desconectar();
            txt_buscar.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conect.Conectar();
            String Squerys = ("Select * from sala where  nomsala like'" + txt_buscmod.Text + "%';");
            conect.buscarquery(Squerys);
            conect.actualizargrid(dgv_modsala, Squerys, Stabla);
            conect.Desconectar();
            txt_buscmod.Clear();

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            txt_mod.Text = this.dgv_modsala.CurrentRow.Cells[1].Value.ToString();
        }

        private void btn_mod_guardar_Click(object sender, EventArgs e)
        {
            String Codigo = this.dgv_borrarsala.CurrentRow.Cells[0].Value.ToString();
            conect.Conectar();
            String Squery = "update sala set  nomsala ='" + txt_mod.Text + "'where pkidsala ='" + Codigo + "'";
            conect.EjecutarQuery(Squery);
            conect.actualizargrid(dgv_sala, Squeery1, Stabla1);
            conect.actualizargrid(dgv_modsala, Squeery, Stabla);
            conect.actualizargrid(dgv_borrarsala, Squeery, Stabla);
            conect.Desconectar();
            txt_mod.Clear();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            String SCelda = this.dgv_borrarsala.CurrentRow.Cells[0].Value.ToString();
            var Vresultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Vresultado == DialogResult.Yes)
            {
                conect.Conectar();
                String Squerys = "delete from  sala where pkidsalas = '" + SCelda + "';";
                conect.EjecutarQuery(Squerys);
                conect.actualizargrid(dgv_sala, Squeery1, Stabla1);
                conect.actualizargrid(dgv_modsala, Squeery, Stabla);
                conect.actualizargrid(dgv_borrarsala, Squeery, Stabla);
                conect.Desconectar();

            }
            else
            {
                return;
            }
        }

        private void lbl_titulo_mantenimiento_cine_Click(object sender, EventArgs e)
        {

        }
    }
}
