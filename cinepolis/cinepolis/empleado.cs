﻿using System;
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
    public partial class empleado : Form
    {
        conexionymanipulacion conect = new conexionymanipulacion();
        String Stabla = "empleado";
        String Squeery = "select * from empleado";
        public empleado()
        {
            InitializeComponent();
            conect.actualizargrid(dgv_emplados_modificar, Squeery, Stabla);
            conect.actualizargrid(dgv_buscar_empleado, Squeery, Stabla);
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            seleccion r = new seleccion();
            r.ShowDialog();
        }

        private void btn_cerrarsesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 r = new Form1();
            r.ShowDialog();
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nombre1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_nombre2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_apellido1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_apellido2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_dpi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
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
                MessageBox.Show("Este campo solo debe llevar numero", "validacion de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txt_nit_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
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
                MessageBox.Show("Este campo solo debe llevar numero", "validacion de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_mod_nombre1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txt_mod_nombre1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_mod_nombre2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_mod_apellido1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_mod_apellido2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_mod_dpi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
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
                MessageBox.Show("Este campo solo debe llevar numero", "validacion de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_mod_nit_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_mod_apellido2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            conect.Conectar();
            String Squery = "insert into  empleado (nom1empleado,nom2empleado,ape1empleado,ape2empleado,dirempleado,dpiempleado,nitempleado,fechanacempleado,pkidcine,pkidpuesto) values('" + txt_nombre1.Text + "','" + txt_nombre2.Text + "','" + txt_apellido1.Text + "','" + txt_apellido2.Text + "','" + txt_direccion.Text + "','" + txt_dpi.Text + "','" + txt_nit.Text + "','" + txt_fecha_nac.Text + "','" + cbo_cine.Text + "','" + cbo_puesto.Text + "');";
            conect.EjecutarQuery(Squery);
            conect.actualizargrid(dgv_emplados_modificar, Squeery, Stabla);
            conect.actualizargrid(dgv_buscar_empleado, Squeery, Stabla);
            conect.Desconectar();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            txt_mod_nombre1.Text = this.dgv_emplados_modificar.CurrentRow.Cells[1].Value.ToString();
            txt_mod_nombre2.Text = this.dgv_emplados_modificar.CurrentRow.Cells[2].Value.ToString();
            txt_mod_apellido1.Text = this.dgv_emplados_modificar.CurrentRow.Cells[3].Value.ToString();
            txt_mod_apellido2.Text = this.dgv_emplados_modificar.CurrentRow.Cells[4].Value.ToString();
            txt_mod_direccion.Text = this.dgv_emplados_modificar.CurrentRow.Cells[5].Value.ToString();
            txt_mod_dpi.Text = this.dgv_emplados_modificar.CurrentRow.Cells[6].Value.ToString();
            txt_mod_nit.Text = this.dgv_emplados_modificar.CurrentRow.Cells[7].Value.ToString();
            txt_mod_fecha_nac.Text = this.dgv_emplados_modificar.CurrentRow.Cells[8].Value.ToString();
            cbo_mod_cine.Text = this.dgv_emplados_modificar.CurrentRow.Cells[9].Value.ToString();
            cbo_mod_puesto.Text = this.dgv_emplados_modificar.CurrentRow.Cells[10].Value.ToString();


        }

        private void btn_mod_guardar_Click(object sender, EventArgs e)
        {
            String Codigo = this.dgv_emplados_modificar.CurrentRow.Cells[0].Value.ToString();
            conect.Conectar();
            String Squery = "update empleado set  nom1empleado ='" + txt_mod_nombre1.Text + "', nom2empleado ='" + txt_mod_nombre2.Text + "',ape1empleado ='" + txt_mod_apellido1.Text + "',ape2empleado ='" + txt_mod_apellido2.Text + "',dirempleado ='" + txt_mod_direccion.Text + "',dpiempleado ='" + txt_mod_dpi.Text + "',nitempleado ='" + txt_mod_nit.Text + "',fechanacempleado ='" + txt_mod_fecha_nac.Text + "',pkidcine ='" + cbo_mod_cine.Text + "',pkidpuesto ='" + cbo_mod_puesto.Text + "' where pkidempleado ='" + Codigo + "'";
            conect.EjecutarQuery(Squery);
            conect.actualizargrid(dgv_emplados_modificar, Squeery, Stabla);
            conect.actualizargrid(dgv_buscar_empleado, Squeery, Stabla);
            conect.Desconectar();
        }

        private void btn_buscarmod_Click(object sender, EventArgs e)
        {
            conect.Conectar();
            String Squerys = ("Select* from empleado where  nom1empleado like'" + txt_modificarbuscar.Text + "%';");
            conect.buscarquery(Squerys);
            conect.actualizargrid(dgv_emplados_modificar, Squerys, Stabla);
            conect.Desconectar();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            conect.Conectar();
            String Squerys = ("Select* from empleado where  nom1empleado like'" + txt_modificarbuscar.Text + "%';");
            conect.buscarquery(Squerys);
            conect.actualizargrid(dgv_buscar_empleado, Squerys, Stabla);
            conect.Desconectar();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            String SCelda = this.dgv_buscar_empleado.CurrentRow.Cells[0].Value.ToString();
            var Vresultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Vresultado == DialogResult.Yes)
            {
                conect.Conectar();
                String Squerys = "delete from  empleado where pkidempleado = '" + SCelda + "';";
                conect.EjecutarQuery(Squerys);
                conect.actualizargrid(dgv_emplados_modificar, Squeery, Stabla);
                conect.actualizargrid(dgv_buscar_empleado, Squeery, Stabla);
                conect.Desconectar();
            }
        }

        private void empleado_Load(object sender, EventArgs e)
        {

        }
    }
}