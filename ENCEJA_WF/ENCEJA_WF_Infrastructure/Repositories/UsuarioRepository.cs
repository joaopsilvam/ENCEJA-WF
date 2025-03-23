using ENCEJA_WF_Domain.Entities;
using ENCEJA_WF_Domain.Interfaces.Repositories;

namespace ENCEJA_WF_Infrastructure.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ApplicationDbContext context) : base(context)
        {
        }

    }
}
