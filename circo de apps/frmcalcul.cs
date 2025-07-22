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
            if (operador == "")
            {
                lblresultado.Text = lblconta.Text;
            }
            else
            {
                string primeironumstr = primeiroNumero.ToString();
                if (primeironumstr.Contains("."))
                {
                    primeironumstr = primeironumstr.Replace(".", ",");
                }
                lblresultado.Text = $"{primeironumstr}{operador}{lblconta.Text}";
            }
        }

        private void btnvirgula_Click(object sender, EventArgs e)
        {
            if (!virguladigitada)
            {
                if (lblconta.Text == "" || novoNumero)
                {
                    lblconta.Text = "0,";
                    novoNumero = false;

                }
                else
                {
                    lblconta.Text += ",";
                }
                virguladigitada = true;
            }
            if (operador == "")
            {
                lblresultado.Text = lblconta.Text;
            }
            else
            {
                string primeiroNumStr = primeiroNumero.ToString();
                if (primeiroNumStr.Contains("."))
                {
                    primeiroNumStr = primeiroNumStr.Replace(".", ",");
                }
                primeiroNumStr = $"{primeiroNumStr} {operador} {lblconta}";
            }

        }
        private void btnigual_Click(object sender, EventArgs e)
        {
            String segundonumeroText = lblconta.Text;
            string operadorAterior = operador;
            calcularResultado();
            string primeiroNumstr = primeiroNumero.ToString();
            if (primeiroNumstr.Contains("."))
            {
                primeiroNumstr = primeiroNumstr.Replace(".", ",");
            }
            lblresultado.Text = $"{primeiroNumstr}{operadorAterior}{segundonumeroText}";
            operador = "";
            novoNumero = true;
            virguladigitada = false;
        }


        private void calcularResultado()
        {
            if (operador == "" || novoNumero)
            {
                return;
            }
            double segundoNumero = double.Parse(lblconta.Text);
            double resultado = 0;
            switch (operador)
            {
                case "+":
                    resultado = primeiroNumero + segundoNumero;
                    break;
                case "-":
                    resultado = primeiroNumero - segundoNumero;
                    break;
                case "X":
                    resultado = primeiroNumero * segundoNumero;
                    break;
                case "/":
                    if (segundoNumero != 0)
                    {
                        resultado = primeiroNumero / segundoNumero;
                    }
                    else
                    {
                        MessageBox.Show("Divisão por zero não é permitida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblconta.Text = "0";
                        primeiroNumero = 0;
                        operador = "";
                        novoNumero = true;
                        virguladigitada = false;
                        lblresultado.Text = "0";
                        return;
                    }
                    break;
            }
            lblconta.Text = resultado.ToString();
        }

        private void frmcalcul_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (!novoNumero && operador != "")
            {
                calcularResultado();
            }
            primeiroNumero = double.Parse(lblconta.Text);
            operador = btn.Text;
            novoNumero = true;
            string primeiroNumStr = primeiroNumero.ToString();
            if (primeiroNumStr.Contains("."))
            {
                primeiroNumStr = primeiroNumStr.Replace(".", ",");
            }
            lblresultado.Text = $"{primeiroNumStr} {operador}";
        }
    }
}
