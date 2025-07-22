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
    public partial class frmcpf : Form
    {
        public frmcpf()
        {
            InitializeComponent();
        }

        private void frmcpf_Load(object sender, EventArgs e)
        {
            this.ActiveControl = mtxtcpf;
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnverificar_Click(object sender, EventArgs e)
        {
            string cpf = mtxtcpf.Text.Trim();
            bool valido = ValidarCPF(cpf);
            if (valido == true)
            {
                lblresultado.Text = "CPF Válido";
            }
            else
            {
                lblresultado.Text = "CPF Invalido";
            }
        }

        public static bool ValidarCPF(string cpf)
        {
            cpf = new string(cpf.Where(char.IsDigit).ToArray());
            if (cpf.Length != 11 || cpf.Distinct().Count() == 1)
                return false;
            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += (cpf[i] - '0') * (10 - i);
            int primeirodigito = soma % 11;
            primeirodigito = (primeirodigito < 2) ? 0 : 11 - primeirodigito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += (cpf[i] - '0') * (11 - i);
            int segundodigito = soma % 11;
            segundodigito = (segundodigito < 2) ? 0 : 11 - segundodigito;
            return cpf[9] - '0' == primeirodigito && cpf[10] - '0' == segundodigito;
        }

        private void mtxtcpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnverificar.PerformClick();
            }
        }
    }
}
