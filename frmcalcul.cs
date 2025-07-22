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
    public partial class frmcalcul : Form
    {
        double primeiroNumero = 0;
        string operador = "";
        bool novoNumero = true;
        bool virguladigitada = false;
        public frmcalcul()
        {
            InitializeComponent();
        }

        private void frmcalcul_Load(object sender, EventArgs e)
        {
            lblconta.Text = "0";
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (novoNumero)
            {
                lblconta.Text = btn.Text;
                novoNumero = false;
                virguladigitada = false;
            }
            else
            {
                if (lblconta.Text == "0" && btn.Text == "0")
                {
                    return;
                }
                if (lblconta.Text == "0" && btn.Text != "0")
                {
                    lblconta.Text = btn.Text;
                }
                else
                {
                    lblconta.Text += btn.Text;
                }
            }
        }
    }
}
