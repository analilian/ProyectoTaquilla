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
    public partial class reportes : Form
    {
        //----------------------------------------programado por walter y rodrigo-------------------------------------------
        //----------------------------------------fecha inicio:1/08/2016----------------------------------------------------
        //----------------------------------------fecha fin: 17/08/2016-----------------------------------------------------
        string usu;
        public reportes(string usuario)
        {
            InitializeComponent();
            usu = usuario;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            seleccion r = new seleccion(usu);
            r.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 r = new Form1();
            r.ShowDialog();
        }

        private void reportes_Load(object sender, EventArgs e)
        {

        }



        private const string ayudacinetopiaadministrativa = "Title of this help project.chm";
        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, Application.StartupPath + @"/" + ayudacinetopiaadministrativa);
        }

        private void btn_peliculataquillera_Click(object sender, EventArgs e)
        {
            this.Hide();
            CR_pelicula_taquillera r = new CR_pelicula_taquillera(usu);
            r.ShowDialog();
        }

        private void btn_horariosmasusados_Click(object sender, EventArgs e)
        {
            this.Hide();
            CR_horario_mas_optimo r = new CR_horario_mas_optimo(usu);
            r.ShowDialog();
        }

        private void btn_puntoscliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            CR_tarjeta_puntos r = new CR_tarjeta_puntos(usu);
            r.ShowDialog();
        }

        private void btn_ganancias_Click(object sender, EventArgs e)
        {
            this.Hide();
            CR_ganancia r = new CR_ganancia(usu);
            r.ShowDialog();
        }
    }
}
