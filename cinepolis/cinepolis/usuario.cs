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
    public partial class usuario : Form
    {
        conexionymanipulacion conect = new conexionymanipulacion();
        String Stabla ="Usuarios";
        String Squeery = "select* from Usuarios";
 


        public usuario()
        {
            InitializeComponent();
            conect.actualizargrid(dgv_ingresarusuario,Squeery, Stabla);
            conect.actualizargrid(dgv_borrarusuario, Squeery, Stabla);
            conect.actualizargrid(dgv_modificar, Squeery, Stabla);
        }
        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 r = new Form1();
            r.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            seleccion r = new seleccion();
            r.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            conect.Conectar();
            String Squery="insert into  usuarios (nomusuario,contusuario,nivelusuario,pkidempleado) values('"+txt_nombreusuario.Text+"','"+ txt_pasusuario.Text+"','"+ cbo_nivelsusario.Text+"','"+txt_empleado.Text+"');";
            conect.actualizargrid(dgv_ingresarusuario, Squeery, Stabla);
            conect.actualizargrid(dgv_borrarusuario, Squeery, Stabla);
            conect.actualizargrid(dgv_modificar, Squeery, Stabla);
            conect.Desconectar();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void usuario_Load(object sender, EventArgs e)
        {

        }

        private void dgv_empleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_eleminarusuario_Click(object sender, EventArgs e)
        {
            String SCelda = this.dgv_borrarusuario.CurrentRow.Cells[0].Value.ToString();
            var Vresultado= MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Vresultado == DialogResult.Yes)
            {
                conect.Conectar();
                String Squerys = "delete from  usuarios where pkidusuario = '" + SCelda + "';";
                conect.EjecutarQuery(Squerys);
                conect.actualizargrid(dgv_ingresarusuario, Squeery, Stabla);
                conect.actualizargrid(dgv_borrarusuario, Squeery, Stabla);
                conect.actualizargrid(dgv_modificar, Squeery, Stabla);
                conect.Desconectar();

            }
            else
            {
                return;
            }
                
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            conect.Conectar();
            String Squerys = ("Select* from usuarios where nomusuario='"+ txt_buscarusuario.Text + "%' or conusuario= '" + txt_buscarusuario.Text + "%' or pkidempleado ='" + txt_buscarusuario.Text + "%';" );
            conect.buscarquery(Squerys);
            conect.actualizargrid(dgv_borrarusuario, Squerys, Stabla);
            conect.Desconectar();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_buscarmod_Click(object sender, EventArgs e)
        {
            conect.Conectar();
            String Squerys = ("Select* from usuarios where nomusuario='" + txt_modificarbuscar.Text + "%' or conusuario= '" + txt_modificarbuscar.Text + "%' or pkidempleado ='" + txt_modificarbuscar.Text + "%';");
            conect.buscarquery(Squerys);
            conect.actualizargrid(dgv_modificar, Squerys, Stabla);
            conect.Desconectar();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txt_nommod.Text= this.dgv_modificar.CurrentRow.Cells[1].Value.ToString();
            txt_conmod.Text = this.dgv_modificar.CurrentRow.Cells[2].Value.ToString();
            cbo_modnivel.Text = this.dgv_modificar.CurrentRow.Cells[3].Value.ToString();
          txt_modempl.Text= this.dgv_modificar.CurrentRow.Cells[4].Value.ToString();
        }

        private void btn_insertarmod_Click(object sender, EventArgs e)
        {
            conect.Conectar();
            String Squery = "insert into  usuarios (nomusuario,contusuario,nivelusuario,pkidempleado) values('" + txt_nommod.Text + "','" + txt_conmod.Text + "','" + cbo_modnivel.Text + "','" + txt_modempl.Text + "');";
            conect.actualizargrid(dgv_ingresarusuario, Squeery, Stabla);
            conect.actualizargrid(dgv_borrarusuario, Squeery, Stabla);
            conect.actualizargrid(dgv_modificar, Squeery, Stabla);
            conect.Desconectar();
        }
    }
}
