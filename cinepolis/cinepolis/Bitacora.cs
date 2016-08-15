using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// programador:: Rodrigo sifontes
// inicio: 14/08/2016 fin: 14/05/2016

    // rodrigo sifontes: se encargo de la realizaciond de form asi como las diferentes operaciones en los demas forms para poder realizar la bitacora.
namespace cinepolis
{ 
    
    public partial class Bitacora : Form
    {
        conexionymanipulacion con = new conexionymanipulacion();
        string usu;
        public Bitacora(string usuario)
        {
            InitializeComponent();
            usu = usuario;
            con.actualizargrid(dgv_buscar, "select * from bitacora", "bitacora");
            nombre_columna();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            seleccion r = new seleccion(usu);
            r.ShowDialog();
        }

        private void lbl_codigo_buscar_Click(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            con.Conectar();
            String Squerys = ("Select* from bitacora where usubitacora like'" + txt_buscar.Text + "%' or ipusuario like '" + txt_buscar.Text + "%' or eventobitacora like'" + txt_buscar.Text + "%'or fechabitacora like'" + txt_buscar.Text + "%';");
            con.buscarquery(Squerys);
            con.actualizargrid(dgv_buscar, Squerys,"bitacora");
            nombre_columna();
            con.Desconectar();
        }

        private void Bitacora_Load(object sender, EventArgs e)
        {

        }
        public void nombre_columna()
        {
            this.dgv_buscar.Columns[0].HeaderText = "No";
            this.dgv_buscar.Columns[1].HeaderText = "Usuario";
            this.dgv_buscar.Columns[2].HeaderText = "Ip del ordenador";
            this.dgv_buscar.Columns[3].HeaderText = "Evento";
            this.dgv_buscar.Columns[4].HeaderText = "FEcha";
        }
    }
}
