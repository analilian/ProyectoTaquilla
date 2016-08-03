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
        String Stabla ="usuarios";
        String Squeery = "select* from usuarios";
 


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
            if (txt_pasusuario.Text == txt_confirmar.Text)
            {
                conect.Conectar();
                String Squery = "insert into  usuarios (nomusuario,contusuario,nivelusuario,pkidempleado) values('" + txt_nombreusuario.Text + "','" + txt_pasusuario.Text + "','" + cbo_nivelsusario.Text + "','" + txt_empleado.Text + "');";
                conect.EjecutarQuery(Squery);
                conect.actualizargrid(dgv_ingresarusuario, Squeery, Stabla);
                conect.actualizargrid(dgv_borrarusuario, Squeery, Stabla);
                conect.actualizargrid(dgv_modificar, Squeery, Stabla);
                conect.Desconectar();
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
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
            String Squerys = ("Select* from usuarios where  nomusuario like'"+ txt_buscarusuario.Text + "%' or contusuario like '" + txt_buscarusuario.Text + "%' or pkidempleado like '" + txt_buscarusuario.Text + "%';" );
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
            String Squerys = ("Select* from usuarios where nomusuario like'" + txt_modificarbuscar.Text + "%' or contusuario like '" + txt_modificarbuscar.Text + "%' or pkidempleado like '" + txt_modificarbuscar.Text + "%';");
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
            String Codigo = this.dgv_modificar.CurrentRow.Cells[0].Value.ToString();
            conect.Conectar();
            String Squery = "update usuarios set nomusuario ='"+txt_nommod.Text+"',contusuario='"+txt_conmod.Text+"' ,nivelusuario='"+cbo_modnivel.Text+"',pkidempleado ='"+txt_modempl.Text+"'where pkidusuario='"+Codigo+ "'";
            conect.EjecutarQuery(Squery);
            conect.actualizargrid(dgv_ingresarusuario, Squeery, Stabla);
            conect.actualizargrid(dgv_borrarusuario, Squeery, Stabla);
            conect.actualizargrid(dgv_modificar, Squeery, Stabla);
            conect.Desconectar();
        }

        private void txt_nombreusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Este campo solo debe llevar letras", "validacion de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_pasusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Este campo no puede llevar simbolos", "validacion de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_nommod_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nommod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Este campo solo debe llevar letras", "validacion de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_conmod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Este campo no puede llevar simbolos", "validacion de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_modificarbuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_modificar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}
