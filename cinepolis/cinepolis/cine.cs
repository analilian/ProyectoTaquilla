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
    public partial class cine : Form
    {
        conexionymanipulacion conect = new conexionymanipulacion();
        String Stabla = "cine";
        String Squeery = "select* from cine";
        string sdireccion = "localhost";
        string susuario = "root";
        string spass = "";

        public cine()
        {
            InitializeComponent();
            conect.actualizargrid(dgv_mod_clasificacion, Squeery, Stabla);
            conect.actualizargrid(dgv_clasificacion, Squeery, Stabla);
            conect.actualizargrid(dgv_borrar_categoria, Squeery, Stabla);
            nombre_columna();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            mantenimiento r = new mantenimiento();
            r.ShowDialog();
        }

        private void cine_Load(object sender, EventArgs e)
        {
            cb1();
            cb2();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string convregion = cbo_cine_region.SelectedValue.ToString();

            if (txt_clasificacion.Text=="" || txt_descrip_clasificacion.Text=="")
            {
                MessageBox.Show("Llene los campos por favor");
            }
            else
            {

                try
                {
                    conect.Conectar();
                    String Squery = "insert into  cine (nomcine,direccin,pk_idregion) values('" + txt_clasificacion.Text + "','" + txt_descrip_clasificacion.Text + "','" + convregion + "');";
                    conect.EjecutarQuery(Squery);
                    conect.actualizargrid(dgv_mod_clasificacion, Squeery, Stabla);
                    conect.actualizargrid(dgv_clasificacion, Squeery, Stabla);
                    conect.actualizargrid(dgv_borrar_categoria, Squeery, Stabla);
                    nombre_columna();
                    conect.Desconectar();
                    txt_clasificacion.Clear();
                    txt_descrip_clasificacion.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.TargetSite);
                    MessageBox.Show("Error en la Tabla de cine");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                conect.Conectar();
                String Squerys = ("Select* from cine where  nomcine like'" + txt_buscarmod.Text + "%' or direccine like '" + txt_buscarmod.Text + "%';");
                conect.buscarquery(Squerys);
                conect.actualizargrid(dgv_mod_clasificacion, Squerys, Stabla);
                nombre_columna();
                conect.Desconectar();
                txt_buscarmod.Clear();
            }  
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.TargetSite);
                MessageBox.Show("Error en la Busqueda en la tabla cine");
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            txt_nommod.Text = this.dgv_mod_clasificacion.CurrentRow.Cells[1].Value.ToString();
            txt_dirmod.Text = this.dgv_mod_clasificacion.CurrentRow.Cells[2].Value.ToString();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_mod_guardar_Click(object sender, EventArgs e)
        {
            string convregionmod = cbo_region_mod.SelectedValue.ToString();

            if (txt_nommod.Text=="" || txt_dirmod.Text=="")
            {
                MessageBox.Show("Llene los campos por favor");
            }
            else
            {

                try
                {
                    String Codigo = this.
                        dgv_mod_clasificacion.CurrentRow.Cells[0].Value.ToString();
                    conect.Conectar();
                    String Squery = "update cine set  nomcine ='" + txt_nommod.Text + "', direccin ='" + txt_dirmod.Text + "', pk_idregion ='" + convregionmod + "'where pk_idcine ='" + Codigo + "'";
                    conect.EjecutarQuery(Squery);
                    conect.actualizargrid(dgv_mod_clasificacion, Squeery, Stabla);
                    conect.actualizargrid(dgv_clasificacion, Squeery, Stabla);
                    conect.actualizargrid(dgv_borrar_categoria, Squeery, Stabla);
                    nombre_columna();
                    conect.Desconectar();
                    txt_nommod.Clear();
                    txt_dirmod.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.TargetSite);
                    MessageBox.Show("Error en la Actualizacion en la Tabla Cine");
                }
            }

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                conect.Conectar();
                String Squerys = ("Select* from cine where  nomcine like'" + txt_buscar.Text + "%' or direccine like '" + txt_buscar.Text + "%';");
                conect.buscarquery(Squerys);
                conect.actualizargrid(dgv_borrar_categoria, Squerys, Stabla);
                nombre_columna();
                conect.Desconectar();
                txt_buscar.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.TargetSite);
                MessageBox.Show("Error en la Busqueda sobre Tabla cine");
            }
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
           try {
                String SCelda = this.dgv_borrar_categoria.CurrentRow.Cells[0].Value.ToString();
                var Vresultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Vresultado == DialogResult.Yes)
                {
                    conect.Conectar();
                    String Squerys = "delete from  cine where pk_idcine = '" + SCelda + "';";
                    conect.EjecutarQuery(Squerys);
                    conect.actualizargrid(dgv_mod_clasificacion, Squeery, Stabla);
                    conect.actualizargrid(dgv_clasificacion, Squeery, Stabla);
                    conect.actualizargrid(dgv_borrar_categoria, Squeery, Stabla);
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
                MessageBox.Show("Error al Eliminar un Registro en la Tabla cine");
            }
        }
        public void nombre_columna()
        {
            this.dgv_clasificacion.Columns[0].HeaderText = "No";
            this.dgv_clasificacion.Columns[1].HeaderText = "Cine";
            this.dgv_clasificacion.Columns[2].HeaderText = "Direccion";
            this.dgv_clasificacion.Columns[3].HeaderText = "Region";
            this.dgv_mod_clasificacion.Columns[0].HeaderText = "No";
            this.dgv_mod_clasificacion.Columns[1].HeaderText = "Cine";
            this.dgv_mod_clasificacion.Columns[2].HeaderText = "Direccion";
            this.dgv_mod_clasificacion.Columns[3].HeaderText = "Region";
            this.dgv_borrar_categoria.Columns[0].HeaderText = "No";
            this.dgv_borrar_categoria.Columns[1].HeaderText = "Cine";
            this.dgv_borrar_categoria.Columns[2].HeaderText = "Direccion";
            this.dgv_borrar_categoria.Columns[3].HeaderText = "DRegion";

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_titulo_mantenimiento_cine_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cb1()
        {
            try
            {

                MySqlConnection micon = new MySqlConnection("server='" + sdireccion + "'; database= bdcinetopia; Uid= '" + susuario + "' ;pwd=  '" + spass + "';");
                //se realiza la conexión a la base de datos
                micon.Open();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select pk_idregion, nombreregion from region;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, micon);
                //se indica con quu tabla se llena
                dad.Fill(ds, "Region");
                cbo_cine_region.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_cine_region.ValueMember = ("pk_idregion");
                //se indica el valor a desplegar en el combobox
                cbo_cine_region.DisplayMember = ("nombreregion");
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

                MySqlConnection micon = new MySqlConnection("server='" + sdireccion + "'; database= bdcinetopia; Uid= '" + susuario + "' ;pwd=  '" + spass + "';");
                //se realiza la conexión a la base de datos
                micon.Open();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select pk_idregion, nombreregion from region;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, micon);
                //se indica con quu tabla se llena
                dad.Fill(ds, "Region");
                cbo_region_mod.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_region_mod.ValueMember = ("pk_idregion");
                //se indica el valor a desplegar en el combobox
                cbo_region_mod.DisplayMember = ("nombreregion");
                micon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}

