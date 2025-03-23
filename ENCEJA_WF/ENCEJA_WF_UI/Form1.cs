using System;
using System.Linq;
using System.Windows.Forms;
using ENCEJA_WF_Infrastructure;

namespace ENCEJA_WF_UI
{
    public partial class Form1 : Form
    {
        private readonly ApplicationDbContext _dbContext;

        public Form1(ApplicationDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        // Exemplo de uso do DbContext
        private void button1_Click(object sender, EventArgs e)
        {
            var alunos = _dbContext.Alunos.ToList();
            MessageBox.Show($"Total de alunos: {alunos.Count}");
        }
    }
}
