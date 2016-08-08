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
    public partial class categoria : Form
    {
        conexionymanipulacion conect = new conexionymanipulacion();
        String Stabla = "categoria";
        String Squeery = "select* from categoria";
        public categoria()
        {
            InitializeComponent();
            conect.actualizargrid(dgv_categoria, Squeery, Stabla);
            conect.actualizargrid(dgv_mod_categoria, Squeery, Stabla);
            conect.actualizargrid(dgv_borrar_categoria, Squeery, Stabla);
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
            try
            {
                conect.Conectar();
                String Squery = "insert into  categoria (nomcategoria) values('" + txt_categoria.Text + "');";
                conect.EjecutarQuery(Squery);
                conect.actualizargrid(dgv_categoria, Squeery, Stabla);
                conect.actualizargrid(dgv_mod_categoria, Squeery, Stabla);
                conect.actualizargrid(dgv_borrar_categoria, Squeery, Stabla);
                nombre_columna();
                conect.Desconectar();
                txt_categoria.Clear();
            }catch(Exception ex){
 MessageBox.Show(ex.Message + ex.TargetSite);
                MessageBox.Show("Error al Guardar el nombre de la Categoria");
            }
        }


        private void categoria_Load(object sender, EventArgs e)
        {

        }

        private void btn_buscarmod_Click(object sender, EventArgs e)
        {
            try
            {
                conect.Conectar();
                String Squerys = ("Select * from categoria where  nomcategoria like'" + txt_buscarmod.Text + "%';");
                conect.buscarquery(Squerys);
                conect.actualizargrid(dgv_mod_categoria, Squerys, Stabla);
                nombre_columna();
                conect.Desconectar();
                txt_buscarmod.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.TargetSite);
                MessageBox.Show("Error al buscar la categoria");
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            txt_mod_categoriaa.Text = this.dgv_mod_categoria.CurrentRow.Cells[1].Value.ToString();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            conect.Conectar();
            String Squerys = ("Select* from categoria where  nomcategoria like'" + txt_buscar.Text + "%';");
            conect.buscarquery(Squerys);
            conect.actualizargrid(dgv_borrar_categoria, Squerys, Stabla);
            nombre_columna();
            conect.Desconectar();
            txt_buscar.Clear();

        }

        private void btn_mod_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                String Codigo = this.dgv_mod_categoria.CurrentRow.Cells[0].Value.ToString();
                conect.Conectar();
                String Squery = "update categoria set  nomcategoria ='" + txt_mod_categoriaa.Text + "'where pkidcategorias ='" + Codigo + "'";
                conect.EjecutarQuery(Squery);
                conect.actualizargrid(dgv_categoria, Squeery, Stabla);
                conect.actualizargrid(dgv_mod_categoria, Squeery, Stabla);
                conect.actualizargrid(dgv_borrar_categoria, Squeery, Stabla);
                nombre_columna();
                conect.Desconectar();
                txt_mod_categoriaa.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.TargetSite);
                MessageBox.Show("Error en la Actualizacion de Categoria");
            }
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            try
            {
                String SCelda = this.dgv_borrar_categoria.CurrentRow.Cells[0].Value.ToString();
                var Vresultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Vresultado == DialogResult.Yes)
                {
                    conect.Conectar();
                    String Squerys = "delete from  categoria where pkidcategorias = '" + SCelda + "';";
                    conect.EjecutarQuery(Squerys);
                    conect.actualizargrid(dgv_categoria, Squeery, Stabla);
                    conect.actualizargrid(dgv_mod_categoria, Squeery, Stabla);
                    conect.actualizargrid(dgv_borrar_categoria, Squeery, Stabla);
                    nombre_columna();
                    conect.Desconectar();

                }
                else
                {
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.TargetSite);
                MessageBox.Show("Error al Borrar la Categoria");

            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
        public void nombre_columna()
        {
            this.dgv_categoria.Columns[0].HeaderText = "No";
            this.dgv_categoria.Columns[1].HeaderText = "Categoria";
          
            this.dgv_borrar_categoria.Columns[0].HeaderText = "No";
            this.dgv_borrar_categoria.Columns[1].HeaderText = "Categoria";
          
                this.dgv_mod_categoria.Columns[0].HeaderText = "No";
            this.dgv_mod_categoria.Columns[1].HeaderText = "Categoria";
        

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
    }

