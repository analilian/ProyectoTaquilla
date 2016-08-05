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
    public partial class Horario : Form
    {
        conexionymanipulacion conect = new conexionymanipulacion();
        String Stabla = "horario";
        String Squeery = "select* from horario";

        public Horario()
        {
            InitializeComponent();
            conect.actualizargrid(dgv_mostrar_peliculas, Squeery, Stabla);
            conect.actualizargrid(dgv_borrar_horario, Squeery, Stabla);
            conect.actualizargrid(dgv_mod_horario, Squeery, Stabla);
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            mantenimiento r = new mantenimiento();
            r.ShowDialog();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            conect.Conectar();
            String Squery = "insert into  horario (horainiciohor,horafinalhor) values('" + txt_horario_inicio.Text + "','" + txt_hora_final.Text +  "');";
            conect.EjecutarQuery(Squery);
            conect.actualizargrid(dgv_mostrar_peliculas, Squeery, Stabla);
            conect.actualizargrid(dgv_borrar_horario, Squeery, Stabla);
            conect.actualizargrid(dgv_mod_horario, Squeery, Stabla);
            conect.Desconectar();
            txt_horario_inicio.Clear();
            txt_hora_final.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Horario_Load(object sender, EventArgs e)
        {

        }

        private void btn_buscarmod_Click(object sender, EventArgs e)
        {

            conect.Conectar();
            String Squerys = ("Select* from horario where  horainiciohor like'" + txt_buscarmod.Text + "%' or horafinalhor like '" + txt_buscarmod.Text + "%';");
            conect.buscarquery(Squerys);
            conect.actualizargrid(dgv_mod_horario, Squerys, Stabla);
            conect.Desconectar();
            txt_buscarmod.Clear();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
           txt_mod_horainicio.Text = this.dgv_mod_horario.CurrentRow.Cells[1].Value.ToString();
            txt_mod_horafin.Text = this.dgv_mod_horario.CurrentRow.Cells[2].Value.ToString();
          

        }

        private void btn_mod_guardar_Click(object sender, EventArgs e)
        {
            String Codigo = this.dgv_mod_horario.CurrentRow.Cells[0].Value.ToString();
            conect.Conectar();
            String Squery = "update horario set horainiciohor = '" + txt_mod_horainicio.Text + "',horafinalhor ='" + txt_mod_horafin.Text +"'where pkidhorario ='" + Codigo + "'";
            conect.EjecutarQuery(Squery);
            conect.actualizargrid(dgv_mostrar_peliculas, Squeery, Stabla);
            conect.actualizargrid(dgv_borrar_horario, Squeery, Stabla);
            conect.actualizargrid(dgv_mod_horario, Squeery, Stabla);
            conect.Desconectar();
            txt_mod_horainicio.Clear();
            txt_mod_horafin.Clear();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            conect.Conectar();
            String Squerys = ("Select * from horario where  horainiciohor like'" + txt_buscar.Text + "%' or horafinalhor like '" + txt_buscar.Text + "%';");
            conect.buscarquery(Squerys);
            conect.actualizargrid(dgv_borrar_horario, Squerys, Stabla);
            conect.Desconectar();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            String SCelda = this.dgv_borrar_horario.CurrentRow.Cells[0].Value.ToString();
            var Vresultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Vresultado == DialogResult.Yes)
            {
                conect.Conectar();
                String Squerys = "delete from  horario where pkidhorario = '" + SCelda + "';";
                conect.EjecutarQuery(Squerys);
                conect.actualizargrid(dgv_mostrar_peliculas, Squeery, Stabla);
                conect.actualizargrid(dgv_borrar_horario, Squeery, Stabla);
                conect.actualizargrid(dgv_mod_horario, Squeery, Stabla);
                conect.Desconectar();

            }
            else
            {
                return;
            }
        }

        private void txt_mod_horainicio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
