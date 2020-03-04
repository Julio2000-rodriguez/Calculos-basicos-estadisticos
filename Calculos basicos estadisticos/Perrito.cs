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
    public partial class Perrito : Form
    {
        Payaso objpayaso = new Payaso();
        public Perrito()
        {
            InitializeComponent();
        }

        private void Perrito_Load(object sender, EventArgs e)
        {
            cboCojo.Items.AddRange(objpayaso.Tipo );
            cboCojo.SelectedIndex = 0; 
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            try
            {
                lblRespuesta.Text = "valor:" + objpayaso.convertir(cboHacer.SelectedIndex, cboHecho.SelectedIndex, double.Parse(txtC.Text), cboCojo.SelectedIndex) + "" + objpayaso.etiquetas[cboCojo.SelectedIndex][cboHecho.SelectedIndex];
            }
            catch
            {
                MessageBox.Show("error", "conversores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboCojo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboHacer.Items.Clear();
            cboHecho.Items.Clear();
            cboHacer.Items.AddRange(objpayaso.etiquetas[cboCojo.SelectedIndex]);
            cboHecho.Items.AddRange(objpayaso.etiquetas[cboCojo.SelectedIndex]);
            cboHacer.SelectedIndex = 0;
            cboHecho.SelectedIndex = 1;
            lblRespuesta.Text = "?";
            txtC.Text  = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
