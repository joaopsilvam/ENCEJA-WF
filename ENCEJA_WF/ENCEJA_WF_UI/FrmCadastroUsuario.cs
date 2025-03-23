using ENCEJA_WF_Domain.Entities;
using ENCEJA_WF_Domain.Interfaces.Repositories;

namespace ENCEJA_WF_UI
{
    public partial class FrmCadastroUsuario : Form
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public FrmCadastroUsuario(IUsuarioRepository usuarioRepository)
        {
            InitializeComponent();
            _usuarioRepository = usuarioRepository;
        }

        private void FrmCadastroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = inputNome.Text;
            string email = inputEmail.Text;
            string senha = inputSenha.Text;
            try
            {

                var usuario = new Usuario
                {
                    Nome = nome,
                    Email = email,
                    Senha = senha
                };

                _usuarioRepository.AddAsync(usuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar usuário: " + ex.Message);
            }
        }
    }
}
