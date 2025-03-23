namespace ENCEJA_WF_UI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Home telaInicial = new();
            telaInicial.Show();
            //this.Close();
        }
    }
}
