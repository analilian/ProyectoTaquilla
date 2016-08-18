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
    public partial class seleccion : Form
    {
        //----------------------------------------programado por walter y rodrigo-------------------------------------------
        //----------------------------------------fecha inicio:1/08/2016----------------------------------------------------
        //----------------------------------------fecha fin: 17/08/2016-----------------------------------------------------
        string usuario;
        public seleccion(string usu)
        {
            InitializeComponent();
            this.usuario=usu;
        }


        private const string ayudacinetopiaadministrativa = "Title of this help project.chm";


        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this,Application.StartupPath + @"/"+ayudacinetopiaadministrativa);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            mantenimiento r = new mantenimiento(usuario);
            r.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 r = new Form1();
            r.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            reportes r = new reportes(usuario);
            r.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            usuario r = new usuario(usuario);
            r.ShowDialog();
        }

        private void seleccion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            empleado r = new empleado(usuario);
            r.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
           Bitacora r = new Bitacora(usuario);
            r.ShowDialog();
        }
    }
}
