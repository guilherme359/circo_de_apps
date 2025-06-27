namespace circideapps
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
            frmsplash splash = new frmsplash();
            splash.Show();
            Application.DoEvents();
            Thread.Sleep(1500);
            splash.Close();

            InitializeComponent();
            frmsplash2 splash2 = new frmsplash2();
            splash2.Show();
            Application.DoEvents();
            Thread.Sleep(1500);
            splash2.Close();
        }


        private void pbxfechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pbxbuscacep_Click(object sender, EventArgs e)
        {
            foreach (Form formAberto in Application.OpenForms)
            {
                if (formAberto is frmbuscacep)
                {
                    formAberto.Focus();
                    return;
                }
            }
            frmbuscacep frmbuscacep = new frmbuscacep();
            frmbuscacep.Show();

        }

        private void pbxclima_Click(object sender, EventArgs e)
        {
            foreach (Form formAberto in Application.OpenForms)
            {
                if (formAberto is frmclima)
                {
                    formAberto.Focus();
                    return;
                }
            }
            frmclima clima = new frmclima();
            clima.Show();
        }

        private void pbxcaracoroa_Click(object sender, EventArgs e)
        {
            foreach (Form formAberto in Application.OpenForms)
            {
                if (formAberto is frmcaracoroa)
                {
                    formAberto.Focus();
                    return;
                }
            }
            frmcaracoroa caracoroa = new frmcaracoroa();
            caracoroa.Show();
        }

        private void pbxcpf_Click(object sender, EventArgs e)
        {
            foreach (Form formAberto in Application.OpenForms)
            {
                if (formAberto is frmcpf)
                {
                    formAberto.Focus();
                    return;
                }
            }
            frmcpf cpf = new frmcpf();
            cpf.Show();
        }
    }
}