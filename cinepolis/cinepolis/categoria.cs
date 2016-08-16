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
        Boolean binsert = true;
        string usu;

        public categoria(string usuario)
        {
            InitializeComponent();
            conect.actualizargrid(dgv_categoria, Squeery, Stabla);
            nombre_columna();
            usu = usuario;
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            mantenimiento r = new mantenimiento(usu);
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
                btn_eliminar_categoria.Enabled = true;
                btn_buscar_categoria.Enabled = true;
                MessageBox.Show("modificar");

            }
        }


        private void insert()
        {
            if (txt_nom_categ.Text == "")
            {
                MessageBox.Show("Llene los campos por favor");
            }
            else
            {

                try
                {
                    conect.Conectar();
                    String Squery = "insert into  categoria (nomcategoria) values('" + txt_nom_categ.Text + "');";

                    conect.EjecutarQuery(Squery);
                    String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usu + "','" + conect.ip() + "','agrego categoria', NOW());";
                    conect.EjecutarQuery1(Query);
                    conect.actualizargrid(dgv_categoria, Squeery, Stabla);
                    nombre_columna();
                    conect.Desconectar();
                    txt_nom_categ.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.TargetSite);
                    MessageBox.Show("Error al Guardar el nombre de la Categoria");
                }
            }
        }


        private void categoria_Load(object sender, EventArgs e)
        {

        }

        private void btn_buscarmod_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
           ;

        }

        private void btn_mod_guardar_Click(object sender, EventArgs e)
        {
           
        }

        private void update()
        {
            if (txt_nom_categ.Text == "")
            {
                MessageBox.Show("Llene los campos por favor");
            }
            else
            {

                try
                {
                    String Codigo = this.dgv_categoria.CurrentRow.Cells[0].Value.ToString();
                    conect.Conectar();
                    String Squery = "update categoria set  nomcategoria ='" + txt_nom_categ.Text + "'where pk_idcategorias ='" + Codigo + "'";
                    conect.EjecutarQuery(Squery);
                    String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usu + "','" + conect.ip() + "','modifico categoria', NOW());";
                    conect.EjecutarQuery1(Query);
                    conect.actualizargrid(dgv_categoria, Squeery, Stabla);
                    nombre_columna();
                    conect.Desconectar();
                    txt_nom_categ.Clear();
                    binsert = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message + ex.TargetSite);
                    MessageBox.Show("Error en la Actualizacion de Categoria");
                }
            }
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
           
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
        public void nombre_columna()
        {
            this.dgv_categoria.Columns[0].HeaderText = "No";
            this.dgv_categoria.Columns[1].HeaderText = "Categoria";
          
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void bttn_actualizar_pelicula_Click(object sender, EventArgs e)
        {
            btn_eliminar_categoria.Enabled = false;
            btn_buscar_categoria.Enabled = false;
            binsert = false;

            txt_nom_categ.Text = this.dgv_categoria.CurrentRow.Cells[1].Value.ToString();
        }

        private void btn_buscar_pelicula_Click(object sender, EventArgs e)
        {
            try
            {
                conect.Conectar();
                String Squerys = ("Select * from categoria where  nomcategoria like'" + txt_buscarmod.Text + "%';");
                conect.buscarquery(Squerys);
                conect.actualizargrid(dgv_categoria, Squerys, Stabla);
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

        private void btn_eliminar_pelicula_Click(object sender, EventArgs e)
        {
            try
            {
                String SCelda = this.dgv_categoria.CurrentRow.Cells[0].Value.ToString();
                var Vresultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Vresultado == DialogResult.Yes)
                {
                    conect.Conectar();
                    String Squerys = "delete from  categoria where pk_idcategorias = '" + SCelda + "';";
                    conect.EjecutarQuery(Squerys);
                    String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usu + "','" + conect.ip() + "','Elimino categoria', NOW());";
                    conect.EjecutarQuery1(Query);
                    conect.actualizargrid(dgv_categoria, Squeery, Stabla);
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
                MessageBox.Show("Error al Borrar la Categoria");

            }
        }
    }
    }

