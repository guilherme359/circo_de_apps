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
            Thread.Sleep(3000);
            splash.Close();
        }


        private void pbxfechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pbxbuscacep_Click(object sender, EventArgs e)
        {
            frmbuscacep frmbuscacep = new frmbuscacep();
            frmbuscacep.Show();

        }
    }
}