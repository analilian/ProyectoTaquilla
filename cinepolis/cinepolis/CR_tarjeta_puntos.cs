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
    public partial class CR_tarjeta_puntos : Form
    {
        conexionymanipulacion conect = new conexionymanipulacion();
        string usu;
        public CR_tarjeta_puntos(string usuario)
        {
            InitializeComponent();
            usu = usuario;
            reporte();
        }

        private void txt_regreso_reporte_puntos_Click(object sender, EventArgs e)
        {
            this.Hide();
            reportes r = new reportes(usu);
            r.ShowDialog();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
        public void reporte()
        {
            conect.Conectar();
            String Query = "insert into bitacora(usubitacora,ipusuario,eventobitacora,fechabitacora) values('" + usu + "','" + conect.ip() + "','visualizacion de reporte de puntos de los clientes', NOW());";
            conect.EjecutarQuery1(Query);
            conect.Desconectar();
        }
    }
}
