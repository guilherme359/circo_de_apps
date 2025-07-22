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
    public partial class frmcaracoroa : Form
    {
        int contadorCara = 0;
        int contadorCoroa = 0;
        Random random = new Random();
        public frmcaracoroa()
        {
            InitializeComponent();
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnjogar_Click(object sender, EventArgs e)
        {
            int resultado = random.Next(0, 2);
            if (resultado == 0)
            {
                lblresultado.Text = "CARA";
                pbxmoeda.Image = Properties.Resources.cara;
                contadorCara++;
            }
            else
            {
                lblresultado.Text = "COROA";
                pbxmoeda.Image = Properties.Resources.coroa;
                contadorCoroa++;
            }
            AtualizarPlacar();
        }

        private void AtualizarPlacar()
        {
            lblplacar.Text = $"Placar\nCara: {contadorCara}\nCoroa: {contadorCoroa}";
        }
    }
}
