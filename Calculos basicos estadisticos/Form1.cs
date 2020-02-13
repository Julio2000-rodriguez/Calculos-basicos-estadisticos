using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculos_basicos_estadisticos
{
    public partial class Form1 : Form
    {
        estadistica objEstadistica = new estadistica();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMediaAritmetica_Click(object sender, EventArgs e)
        {
            lblX.Text = "X="+ objEstadistica.media(txtSerie.Text.Split(','));
        }

        private void btnCalcularEstandar_Click(object sender, EventArgs e)
        {
            lblX.Text = "Estandar=" + objEstadistica.estandar(txtSerie.Text.Split(','));
        }

        private void btnCalcularTipica_Click(object sender, EventArgs e)
        {
            lblX.Text = "Tipica=" + objEstadistica.tipica(txtSerie.Text.Split(','));
        }
    }
}
