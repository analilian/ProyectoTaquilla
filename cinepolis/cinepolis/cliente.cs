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
    public partial class cliente : Form
    {
        //----------------------------------------programado por walter y rodrigo-------------------------------------------
        //----------------------------------------fecha inicio:1/08/2016----------------------------------------------------
        //----------------------------------------fecha fin: 17/08/2016-----------------------------------------------------
        encriptado encrip = new encriptado();
        conexionymanipulacion conect = new conexionymanipulacion();
        String Stabla = "cliente";
        String Squeery = "SELECT * FROM `cliente`";
        Boolean binsert = true;
        string usu;


        public cliente(string usuario)
        {
            InitializeComponent();
            conect.actualizargrid(dgv_ingresarusuario, Squeery, Stabla);
            nombre_columna();
            desactivar();
            usu = usuario;
        }


        public void nombre_columna()
        {
            this.dgv_ingresarusuario.Columns[0].HeaderText = "No";
            
            this.dgv_ingresarusuario.Columns[1].HeaderText = "Nombre";
            this.dgv_ingresarusuario.Columns[2].HeaderText = "Nombre";
            this.dgv_ingresarusuario.Columns[3].HeaderText = "Apellido";
            this.dgv_ingresarusuario.Columns[4].HeaderText = "Apellido";
            this.dgv_ingresarusuario.Columns[5].HeaderText = "DPI";
            this.dgv_ingresarusuario.Columns[6].HeaderText = "Direccion";
            this.dgv_ingresarusuario.Columns[7].HeaderText = "Correo";
            this.dgv_ingresarusuario.Columns[8].HeaderText = "Pelicula";
            this.dgv_ingresarusuario.Columns[9].HeaderText = "Tarjeta";


        }

        private void btn_eliminar_usuario_Click(object sender, EventArgs e)
        {
            String SCelda = this.dgv_ingresarusuario.CurrentRow.Cells[0].Value.ToString();
            var Vresultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Vresultado == DialogResult.Yes)
            {
                conect.Conectar();
                String Squerys = "delete from  cliente where pk_idcliente = '" + SCelda + "';";
                conect.EjecutarQuery(Squerys);
                String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usu + "','" + conect.ip() + "','borro cliente', NOW());";
                conect.EjecutarQuery(Query);
                conect.actualizargrid(dgv_ingresarusuario, Squeery, Stabla);
                nombre_columna();
                conect.Desconectar();

            }
        }

        private void btn_agregarusuario_Click(object sender, EventArgs e)
        {
            if (binsert == true)
            {
                insert();
                MessageBox.Show("insetar");
            }
            else
            {
                update();

                btn_buscar_usuario.Enabled = true;
                btn_eliminar_usuario.Enabled = true;
                MessageBox.Show("modificar");

            }
        }


        private void insert()
        {
            if (txt_dpi.Text == "" || txt_nom1.Text=="" || txt_nom2.Text=="" || txt_ape1.Text=="" || txt_ape2.Text=="" || txt_direccion.Text=="" || txt_correo.Text=="" || cbo_peli.Text=="" || cbo_tarjeta.Text=="")
            {
                MessageBox.Show("Llene todos los campos por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    string tarjeta = cbo_tarjeta.SelectedValue.ToString();
                    string pelicula = cbo_peli.SelectedValue.ToString();
                    string scodigo = this.dgv_ingresarusuario.CurrentRow.Cells[0].Value.ToString();
                    conect.Conectar();
                    String Squery = "insert into  cliente (dpicliente,nom1cliente,nom2cliente,ape1cliente,ape2cliente,direccion,correocliente,pk_idpelicula,pk_idtarjeta) values('" + txt_dpi.Text + "','" + txt_nom1.Text + "','" + txt_nom2.Text + "','" + txt_ape1.Text + "','" + txt_ape2.Text + "','" + txt_direccion.Text + "','" + cbo_tarjeta.Text + "','" + pelicula + "','" + tarjeta + "');";
                    conect.EjecutarQuery(Squery);
                    String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usu + "','" + conect.ip() + "','agrego cliente', NOW());";
                    conect.EjecutarQuery1(Query);
                    conect.actualizargrid(dgv_ingresarusuario, Squeery, Stabla);
                    nombre_columna();
                    limpiar();
                    conect.Desconectar();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.TargetSite);
                    MessageBox.Show("Error en la Insercion sobre Tabla Sala");
                }
            }
        }



        private void update()
        {
            if (txt_dpi.Text == "" || txt_nom1.Text == "" || txt_nom2.Text == "" || txt_ape1.Text == "" || txt_ape2.Text == "" || txt_direccion.Text == "" || txt_correo.Text == "" || cbo_peli.Text == "" || cbo_tarjeta.Text == "")
            {
                MessageBox.Show("Llene todos los campos por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    string tarjeta = cbo_tarjeta.SelectedValue.ToString();
                    string pelicula = cbo_peli.SelectedValue.ToString();
                    String Codigo = this.dgv_ingresarusuario.CurrentRow.Cells[0].Value.ToString();
                    conect.Conectar();
                    String Squery = "update cliente set  dpicliente ='" + txt_dpi.Text + "',nom1cliente ='" + txt_nom1.Text + "',nom2cliente ='" + txt_nom2.Text + "',ape1cliente ='" + txt_ape1.Text + "',ape2cliente ='" + txt_ape2.Text + "',direccion ='" + txt_direccion.Text + "',correocliente ='" + txt_correo.Text + "',pk_idpelicula ='" + pelicula + "',pk_idtarjeta ='" + tarjeta + "' where pk_idcliente ='" + Codigo + "'";
                    conect.EjecutarQuery(Squery);
                    String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usu + "','" + conect.ip() + "','modifico cliente', NOW());";
                    conect.EjecutarQuery1(Query);
                    conect.actualizargrid(dgv_ingresarusuario, Squeery, Stabla);
                    nombre_columna();
                    conect.Desconectar();
                    limpiar();
                    binsert = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.TargetSite);
                    MessageBox.Show("Error en la Actualicaion sobre Tabla sala");
                }
            }
        }

        private void limpiar()
        {
            txt_dpi.Clear();
            txt_nom1.Clear();
            txt_nom2.Clear();
            txt_ape1.Clear();
            txt_ape2.Clear();
            txt_direccion.Clear();
            txt_correo.Clear();
            cbo_peli.ResetText();
            cbo_tarjeta.ResetText();
        }

        private void desactivar()
        {
            txt_dpi.Enabled = false;
            txt_nom1.Enabled = false;
            txt_nom2.Enabled = false;
            txt_ape1.Enabled = false;
            txt_ape2.Enabled = false;
            txt_direccion.Enabled = false;
            txt_correo.Enabled = false;
            cbo_peli.Enabled = false;
            cbo_tarjeta.Enabled = false;
            btn_eliminar_usuario.Enabled = false;
            btn_agregarusuario.Enabled = false;
            bttn_actualizar_usuario.Enabled = false;
            btn_desactivar.Enabled = false;
            btn_activar.Enabled = true;
        }


        private void activar()
        {
            txt_dpi.Enabled = true;
            txt_nom1.Enabled = true;
            txt_nom2.Enabled = true;
            txt_ape1.Enabled = true;
            txt_ape2.Enabled = true;
            txt_direccion.Enabled = true;
            txt_correo.Enabled = true;
            cbo_peli.Enabled = true;
            cbo_tarjeta.Enabled = true;
            btn_eliminar_usuario.Enabled = true;
            btn_agregarusuario.Enabled = true;
            bttn_actualizar_usuario.Enabled = true;
            btn_desactivar.Enabled = true;
            btn_activar.Enabled = false;
        }


        private void bttn_actualizar_usuario_Click(object sender, EventArgs e)
        {
            binsert = false;
            btn_eliminar_usuario.Enabled = false;
            btn_buscar_usuario.Enabled = false;
            //txt_sala.Text = this.dgv_ingresarusuario.CurrentRow.Cells[0].Value.ToString();
            txt_dpi.Text = this.dgv_ingresarusuario.CurrentRow.Cells[1].Value.ToString();
            txt_nom1.Text = this.dgv_ingresarusuario.CurrentRow.Cells[2].Value.ToString();
            txt_nom2.Text = this.dgv_ingresarusuario.CurrentRow.Cells[3].Value.ToString();
            txt_ape1.Text = this.dgv_ingresarusuario.CurrentRow.Cells[4].Value.ToString();
            txt_ape2.Text = this.dgv_ingresarusuario.CurrentRow.Cells[5].Value.ToString();
            txt_direccion.Text = this.dgv_ingresarusuario.CurrentRow.Cells[6].Value.ToString();
            txt_correo.Text = this.dgv_ingresarusuario.CurrentRow.Cells[7].Value.ToString();
            cbo_peli.Text = this.dgv_ingresarusuario.CurrentRow.Cells[8].Value.ToString();
            cbo_tarjeta.Text = this.dgv_ingresarusuario.CurrentRow.Cells[9].Value.ToString();
        }

        private void btn_buscar_usuario_Click(object sender, EventArgs e)
        {
            conect.Conectar();
            String Squerys = ("Select * from cliente where  nom1cliente like'" + txt_buscar_usuario.Text + "%' or nom2cliente like'" + txt_buscar_usuario.Text + "%';");
            conect.buscarquery(Squerys);
            conect.actualizargrid(dgv_ingresarusuario, Squerys, Stabla);
            nombre_columna();
            conect.Desconectar();
            txt_buscar_usuario.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conect.actualizargrid(dgv_ingresarusuario, Squeery, Stabla);
        }

        private void cliente_Load(object sender, EventArgs e)
        {
            cb2();
            cb1();
        }

        private const string ayudacinetopiaadministrativa = "Title of this help project.chm";
        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, Application.StartupPath + @"/" + ayudacinetopiaadministrativa);
        }


        private void cb1()
        {
            try
            {

                conect.Conectar();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select pk_idpelicula, nompelicula from pelicula;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, conect.Ruta());
                //se indica con quu tabla se llena
                dad.Fill(ds, "Pelicula");
                cbo_peli.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_peli.ValueMember = ("pk_idpelicula");
                //se indica el valor a desplegar en el combobox
                cbo_peli.DisplayMember = ("nompelicula");
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
                String Query = "select pk_idtarjeta, puntostarjeta from tarjeta;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, conect.Ruta());
                //se indica con quu tabla se llena
                dad.Fill(ds, "Tarjeta");
                cbo_tarjeta.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_tarjeta.ValueMember = ("pk_idtarjeta");
                //se indica el valor a desplegar en el combobox
                cbo_tarjeta.DisplayMember = ("pk_idtarjeta");
                conect.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_desactivar_Click(object sender, EventArgs e)
        {
            desactivar();
        }

        private void btn_activar_Click(object sender, EventArgs e)
        {
            activar();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            mantenimiento r = new mantenimiento(usu);
            r.ShowDialog();
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
    }
}
