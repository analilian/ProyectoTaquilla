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
    public partial class fecha : Form
    {
        public fecha()
        {
            InitializeComponent();
            conect.actualizargrid(dgv_mostrar_peliculas, Squeery, Stabla);
            conect.actualizargrid(dgv_borrar_horario, Squeery, Stabla);
            conect.actualizargrid(dgv_mod_horario, Squeery, Stabla);
        }
        conexionymanipulacion conect = new conexionymanipulacion();
        String Stabla = "fechascartelera";
        String Squeery = "select* from fechascartelera";
        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
           
                try
                {
                    conect.Conectar();
                    String Squery = "insert into  fechascartelera (fechainicar,fechafinalcar) values('" + this.dtp_fecha_inicio.Text + "','" + this.dtp_fecha_fin.Text + "');";
                    conect.EjecutarQuery(Squery);
                    conect.actualizargrid(dgv_mostrar_peliculas, Squeery, Stabla);
                    conect.actualizargrid(dgv_borrar_horario, Squeery, Stabla);
                    conect.actualizargrid(dgv_mod_horario, Squeery, Stabla);
                    conect.Desconectar();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.TargetSite);
                    MessageBox.Show("Error en la Insercion sobre Tabla fecha cartelera");
                }
           
        }

        private void btn_mod_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                String Codigo = this.dgv_mod_horario.CurrentRow.Cells[0].Value.ToString();
                conect.Conectar();
                String Squery = "update fechascartelera set fechainicar = '" + this.dtp_fecha_inicio_mod.Text + "',fechafinalcar ='" + this.dtp_fecha_fin_mod.Text + "'where pk_idfcar ='" + Codigo + "'";
                conect.EjecutarQuery(Squery);
                conect.actualizargrid(dgv_mostrar_peliculas, Squeery, Stabla);
                conect.actualizargrid(dgv_borrar_horario, Squeery, Stabla);
                conect.actualizargrid(dgv_mod_horario, Squeery, Stabla);
                conect.Desconectar();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.TargetSite);
                MessageBox.Show("Error en la Actualizacion sobre Tabla horario");
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            this.dtp_fecha_inicio_mod.Text = this.dgv_mod_horario.CurrentRow.Cells[1].Value.ToString();
            this.dtp_fecha_fin_mod.Text = this.dgv_mod_horario.CurrentRow.Cells[2].Value.ToString();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            try
            {

            String sCelda = this.dgv_borrar_horario.CurrentRow.Cells[0].Value.ToString();
            conect.Conectar();
            String Squerys = "delete from  fechascartelera where pk_idfcar = '" + sCelda + "';";
            conect.EjecutarQuery(Squerys);
            conect.actualizargrid(dgv_mostrar_peliculas, Squeery, Stabla);
            conect.actualizargrid(dgv_borrar_horario, Squeery, Stabla);
            conect.actualizargrid(dgv_mod_horario, Squeery, Stabla);
            conect.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.TargetSite);
                MessageBox.Show("Error en borrar sobre Tabla fechascartelera");
            }
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            mantenimiento r = new mantenimiento();
            r.ShowDialog();
        }

        private void fecha_Load(object sender, EventArgs e)
        {

        }
    }
}
