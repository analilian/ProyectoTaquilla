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
        Boolean binsert = true; 

        public Horario()
        {
            InitializeComponent();
            conect.actualizargrid(dgv_mostrar_horario, Squeery, Stabla);
            nombre_columna();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            mantenimiento r = new mantenimiento();
            r.ShowDialog();
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
                btn_eliminar_horario.Enabled = true;
                btn_buscar_horario.Enabled = true;
                MessageBox.Show("modificar");

            }
        }

        private void insert()
        {
            if (txt_horario_inicio.Text == "" || txt_hora_final.Text == "")
            {
                MessageBox.Show("Llene los campos por favor");
            }
            else
            {
                try
                {
                    conect.Conectar();
                    String Squery = "insert into  horario (horainiciohor,horafinalhor) values('" + txt_horario_inicio.Text + "','" + txt_hora_final.Text + "');";
                    conect.EjecutarQuery(Squery);
                    conect.actualizargrid(dgv_mostrar_horario, Squeery, Stabla);
                    nombre_columna();
                    conect.Desconectar();
                    txt_horario_inicio.Clear();
                    txt_hora_final.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.TargetSite);
                    MessageBox.Show("Error en la Insercion sobre Tabla horario");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Horario_Load(object sender, EventArgs e)
        {

        }

        private void btn_buscarmod_Click(object sender, EventArgs e)
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
            if (txt_horario_inicio.Text == "" || txt_hora_final.Text == "")
            {
                MessageBox.Show("Llene todos los campos por favor");
            }
            else
            {
                try
                {
                    String Codigo = this.dgv_mostrar_horario.CurrentRow.Cells[0].Value.ToString();
                    conect.Conectar();
                    String Squery = "update horario set horainiciohor = '" + txt_horario_inicio.Text + "',horafinalhor ='" + txt_hora_final.Text + "'where pk_idhorario ='" + Codigo + "'";
                    conect.EjecutarQuery(Squery);
                    conect.actualizargrid(dgv_mostrar_horario, Squeery, Stabla);
                    nombre_columna();
                    conect.Desconectar();
                    txt_horario_inicio.Clear();
                    txt_hora_final.Clear();
                    binsert = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.TargetSite);
                    MessageBox.Show("Error en la Actualizacion sobre Tabla horario");
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
                String SCelda = this.dgv_mostrar_horario.CurrentRow.Cells[0].Value.ToString();
                var Vresultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Vresultado == DialogResult.Yes)
                {
                    conect.Conectar();
                    String Squerys = "delete from  horario where pk_idhorario = '" + SCelda + "';";
                    conect.EjecutarQuery(Squerys);
                    conect.actualizargrid(dgv_mostrar_horario, Squeery, Stabla);
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
                MessageBox.Show("Error en la Eliminacion sobre Tabla horario");
            }
        }

        private void txt_mod_horainicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        public void nombre_columna()
        {
            this.dgv_mostrar_horario.Columns[0].HeaderText = "No";
            this.dgv_mostrar_horario.Columns[1].HeaderText = "Hora De Inicio";
            this.dgv_mostrar_horario.Columns[2].HeaderText = "Hora De Finalizacion";

        }

        private void bttn_actualizar_pelicula_Click(object sender, EventArgs e)
        {
            binsert = false;
            btn_eliminar_horario.Enabled = true;
            btn_buscar_horario.Enabled = true;
            txt_horario_inicio.Text = this.dgv_mostrar_horario.CurrentRow.Cells[1].Value.ToString();
            txt_hora_final.Text = this.dgv_mostrar_horario.CurrentRow.Cells[2].Value.ToString();
        }

        private void btn_buscar_horario_Click(object sender, EventArgs e)
        {
            try
            {
                conect.Conectar();
                String Squerys = ("Select* from horario where  horainiciohor like'" + txt_buscarmod.Text + "%' or horafinalhor like '" + txt_buscarmod.Text + "%';");
                conect.buscarquery(Squerys);
                conect.actualizargrid(dgv_mostrar_horario, Squerys, Stabla);
                nombre_columna();
                conect.Desconectar();
                txt_buscarmod.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.TargetSite);
                MessageBox.Show("Error en la Insercion sobre Tabla horario");
            }
        }

        private void btn_eliminar_horario_Click(object sender, EventArgs e)
        {
            delete();
        }
    }
}
