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

//programadores: walter y rodrigo
namespace cinepolis
{
    //----------------------------------------programado por walter y rodrigo-------------------------------------------
    //----------------------------------------fecha inicio:1/08/2016----------------------------------------------------
    //----------------------------------------fecha fin: 17/08/2016-----------------------------------------------------
    public partial class sala : Form
    {
        string usu;
        conexionymanipulacion conect = new conexionymanipulacion();
        String Stabla = "sala";
        String Stabla1 = "cinessala";
        String Squeery = "select * from sala";
        String Squeery1 = "select b.nomcine, a.nomsala from sala a, cine b, cinessala c where c.pk_idcine=b.pk_idcine and c.pk_idsala=a.pk_idsala ORDER BY `b`.`nomcine` ASC";
        
        Boolean binsert = true;
    
        public sala(string usuario)
        {
            InitializeComponent();
            conect.actualizargrid(dgv_sala, Squeery, Stabla);
            conect.actualizargrid(dgv_salacine, Squeery1, Stabla1);
            nombre_columna();
            usu = usuario;
            txt_sala.Enabled = false;
            btn_desactivar.Enabled = false;
            btn_actualizar_sala.Enabled = false;
            btn_guardar.Enabled = true;
            btn_eliminar_sala.Enabled = false;
            btn_activar.Enabled = true;
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
                cb1();
            }
            else
            {
                update();
                btn_buscar_sala.Enabled = true;
                btn_eliminar_sala.Enabled = true;
                MessageBox.Show("modificar");
                cb1();

            }

            
        }


