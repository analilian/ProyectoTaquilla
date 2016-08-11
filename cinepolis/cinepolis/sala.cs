﻿using System;
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
    public partial class sala : Form
    {
        conexionymanipulacion conect = new conexionymanipulacion();
        String Stabla = "sala";
        String Stabla1 = "cine";
        String Squeery = "select * from sala";
        String Squeery1 = "select * from cine";
        string sdireccion = "localhost";
        string susuario = "root";
        string spass = "";
        public sala()
        {
            InitializeComponent();
            conect.actualizargrid(dgv_sala, Squeery1, Stabla1);
            conect.actualizargrid(dgv_modsala, Squeery, Stabla);
            conect.actualizargrid(dgv_borrarsala, Squeery, Stabla);
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
            if (txt_sala.Text == "")
            {
                MessageBox.Show("Llene los campos por favor");
            }
            else
            {
                try
                {
                    string scodigo = this.dgv_sala.CurrentRow.Cells[0].Value.ToString();
                    conect.Conectar();
                    String Squery = "insert into  sala (nomsala) values('" + txt_sala.Text + "');";
                    conect.EjecutarQuery(Squery);
                    MySqlConnection conex = new MySqlConnection("server='" + sdireccion + "'; database= bdcinetopia; Uid= '" + susuario + "' ;pwd=  '" + spass + "';");

                    //----------------------sirve para obtener el dato de una columna de una tabla
                    DataTable dt = new DataTable();
                    String sQuery = "SELECT pk_idsala FROM sala WHERE nomsala= '"+ txt_sala.Text + "'";
                    MySqlCommand comando = new MySqlCommand(sQuery, conex);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    adaptador.Fill(dt);
                    DataRow fila = dt.Rows[0];
                    string sid = Convert.ToString(fila[0]);
                    //MessageBox.Show(sid);

                    //------inserta en tabla intermedia cinessala-------------------------------
                    String Squery1 = "insert into  cinessala (pk_idcine,pk_idsala) values('" + scodigo + "','"+ sid +"');";
                    conect.EjecutarQuery(Squery1);
                    //------Actualizar datagrid------------------------
                    conect.actualizargrid(dgv_modsala, Squeery, Stabla);
                    conect.actualizargrid(dgv_borrarsala, Squeery, Stabla);
                    conect.actualizargrid(dgv_borrarsala, Squeery, Stabla);
                    nombre_columna();
                    conect.Desconectar();
                    txt_sala.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.TargetSite);
                    MessageBox.Show("Error en la Insercion sobre Tabla Sala");
                }
            }
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
           try{
               conect.Conectar();
            String Squerys = ("Select * from sala where  nomsala like'" + txt_buscar.Text + "%';");
            conect.buscarquery(Squerys);
            conect.actualizargrid(dgv_borrarsala, Squerys, Stabla);
            nombre_columna();
            conect.Desconectar();
            txt_buscar.Clear();
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message + ex.TargetSite);
               MessageBox.Show("Error en la Busqueda sobre Tabla sala");
           }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conect.Conectar();
            String Squerys = ("Select * from sala where  nomsala like'" + txt_buscmod.Text + "%';");
            conect.buscarquery(Squerys);
            conect.actualizargrid(dgv_modsala, Squerys, Stabla);
            nombre_columna();
            conect.Desconectar();
            txt_buscmod.Clear();

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            txt_mod.Text = this.dgv_modsala.CurrentRow.Cells[1].Value.ToString();
        }

        private void btn_mod_guardar_Click(object sender, EventArgs e)
        {
            if (txt_mod.Text == "")
            {
                MessageBox.Show("Llene todos los campos por favor");
            }
            else
            {
                try
                {
                    String Codigo = this.dgv_borrarsala.CurrentRow.Cells[0].Value.ToString();
                    conect.Conectar();
                    String Squery = "update sala set  nomsala ='" + txt_mod.Text + "'where pk_idsala ='" + Codigo + "'";
                    conect.EjecutarQuery(Squery);
                    conect.actualizargrid(dgv_sala, Squeery1, Stabla1);
                    conect.actualizargrid(dgv_modsala, Squeery, Stabla);
                    conect.actualizargrid(dgv_borrarsala, Squeery, Stabla);
                    nombre_columna();
                    conect.Desconectar();
                    txt_mod.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.TargetSite);
                    MessageBox.Show("Error en la Actualicaion sobre Tabla sala");
                }
            }
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            try
            {
                String SCelda = this.dgv_borrarsala.CurrentRow.Cells[0].Value.ToString();
                var Vresultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Vresultado == DialogResult.Yes)
                {
                    conect.Conectar();
                    String Squerys = "delete from  sala where pk_idsala = '" + SCelda + "';";
                    conect.EjecutarQuery(Squerys);
                    conect.actualizargrid(dgv_sala, Squeery1, Stabla1);
                    conect.actualizargrid(dgv_modsala, Squeery, Stabla);
                    conect.actualizargrid(dgv_borrarsala, Squeery, Stabla);
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
                MessageBox.Show("Error en la Eliminacion sobre Tabla sala");
            }
            
        }

        private void lbl_titulo_mantenimiento_cine_Click(object sender, EventArgs e)
        {

        }
        public void nombre_columna()
        {
            this.dgv_sala.Columns[0].HeaderText = "No";
            this.dgv_sala.Columns[1].HeaderText = "Nombre de sala";
        
            this.dgv_modsala.Columns[0].HeaderText = "No";
            this.dgv_modsala.Columns[1].HeaderText = "Nombre De Sala";
  
            this.dgv_borrarsala.Columns[0].HeaderText = "No";
            this.dgv_borrarsala.Columns[1].HeaderText = "Nombre De Sala";
      

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
