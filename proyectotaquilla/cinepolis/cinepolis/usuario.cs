using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace cinepolis
{
    public partial class usuario : Form
    {
        encriptado encrip = new encriptado();
        conexionymanipulacion conect = new conexionymanipulacion();
        String Stabla ="usuario";
        String Squeery = "select* from usuario";
        MySqlConnection micon = new MySqlConnection("server=localhost; database=bdcinetopia; Uid=root; pwd=;");



        public usuario()
        {
            InitializeComponent();
            conect.actualizargrid(dgv_ingresarusuario,Squeery, Stabla);
            conect.actualizargrid(dgv_borrarusuario, Squeery, Stabla);
            conect.actualizargrid(dgv_modificar, Squeery, Stabla);
            nombre_columna();
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

        public void limpiaringresar()
        {
            txt_nombreusuario.Clear();
            txt_pasusuario.Clear();
            txt_confirmar.Clear();
            cbo_nivelsusario.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txt_pasusuario.Text == txt_confirmar.Text)
            {
                int admin ;
      
                conect.Conectar();
                if (cbo_nivelsusario.Text == "administrativo")
                {
                    admin = 1;
                    String Squery = "insert into  usuario (nomusuario,contusuario,pkidrole,pkidempleado) values('" + txt_nombreusuario.Text + "','" + encrip.EncryptKey(txt_pasusuario.Text) + "','" + admin + "','" + cbo_elegirempleado.Text + "');";
                    conect.EjecutarQuery(Squery);
                    limpiaringresar();
                }
                else
                {
                
                    admin = 2;
                    String Squery = "insert into  usuario (nomusuario,contusuario,pkidrole,pkidempleado) values('" + txt_nombreusuario.Text + "','" + encrip.EncryptKey(txt_pasusuario.Text) + "','" + admin + "','" + cbo_elegirempleado.Text + "');";
                    conect.EjecutarQuery(Squery);
                    limpiaringresar();
                }

                conect.actualizargrid(dgv_ingresarusuario, Squeery, Stabla);
                conect.actualizargrid(dgv_borrarusuario, Squeery, Stabla);
                conect.actualizargrid(dgv_modificar, Squeery, Stabla);
                nombre_columna();
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
            cb1();
            cb2();
            cb3();
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
                String Squerys = "delete from  usuario where pkidusuario = '" + SCelda + "';";
                conect.EjecutarQuery(Squerys);
                conect.actualizargrid(dgv_ingresarusuario, Squeery, Stabla);
                conect.actualizargrid(dgv_borrarusuario, Squeery, Stabla);
                conect.actualizargrid(dgv_modificar, Squeery, Stabla);
                nombre_columna();
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
            String Squerys = ("Select* from usuario where  nomusuario like'"+ txt_buscarusuario.Text +  "%' or pkidempleado like '" + txt_buscarusuario.Text + "%'or pkidrole like '" + txt_buscarusuario.Text + "%';");
            conect.buscarquery(Squerys);
            conect.actualizargrid(dgv_borrarusuario, Squerys, Stabla);
            nombre_columna();
            conect.Desconectar();
            txt_buscarusuario.Clear();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_buscarmod_Click(object sender, EventArgs e)
        {
            conect.Conectar();
            String Squerys = ("Select* from usuario where nomusuario like'" + txt_modificarbuscar.Text + "%' or pkidempleado like '" + txt_modificarbuscar.Text + "%' or pkidrole like '" + txt_modificarbuscar.Text + "%';");
            conect.buscarquery(Squerys);
            conect.actualizargrid(dgv_modificar, Squerys, Stabla);
            nombre_columna();
            conect.Desconectar();
            txt_modificarbuscar.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txt_nommod.Text= this.dgv_modificar.CurrentRow.Cells[1].Value.ToString();
            txt_conmod.Text = encrip.DecryptKey(this.dgv_modificar.CurrentRow.Cells[2].Value.ToString()); ;
            cbo_modnivel.Text = this.dgv_modificar.CurrentRow.Cells[3].Value.ToString();
          txt_modempl.Text= this.dgv_modificar.CurrentRow.Cells[4].Value.ToString();
        }

        public void limpiarmod()
        {
            txt_nommod.Clear();
            txt_conmod.Clear();
            txt_confmod.Clear();
            cbo_modnivel.ResetText();
            txt_modempl.Clear();
        } 

        private void btn_insertarmod_Click(object sender, EventArgs e)
        {
            String Codigo = this.dgv_modificar.CurrentRow.Cells[0].Value.ToString();
            conect.Conectar();
            if (txt_conmod.Text == txt_confmod.Text)
            {
                String Squery = "update usuario set nomusuario ='" + txt_nommod.Text + "',contusuario='" + encrip.EncryptKey(txt_conmod.Text) + "' ,pkidrole='" + cbo_modnivel.Text + "',pkidempleado ='" + txt_modempl.Text + "'where pkidusuario='" + Codigo + "'";
                conect.EjecutarQuery(Squery);
                conect.actualizargrid(dgv_ingresarusuario, Squeery, Stabla);
                conect.actualizargrid(dgv_borrarusuario, Squeery, Stabla);
                conect.actualizargrid(dgv_modificar, Squeery, Stabla);
                nombre_columna();
                conect.Desconectar();
                limpiarmod();
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }


        private void cb1()
        {
            try
            {
              
                string s = "select * from bdcinetopia.role";
              
                micon.Open();
                MySqlCommand mcd = new MySqlCommand(s, micon);
                MySqlDataReader mdr = mcd.ExecuteReader();
                while (mdr.Read())
                {
                    cbo_nivelsusario.Items.Add(mdr.GetString("role"));
                }
                micon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cb2()
        {
            try
            {
            
                string s = "select * from bdcinetopia.empleado";

                micon.Open();
                MySqlCommand mcd = new MySqlCommand(s, micon);
                MySqlDataReader mdr = mcd.ExecuteReader();
                while (mdr.Read())
                {
                    cbo_elegirempleado.Items.Add(mdr.GetString("pkidempleado"));
                }
                micon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cb3()
        {
            try
            {

                string s = "select * from bdcinetopia.role";

                micon.Open();
                MySqlCommand mcd = new MySqlCommand(s, micon);
                MySqlDataReader mdr = mcd.ExecuteReader();
                while (mdr.Read())
                {
                    cbo_modnivel.Items.Add(mdr.GetString("role"));
                }
                micon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_conmod_TextChanged(object sender, EventArgs e)
        {

        }
        public void nombre_columna()
        {
           this.dgv_ingresarusuario.Columns[0].HeaderText = "No";
            this.dgv_ingresarusuario.Columns[1].HeaderText = "Usuario";
            this.dgv_ingresarusuario.Columns[3].HeaderText = "Empleado";
            this.dgv_ingresarusuario.Columns[4].HeaderText = "Role";
            this.dgv_ingresarusuario.Columns[2].Visible = false;
            this.dgv_modificar.Columns[0].HeaderText = "No";
            this.dgv_modificar.Columns[1].HeaderText = "Usuario";
            this.dgv_modificar.Columns[3].HeaderText = "Empleado";
            this.dgv_modificar.Columns[4].HeaderText = "Role";
            this.dgv_modificar.Columns[2].Visible = false;
            this.dgv_borrarusuario.Columns[0].HeaderText = "No";
            this.dgv_borrarusuario.Columns[1].HeaderText = "Usuario";
            this.dgv_borrarusuario.Columns[3].HeaderText = "Empleado";
            this.dgv_borrarusuario.Columns[4].HeaderText = "Role";
            this.dgv_borrarusuario.Columns[2].Visible = false;

        }
    }
}
