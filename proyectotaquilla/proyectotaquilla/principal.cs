using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectotaquilla
{
    public partial class FPrincipal : Form
    {
        public FPrincipal()
        {
            InitializeComponent();
        }

        private void bvercartelera_Click(object sender, EventArgs e)
        {
            cartelera carte = new cartelera();
            this.Hide();
            carte.Show();


        }

        private void FPrincipal_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pBfoto2.Visible == true)
            {
                pBfoto2.Visible = false;
                pBfoto3.Visible = true;

            }
            else if (pBfoto3.Visible == true)
            {
                pBfoto3.Visible = false;
                pBfoto4.Visible = true;

            }
            else if (pBfoto4.Visible == true)
            {
                pBfoto4.Visible = false;
                pBfoto5.Visible = true;

            }
            else if (pBfoto5.Visible == true)
            {
                pBfoto5.Visible = false;
                pBfoto2.Visible = true;

            }
        }
    }
}