        private void insert()
        {
            if (txt_sala.Text == "")
            {
                MessageBox.Show("Llene todos los campos por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    string scodigo = this.dgv_sala.CurrentRow.Cells[0].Value.ToString();
                    conect.Conectar();
                    String Squery = "insert into  sala (nomsala) values('" + txt_sala.Text + "');";
                    conect.EjecutarQuery(Squery);
                    String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usu + "','" + conect.ip() + "','agrego sala', NOW());";
                    conect.EjecutarQuery1(Query);

                    //----------------------sirve para obtener el dato de una columna de una tabla

                    //DataTable dt = new DataTable();
                    //String sQuery = "SELECT pk_idsala FROM sala WHERE nomsala= '"+ txt_sala.Text + "'";
                    //MySqlCommand comando = new MySqlCommand(sQuery, conect.rutaconectada());
                    //MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    //adaptador.Fill(dt);
                    //DataRow fila = dt.Rows[0];
                    //string sid = Convert.ToString(fila[0]);
                    //MessageBox.Show(sid);

                    //------inserta en tabla intermedia cinessala-------------------------------

                    //String Squery1 = "insert into  cinessala (pk_idcine,pk_idsala) values('" + scodigo + "','"+ sid +"');";
                    //conect.EjecutarQuery(Squery1);

                    //------Actualizar datagrid------------------------
                    conect.actualizargrid(dgv_sala, Squeery, Stabla);
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
            cb1();
            cb2();
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
          
        }


        private void buscar()
        {
            conect.Conectar();
            String Squerys = ("Select * from sala where  nomsala like'" + txt_buscar_sala.Text + "%';");
            conect.buscarquery(Squerys);
            conect.actualizargrid(dgv_sala, Squerys, Stabla);
            nombre_columna();
            conect.Desconectar();
            txt_buscar_sala.Clear();
        } 

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_mod_guardar_Click(object sender, EventArgs e)
        {
            update();
        }


        private void update()
        {
            if (txt_sala.Text == "")
            {
                MessageBox.Show("Llene todos los campos por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    String Codigo = this.dgv_sala.CurrentRow.Cells[0].Value.ToString();
                    conect.Conectar();
                    String Squery = "update sala set  nomsala ='" + txt_sala.Text + "'where pk_idsala ='" + Codigo + "'";
                    conect.EjecutarQuery(Squery);
                    String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usu + "','" + conect.ip() + "','modifico sala', NOW());";
                    conect.EjecutarQuery1(Query);
                    conect.actualizargrid(dgv_sala, Squeery, Stabla);
                    nombre_columna();
                    conect.Desconectar();
                    txt_sala.Clear();
                    binsert = true;
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
            delete();
        }

        private void delete()
        {
            try
            {
                String SCelda = this.dgv_sala.CurrentRow.Cells[0].Value.ToString();
                var Vresultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Vresultado == DialogResult.Yes)
                {
                    conect.Conectar();
                    String Squerys = "delete from  sala where pk_idsala = '" + SCelda + "';";
                    conect.EjecutarQuery(Squerys);
                    String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usu + "','" + conect.ip() + "','borro sala', NOW());";
                    conect.EjecutarQuery1(Query);
                    conect.actualizargrid(dgv_sala, Squeery, Stabla);
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
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_sala_Click(object sender, EventArgs e)
        {
            delete();
            cb1();
        }

        private void btn_actualizar_sala_Click(object sender, EventArgs e)
        {
            binsert = false;
            btn_buscar_sala.Enabled = false;
            btn_eliminar_sala.Enabled = false;
            txt_sala.Text = this.dgv_sala.CurrentRow.Cells[1].Value.ToString();
        }

        private void btn_buscar_sala_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void cb1()
        {
            try
            {

                conect.Conectar();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select pk_idsala, nomsala from sala;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, conect.Ruta());
                //se indica con quu tabla se llena
                dad.Fill(ds, "Sala");
                cbo_relacion_sala.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_relacion_sala.ValueMember = ("pk_idsala");
                //se indica el valor a desplegar en el combobox
                cbo_relacion_sala.DisplayMember = ("nomsala");
                conect.Desconectar();
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

                conect.Conectar();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select pk_idcine, nomcine from cine;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, conect.Ruta());
                //se indica con quu tabla se llena
                dad.Fill(ds, "Cine");
                cbo_relacion_cine.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_relacion_cine.ValueMember = ("pk_idcine");
                //se indica el valor a desplegar en el combobox
                cbo_relacion_cine.DisplayMember = ("nomcine");
                conect.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string sala = cbo_relacion_sala.SelectedValue.ToString();
            string cine = cbo_relacion_cine.SelectedValue.ToString();

            if (cbo_relacion_cine.Text == "" || cbo_relacion_sala.Text=="")
            {
                MessageBox.Show("Llene todos los campos por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    string scodigo = this.dgv_sala.CurrentRow.Cells[0].Value.ToString();
                    conect.Conectar();
                    String Squery = "insert into  cinessala (pk_idcine, pk_idsala) values('" + cine + "', '" + sala + "');";
                    conect.EjecutarQuery(Squery);
                    conect.actualizargrid(dgv_sala, Squeery, Stabla);
                    conect.actualizargrid(dgv_salacine, Squeery1, Stabla1);
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

        private void btn_desactivar_Click(object sender, EventArgs e)
        {
            txt_sala.Enabled = false;
            btn_desactivar.Enabled = false;
            btn_actualizar_sala.Enabled = false;
            btn_guardar.Enabled = true;
            btn_eliminar_sala.Enabled = false;
            btn_activar.Enabled = true;
        }

        private void btn_activar_Click(object sender, EventArgs e)
        {
            txt_sala.Enabled = true;
            btn_desactivar.Enabled = true;
            btn_actualizar_sala.Enabled = true;
            btn_guardar.Enabled = true;
            btn_eliminar_sala.Enabled = true;
            btn_activar.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conect.actualizargrid(dgv_sala, Squeery, Stabla);
            conect.actualizargrid(dgv_salacine, Squeery1, Stabla1);
        }


        private const string ayudacinetopiaadministrativa = "Title of this help project.chm";

        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, Application.StartupPath + @"/" + ayudacinetopiaadministrativa);
        }
    }
}
