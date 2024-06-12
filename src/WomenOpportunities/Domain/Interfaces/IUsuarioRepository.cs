using WomenOpportunities.Domain.Entities;

namespace WomenOpportunities.Domain.Interfaces;

public interface IUsuarioRepository
{
    void CriarUsuario(Usuario usuario);
    void AtualizarUsuario(Usuario usuario);
    Task<bool> RemoverUsuario(Guid id);
    Task<Usuario> ObterUsuarioPorId(Guid usuarioId);
    Task<IEnumerable<Usuario>> ObterUsuarios();
}