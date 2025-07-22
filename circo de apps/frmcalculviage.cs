using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circideapps
{
    public partial class frmcalculviage : Form
    {
        public frmcalculviage()
        {
            InitializeComponent();
        }

        private void frmcalculviage_Load(object sender, EventArgs e)
        {

        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            float alcool = 4.27f;
            float gascomum = 6.28f;
            float gasaditi = 6.50f;
            float diesel = 5.93f;
            float tempo, litros, gasta;
            Int32 distancia = Convert.ToInt32(txtdistancia.Text.Trim());
            Int32 autonomia = Convert.ToInt32(txtautonomia.Text.Trim());
            if (cbbtipo.Text == "ALCOOL")
            {
                tempo = distancia / 90;
                litros = distancia / autonomia;
                gasta = litros * alcool;
            }
            else if (cbbtipo.Text == "GASOLINA COMUM")
            {
                tempo = distancia / 90;
                litros = distancia / autonomia;
                gasta = litros * gascomum;
            }
            else if (cbbtipo.Text == "GASOLINA ADITIVADA")
            {
                tempo = distancia / 90;
                litros = distancia / autonomia;
                gasta = litros * gasaditi;
            }
            else
            {
                tempo = distancia / 90;
                litros = distancia / autonomia;
                gasta = litros * diesel;
            }
            lblgastototal.Text = $"Litros gastos: {litros.ToString("F")}";
            lblgastototal.Text = $"Total: {gasta.ToString("C")}";
            lbltempo.Text = $"Tempo total: {tempo.ToString("F")}";
        }

        private void txtcombustivel_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
