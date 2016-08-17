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
        string usu;
        public fecha(string usuario)
        {
            InitializeComponent();
            
            conect.actualizargrid(dgv_mostrar_fecha, Squeery, Stabla);
            nombre_columna();
            usu = usuario;


            dtp_fecha_fin.Enabled = false;
            dtp_fecha_inicio.Enabled = false;
            bttn_actualizar_fecha.Enabled = false;
            btn_guardar.Enabled = false;
            btn_eliminar_fecha.Enabled = false;
            btn_desactivar.Enabled = false;
            btn_activar.Enabled = true;
        }
        conexionymanipulacion conect = new conexionymanipulacion();
        String Stabla = "fechascartelera";
        String Squeery = "select * from fechascartelera";
        Boolean binsert = true;
        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
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
                btn_eliminar_fecha.Enabled = true;
                btn_buscar_fecha.Enabled = true;
                MessageBox.Show("modificar");

            }
        }

        private void insert()
        {
            try
            {
                conect.Conectar();
                String Squery = "insert into  fechascartelera (fechainicar,fechafinalcar) values('" + this.dtp_fecha_inicio.Text + "','" + this.dtp_fecha_fin.Text + "');";
                conect.EjecutarQuery(Squery);
                String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usu + "','" + conect.ip() + "','agrego fecha', NOW());";
                conect.EjecutarQuery1(Query);
                conect.actualizargrid(dgv_mostrar_fecha, Squeery, Stabla);
                nombre_columna();
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
            
        }

        private void update()
        {
            try
            {
                String Codigo = this.dgv_mostrar_fecha.CurrentRow.Cells[0].Value.ToString();
                conect.Conectar();
                String Squery = "update fechascartelera set fechainicar = '" + this.dtp_fecha_inicio.Text + "',fechafinalcar ='" + this.dtp_fecha_fin.Text + "'where pk_idfcar ='" + Codigo + "'";
                conect.EjecutarQuery(Squery);
                String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usu + "','" + conect.ip() + "','modifico fecha', NOW());";
                conect.EjecutarQuery1(Query);
                conect.actualizargrid(dgv_mostrar_fecha, Squeery, Stabla);
                nombre_columna();
                conect.Desconectar();
                binsert = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.TargetSite);
                MessageBox.Show("Error en la Actualizacion sobre Tabla horario");
            }
        }


        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
           
        }

        private void delete()
        {
            try
            {

                String sCelda = this.dgv_mostrar_fecha.CurrentRow.Cells[0].Value.ToString();
                conect.Conectar();
                String Squerys = "delete from  fechascartelera where pk_idfcar = '" + sCelda + "';";
                conect.EjecutarQuery(Squerys);
                String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usu + "','" + conect.ip() + "','Elimino fecha', NOW());";
                conect.EjecutarQuery1(Query);
                conect.actualizargrid(dgv_mostrar_fecha, Squeery, Stabla);
                nombre_columna();
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
            mantenimiento r = new mantenimiento(usu);
            r.ShowDialog();
        }

        private void fecha_Load(object sender, EventArgs e)
        {

        }

        private void bttn_actualizar_pelicula_Click(object sender, EventArgs e)
        {
            binsert = false;
            btn_eliminar_fecha.Enabled = false;
            btn_buscar_fecha.Enabled = false;
            this.dtp_fecha_inicio.Text = this.dgv_mostrar_fecha.CurrentRow.Cells[1].Value.ToString();
            this.dtp_fecha_fin.Text = this.dgv_mostrar_fecha.CurrentRow.Cells[2].Value.ToString();
        }

        private void btn_buscarmod_Click(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

        }

        public void nombre_columna()
        {
            this.dgv_mostrar_fecha.Columns[0].HeaderText = "No";
            this.dgv_mostrar_fecha.Columns[1].HeaderText = "Fecha inicio película";
            this.dgv_mostrar_fecha.Columns[2].HeaderText = "Fecha finalización película";
           
        }

        private void btn_buscar_fecha_Click(object sender, EventArgs e)
        {
            conect.Conectar();
            String Squerys = ("Select * from fechascartelera where fechainicar like '%" + txt_buscarmod.Text + "%' or fechafinalcar like '%" + txt_buscarmod.Text + "%';");
            conect.buscarquery(Squerys);
            conect.actualizargrid(dgv_mostrar_fecha, Squerys, Stabla);
            nombre_columna();
            conect.Desconectar();
            txt_buscarmod.Clear();
        }

        private void btn_eliminar_fecha_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn_desactivar_Click(object sender, EventArgs e)
        {
            dtp_fecha_fin.Enabled = false;
            dtp_fecha_inicio.Enabled = false;
            bttn_actualizar_fecha.Enabled = false;
            btn_guardar.Enabled = false;
            btn_eliminar_fecha.Enabled = false;
            btn_desactivar.Enabled = false;
            btn_activar.Enabled = true;
        }

        private void btn_activar_Click(object sender, EventArgs e)
        {
            dtp_fecha_fin.Enabled = true;
            dtp_fecha_inicio.Enabled = true;
            bttn_actualizar_fecha.Enabled = true;
            btn_guardar.Enabled = true;
            btn_eliminar_fecha.Enabled = true;
            btn_desactivar.Enabled = true;
            btn_activar.Enabled = false;
        }


        private const string ayudacinetopiaadministrativa = "Title of this help project.chm";
        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, Application.StartupPath + @"/" + ayudacinetopiaadministrativa);
        }
    }
}
