using EstartandoDevsCore.Data;
using Microsoft.EntityFrameworkCore;
using WomenOpportunities.Domain.Entities;
using WomenOpportunities.Domain.Interfaces;
using WomenOpportunities.Infra.Data;

namespace WomenOpportunities.Infra.Repositories;

public class InstituicaoRepository : IInstituicaoRepository
{
    private readonly WOContext _context;

    public InstituicaoRepository(WOContext context)
    {
        _context = context;
    }
    
    public IUnitOfWorks UnitOfWork { get; }

    public async Task<IEnumerable<Instituicao>> ObterInstituicoes()
    {
        return await _context.Instituicaos.ToListAsync();
    }

    public void Dispose()
    {
        _context?.Dispose();
    }

    public async Task<Instituicao> ObterPorId(Guid Id)
    {
        return await _context.Instituicaos.FirstOrDefaultAsync(i => i.Id == Id);
    }

    public void Adicionar(Instituicao entity)
    {
        _context.Instituicaos.Add(entity);
    }

    public void Atualizar(Instituicao entity)
    {
        _context.Instituicaos.Update(entity);
    }

    public void Apagar(Func<Instituicao, bool> predicate)
    {
        _context.Instituicaos.RemoveRange(_context.Instituicaos.Where(predicate));
    }

}