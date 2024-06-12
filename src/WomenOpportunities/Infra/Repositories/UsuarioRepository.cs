using Microsoft.EntityFrameworkCore;
using WomenOpportunities.Domain.Entities;
using WomenOpportunities.Domain.Interfaces;
using WomenOpportunities.Infra.Data;

namespace WomenOpportunities.Infra.Repositories;

public class UsuarioRepository : IUsuarioRepository
{
    private readonly WOContext _context;

    public UsuarioRepository(WOContext context)
    {
        _context = context;
    }

    public void CriarUsuario(Usuario usuario)
    {
        _context.Usuarios.Add(usuario);
        _context.SaveChanges();
    }

    public void AtualizarUsuario(Usuario usuario)
    {
        _context.Usuarios.Update(usuario);
        _context.SaveChanges();    }

    public async Task<bool> RemoverUsuario(Guid id)
    {
        var usuario = await _context.Usuarios.FirstOrDefaultAsync(x => x.Id == id);

        if (usuario is null)
        {
            return false;
        }

        _context.Usuarios.Remove(usuario);
        await _context.SaveChangesAsync();

        return true;    
    }

    public async Task<Usuario> ObterUsuarioPorId(Guid usuarioId)
    {
        return await _context.Usuarios.FirstOrDefaultAsync(x => x.Id == usuarioId);
    }

    public async Task<IEnumerable<Usuario>> ObterUsuarios()
    {
        return await _context.Usuarios.ToListAsync();
    }
}