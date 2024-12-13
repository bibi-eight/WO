using EstartandoDevsCore.Data;
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
    
    public IUnitOfWorks UnitOfWork { get; }

    public async Task<IEnumerable<Usuario>> ObterUsuarios()
    {
        return await _context.Usuarios.ToListAsync();
    }

    public async Task<Usuario> ObterPorId(Guid Id)
    {
        return await _context.Usuarios.FirstOrDefaultAsync(u => u.Id == Id);
    }

    public void Adicionar(Usuario entity)
    {
        _context.Usuarios.Add(entity);
    }

    public void Atualizar(Usuario entity)
    {
        _context.Usuarios.Update(entity);
    }

    public void Apagar(Func<Usuario, bool> predicate)
    {
        _context.Usuarios.RemoveRange(_context.Usuarios.Where(predicate));
    }

    public void Dispose()
    {
        _context?.Dispose();
    }
}