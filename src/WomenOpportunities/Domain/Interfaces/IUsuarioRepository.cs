using EstartandoDevsCore.Data;
using WomenOpportunities.Domain.Entities;

namespace WomenOpportunities.Domain.Interfaces;

public interface IUsuarioRepository : IRepository<Usuario>
{
    Task<IEnumerable<Usuario>> ObterUsuarios();
}